﻿using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using FluentAssertions;
using MediatR;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Responses;
using Sfa.Das.Sas.Core.Configuration;
using Sfa.Das.Sas.Web.Controllers;
using Sfa.Das.Sas.Web.Services;
using Sfa.Das.Sas.Web.ViewModels;
using SFA.DAS.NLog.Logger;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Controllers
{
    [TestFixture]
    public sealed class ApprenticeshipControllerTests
    {
        private const string ApprenticeshipApiBaseUrl = "www.baseUrlForApprenticeshipsApi.com";
        private ApprenticeshipController _sut;
        private Mock<ILog> _mockLogger;
        private Mock<IMappingService> _mockMappingService;
        private Mock<IMediator> _mockMediator;
        private Mock<IConfigurationSettings> _configurationSettingsMock;

        [SetUp]
        public void Init()
        {
            _mockLogger = new Mock<ILog>();
            _mockMappingService = new Mock<IMappingService>();
            _mockMediator = new Mock<IMediator>();
            _configurationSettingsMock = new Mock<IConfigurationSettings>();
            _configurationSettingsMock.SetupGet(mock => mock.ApprenticeshipApiBaseUrl).Returns(ApprenticeshipApiBaseUrl);

            _sut = new ApprenticeshipController(
                _mockLogger.Object,
                _mockMappingService.Object,
                _mockMediator.Object,
                Mock.Of<IButtonTextService>(),
                Mock.Of<IFundingBandService>(),
                _configurationSettingsMock.Object);
        }

        [Test]
        public async Task ShouldRedirectIfSearchResultsPageTooHigh()
        {
            var viewModel = new ApprenticeshipSearchResultViewModel();
            _mockMappingService.Setup(x =>
                x.Map<ApprenticeshipSearchResponse, ApprenticeshipSearchResultViewModel>(It.IsAny<ApprenticeshipSearchResponse>()))
                .Returns(viewModel);
            _mockMediator.Setup(x => x.Send(It.IsAny<ApprenticeshipSearchQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ApprenticeshipSearchResponse
                {
                    StatusCode = ApprenticeshipSearchResponse.ResponseCodes.PageNumberOutOfUpperBound
                });

            var urlHelper = new Mock<UrlHelper>();

            urlHelper.Setup(x => x.Action(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RouteValueDictionary>()))
                     .Returns("www.google.co.uk");

            _sut.Url = urlHelper.Object;

            var result = await _sut.SearchResults(new ApprenticeshipSearchQuery()) as RedirectResult;

            result.Should().NotBeNull();
        }

        [Test]
        public void ShouldReturnSearchResults()
        {
            var viewModel = new ApprenticeshipSearchResultViewModel();

            _mockMediator.Setup(x => x.Send(It.IsAny<ApprenticeshipSearchQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ApprenticeshipSearchResponse
                        {
                            StatusCode = ApprenticeshipSearchResponse.ResponseCodes.Success
                        });

            _mockMappingService.Setup(x =>
                x.Map<ApprenticeshipSearchResponse, ApprenticeshipSearchResultViewModel>(It.IsAny<ApprenticeshipSearchResponse>()))
                .Returns(viewModel);

            var result = _sut.SearchResults(new ApprenticeshipSearchQuery()).Result as ViewResult;

            _mockMediator.Verify(x => x.Send(It.IsAny<ApprenticeshipSearchQuery>(), It.IsAny<CancellationToken>()));
            _mockMappingService.Verify(
                x =>
                x.Map<ApprenticeshipSearchResponse, ApprenticeshipSearchResultViewModel>(It.IsAny<ApprenticeshipSearchResponse>()),
                Times.Once);

            result.Model.Should().Be(viewModel);
        }

        [Test]
        public async Task ShouldSetSearchViewModel()
        {
            // Arrange
            var searchTerm = "Sport";
            var viewModel = new ApprenticeshipSearchResultViewModel { SearchTerm = searchTerm };
            _mockMappingService.Setup(x =>
                x.Map<ApprenticeshipSearchResponse, ApprenticeshipSearchResultViewModel>(It.IsAny<ApprenticeshipSearchResponse>()))
                .Returns(viewModel);
            _mockMediator.Setup(x => x.Send(It.IsAny<ApprenticeshipSearchQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ApprenticeshipSearchResponse
                {
                    StatusCode = ApprenticeshipSearchResponse.ResponseCodes.Success
                });

            var urlHelper = new Mock<UrlHelper>();

            urlHelper.Setup(x => x.Action(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<RouteValueDictionary>()))
                     .Returns("www.google.co.uk");

            _sut.Url = urlHelper.Object;

            // Act
            var result = await _sut.SearchResults(new ApprenticeshipSearchQuery { Keywords = searchTerm }) as ViewResult;

            // Assert
            var model = result.Model as ApprenticeshipSearchResultViewModel;
            model.SearchViewModel.Should().NotBeNull();
            model.SearchViewModel.SearchTerm.Should().Be(searchTerm);
            model.SearchViewModel.ApprenticeshipInfoApiBaseUrl.Should().Be(ApprenticeshipApiBaseUrl);
        }

        [Test]
        public void ShouldReturnResultWhenSearching()
        {
            // act
            var result = _sut.Search() as ViewResult;

            // assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnStandardNotFound()
        {
            _mockMediator.Setup(x => x.Send(It.IsAny<GetStandardQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetStandardResponse
                {
                    StatusCode = GetStandardResponse.ResponseCodes.StandardNotFound
                });

            var result = _sut.Standard("2", "test").Result as HttpNotFoundResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }

        [Test]
        public void ShouldReturnViewModelWhenAssessmentOrgsEntityNotFound()
        {
            var viewModel = new StandardViewModel();
            var response = new GetStandardResponse { StatusCode = GetStandardResponse.ResponseCodes.AssessmentOrgsEntityNotFound };
            _mockMediator.Setup(x => x.Send(It.IsAny<GetStandardQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);
            _mockMappingService.Setup(m => m.Map<GetStandardResponse, StandardViewModel>(response))
                .Returns(viewModel);

            var result = _sut.Standard("2", "test").Result as ViewResult;

            result.Should().NotBeNull();
            result.Model.Should().Be(viewModel);
        }

        [Test]
        public void ShouldReturnStandard()
        {
            // Assign
            var response = new GetStandardResponse();
            var viewModel = new StandardViewModel();

            _mockMediator.Setup(m => m.Send(It.IsAny<GetStandardQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            _mockMappingService.Setup(m => m.Map<GetStandardResponse, StandardViewModel>(response))
                .Returns(viewModel);

            // Act
            var result = _sut.Standard("1", "test").Result as ViewResult;

            // Assert
            _mockMediator.Verify(m => m.Send(It.IsAny<GetStandardQuery>(), It.IsAny<CancellationToken>()));
            _mockMappingService.Verify(m => m.Map<GetStandardResponse, StandardViewModel>(response));

            result.Model.Should().Be(viewModel);
        }

        [Test]
        public void ShouldReturnNotFoundIfStandardIdIsBelowZero()
        {
            _mockMediator.Setup(x => x.Send(It.IsAny<GetStandardQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetStandardResponse
                {
                    StatusCode = GetStandardResponse.ResponseCodes.InvalidStandardId
                });

            var result = _sut.Standard("-2", "test").Result as HttpNotFoundResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }

        [Test]
        public void ShouldReturnFramework()
        {
            // Assign
            var response = new GetFrameworkResponse();
            var viewModel = new FrameworkViewModel();

            _mockMediator.Setup(m => m.Send(It.IsAny<GetFrameworkQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            _mockMappingService.Setup(m => m.Map<GetFrameworkResponse, FrameworkViewModel>(response))
                .Returns(viewModel);

            // Act
            var result = _sut.Framework("1", "test").Result as ViewResult;

            // Assert
            _mockMediator.Verify(m => m.Send(It.IsAny<GetFrameworkQuery>(), It.IsAny<CancellationToken>()));
            _mockMappingService.Verify(m => m.Map<GetFrameworkResponse, FrameworkViewModel>(response));

            result.Model.Should().Be(viewModel);
        }

        [Test]
        public void ShouldReturnFrameworkNotFound()
        {
            _mockMediator.Setup(x => x.Send(It.IsAny<GetFrameworkQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetFrameworkResponse
                {
                    StatusCode = GetFrameworkResponse.ResponseCodes.FrameworkNotFound
                });

            var result = _sut.Framework("2", "test").Result as HttpNotFoundResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }

        [Test]
        public void ShouldReturnNotFoundIfFrameworkIdBelowZero()
        {
            _mockMediator.Setup(x => x.Send(It.IsAny<GetFrameworkQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetFrameworkResponse
                {
                    StatusCode = GetFrameworkResponse.ResponseCodes.InvalidFrameworkId
                });

            var result = _sut.Framework("2", "test").Result as HttpNotFoundResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }

        [Test]
        public void ShouldReturnStandardProviders()
        {
            var response = new GetStandardProvidersResponse
            {
                StatusCode = GetStandardProvidersResponse.ResponseCodes.Success
            };

            _mockMediator.Setup(x => x.Send(It.IsAny<GetStandardProvidersQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            _mockMappingService.Setup(x =>
                x.Map<GetStandardProvidersResponse, ProviderSearchViewModel>(response))
                .Returns(new ProviderSearchViewModel());

            _sut.SearchForStandardProviders("2", ProviderSearchResponseCodes.Success, "AB12 3CD", "test",string.Empty, string.Empty, null);

            _mockMediator.Verify(x => x.Send(It.IsAny<GetStandardProvidersQuery>(), It.IsAny<CancellationToken>()), Times.Once);

            _mockMappingService.Verify(
                x => x.Map<GetStandardProvidersResponse, ProviderSearchViewModel>(response), Times.Once);
        }

        [Test]
        public void ShouldReturnStandardProvidersNotFound()
        {
            var response = new GetStandardProvidersResponse
            {
                StatusCode = GetStandardProvidersResponse.ResponseCodes.NoStandardFound
            };

            _mockMediator.Setup(x => x.Send(It.IsAny<GetStandardProvidersQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            _mockMappingService.Setup(x => x.Map<GetStandardProvidersResponse, ProviderSearchViewModel>(
                It.IsAny<GetStandardProvidersResponse>()));

            var result = _sut.SearchForStandardProviders("2", ProviderSearchResponseCodes.Success, "AB12 3CD", "test", string.Empty, string.Empty, null).Result as HttpNotFoundResult;

            _mockMediator.Verify(x => x.Send(It.IsAny<GetStandardProvidersQuery>(), It.IsAny<CancellationToken>()), Times.Once);

            _mockMappingService.Verify(
                x => x.Map<GetStandardProvidersResponse, ProviderSearchViewModel>(
                    It.IsAny<GetStandardProvidersResponse>()), Times.Never);

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }

        [Test]
        public void ShouldReturnFrameworkProviders()
        {
            // Assign
            var response = new GetFrameworkProvidersResponse
            {
                StatusCode = GetFrameworkProvidersResponse.ResponseCodes.Success
            };

            _mockMediator.Setup(x => x.Send(It.IsAny<GetFrameworkProvidersQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            _mockMappingService.Setup(x =>
                x.Map<GetFrameworkProvidersResponse, ProviderSearchViewModel>(response))
                .Returns(new ProviderSearchViewModel());

            // Act
            _sut.SearchForFrameworkProviders("2", ProviderSearchResponseCodes.Success, "AB12 3CD", "test", string.Empty, string.Empty, null);

            // Assert
            _mockMediator.Verify(x => x.Send(It.IsAny<GetFrameworkProvidersQuery>(), It.IsAny<CancellationToken>()), Times.Once);

            _mockMappingService.Verify(
                x => x.Map<GetFrameworkProvidersResponse, ProviderSearchViewModel>(response), Times.Once);
        }

        [Test]
        public void ShouldReturnFrameworkProvidersNotFound()
        {
            var response = new GetFrameworkProvidersResponse
            {
                StatusCode = GetFrameworkProvidersResponse.ResponseCodes.NoFrameworkFound
            };

            _mockMediator.Setup(x => x.Send(It.IsAny<GetFrameworkProvidersQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(response);

            _mockMappingService.Setup(x => x.Map<GetFrameworkProvidersResponse, ProviderSearchViewModel>(
                It.IsAny<GetFrameworkProvidersResponse>()));

            var result = _sut.SearchForFrameworkProviders("2", ProviderSearchResponseCodes.Success, "AB12 3CD", "test", string.Empty, string.Empty, null).Result as HttpNotFoundResult;

            _mockMediator.Verify(x => x.Send(It.IsAny<GetFrameworkProvidersQuery>(), It.IsAny<CancellationToken>()), Times.Once);

            _mockMappingService.Verify(
                x => x.Map<GetFrameworkProvidersResponse, ProviderSearchViewModel>(
                    It.IsAny<GetFrameworkProvidersResponse>()), Times.Never);

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(404);
        }
    }
}
