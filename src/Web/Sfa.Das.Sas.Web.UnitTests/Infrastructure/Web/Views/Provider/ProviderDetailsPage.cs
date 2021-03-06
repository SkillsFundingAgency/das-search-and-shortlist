﻿using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using RazorGenerator.Testing;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.ExtensionHelpers;
using Sfa.Das.Sas.Web.ViewModels;
using Sfa.Das.Sas.Web.Views.Provider;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Web.Views.Provider
{
    [TestFixture]
    public sealed class ProviderDetailsPage : ViewTestBase
    {
        [Test]
        public void ShouldShowAllFieldsWhenEverythingIsOk()
        {
            var detail = new Detail();

            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                LegalName = "Legal Test Name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                LocationAddressLine = "Test location name, Address 1, Address 2, Town, County, PostCode",
                DeliveryModes = new List<string> { "BlockRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "http://www.testcontact.url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "www.test-apprenticeship.info.url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".apprenticeshipContactTitle").Should().Contain("Website");
            GetPartial(html, ".apprenticeshipContact").Should().Contain("Test name website");
            GetAttribute(html, ".apprenticeshipContact", "href").Should().Be("http://www.test-apprenticeship.info.url", "because http be added if missing");
            GetPartial(html, ".providerContactTitle").Should().Contain("Contact page");
            GetPartial(html, ".providerContact").Should().Contain("contact this training provider");
            GetAttribute(html, ".providerContact", "href").Should().Be("http://www.testcontact.url", "http should only be added once");

            GetPartial(html, ".legal-name").Should().Contain("Legal Test Name");
            GetPartial(html, ".phone-title").Should().Contain("Phone");
            GetPartial(html, ".phone").Should().Contain(model.ContactInformation.Phone);
            GetPartial(html, ".email-title").Should().Contain("Email");
            GetPartial(html, ".email").Should().Contain(model.ContactInformation.Email);
            GetPartial(html, ".training-structure").Should().Contain("Training options");
            GetPartial(html, ".block-release").Should().Contain("block release");
            GetPartial(html, ".block-release-absent").Should().BeEmpty();
            GetPartial(html, ".hundred-percent-employer").Should().BeEmpty();
            GetPartial(html, ".hundred-percent-employer-absent").Should().Contain("at your location");
            GetPartial(html, ".day-release").Should().BeEmpty();
            GetPartial(html, ".day-release-absent").Should().Contain("day release");
            GetPartial(html, ".training-location-title").Should().Contain("Address");
            GetPartial(html, ".training-location").Should().Contain("Test location name, Address 1, Address 2, Town, County, PostCode");
        }

        [Test]
        public void ShouldShowAllDeliveryModesProperly()
        {
            var detail = new Detail();

            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".training-structure").Should().Contain("Training options");
            GetPartial(html, ".block-release").Should().Contain("block release");
            GetPartial(html, ".block-release-absent").Should().BeEmpty();
            GetPartial(html, ".hundred-percent-employer").Should().Contain("at your location");
            GetPartial(html, ".hundred-percent-employer-absent").Should().BeEmpty();
            GetPartial(html, ".day-release").Should().Contain("day release");
            GetPartial(html, ".day-release-absent").Should().BeEmpty();
        }

        [Test]
        public void ShouldShowAllDeliveryModesAreAbsent()
        {
            var detail = new Detail();

            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string>(),
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".training-structure").Should().Contain("Training options");
            GetPartial(html, ".block-release-absent").Should().Contain("block release");
            GetPartial(html, ".block-release").Should().BeEmpty();
            GetPartial(html, ".hundred-percent-employer-absent").Should().Contain("at your location");
            GetPartial(html, ".hundred-percent-employer").Should().BeEmpty();
            GetPartial(html, ".day-release-absent").Should().Contain("day release");
            GetPartial(html, ".day-release").Should().BeEmpty();
        }

        [Test]
        public void ShouldShowAddressIfThereAreMoreDeliveryModesApartFromEmployerLocation()
        {
            var detail = new Detail();

            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                LocationAddressLine = "Test location name, Address 1, Address 2",
                DeliveryModes = new List<string> { "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();
            var locationText = GetPartial(html, ".training-location");

            locationText.Should().Contain(model.Location.LocationName);
            locationText.Should().Contain(model.Address.Address1);
            locationText.Should().Contain(model.Address.Address2);

        }

        [Test]
        public void ShouldShowProviderLocationWhenDifferentDeliveryModesThan100PercentEmployerLocation()
        {
            var detail = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                LocationAddressLine = "Test location name, Address 1, Address 2",
                DeliveryModes = new List<string> { "BlockRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();

            var locationText = GetPartial(html, ".training-location");

            locationText.Should().Contain(model.Location.LocationName);
            locationText.Should().Contain(model.Address.Address1);
            locationText.Should().Contain(model.Address.Address2);
        }

        [Test]
        public void ShouldShowProviderMarketingInfo()
        {
            var detail = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };
            var html = detail.RenderAsHtml(model).ToAngleSharp();

            var providerMarketingInfoHtml = GetPartial(html, ".provider-marketing-info");

            providerMarketingInfoHtml.Should().Contain(model.ProviderMarketingInfo);
        }

        [Test]
        public void ShouldShowSourceOfSatisfactionDataIdThereIsAny()
        {
            var details = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "100%",
                LearnerSatisfactionMessage = "100%",
                EmployerSatisfaction = 12,
                LearnerSatisfaction = 45,
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".satisfaction-source").Should().Contain("Source:");
        }

        [Test]
        public void ShouldNotShowSourceOfSatisfactionDataIdThereIsAny()
        {
            var details = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                EmployerSatisfactionMessage = "no data available",
                LearnerSatisfactionMessage = "no data available",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".satisfaction-source").Should().NotContain("Source:");
        }

        [Test]
        public void ShouldShowNationalProviderMessageWhenThatProviderIsAvailableAroundTheCountry()
        {
            var details = new Detail();
            
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                NationalProvider = true,
                EmployerSatisfactionMessage = "no data available",
                LearnerSatisfactionMessage = "no data available",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".national-message").Should().NotBeNullOrEmpty();
            GetPartial(html, ".national-message").Should().Be("National This training provider is willing to offer apprenticeship training across England.");
        }

        [Test]
        public void ShouldNotShowNationalProviderMessageWhenThatFieldIsFalse()
        {
            var details = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                Name = "Test name",
                NationalProvider = false,
                EmployerSatisfactionMessage = "no data available",
                LearnerSatisfactionMessage = "no data available",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                },
                ProviderMarketingInfo = "Test provider marketing info",
                ApprenticeshipName = "Test level"
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".national-message").Should().BeNullOrEmpty();
        }

        [Test]
        public void ShouldShowMoreInformationLinkWhenThereIsProviderAchivementValue()
        {
            var details = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                NationalAchievementRate = 83,
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                }
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".more-information").Should().NotBeNullOrEmpty();
        }

        [Test]
        public void ShouldNotShowMoreInformationLinkWhenThereIsNoProviderAchivementValue()
        {
            var details = new Detail();
            var model = new ApprenticeshipDetailsViewModel
            {
                AchievementRateMessage = "no data available",
                Location = new Location
                {
                    LocationId = 1,
                    LocationName = "Test location name"
                },
                Address = new Address
                {
                    Address1 = "Address 1",
                    Address2 = "Address 2",
                    County = "County",
                    Postcode = "PostCode",
                    Town = "Town"
                },
                DeliveryModes = new List<string> { "BlockRelease", "100PercentEmployer", "DayRelease" },
                ContactInformation = new ContactInformation
                {
                    ContactUsUrl = "Test contact url",
                    Email = "Test email",
                    Website = "Test website",
                    Phone = "Test phone"
                },
                Apprenticeship = new ApprenticeshipBasic
                {
                    ApprenticeshipInfoUrl = "Test apprenticeship info url",
                    ApprenticeshipMarketingInfo = "Test apprenticeship marketing info"
                }
            };

            var html = details.RenderAsHtml(model).ToAngleSharp();

            GetPartial(html, ".more-information").Should().BeNullOrEmpty();
        }
    }
}