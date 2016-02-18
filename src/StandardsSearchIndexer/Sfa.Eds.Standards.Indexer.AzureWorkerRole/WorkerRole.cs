using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Microsoft.WindowsAzure.ServiceRuntime;
using Sfa.Eds.Indexer.Common.Configuration;
using Sfa.Eds.Indexer.StandardIndexer.Consumers;
using Sfa.Eds.ProviderIndexer.Consumers;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.DependencyResolution;

namespace Sfa.Eds.Standards.Indexer.AzureWorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent _runCompleteEvent = new ManualResetEvent(false);
        private IStandardControlQueueConsumer _standardControlQueueConsumer;
        private IProviderControlQueueConsumer _providerControlQueueConsumer;

        public override void Run()
        {
            Log.Info("Starting indexer...");
            while (true)
            {
                try
                {
                    var tasks = new List<Task>
                    {
                        _standardControlQueueConsumer.CheckMessage(),
                        _providerControlQueueConsumer.CheckMessage()
                    };

                    Task.WaitAll(tasks.ToArray());
                }
                catch (Exception ex)
                {
                    Log.Fatal("Exception from  " + ex);
                }

                Thread.Sleep(TimeSpan.FromMinutes(10));
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;
            Initialise();

            // For information on handling configuration changes see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.
            var result = base.OnStart();

            Log.Info("Started...");

            return result;
        }

        public override void OnStop()
        {
            Log.Info("Stopping...");

            _cancellationTokenSource.Cancel();
            _runCompleteEvent.WaitOne();

            base.OnStop();

            Log.Info("Stopped...");
        }

        private void Initialise()
        {
            var container = IoC.Initialize();
            _standardControlQueueConsumer = container.GetInstance<IStandardControlQueueConsumer>();
            _providerControlQueueConsumer = container.GetInstance<IProviderControlQueueConsumer>();

            Log4NetSettings.Initialise();
        }
    }
}