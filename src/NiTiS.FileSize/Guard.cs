using System;
using System.Runtime.CompilerServices;

namespace NiTiS;

internal static class Guard
{
	/// <summary>
	/// Asserts that the input value is zero or positive value.
	/// </summary>
	/// <param name="value">The input <see langword="long" /> value to test.</param>
	/// <param name="name">The name of the input parameter being tested.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="value"/> is negative.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void IsPositiveOrZero(long value, string name)
	{
		if (value >= 0) return;

		throw new ArgumentOutOfRangeException(name, message: "Value cannot be negative.");
	}
}