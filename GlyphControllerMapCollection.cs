using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200038C RID: 908
[Token(Token = "0x200038C")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0xDDFD0", Offset = "0xDD3D0")]
public class GlyphControllerMapCollection : ScriptableObject
{
	// Token: 0x06001371 RID: 4977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x3B7840", Offset = "0x3B6C40", VA = "0x103B7840")]
	public void Initialize()
	{
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002D6")]
	public static GlyphControllerMapCollection Instance
	{
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x3B7AE0", Offset = "0x3B6EE0", VA = "0x103B7AE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x3B79B0", Offset = "0x3B6DB0", VA = "0x103B79B0")]
	public GlyphCollection TryGetGlyphCollectionForController(string controllerName)
	{
		return null;
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001374")]
	[Address(RVA = "0x3B7A80", Offset = "0x3B6E80", VA = "0x103B7A80")]
	public GlyphControllerMapCollection()
	{
	}

	// Token: 0x040013B3 RID: 5043
	[Token(Token = "0x40013B3")]
	[FieldOffset(Offset = "0xC")]
	public List<GlyphControllerMapCollection.GlyphControllerMap> nameToGlyphCollectionList;

	// Token: 0x040013B4 RID: 5044
	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, string> nameToGlyphCollectionDict;

	// Token: 0x040013B5 RID: 5045
	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x0")]
	private static GlyphControllerMapCollection _instance;

	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	[Serializable]
	public class GlyphControllerMap
	{
		// Token: 0x06001375 RID: 4981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public GlyphControllerMap()
		{
		}

		// Token: 0x040013B6 RID: 5046
		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x8")]
		public string controllerName;

		// Token: 0x040013B7 RID: 5047
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0xC")]
		public string glyphCollectionPath;
	}
}
