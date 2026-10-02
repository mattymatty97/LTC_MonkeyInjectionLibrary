using System.Collections.Generic;
using JetBrains.Annotations;

namespace InjectionLibrary.Utils;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public sealed class InverseComparer<T> : IComparer<T>
{
    public static readonly InverseComparer<T> Default = new(Comparer<T>.Default);

    public static InverseComparer<T> Reverse(IComparer<T> comparer)
    {
        return new InverseComparer<T>(comparer);
    }

    private readonly IComparer<T> _comparer;

    private InverseComparer(IComparer<T> comparer)
    {
        this._comparer = comparer;
    }

    public int Compare(T x, T y)
    {
        return _comparer.Compare(y, x);
    }
}
