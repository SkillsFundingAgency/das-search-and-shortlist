﻿namespace Sfa.Das.WebTest.Infrastructure.Settings
{
    using System.Configuration;
    using System.Reflection;

    public class BrowserSettings : IBrowserSettings
    {
        private readonly IProvideSettings _settings;

        public BrowserSettings(IProvideSettings settings)
        {
            _settings = settings;
        }

        public string BaseUrl => ConfigurationManager.AppSettings["service.url"];

        public string Browser => ConfigurationManager.AppSettings["browser"];

        public string Device => ConfigurationManager.AppSettings["device"];
        public string RemoteUrl => ConfigurationManager.AppSettings["RemoteUrl"];

        public string BrowserStackUser => _settings.GetSetting("browserstack.user");

        public string BrowserStackKey => _settings.GetSetting("browserstack.key");

        public string OS => ConfigurationManager.AppSettings["os"];

        public string OSVersion => ConfigurationManager.AppSettings["os_version"];

        public string BrowserVersion => ConfigurationManager.AppSettings["browser_version"];

        public string Project => ConfigurationManager.AppSettings["project"];

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string Resolution => ConfigurationManager.AppSettings["resolution"];

        public string Build => ConfigurationManager.AppSettings["build"];
    }
}