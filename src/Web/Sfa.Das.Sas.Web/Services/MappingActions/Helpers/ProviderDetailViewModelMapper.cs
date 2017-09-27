namespace Sfa.Das.Sas.Web.Services.MappingActions.Helpers
{
    using System.Linq;
    using SFA.DAS.Apprenticeships.Api.Types.Providers;
    using ViewModels;

    public static class ProviderDetailViewModelMapper
    {
        public static ProviderDetailViewModel GetProviderDetailViewModel(Provider provider)
        {
            var viewModel = new ProviderDetailViewModel();
            if (provider.Aliases != null && provider.Aliases.Any())
            {
                viewModel.TradingNames = provider.Aliases.ToList().Aggregate((aggregatingTradingNames, aliasToAdd) => aggregatingTradingNames + ", " + aliasToAdd);
            }

            var employerSatisfationMessage =
                (provider.EmployerSatisfaction > 0)
                    ? ProviderMappingHelper.GetPercentageText(provider.EmployerSatisfaction)
                    : ProviderMappingHelper.GetPercentageText(null);

            var learnerSatisfationMessage =
                (provider.LearnerSatisfaction > 0)
                    ? ProviderMappingHelper.GetPercentageText(provider.LearnerSatisfaction)
                    : ProviderMappingHelper.GetPercentageText(null);

            viewModel.Email = provider.Email;
            viewModel.IsEmployerProvider = provider.IsEmployerProvider;
            viewModel.EmployerSatisfaction = provider.EmployerSatisfaction;
            viewModel.EmployerSatisfactionMessage = employerSatisfationMessage;
            viewModel.IsHigherEducationInstitute = provider.IsHigherEducationInstitute;
            viewModel.LearnerSatisfaction = provider.LearnerSatisfaction;
            viewModel.LearnerSatisfactionMessage = learnerSatisfationMessage;
            viewModel.NationalProvider = provider.NationalProvider;
            viewModel.Phone = provider.Phone;
            viewModel.UkPrn = provider.Ukprn;
            viewModel.ProviderName = provider.ProviderName;
            viewModel.Website = provider.Website;
            return viewModel;
        }
    }
}