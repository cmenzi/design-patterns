namespace ZbW.DesignPatterns.Command
{
    public class OpenCloseButton
    {
        public bool IsOpen { get; private set; }

        public OpenCloseButton() { }

        public void Open()
        {
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }
    }
}
