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
/// An attribute used to mark methods, fields, properties, or events as injected members.
/// This attribute is intended to be used within the context of dynamically injecting
/// interface implementations or other members into types, typically through runtime processing or tooling.
/// </summary>
/// <remarks>
/// This attribute is automatically added to members during the injection process.
/// </remarks>
/// <seealso cref="InjectionLibrary.Utils.InjectionHelper"/>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Event,
    AllowMultiple = true)]
internal class InjectedMemberAttribute : Attribute;