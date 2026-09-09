// Build: 53c6068eaa3445d3ad6c206843c9ebc4
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
