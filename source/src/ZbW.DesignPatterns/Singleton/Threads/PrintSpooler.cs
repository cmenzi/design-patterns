namespace ZbW.DesignPatterns.Singleton.Threads
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class PrintSpooler
    {
        private static PrintSpooler _instance;

        private readonly Queue<PrintJob> _jobs;
        private readonly Thread _thread;
        private volatile bool cancelRequested;
        private readonly AutoResetEvent _autoResetEvent;
        
        private PrintSpooler()
        {
            _jobs = new Queue<PrintJob>();
            _thread = new Thread(ProcessPrintJobs);
            _autoResetEvent = new AutoResetEvent(false);
        }

        private void ProcessPrintJobs(object obj)
        {
            while (!cancelRequested)
            {
                if (_autoResetEvent.WaitOne())
                {
                    if (_jobs.Count > 0)
                    {
                        var printJob = _jobs.Dequeue();
                        Console.WriteLine($"Print Job: {printJob}");
                    }
                }
            }
        }

        public void Start()
        {
            _thread.Start();
        }

        public void Stop()
        {
            cancelRequested = true;
            _thread.Join();
        }

        public void Enqueue(PrintJob printJob)
        {
            _jobs.Enqueue(printJob);
            _autoResetEvent.Set();
        }

        public static PrintSpooler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PrintSpooler();
            }

            return _instance;
        }
    }
}
