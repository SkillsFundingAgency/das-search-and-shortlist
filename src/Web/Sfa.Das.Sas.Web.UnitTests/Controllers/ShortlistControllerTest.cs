﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.Core.Collections;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Core.Logging;
using Sfa.Das.Sas.Web.Common;
using Sfa.Das.Sas.Web.Controllers;
using Sfa.Das.Sas.Web.UnitTests.Extensions;

namespace Sfa.Das.Sas.Web.UnitTests.Controllers
{
    [TestClass]
    public class ShortlistControllerTest
    {
        private const string RequestUrl = "http://www.google.co.uk";
        private const int StandardId = 5;
        private ShortlistController _controller;
        private Mock<IGetStandards> _mockStandardRepository;
        private Mock<IListCollection<int>> _mockCookieRepository;

        [SetUp]
        public void Init()
        {
            _mockStandardRepository = new Mock<IGetStandards>();
            _mockCookieRepository = new Mock<IListCollection<int>>();

            _controller = new ShortlistController(
                new Mock<ILog>().Object,
                _mockCookieRepository.Object);

           _controller.SetRequestUrl(RequestUrl);
        }

        [Test]
        public void ShouldAddStandardToShortListIfRequested()
        {
            // Arrange
            _mockStandardRepository.Setup(x => x.GetStandardById(It.IsAny<int>())).Returns(new Standard());
            _mockCookieRepository.Setup(x => x.AddItem(Constants.StandardsShortListCookieName, StandardId));

            // Act
            var result = _controller.AddStandard(StandardId, string.Empty);

            // Assert
            NUnit.Framework.Assert.IsNotNull(result);
            _mockCookieRepository.Verify(x => x.AddItem(Constants.StandardsShortListCookieName, StandardId), Times.Once());
        }

        [Test]
        public void ShouldRemoveStandardFromShortListIfRequested()
        {
            // Arrange
            _mockStandardRepository.Setup(x => x.GetStandardById(It.IsAny<int>())).Returns(new Standard());
            _mockCookieRepository.Setup(x => x.RemoveItem(Constants.StandardsShortListCookieName, StandardId));

            // Act
            var result = _controller.RemoveStandard(StandardId, string.Empty);

            // Assert
            NUnit.Framework.Assert.IsNotNull(result);
            _mockCookieRepository.Verify(x => x.RemoveItem(Constants.StandardsShortListCookieName, StandardId), Times.Once());
        }
    }
}
