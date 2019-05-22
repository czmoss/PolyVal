/*
Copyright 2019 Charles Moss

This file is part of PolyVal.

PolyVal is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free
Software Foundation, either version 3 of the License, or (at your
option) any later version.

PolyVal is distributed in the hope that it will be useful, but WITHOUT
ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
for more details.

You should have received a copy of the GNU General Public License along
with PolyVal.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Linq;
using System.Windows.Input;

namespace PolyVal
{
    public class AddTermCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (parameter == null)
            {
                return false;
            }

            return parameter is MainWindowViewModel vm && vm.Coefficient != 0 && vm.Exponent >= 0;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainWindowViewModel vm)
            {
                // Instead of having to gather like terms during evaluation,
                // let's just put them together now.
                var term = vm.Terms.FirstOrDefault(t => t.Exponent == vm.Exponent);
                if (term != null)
                {
                    term.Coefficient += vm.Coefficient;
                }
                else
                {
                    vm.Terms.Add(new TermViewModel
                    {
                        Coefficient = vm.Coefficient,
                        Exponent = vm.Exponent,
                    });
                }
                vm.ResetCoefficientAndExponent();
            }
        }
    }
}
