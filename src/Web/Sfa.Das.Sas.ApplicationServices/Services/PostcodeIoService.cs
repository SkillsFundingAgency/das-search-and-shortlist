﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core;
using Sfa.Das.Sas.Core.Configuration;
using SSfa.Das.Sas.ApplicationServices.Settings;

namespace Sfa.Das.Sas.ApplicationServices.Services
{
    public class PostcodeIoService : IPostcodeIoService
    {
        private readonly IRetryWebRequests _retryService;
        private readonly ILogger<PostcodeIoService> _logger;
        private readonly PostcodeLookupSettings _applicationSettings;

        public PostcodeIoService(IRetryWebRequests retryService, ILogger<PostcodeIoService> logger, IOptions<PostcodeLookupSettings> applicationSettings)
        {
            _retryService = retryService;
            _logger = logger;
            _applicationSettings = applicationSettings.Value;
        }

        public async Task<string> GetPostcodeStatus(string postcode)
        {
            var country = await GetPostcodeCountry(postcode);

            if (country == "Error")
            {
                country = await GetTerminatedPostCode(postcode, country);
            }

            return country;
        }

        private async Task<string> GetPostcodeCountry(string postcode)
        {
            try
            {
                var uri = new Uri(new Uri(_applicationSettings.PostcodeUrl), postcode.Replace(" ", string.Empty));
                var response = await _retryService.RetryWeb(() => MakeRequestAsync(uri.ToString()), CouldntConnect);

                if (response.IsSuccessStatusCode)
                {
                    var value = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<PostCodeResponse>(value);
                    return result.Result.Country;
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(string.Concat("Couldn't connect to postcode service", ex.Message));
            }

            return "Error";
        }

        private async Task<string> GetTerminatedPostCode(string postcode, string prevMessage)
        {
            try
            {
                var terminatedUri = new Uri(new Uri(_applicationSettings.PostcodeTerminatedUrl), postcode.Replace(" ", string.Empty));
                var terminated = await _retryService.RetryWeb(() => MakeRequestAsync(terminatedUri.ToString()), CouldntConnect);

                if (terminated.IsSuccessStatusCode)
                {
                    return "Terminated";
                }
            }
            catch (Exception ex)
            {
                _logger.LogWarning(string.Concat("Couldn't connect to postcode service", ex.Message));
            }

            return prevMessage;
        }

        private async Task<HttpResponseMessage> MakeRequestAsync(string url)
        {
            using (var client = new HttpClient())
            {
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    return await client.SendAsync(request);
                }
            }
        }

        private void CouldntConnect(Exception ex)
        {
            _logger.LogWarning(string.Concat("Couldn't connect to postcode service, retrying...", ex.Message));
        }
    }
}
