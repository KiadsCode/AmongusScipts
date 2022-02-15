using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public static class TextMeshProExtensions
{
	// Token: 0x06000669 RID: 1641 RVA: 0x00003A68 File Offset: 0x00001C68
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x4AC5F0", Offset = "0x4AB9F0", VA = "0x104AC5F0")]
	public static float GetNotDumbRenderedHeight(this TextMeshPro self)
	{
		return 0f;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00003A80 File Offset: 0x00001C80
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x4AC470", Offset = "0x4AB870", VA = "0x104AC470")]
	public static Vector2 CursorPos(this TextMeshPro self)
	{
		return default(Vector2);
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x600066B")]
	[Address(RVA = "0x4AC940", Offset = "0x4ABD40", VA = "0x104AC940")]
	private static int TextInfoIndexOf(this TextMeshPro self, string str)
	{
		return 0;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x600066C")]
	[Address(RVA = "0x4AC670", Offset = "0x4ABA70", VA = "0x104AC670")]
	public static bool GetWordPosition(this TextMeshPro self, string str, out Vector3 bottomLeft, out Vector3 topRight)
	{
		return default(bool);
	}

	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x370150", Offset = "0x36F550", VA = "0x10370150")]
		internal bool <CursorPos>b__1_0(TMP_LineInfo l)
		{
			return default(bool);
		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextMeshProExtensions.<>c <>9;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x4")]
		public static Func<TMP_LineInfo, bool> <>9__1_0;
	}
}
