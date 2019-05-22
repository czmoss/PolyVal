using System;
using System.Windows.Input;

namespace PolyVal
{
    public class EvaluateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return parameter is MainWindowViewModel;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainWindowViewModel vm)
            {
                // In case there are no terms, let's treat that as the zero polynomial.
                if (vm.Degree == null)
                {
                    vm.Value = 0;
                    return;
                }

                var value = 0d;
                foreach (var term in vm.Terms)
                {
                    var product = 1d;
                    for (var i = 0; i < term.Exponent; i++)
                    {
                        product *= vm.Point;
                    }
                    value += term.Coefficient * product;
                }
                vm.Value = value;
            }
        }
    }
}
