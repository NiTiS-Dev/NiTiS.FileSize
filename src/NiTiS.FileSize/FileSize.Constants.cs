namespace NiTiS;

public partial struct FileSize
{
	/// <summary>
	/// Amount of bits per 1 byte.
	/// </summary>
	public const int BitsPerByte = 8;

	/// <summary>
	/// Amount of bytes per one kilobyte.
	/// </summary>
	public const int BytesPerKilobyte = 1_000;

	/// <summary>
	/// Amount of bytes per one megabyte.
	/// </summary>
	public const int BytesPerMegabyte = 1_000_000;

	/// <summary>
	/// Amount of bytes per one gigabyte.
	/// </summary>
	public const int BytesPerGigabyte = 1_000_000_000;

	/// <summary>
	/// Amount of bytes per one gigabyte.
	/// </summary>
	public const ulong BytesPerTerabyte = 1_000_000_000_000;

	/// <summary>
	/// Amount of bytes per one petabyte.
	/// </summary>
	public const ulong BytesPerPetabyte = 1_000_000_000_000_000;
}