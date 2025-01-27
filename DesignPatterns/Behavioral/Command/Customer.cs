using DesignPatterns.Creational.Command.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Command
{
    public class Customer
    {
        public ICommand Command;
        public void SetCommand(ICommand command)
        {
            Command = command;
        }
        public EAction ExecuteCommand() {
            return Command.Execute();
        }
    }

}
