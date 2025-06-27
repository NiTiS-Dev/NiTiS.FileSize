using System.ComponentModel;
using System.IO;

namespace NiTiS;

/// <summary>
/// Extension class.
/// </summary>
public static class FileSizeExtensions
{
	/// <summary>
	/// Retrieves size of provided file and initializes <see cref="FileSize"/> instance.
	/// </summary>
	/// <param name="file">File to get size of.</param>
	/// <returns>Initialized <see cref="FileSize"/> structure with size of <paramref name="file"/>.</returns>
	#if NET10_0_OR_GREATER
	[EditorBrowsable(EditorBrowsableState.Never)] // Hide deprecated extensions, use C# 14 new ones
	#endif
	public static FileSize GetFileSize(this FileInfo file)
	{
		return new FileSize(file.Length);
	}
}