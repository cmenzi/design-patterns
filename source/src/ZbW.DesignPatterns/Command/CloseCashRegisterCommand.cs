using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Command
{
    public class CloseCashRegisterCommand : ICommand
    {
        private OpenCloseButton _closeButton { get; set; }

        public CloseCashRegisterCommand(OpenCloseButton closeButton)
        {
            _closeButton = closeButton;
        }

        public void Execute()
        {
            _closeButton.Close();
        }
    }
}
