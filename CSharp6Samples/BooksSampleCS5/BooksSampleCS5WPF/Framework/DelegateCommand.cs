using System;
using System.Windows.Input;

namespace BooksSample.Framework
{
    public class DelegateCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;

        // TODO: nameof
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action execute)
            : this(execute, null)
        { }

        public event EventHandler CanExecuteChanged;

        // TODO: elvis operator && expression bodied member

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return true;
            return _canExecute.Invoke();
        }


        public void Execute(object parameter)
        {
            _execute();
        }

        // TODO: Elvis operator
        public void RaiseCanExecuteChanged()
        {
            EventHandler handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

    }
}