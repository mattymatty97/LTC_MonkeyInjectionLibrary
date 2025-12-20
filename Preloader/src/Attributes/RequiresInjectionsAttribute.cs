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