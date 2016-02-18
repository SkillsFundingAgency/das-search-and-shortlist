using System;
using System.Collections.Generic;
using Sfa.Eds.Indexer.Common.Models;

namespace Sfa.Eds.ProviderIndexer.Helpers
{
    public interface IProviderHelper
    {
        bool CreateIndex(DateTime scheduledRefreshDateTime);
        void IndexProviders(DateTime scheduledRefreshDateTime, List<Provider> providers);
        void SwapIndexes(DateTime scheduledRefreshDateTime);
        void DeleteOldIndexes(DateTime scheduledRefreshDateTime);
        bool IsIndexCorrectlyCreated(DateTime scheduledRefreshDateTime);
        string GetIndexNameAndDateExtension(DateTime dateTime);
        List<Provider> GetProviders();
    }
}