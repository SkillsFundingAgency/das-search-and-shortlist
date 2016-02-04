﻿using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Sfa.Eds.Das.Web.Controllers;
using Sfa.Eds.Das.Web.Services;

namespace Sfa.Eds.Das.Web.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(null, null);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void Search()
        {
            var mockSearchService = new Mock<ISearchForStandards>();

            // Arrange
            HomeController controller = new HomeController(mockSearchService.Object, null);

            // Act
            ViewResult result = controller.Search(new Models.SearchCriteria()) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
