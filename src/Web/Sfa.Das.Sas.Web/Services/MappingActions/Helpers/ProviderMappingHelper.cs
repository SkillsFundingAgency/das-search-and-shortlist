﻿using System.Collections.Generic;
using Sfa.Das.Sas.Web.Extensions;

namespace Sfa.Das.Sas.Web.Services.MappingActions.Helpers
{
    using System.Linq;

    using Microsoft.Ajax.Utilities;

    using Sfa.Das.Sas.ApplicationServices.Models;

    public static class ProviderMappingHelper
    {
        public static string GetPercentageText(double? level)
        {
            if (level == null)
            {
                return "no data available";
            }

            return $"{level}%";
        }

        public static string GetPercentageText(double? level, bool isHei)
        {
            if (level == null && isHei)
            {
                return "Not currently collected for this training organisation";
            }

            if (level == null)
            {
                return "no data available";
            }

            return $"{level}%";
        }

        public static string GetDeliveryOptionText(List<string> deliveryOptions)
        {
            var deliveryOptionsMessage = string.Empty;
            if (deliveryOptions.IsNullOrEmpty())
            {
                return string.Empty;
            }

            if (deliveryOptions.Contains("DayRelease"))
            {
                deliveryOptionsMessage = "day release";
            }

            if (deliveryOptions.Contains("BlockRelease"))
            {
                deliveryOptionsMessage = deliveryOptionsMessage == string.Empty ? "block release" : string.Concat(deliveryOptionsMessage, ", block release");
            }

            if (deliveryOptions.Contains("100PercentEmployer"))
            {
                deliveryOptionsMessage = deliveryOptionsMessage == string.Empty ? "at your location" : string.Concat(deliveryOptionsMessage, ", at your location");
            }

            return $"{deliveryOptionsMessage}";
        }

        public static string GetCommaList(params string [] list)
        {
            return string.Join(", ", list.Where(m => !m.IsNullOrWhiteSpace()));
        }

        internal static string GetLocationAddressLine(TrainingLocation providerLocation)
        {
            return GetCommaList(
                providerLocation.LocationName,
                providerLocation.Address.Address1,
                providerLocation.Address.Address2,
                providerLocation.Address.Town,
                providerLocation.Address.County,
                providerLocation.Address.Postcode);
        }
    }
}