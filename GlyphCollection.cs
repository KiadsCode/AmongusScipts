using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x02000389 RID: 905
[Token(Token = "0x2000389")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDDF70", Offset = "0xDD370")]
public class GlyphCollection : ScriptableObject
{
	// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x3B7510", Offset = "0x3B6910", VA = "0x103B7510")]
	public void Initialize()
	{
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x0600136C RID: 4972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D5")]
	private static string GlyphPath
	{
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x3B7810", Offset = "0x3B6C10", VA = "0x103B7810")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600136D")]
	[Address(RVA = "0x3B6A60", Offset = "0x3B5E60", VA = "0x103B6A60")]
	public static Sprite FindGlyph(int actionName, out GlyphCollection.ErrorCode error)
	{
		return null;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x3B77B0", Offset = "0x3B6BB0", VA = "0x103B77B0")]
	public GlyphCollection()
	{
	}

	// Token: 0x040013A4 RID: 5028
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0xC")]
	public string controllerType;

	// Token: 0x040013A5 RID: 5029
	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x10")]
	public List<GlyphCollection.GlyphMap> glyphMaps;

	// Token: 0x040013A6 RID: 5030
	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<string, GlyphCollection.GlyphMap> glyphDict;

	// Token: 0x040013A7 RID: 5031
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x0")]
	private static List<ActionElementMap> mapResults;

	// Token: 0x040013A8 RID: 5032
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x4")]
	private static GlyphCollection defaultGlyphCollection;

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, GlyphCollection> otherGlyphCollections;

	// Token: 0x040013AA RID: 5034
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0xC")]
	private static HashSet<string> controllersWithNoValidGlyphCollection;

	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	[Serializable]
	public class GlyphMap
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public GlyphMap()
		{
		}

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x8")]
		public string elementIdentifier;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0xC")]
		public string alternateElementIdentifier;

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x10")]
		public Sprite glyph;
	}

	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public enum ErrorCode
	{
		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		None,
		// Token: 0x040013B0 RID: 5040
		[Token(Token = "0x40013B0")]
		NoController,
		// Token: 0x040013B1 RID: 5041
		[Token(Token = "0x40013B1")]
		NoGlyphFound,
		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		NoElementsBoundToAction
	}
}
