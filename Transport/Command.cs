using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Transport
{
    class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action _action;

        public Command(Action actionToExecute)
        {
            this._action = actionToExecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._action();
        }
    }
}
