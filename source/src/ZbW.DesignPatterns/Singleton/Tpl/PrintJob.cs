namespace ZbW.DesignPatterns.Singleton.Tpl
{
    public class PrintJob
    {
        private readonly string _content;

        public PrintJob(string content)
        {
            _content = content;
        }

        public override string ToString()
        {
            return _content;
        }
    }
}
