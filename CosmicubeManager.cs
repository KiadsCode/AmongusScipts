using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Token(Token = "0x2000120")]
public class CosmicubeManager : DestroyableSingleton<CosmicubeManager>
{
	// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x800100", Offset = "0x7FF500", VA = "0x10800100")]
	public Cosmicube GetCubeByID(string id)
	{
		return null;
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x8002A0", Offset = "0x7FF6A0", VA = "0x108002A0")]
	public Cosmicube[] GetUnlockedCubes()
	{
		return null;
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x8001E0", Offset = "0x7FF5E0", VA = "0x108001E0")]
	public CosmicubeData GetDataForPodId(string podId)
	{
		return null;
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x7FFE80", Offset = "0x7FF280", VA = "0x107FFE80")]
	public float GetCompletionProgress(Cosmicube cube)
	{
		return 0f;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x8000D0", Offset = "0x7FF4D0", VA = "0x108000D0")]
	public float GetCompletionProgress(string cubeId)
	{
		return 0f;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x8006B0", Offset = "0x7FFAB0", VA = "0x108006B0")]
	public CosmicubeManager()
	{
	}

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<UnlockableCosmetic.UnlockableQuality, Color> qualityColorMap;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x10")]
	public List<Cosmicube> allCubes;

	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x78D720", Offset = "0x78CB20", VA = "0x1078D720")]
		internal bool <GetCubeByID>b__0(Cosmicube h)
		{
			return default(bool);
		}

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x8")]
		public string id;
	}

	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x78D430", Offset = "0x78C830", VA = "0x1078D430")]
		internal bool <GetUnlockedCubes>b__3_0(Cosmicube s, int index)
		{
			return default(bool);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x78D4C0", Offset = "0x78C8C0", VA = "0x1078D4C0")]
		internal int <GetUnlockedCubes>b__3_1(Cosmicube o)
		{
			return 0;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x3702D0", Offset = "0x36F6D0", VA = "0x103702D0")]
		internal string <GetUnlockedCubes>b__3_2(Cosmicube o)
		{
			return null;
		}

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CosmicubeManager.<>c <>9;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x4")]
		public static Func<Cosmicube, int, bool> <>9__3_0;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Cosmicube, int> <>9__3_1;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0xC")]
		public static Func<Cosmicube, string> <>9__3_2;
	}

	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x78D7A0", Offset = "0x78CBA0", VA = "0x1078D7A0")]
		internal bool <GetDataForPodId>b__0(Cosmicube c)
		{
			return default(bool);
		}

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x8")]
		public string podId;
	}
}
