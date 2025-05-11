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
	/// 1000 bytes.
	/// </summary>
	Kilobyte = 0x10 + 1,
	/// <summary>
	/// 1000^2 bytes.
	/// </summary>
	Megabyte = 0x10 + 2,
	/// <summary>
	/// 1000^3 bytes.
	/// </summary>
	Gigabyte = 0x10 + 3,
	/// <summary>
	/// 1000^4 bytes.
	/// </summary>
	Terabyte = 0x10 + 4,
	/// <summary>
	/// 1000^5 bytes.
	/// </summary>
	Petabyte = 0x10 + 5,

	/// <summary>
	/// 1024 bytes.
	/// </summary>
	Kibibyte = 0x20 + 1,
	/// <summary>
	/// 1024^2 bytes.
	/// </summary>
	Mebibyte = 0x20 + 2,
	/// <summary>
	/// 1024^3 bytes.
	/// </summary>
	Gibibyte = 0x20 + 3,
	/// <summary>
	/// 1024^4 bytes.
	/// </summary>
	Tebibyte = 0x20 + 4,
	/// <summary>
	/// 1024^5 bytes.
	/// </summary>
	Pebibyte = 0x20 + 5,
}