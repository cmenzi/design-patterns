using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Command
{
    public class OpenCashRegisterCommand : ICommand
    {
        private OpenCloseButton _openButton { get; set; }

        public OpenCashRegisterCommand(OpenCloseButton openButton)
        {
            _openButton = openButton;
        }

        public void Execute()
        {
            _openButton.Open();
        }
    }
}
