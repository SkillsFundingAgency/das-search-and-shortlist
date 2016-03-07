﻿namespace Sfa.Eds.Das.Indexer.Common.UnitTests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Moq;

    using NUnit.Framework;

    using Sfa.Eds.Das.Indexer.ApplicationServices.Infrastructure;
    using Sfa.Eds.Das.Indexer.ApplicationServices.Services;
    using Sfa.Eds.Das.Indexer.ApplicationServices.Services.Interfaces;
    using Sfa.Eds.Das.Indexer.ApplicationServices.Settings;
    using Sfa.Eds.Das.Indexer.Core;
    using Sfa.Eds.Das.ProviderIndexer.Models;

    [TestFixture]
    public class IndexerServiceTests
    {
        [SetUp]
        public void Setup()
        {
            _mockHelper = new Mock<IGenericIndexerHelper<Provider>>();
            _mockSettings =
                Mock.Of<IIndexSettings<Provider>>(
                    x => x.PauseTime == "10" && x.SearchHost == "http://104.45.94.2:9200" && x.IndexesAlias == "ciproviderindexesalias");

            _sut = new IndexerService<Provider>(_mockSettings, _mockHelper.Object, Mock.Of<ILog>());
        }

        private Mock<IGenericIndexerHelper<Provider>> _mockHelper;

        private IIndexSettings<Provider> _mockSettings;

        private IndexerService<Provider> _sut;

        [Test]
        public async Task ShouldIndexProvidersIfThatIndexHasBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<DateTime>())).Returns(true);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<DateTime>(), It.IsAny<ICollection<Provider>>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<DateTime>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<DateTime>()), Times.AtMostOnce);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldNotIndexProvidersIfThatIndexHasNotBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<DateTime>())).Returns(false);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<DateTime>(), It.IsAny<ICollection<Provider>>()), Times.Never);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldNotSwapIdexesIfNewOneHasNotBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<DateTime>())).Returns(true);
            _mockHelper.Setup(x => x.IsIndexCorrectlyCreated(It.IsAny<DateTime>())).Returns(false);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<DateTime>(), It.IsAny<ICollection<Provider>>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<DateTime>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<DateTime>()), Times.Never);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldSwapIdexesIfNewOneHasBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<DateTime>())).Returns(true);
            _mockHelper.Setup(x => x.IsIndexCorrectlyCreated(It.IsAny<DateTime>())).Returns(true);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<DateTime>(), It.IsAny<ICollection<Provider>>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<DateTime>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<DateTime>()), Times.Once);
            _mockHelper.VerifyAll();
        }
    }
}