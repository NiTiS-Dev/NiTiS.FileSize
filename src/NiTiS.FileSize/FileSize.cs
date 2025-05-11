using System;
using System.Runtime.Serialization;

namespace NiTiS;

/// <summary>
/// Represents the size of a file.
/// </summary>
[DataContract]
public partial struct FileSize : IComparable<FileSize>, IEquatable<FileSize>
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

	public ulong Bits => _bytes * BitsPerByte;

	public double Kilobytes => _bytes / (double)BytesPerKilobyte;

	public double Megabytes => _bytes / (double)BytesPerMegabyte;

	public double Gigabytes => _bytes / (double)BytesPerGigabyte;

	public double Terabytes => _bytes / (double)BytesPerTerabyte;

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
}