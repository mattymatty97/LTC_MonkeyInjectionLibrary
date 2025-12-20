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