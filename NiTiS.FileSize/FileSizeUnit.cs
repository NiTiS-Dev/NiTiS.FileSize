namespace NiTiS;

/// <summary>
/// Represents units of digital storage.
/// </summary>
public enum FileSizeUnit
{
	/// <summary>
	/// Bit equals 1/8 of byte.
	/// </summary>
	Bit = 0,

	/// <summary>
	/// Byte.
	/// </summary>
	Byte = 1,

	/// <summary>
	/// 10 ^ 3 bytes.
	/// </summary>
	Kilobyte = 0x10 + 1,
	/// <summary>
	/// 10 ^ 6 bytes.
	/// </summary>
	Megabyte = 0x10 + 2,
	/// <summary>
	/// 10 ^ 9 bytes.
	/// </summary>
	Gigabyte = 0x10 + 3,
	/// <summary>
	/// 10 ^ 12 bytes.
	/// </summary>
	Terabyte = 0x10 + 4,
	/// <summary>
	/// 10 ^ 15 bytes.
	/// </summary>
	Petabyte = 0x10 + 5,

	/// <summary>
	/// 2 ^ 10 bytes.
	/// </summary>
	Kibibyte = 0x20 + 1,
	/// <summary>
	/// 2 ^ 20 bytes.
	/// </summary>
	Mebibyte = 0x20 + 2,
	/// <summary>
	/// 2 ^ 30 bytes.
	/// </summary>
	Gibibyte = 0x20 + 3,
	/// <summary>
	/// 2 ^ 40 bytes.
	/// </summary>
	Tebibyte = 0x20 + 4,
	/// <summary>
	/// 2 ^ 50 bytes.
	/// </summary>
	Pebibyte = 0x20 + 5,
}