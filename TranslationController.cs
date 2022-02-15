using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050D RID: 1293
[Token(Token = "0x200050D")]
public class TranslationController : DestroyableSingleton<TranslationController>
{
	// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x4B1D70", Offset = "0x4B1170", VA = "0x104B1D70", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x4B24A0", Offset = "0x4B18A0", VA = "0x104B24A0")]
	public void SetLanguage(TranslatedImageSet lang)
	{
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x4B1ED0", Offset = "0x4B12D0", VA = "0x104B1ED0")]
	public Sprite GetImage(ImageNames id)
	{
		return null;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x4B21A0", Offset = "0x4B15A0", VA = "0x104B21A0")]
	public string GetString(StringNames id, params object[] parts)
	{
		return null;
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x4B20D0", Offset = "0x4B14D0", VA = "0x104B20D0")]
	public string GetString(RoleTypes role)
	{
		return null;
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x4B21F0", Offset = "0x4B15F0", VA = "0x104B21F0")]
	public string GetString(string id, string defaultStr, params object[] parts)
	{
		return null;
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x4B1FC0", Offset = "0x4B13C0", VA = "0x104B1FC0")]
	public string GetStringWithDefault(StringNames id, string defaultStr, params object[] parts)
	{
		return null;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x4B2220", Offset = "0x4B1620", VA = "0x104B2220")]
	public string GetString(SystemTypes room)
	{
		return null;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x4B2000", Offset = "0x4B1400", VA = "0x104B2000")]
	public string GetString(TaskTypes task)
	{
		return null;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x4B1F20", Offset = "0x4B1320", VA = "0x104B1F20")]
	public string GetMonthStringViaNumber(int monthNum)
	{
		return null;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x00008B20 File Offset: 0x00006D20
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x4B2370", Offset = "0x4B1770", VA = "0x104B2370")]
	public StringNames GetTaskName(TaskTypes task)
	{
		return StringNames.ExitButton;
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x00008B38 File Offset: 0x00006D38
	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x4B2300", Offset = "0x4B1700", VA = "0x104B2300")]
	public StringNames GetSystemName(SystemTypes room)
	{
		return StringNames.ExitButton;
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x4B1EA0", Offset = "0x4B12A0", VA = "0x104B1EA0")]
	public string GetFITBVariant(StringNames id, List<StringNames> entryIDs)
	{
		return null;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x00008B50 File Offset: 0x00006D50
	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x4B23E0", Offset = "0x4B17E0", VA = "0x104B23E0")]
	internal static uint SelectDefaultLanguage()
	{
		return 0U;
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7C")]
	[Address(RVA = "0x4B28C0", Offset = "0x4B1CC0", VA = "0x104B28C0")]
	public TranslationController()
	{
	}

	// Token: 0x04001F40 RID: 8000
	[Token(Token = "0x4001F40")]
	[FieldOffset(Offset = "0x0")]
	private static readonly StringNames[] SystemTypesToStringNames;

	// Token: 0x04001F41 RID: 8001
	[Token(Token = "0x4001F41")]
	[FieldOffset(Offset = "0x4")]
	private static readonly StringNames[] TaskTypesToStringNames;

	// Token: 0x04001F42 RID: 8002
	[Token(Token = "0x4001F42")]
	[FieldOffset(Offset = "0x10")]
	public TranslatedImageSet[] Languages;

	// Token: 0x04001F43 RID: 8003
	[Token(Token = "0x4001F43")]
	[FieldOffset(Offset = "0x14")]
	public LanguageUnit CurrentLanguage;

	// Token: 0x04001F44 RID: 8004
	[Token(Token = "0x4001F44")]
	[FieldOffset(Offset = "0x18")]
	public LanguageUnit FallbackLanguage;

	// Token: 0x04001F45 RID: 8005
	[Token(Token = "0x4001F45")]
	[FieldOffset(Offset = "0x1C")]
	public TranslatedImageSet FallbackLanguageImageSet;

	// Token: 0x04001F46 RID: 8006
	[Token(Token = "0x4001F46")]
	[FieldOffset(Offset = "0x20")]
	public List<ITranslatedText> ActiveTexts;

	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x370AE0", Offset = "0x36FEE0", VA = "0x10370AE0")]
		internal StringNames <.cctor>b__7_0(SystemTypes t)
		{
			return StringNames.ExitButton;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x370BA0", Offset = "0x36FFA0", VA = "0x10370BA0")]
		internal StringNames <.cctor>b__7_1(TaskTypes t)
		{
			return StringNames.ExitButton;
		}

		// Token: 0x04001F47 RID: 8007
		[Token(Token = "0x4001F47")]
		[FieldOffset(Offset = "0x34E834E3")]
		public static readonly TranslationController.<>c <>9;
	}
}
