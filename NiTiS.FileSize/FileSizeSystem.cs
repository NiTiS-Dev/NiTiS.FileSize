namespace NiTiS;

/// <summary>
/// Represents unit system.
/// </summary>
public enum FileSizeSystem
{
	/// <summary>
	/// Do not use any units.
	/// </summary>
	OnlyBytes = 0,

	/// <summary>
	/// Elements of decimal system have value equals to power of 10.
	/// </summary>
	Decimal = 1,

	/// <summary>
	/// Elements of binary system have value equals to power of 2.
	/// </summary>
	/// <remarks>
	/// Windows uses a binary system, but uses unit names from metric.
	/// </remarks>
	Binary = 2,
}