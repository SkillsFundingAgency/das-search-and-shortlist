﻿using System.Linq;
using SFA.DAS.AssessmentOrgs.Api.Client;

namespace Sfa.Das.Sas.ApplicationServices.Handlers
{
    using Core.Domain.Services;
    using MediatR;
    using Queries;
    using Responses;

    public class GetStandardHandler : IRequestHandler<GetStandardQuery, GetStandardResponse>
    {
        private readonly IGetStandards _getStandards;
        private readonly IAssessmentOrgsApiClient _getAssessmentOrgs;

        public GetStandardHandler(IGetStandards getStandards, IAssessmentOrgsApiClient getAssessmentOrgs)
        {
            _getStandards = getStandards;
            _getAssessmentOrgs = getAssessmentOrgs;
        }

        public GetStandardResponse Handle(GetStandardQuery message)
        {
            var response = new GetStandardResponse();

            var standard = _getStandards.GetStandardById(message.Id);

            int intId;
            int.TryParse(message.Id, out intId);
            if (intId < 0)
            {
                response.StatusCode = GetStandardResponse.ResponseCodes.InvalidStandardId;

                return response;
            }

            if (standard == null)
            {
                response.StatusCode = GetStandardResponse.ResponseCodes.StandardNotFound;

                return response;
            }

            response.AssessmentOrganisations = _getAssessmentOrgs.ByStandard(standard.StandardId).ToList();

            response.Standard = standard;
            response.SearchTerms = message.Keywords;

            return response;
        }
    }
}
