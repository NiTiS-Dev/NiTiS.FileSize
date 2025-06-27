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
	/// Amount of bytes per one kibibyte (1024 bytes).
	/// </summary>
	public const int BytesPerKibibyte = 1_024;

	/// <summary>
	/// Amount of bytes per one megabyte.
	/// </summary>
	public const int BytesPerMegabyte = 1_000_000;

	/// <summary>
	/// Amount of bytes per one mebibyte (1024 kibibytes).
	/// </summary>
	public const int BytesPerMebibyte = 1_048_576;

	/// <summary>
	/// Amount of bytes per one gigabyte.
	/// </summary>
	public const int BytesPerGigabyte = 1_000_000_000;

	/// <summary>
	/// Amount of bytes per one gibibyte (1024 mebibytes).
	/// </summary>
	public const int BytesPerGibibyte = 1_073_741_824;

	/// <summary>
	/// Amount of bytes per one terabyte.
	/// </summary>
	public const ulong BytesPerTerabyte = 1_000_000_000_000;

	/// <summary>
	/// Amount of bytes per one tebibyte (1024 gibibytes).
	/// </summary>
	public const ulong BytesPerTebibyte = 1_099_511_627_776;

	/// <summary>
	/// Amount of bytes per one petabyte.
	/// </summary>
	public const ulong BytesPerPetabyte = 1_000_000_000_000_000;

	/// <summary>
	/// Amount of bytes per one pebibyte (1024 tebibytes).
	/// </summary>
	public const ulong BytesPerPebibyte = 1_125_899_906_842_624;
}