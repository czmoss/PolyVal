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

using System.ComponentModel;

namespace PolyVal
{
    public class TermViewModel : INotifyPropertyChanged
    {
        private double coefficient;
        private int exponent;

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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
