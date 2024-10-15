using System.Diagnostics.CodeAnalysis;

namespace NestedRPObjValidationSample;

public static class Verify
{
    public static void ThrowIfNull([NotNull] object? value) => _ = value ?? throw new ArgumentNullException(nameof(value));
}
