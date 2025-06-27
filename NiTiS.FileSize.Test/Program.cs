using System;
using System.Linq;
using System.Threading.Tasks;

namespace NiTiS.Test;

public class SortTest
{
	[Test]
	public async Task OrderTest()
	{
		Random random = new Random();
		ulong[] ints = new ulong[10];
		FileSize[] sizes = new FileSize[10];

		for (int i = 0; i < 10; i++)
		{
			ints[i] = (ulong)random.Next();
			sizes[i] = new FileSize(ints[i]);
		}

		Array.Sort(ints);
		Array.Sort(sizes);

		await Assert.That(ints).IsEquivalentTo(sizes.Select(t => t.Bytes));
	}
}