﻿using System;
using System.Threading;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Services;
using Sfa.Das.Sas.Shared.Components.Configuration;
using Sfa.Das.Sas.Shared.Components.ViewModels;

namespace Sfa.Das.Sas.Web.UnitTests.Infrastructure.Services
{
    public class CacheStorageServiceTests
    {
        private Mock<IDistributedCache> _mockDistributedCache;
        private CacheStorageService _sut;
        private MemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());

        private TimeSpan cacheAbsoluteExipration;
        private TimeSpan cacheSlidingExpiration;

        [SetUp]
        public void Setup()
        {
            cacheAbsoluteExipration = new TimeSpan(30, 0, 0, 0);
            cacheSlidingExpiration = new TimeSpan(1, 0, 0, 0);

            _mockDistributedCache = new Mock<IDistributedCache>();

            _sut = new CacheStorageService(_mockDistributedCache.Object, memoryCache, new FatSharedComponentsConfiguration { CacheMemoryAbsoluteExpirySeconds = 5 });
        }

        [Test]
        public void GetsDataFromInMemoryCache_AndDoesntCheckDistributedCache()
        {
            memoryCache.Set("123456", "1234567889");

            var response = _sut.RetrieveFromCache<TrainingProviderDetailsViewModel>("123456");

            _mockDistributedCache.Verify(s => s.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Never());
        }

        [Test]
        public void GetsFromDistributedCacheIfKeyDoesntExistInMemoryCache()
        {
            memoryCache = new MemoryCache(new MemoryCacheOptions());

            _sut = new CacheStorageService(_mockDistributedCache.Object, memoryCache, new FatSharedComponentsConfiguration { CacheMemoryAbsoluteExpirySeconds = 5 });

            var response = _sut.RetrieveFromCache<TrainingProviderDetailsViewModel>("123456");

            _mockDistributedCache.Verify(s => s.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once());

        }

        [Test]
        public void SavesToDistributedCache()
        {
            memoryCache = new MemoryCache(new MemoryCacheOptions());

            _sut = new CacheStorageService(_mockDistributedCache.Object, memoryCache, new FatSharedComponentsConfiguration { CacheMemoryAbsoluteExpirySeconds = 5 });

            var response = _sut.SaveToCache<TrainingProviderDetailsViewModel>("testkey", GetTestTrainingProviderDetails(), cacheAbsoluteExipration, cacheSlidingExpiration);

            _mockDistributedCache.Verify(s => s.SetAsync(It.IsAny<string>(), It.IsAny<byte[]>(), It.IsAny<DistributedCacheEntryOptions>(), It.IsAny<CancellationToken>()), Times.Once());
        }

        private TrainingProviderDetailsViewModel GetTestTrainingProviderDetails()
        {
            return new TrainingProviderDetailsViewModel()
            {
                Name = "Test Provider"
            };
        }
    }
}
