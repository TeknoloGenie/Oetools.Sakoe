﻿#region header

// ========================================================================
// Copyright (c) 2018 - Julien Caillon (julien.caillon@gmail.com)
// This file (Main.cs) is part of Oetools.Runner.Cli.
// 
// Oetools.Runner.Cli is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Oetools.Runner.Cli is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Oetools.Runner.Cli. If not, see <http://www.gnu.org/licenses/>.
// ========================================================================

#endregion

using McMaster.Extensions.CommandLineUtils;
using Oetools.Runner.Cli.Command;

namespace Oetools.Runner.Cli {
    
    /// <summary>
    /// Main entry point for this CLI program
    /// </summary>
    internal class EntryPoint {
        public static int Main(string[] args) => CommandLineApplication.Execute<MainCommand>(args);
    }
}