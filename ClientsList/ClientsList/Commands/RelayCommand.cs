using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientsList.Commands
{
    public class RelayCommand : ICommand
    {
        private ExecuteCommandDelegate _execute;
        private CanExecuteCommandDelegate _canExecute;

        public RelayCommand(ExecuteCommandDelegate execute)
            : this(execute, null)
        {

        }

        public RelayCommand(ExecuteCommandDelegate execute, CanExecuteCommandDelegate canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (this._canExecute != null)
            {
                return this._canExecute(parameter);
            }
            return true;
        }

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
