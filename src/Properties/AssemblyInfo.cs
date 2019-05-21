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

using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows;

[assembly: AssemblyTitle("PolyVal")]
[assembly: AssemblyDescription("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyProduct("PolyVal")]
[assembly: AssemblyCopyright("Copyright 2019 Charles Moss")]

[assembly: ComVisible(false)]

[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]

[assembly: ThemeInfo(
    //where theme-specific resource dictionaries are located (used if a resource is not found in the page, or application resource dictionaries)
    ResourceDictionaryLocation.None,
    //where the generic resource dictionary is located (used if a resource is not found in the page, app, or any theme-specific resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly)]

[assembly: AssemblyVersion("0.1.0")]
[assembly: AssemblyInformationalVersion("0.1.0")]
