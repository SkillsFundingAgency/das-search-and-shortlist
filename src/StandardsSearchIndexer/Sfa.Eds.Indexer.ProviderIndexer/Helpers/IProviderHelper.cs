using System;
using System.Collections.Generic;
using Sfa.Eds.Das.Indexer.Common.Models;

namespace Sfa.Eds.Das.ProviderIndexer.Helpers
{
    public interface IProviderHelper
    {
        void IndexProviders(DateTime scheduledRefreshDateTime, ICollection<Provider> providers);

        void DeleteOldIndexes(DateTime scheduledRefreshDateTime);
        bool IsIndexCorrectlyCreated(DateTime scheduledRefreshDateTime);
        string GetIndexNameAndDateExtension(DateTime dateTime);

        bool CreateIndex(DateTime scheduledRefreshDateTime);

        void SwapIndexes(DateTime scheduledRefreshDateTime);
    }
}