﻿namespace Sfa.Das.Sas.ApplicationServices.Responses
{
    public class StatsResponse
    {
        public int StandardCount { get; set; }

        public int FrameworkCount { get; set; }

        public int ProviderCount { get; set; }

        public int ExpiringFrameworks { get; set; }

        public int StandardsWithProviders { get; set; }

        public int FrameworksWithProviders { get; set; }

        public int StandardsWithoutProviders { get; set; }

        public int FrameworksWithoutProviders { get; set; }

        public int EmployersLookingApprentices { get; set; }
    }
}