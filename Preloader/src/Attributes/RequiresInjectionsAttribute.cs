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

using System;

namespace InjectionLibrary.Attributes;

/// <summary>
/// Specifies that the annotated assembly requires specific dependency injections
/// to be applied at runtime. This attribute can be applied multiple times
/// within the same assembly to indicate various injection requirements.
/// </summary>
/// <remarks>
/// This attribute is automatically detected by the preloader logic in the
/// InjectionLibrary to ensure appropriate injections are applied during
/// initialization or runtime.
/// </remarks>
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RequiresInjectionsAttribute : Attribute;