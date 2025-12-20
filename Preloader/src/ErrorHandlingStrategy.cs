// MonkeyInjectionLibrary – A library mod that lets other mods add properties and methods to existing base-game classes at runtime, without modifying game files.
// Copyright (C) 2025  mattymatty97
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

namespace InjectionLibrary;

/// <summary>
/// Defines strategies for handling errors during injection operations.
/// </summary>
public enum ErrorHandlingStrategy
{
    /// <summary>
    /// Immediately terminates the injection process when an error occurs.
    /// </summary>
    Terminate,

    /// <summary>
    /// Silently ignores errors and continues execution.
    /// </summary>
    Ignore,

    /// <summary>
    /// Logs the error as a warning and continues execution.
    /// </summary>
    LogWarning,

    /// <summary>
    /// Logs the error and continues execution.
    /// </summary>
    LogError,
}