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
using JetBrains.Annotations;

namespace InjectionLibrary.Attributes;

/// <summary>
/// Specifies an attribute that can be applied to interfaces to indicate that they should be injected
/// into the specified target type during runtime.
/// </summary>
/// <remarks>
/// This attribute is applied to interfaces and is used for dependency injection purposes.
/// The injection framework uses this attribute to determine and inject the appropriate implementation
/// of the interface into the specified target type.
/// </remarks>
[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
[AttributeUsage(AttributeTargets.Interface, AllowMultiple = true)]
public sealed class InjectInterfaceAttribute(Type targetType) : Attribute
{
    public string AssemblyName => targetType.Assembly.GetName().Name;
    public string TypeName => targetType.FullName;
}