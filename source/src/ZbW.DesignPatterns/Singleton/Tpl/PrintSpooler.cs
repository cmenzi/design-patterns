namespace ZbW.DesignPatterns.Singleton.Tpl
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    public class PrinterSpoolerEx
    {
        public readonly static PrinterSpoolerEx Default = new PrinterSpoolerEx();

        private PrinterSpoolerEx()
        {
        }
    }

    public class PrintSpooler : IAsyncDisposable
    {
        private static PrintSpooler _instance;

        private readonly BlockingCollection<PrintJob> _jobs;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private readonly Task _task;

        private PrintSpooler()
        {
            _jobs = new BlockingCollection<PrintJob>(new ConcurrentQueue<PrintJob>());
            _cancellationTokenSource = new CancellationTokenSource();
            _task = new Task(ProcessPrintJobs, _cancellationTokenSource.Token);
        }

        private void ProcessPrintJobs()
        {
            foreach (var job in _jobs.GetConsumingEnumerable(_cancellationTokenSource.Token))
            {
                Console.WriteLine(job.ToString());
            }
        }

        public void Start()
        {
            Task.Run(() => _task);
        }

        public void Stop()
        {
            _jobs.CompleteAdding();
        }

        public void Enqueue(PrintJob printJob)
        {
            _jobs.Add(printJob);
        }

        public static PrintSpooler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PrintSpooler();
            }

            return _instance;
        }

        public async ValueTask DisposeAsync()
        {
            _cancellationTokenSource.Cancel();
            await _task.ConfigureAwait(false);
        }
    }
}
