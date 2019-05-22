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

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PolyVal
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private double coefficient;
        private int exponent;
        private int selectedIndex;

        private ObservableCollection<TermViewModel> terms = new ObservableCollection<TermViewModel>();

        public double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; OnPropertyChanged(nameof(Coefficient)); }
        }

        public int Exponent
        {
            get { return exponent; }
            set { exponent = value; OnPropertyChanged(nameof(Exponent)); }
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; OnPropertyChanged(nameof(SelectedIndex));  }
        }

        public ObservableCollection<TermViewModel> Terms
        {
            get { return terms; }
            set { terms = value; OnPropertyChanged(nameof(Terms)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ResetCoefficientAndExponent()
        {
            SetCoefficientAndExponent(0d, 0);
        }

        public void SetCoefficientAndExponent(TermViewModel term)
        {
            SetCoefficientAndExponent(term.Coefficient, term.Exponent);
        }

        private void SetCoefficientAndExponent(double c, int e)
        {
            Coefficient = c;
            Exponent = e;
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
