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