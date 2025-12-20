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
/// An attribute used to specify a custom error handling strategy for methods, properties,
/// interfaces, or assemblies. This attribute allows defining an error handling behavior
/// that can be applied during runtime for handling exceptions or special states.
/// </summary>
/// <remarks>
/// This attribute is applicable for Assembly, Interface, Property, and Method targets.
/// </remarks>
[UsedImplicitly(ImplicitUseTargetFlags.Members)]
[AttributeUsage(validOn: AttributeTargets.Assembly | AttributeTargets.Interface | AttributeTargets.Property | AttributeTargets.Method)]
public class HandleErrorsAttribute : Attribute
{
    public HandleErrorsAttribute(ErrorHandlingStrategy strategy)
    {
        Strategy = strategy;
    }

    public HandleErrorsAttribute(int strategy)
    {
        Strategy = (ErrorHandlingStrategy)strategy;
    }

    public ErrorHandlingStrategy Strategy { get; }
}