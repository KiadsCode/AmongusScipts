using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EF RID: 239
[Token(Token = "0x20000EF")]
public class RandomNameGenerator : MonoBehaviour
{
	// Token: 0x060005CC RID: 1484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x4F0510", Offset = "0x4EF910", VA = "0x104F0510")]
	private void Awake()
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x4F0580", Offset = "0x4EF980", VA = "0x104F0580")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x4F0990", Offset = "0x4EFD90", VA = "0x104F0990")]
	public bool ValidateName(string inName)
	{
		return default(bool);
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x4F0980", Offset = "0x4EFD80", VA = "0x104F0980")]
	public void Reset()
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x4F06F0", Offset = "0x4EFAF0", VA = "0x104F06F0")]
	public void Parse(TextReader reader)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x4F0BC0", Offset = "0x4EFFC0", VA = "0x104F0BC0")]
	public RandomNameGenerator()
	{
	}

	// Token: 0x040005F2 RID: 1522
	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0xC")]
	public TextAsset PatternConfig;

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x10")]
	private List<Pattern> Patterns;

	// Token: 0x040005F4 RID: 1524
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<string, WordGroup> WordGroups;

	// Token: 0x040005F5 RID: 1525
	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x0")]
	private static System.Random randy;

	// Token: 0x040005F6 RID: 1526
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x18")]
	private IEnumerable<Pattern> UsablePatterns;

	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x060005D3 RID: 1491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x371680", Offset = "0x370A80", VA = "0x10371680")]
		internal bool <GetName>b__0(Pattern p)
		{
			return default(bool);
		}

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x8")]
		public Pattern pattern;
	}

	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x370780", Offset = "0x36FB80", VA = "0x10370780")]
		internal bool <Parse>b__9_0(string w)
		{
			return default(bool);
		}

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RandomNameGenerator.<>c <>9;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x4")]
		public static Func<string, bool> <>9__9_0;
	}
}
