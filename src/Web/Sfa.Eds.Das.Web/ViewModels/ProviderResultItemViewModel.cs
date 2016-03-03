﻿using System.Collections.Generic;
using Sfa.Das.ApplicationServices.Models;

namespace Sfa.Eds.Das.Web.ViewModels
{
    public class ProviderResultItemViewModel
    {
        public int Id { get; set; }

        public string ProviderName { get; set; }

        public string PostCode { get; set; }

        public double Distance { get; set; }

        public string Website { get; set; }

        public string TrainingLocationName { get; set; }

        public string TrainingLocationAddress { get; set; }

        public double EmployerSatisfaction { get; set; }

        public double LearnerSatisfaction { get; set; }

        public List<DeliveryMode> DeliveryModes { get; set; }
    }
}