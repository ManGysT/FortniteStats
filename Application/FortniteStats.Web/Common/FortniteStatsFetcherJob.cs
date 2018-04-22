using FortniteStats.Web.Models;
using FortniteStats.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace FortniteStats.Web.Common
{
    public class FortniteStatsFetcherJob
    {
        private static readonly FortniteStatsFetcherJob instance = new FortniteStatsFetcherJob();
        private Task backgroundThread;
        private CancellationTokenSource cancellationTokenSource;

        public delegate void StatsUpdated(StatsCollection stats);

        private FortniteStatsFetcherJob()
        {
            this.OnStatsUpdated = (sc) => {};
        }

        public static FortniteStatsFetcherJob Instance
        {
            get
            {
                return instance;
            }
        }

        public event StatsUpdated OnStatsUpdated;

        public void Start(StatsFetchingService fetchingService)
        {
            this.RunBackgroundThread(fetchingService);
        }

        public void Stop()
        {
            if (this.cancellationTokenSource.IsCancellationRequested)
            {
                return;
            }

            this.cancellationTokenSource.Cancel();
        }

        private void RunBackgroundThread(StatsFetchingService fetchingService)
        {
            this.cancellationTokenSource = new CancellationTokenSource();

            this.backgroundThread = Task.Factory
                .StartNew(
                    () => FetchFortniteStats(fetchingService, this.cancellationTokenSource.Token),
                    this.cancellationTokenSource.Token
                );
        }

        private void FetchFortniteStats(StatsFetchingService fetchingService, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var stats = fetchingService.GetStats();

                this.OnStatsUpdated(stats);
            }
        }
    }
}