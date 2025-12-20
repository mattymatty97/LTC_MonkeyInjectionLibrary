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