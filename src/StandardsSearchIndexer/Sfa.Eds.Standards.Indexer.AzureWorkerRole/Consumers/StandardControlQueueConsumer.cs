﻿using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using log4net;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.AzureAbstractions;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Services;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Settings;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole.Consumers
{
    public class StandardControlQueueConsumer : IControlQueueConsumer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly ICloudQueueService _cloudQueueService;

        private readonly IStandardIndexSettings _standardIndexSettings;
        private readonly IStandardIndexerService _standardIndexerService;

        public StandardControlQueueConsumer(
            IStandardIndexerService standardIndexerService,
            IStandardIndexSettings standardIndexSettings,
            ICloudQueueService cloudQueueService)
        {
            _standardIndexSettings = standardIndexSettings;
            _cloudQueueService = cloudQueueService;
            _standardIndexerService = standardIndexerService;
        }

        public Task CheckMessage()
        {
            return Task.Run(() =>
            {
                var queue = _cloudQueueService.GetQueueReference(_standardIndexSettings.ConnectionString, _standardIndexSettings.QueueName);
                var cloudQueueMessages = queue.GetMessages(10);
                var messages = cloudQueueMessages.OrderByDescending(x => x.InsertionTime);

                if (messages.Any())
                {
                    var message = messages.FirstOrDefault();
                    if (message != null)
                    {
                        Log.Info("Creating new scheduled standard index at " + DateTime.Now);
                        _standardIndexerService.CreateScheduledIndex(message.InsertionTime?.DateTime ?? DateTime.Now);
                    }
                }

                foreach (var cloudQueueMessage in messages)
                {
                    queue.DeleteMessage(cloudQueueMessage);
                }
            });
        }
    }
}