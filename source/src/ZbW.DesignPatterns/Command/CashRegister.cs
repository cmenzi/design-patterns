using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Command
{
    public class CashRegister
    {
        private ICommand _openCommand { get; set; }
        private ICommand _closeCommand { get; set; }
        
        public CashRegister(ICommand openCommand, ICommand closeCommand)
        {
            _openCommand = openCommand;
            _closeCommand = closeCommand;
        }

        public void Close()
        {
            _closeCommand.Execute();
        }

        public void Open()
        {
            _openCommand.Execute();
        }
    }
}
