using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace NiTiS;

/// <summary>
/// Represents the size of a file.
/// </summary>
[DataContract]
public partial struct FileSize : IComparable<FileSize>, IEquatable<FileSize>, IFormattable
{
	[IgnoreDataMember]
	private ulong _bytes;

	/// <summary>
	/// Gets or sets amount of bytes.
	/// </summary>
	[DataMember(IsRequired = true, Name = "value")]
	public ulong Bytes
	{
		get => _bytes;
		set => _bytes = value;
	}


	/// <summary>
	/// Gets the file size, in bits.
	/// </summary>
	public ulong Bits => _bytes * BitsPerByte;

	/// <summary>
	/// Gets the file size, in kilobytes.
	/// </summary>
	public double Kilobytes => _bytes / (double)BytesPerKilobyte;

	/// <summary>
	/// Gets the file size, in megabytes.
	/// </summary>
	public double Megabytes => _bytes / (double)BytesPerMegabyte;

	/// <summary>
	/// Gets the file size, in gigabytes.
	/// </summary>
	public double Gigabytes => _bytes / (double)BytesPerGigabyte;

	/// <summary>
	/// Gets the file size, in terabytes.
	/// </summary>
	public double Terabytes => _bytes / (double)BytesPerTerabyte;

	/// <summary>
	/// Gets the file size, in petabytes.
	/// </summary>
	public double Petabytes => _bytes / (double)BytesPerPetabyte;

	/// <summary>
	/// Gets the file size, in kibibytes.
	/// </summary>
	public double Kibibytes => _bytes / (double)BytesPerKibibyte;

	/// <summary>
	/// Gets the file size, in mebibytes.
	/// </summary>
	public double Mebibytes => _bytes / (double)BytesPerMebibyte;

	/// <summary>
	/// Gets the file size, in gibibytes.
	/// </summary>
	public double Gibibytes => _bytes / (double)BytesPerGibibyte;

	/// <summary>
	/// Gets the file size, in tebibytes.
	/// </summary>
	public double Tebibytes => _bytes / (double)BytesPerTebibyte;

	/// <summary>
	/// Gets the file size, in pebibytes.
	/// </summary>
	public double Pebibytes => _bytes / (double)BytesPerPebibyte;


	/// <summary>
	/// Initializes a <see cref="FileSize"/> instance with specified byte amount.
	/// </summary>
	/// <param name="bytes">Amount of bytes.</param>
	public FileSize(ulong bytes)
	{
		_bytes = bytes;
	}

	/// <summary>
	/// Initializes a <see cref="FileSize"/> instance with specified byte amount.
	/// </summary>
	/// <param name="bytes">Amount of bytes.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="bytes"/> is negative.</exception>
	public FileSize(long bytes)
	{
		Guard.IsPositiveOrZero(bytes, nameof(bytes));
		_bytes = unchecked((ulong)bytes);
	}

	/// <summary>
	/// Initializes a <see cref="FileSize"/> instance with specified byte amount.
	/// </summary>
	/// <param name="bytes">Amount of bytes.</param>
	public FileSize(uint bytes)
	{
		_bytes = bytes;
	}

	/// <summary>
	/// Initializes a <see cref="FileSize"/> instance with specified byte amount.
	/// </summary>
	/// <param name="bytes">Amount of bytes.</param>
	/// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="bytes"/> is negative.</exception>
	public FileSize(int bytes)
	{
		Guard.IsPositiveOrZero(bytes, nameof(bytes));
		_bytes = unchecked((ulong)bytes);
	}

	/// <summary>
	/// Indicates whether this and a specified file sizes are equal.
	/// </summary>
	/// <param name="other">The other file size to compare with the current file size.</param>
	/// <returns>
	/// <see langword="true" /> if this and <paramref name="other"/> have same size; otherwise, <see langword="false" />.
	/// </returns>
	public bool Equals(FileSize other)
	{
		return this == other;
	}

	/// <inheritdoc />
	public override bool Equals(object? obj)
	{
		return obj is FileSize other && Equals(other);
	}

	/// <inheritdoc />
	public override int GetHashCode()
	{
		return _bytes.GetHashCode();
	}

	/// <summary>
	/// Compares this instance with another <see cref="FileSize"/> object and returns an integer
	/// that indicates whether this instance precedes, follows, or appears in the same position
	/// in the sort order as the specified object.
	/// </summary>
	/// <param name="other">The <see cref="FileSize"/> to compare with this instance.</param>
	/// <returns>
	/// A value that indicates the relative order of the objects being compared.
	/// <list type="table">
	///   <listheader>
	///     <term>Value</term>
	///     <description>Meaning</description>
	///   </listheader>
	///   <item>
	///     <term>Less than zero</term>
	///     <description>This instance precedes <paramref name="other"/> in the sort order.</description>
	///   </item>
	///   <item>
	///     <term>Zero</term>
	///     <description>This instance occurs in the same position as <paramref name="other"/> in the sort order.</description>
	///   </item>
	///   <item>
	///     <term>Greater than zero</term>
	///     <description>This instance follows <paramref name="other"/> in the sort order.</description>
	///   </item>
	/// </list>
	/// </returns>
	public int CompareTo(FileSize other)
	{
		if (_bytes < other._bytes) return -1;
		if (_bytes > other._bytes) return 1;

		return 0;
	}

	/// <summary>
	/// Determines whether two <see cref="FileSize"/> instances represent the same byte count.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if both <see cref="FileSize"/> instances have the same byte count; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator ==(FileSize left, FileSize right)
	{
		return left._bytes == right._bytes;
	}

	/// <summary>
	/// Determines whether two <see cref="FileSize"/> instances represent different byte counts.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if the <see cref="FileSize"/> instances have different byte counts; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator !=(FileSize left, FileSize right)
	{
		return left._bytes != right._bytes;
	}

	/// <summary>
	/// Determines whether one <see cref="FileSize"/> is greater than another.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if <paramref name="left"/> represents more bytes than <paramref name="right"/>; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator >(FileSize left, FileSize right)
	{
		return left._bytes > right._bytes;
	}

	/// <summary>
	/// Determines whether one <see cref="FileSize"/> is greater than or equal to another.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if <paramref name="left"/> represents equal or more bytes than <paramref name="right"/>; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator >=(FileSize left, FileSize right)
	{
		return left._bytes >= right._bytes;
	}

	/// <summary>
	/// Determines whether one <see cref="FileSize"/> is less than another.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if <paramref name="left"/> represents fewer bytes than <paramref name="right"/>; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator <(FileSize left, FileSize right)
	{
		return left._bytes < right._bytes;
	}

	/// <summary>
	/// Determines whether one <see cref="FileSize"/> is less than or equal to another.
	/// </summary>
	/// <param name="left">The first <see cref="FileSize"/> to compare.</param>
	/// <param name="right">The second <see cref="FileSize"/> to compare.</param>
	/// <returns>
	/// <see langword="true" /> if <paramref name="left"/> represents equal or fewer bytes than <paramref name="right"/>; otherwise, <see langword="false" />.
	/// </returns>
	public static bool operator <=(FileSize left, FileSize right)
	{
		return left._bytes <= right._bytes;
	}

	public override string ToString()
	{
		return ToString(null, null, FileSizeSystem.Decimal);
	}

	public string ToString(string? format, IFormatProvider? formatProvider)
	{
		return ToString(format, formatProvider, FileSizeSystem.Decimal);
	}

	public string ToString(string? format, IFormatProvider? formatProvider, FileSizeSystem system)
	{
		return system switch
		{
			FileSizeSystem.OnlyBytes => ToString(format, formatProvider, FileSizeUnit.Byte),
			FileSizeSystem.Decimal => ToStringDecimal(format, formatProvider),
			FileSizeSystem.Binary => ToStringBinary(format, formatProvider),
			_ => throw new ArgumentOutOfRangeException(nameof(system), system, null)
		};
	}

	private string ToStringDecimal(string? format, IFormatProvider? formatProvider)
	{
		return _bytes switch
		{
			>= BytesPerPetabyte => ToString(format, formatProvider, FileSizeUnit.Petabyte),
			>= BytesPerTerabyte => ToString(format, formatProvider, FileSizeUnit.Terabyte),
			>= BytesPerGigabyte => ToString(format, formatProvider, FileSizeUnit.Gigabyte),
			>= BytesPerMegabyte => ToString(format, formatProvider, FileSizeUnit.Megabyte),
			>= BytesPerKilobyte => ToString(format, formatProvider, FileSizeUnit.Kilobyte),
			_ => ToString(format, formatProvider, FileSizeUnit.Byte)
		};
	}

	private string ToStringBinary(string? format, IFormatProvider? formatProvider)
	{
		return _bytes switch
		{
			>= BytesPerPebibyte => ToString(format, formatProvider, FileSizeUnit.Pebibyte),
			>= BytesPerTebibyte => ToString(format, formatProvider, FileSizeUnit.Tebibyte),
			>= BytesPerGibibyte => ToString(format, formatProvider, FileSizeUnit.Gibibyte),
			>= BytesPerMebibyte => ToString(format, formatProvider, FileSizeUnit.Mebibyte),
			>= BytesPerKibibyte => ToString(format, formatProvider, FileSizeUnit.Kibibyte),
			_ => ToString(format, formatProvider, FileSizeUnit.Byte)
		};
	}

	public string ToString(string? format, IFormatProvider? formatProvider, FileSizeUnit unit)
	{
		if (unit == FileSizeUnit.Bit)
		{
			return Bits.ToString(format, formatProvider) + " b";
		}

		if (unit == FileSizeUnit.Byte)
		{
			return Bytes.ToString(format, formatProvider) + " B";
		}

		double value = unit switch
		{
			FileSizeUnit.Kilobyte => Kilobytes,
			FileSizeUnit.Megabyte => Megabytes,
			FileSizeUnit.Gigabyte => Gigabytes,
			FileSizeUnit.Terabyte => Terabytes,
			FileSizeUnit.Petabyte => Petabytes,
			FileSizeUnit.Kibibyte => Kibibytes,
			FileSizeUnit.Mebibyte => Mebibytes,
			FileSizeUnit.Gibibyte => Gibibytes,
			FileSizeUnit.Tebibyte => Tebibytes,
			FileSizeUnit.Pebibyte => Pebibytes,
			_ => throw new InvalidEnumArgumentException(),
		};

		string suffix = unit switch
		{
			FileSizeUnit.Kilobyte => " KB",
			FileSizeUnit.Megabyte => " MB",
			FileSizeUnit.Gigabyte => " GB",
			FileSizeUnit.Terabyte => " TB",
			FileSizeUnit.Petabyte => " PB",
			FileSizeUnit.Kibibyte => " KiB",
			FileSizeUnit.Mebibyte => " MiB",
			FileSizeUnit.Gibibyte => " GiB",
			FileSizeUnit.Tebibyte => " TiB",
			FileSizeUnit.Pebibyte => " PiB"
		};

		return value.ToString(format, formatProvider) + suffix;
	}

	public string ToString(FileSizeSystem system)
	{
		return ToString(null, null, system);
	}

	public string ToString(FileSizeUnit unit)
	{
		return ToString(null, null, unit);
	}

	public string ToString(string? format, FileSizeSystem system)
	{
		return ToString(format, null, system);
	}

	public string ToString(string? format, FileSizeUnit unit)
	{
		return ToString(format, null, unit);
	}
}