using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000505 RID: 1285
[Token(Token = "0x2000505")]
public class LanguageUnit
{
	// Token: 0x06001B5A RID: 7002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x6D9F70", Offset = "0x6D9370", VA = "0x106D9F70")]
	public LanguageUnit(TranslatedImageSet locSet)
	{
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x6D9780", Offset = "0x6D8B80", VA = "0x106D9780")]
	public static void ParseTSV(string tsvText, Dictionary<string, string> allStrings, Dictionary<StringNames, QuickChatSentenceVariantSet> allQuickChatVariantSets)
	{
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x6D9D50", Offset = "0x6D9150", VA = "0x106D9D50")]
	public static string UnescapeCodes(string src, int startAt)
	{
		return null;
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x6D92F0", Offset = "0x6D86F0", VA = "0x106D92F0")]
	public string GetString(string idString, string defaultStr, params object[] parts)
	{
		return null;
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x6D9240", Offset = "0x6D8640", VA = "0x106D9240")]
	public string GetString(StringNames stringId, string defaultStr, params object[] parts)
	{
		return null;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x6D91E0", Offset = "0x6D85E0", VA = "0x106D91E0")]
	public Sprite GetImage(ImageNames id)
	{
		return null;
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x6D9540", Offset = "0x6D8940", VA = "0x106D9540")]
	private static void HandleQCSentenceVariant(string id, string value, Dictionary<StringNames, QuickChatSentenceVariantSet> allQuickChatVariantSets)
	{
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x6D9160", Offset = "0x6D8560", VA = "0x106D9160")]
	public string GetFITBVariant(StringNames id, List<StringNames> entryIDs)
	{
		return null;
	}

	// Token: 0x04001BA7 RID: 7079
	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x0")]
	private static StringBuilder builder;

	// Token: 0x04001BA8 RID: 7080
	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x8")]
	public bool IsEnglish;

	// Token: 0x04001BA9 RID: 7081
	[Token(Token = "0x4001BA9")]
	[FieldOffset(Offset = "0xC")]
	public SupportedLangs languageID;

	// Token: 0x04001BAA RID: 7082
	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, string> AllStrings;

	// Token: 0x04001BAB RID: 7083
	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<ImageNames, Sprite> AllImages;

	// Token: 0x04001BAC RID: 7084
	[Token(Token = "0x4001BAC")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<StringNames, QuickChatSentenceVariantSet> AllQuickChatVariantSets;
}
