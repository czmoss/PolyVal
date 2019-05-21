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

using System.Windows;

namespace PolyVal
{
    public partial class App : Application
    {
        public void AppStartup(object sender, StartupEventArgs args)
        {
            var w = new MainWindow { DataContext = new MainWindowViewModel() };
            w.Show();
        }
    }
}
