namespace ZbW.DesignPatterns.Tests.Singleton.Threading
{
    using Xunit;

    using ZbW.DesignPatterns.Singleton.Threads;

    public class SingletonTests
    {
        [Fact]
        public void PrintJob_WhenAddingPrintJob_ThenPrintPrintJob()
        {
            // Arrange
            var printSpooler = PrintSpooler.GetInstance();

            // Act
            printSpooler.Enqueue(new PrintJob("42"));
           
            // Assert?
        }
    }
}
