using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A3 RID: 931
[Token(Token = "0x20003A3")]
[Attribute(Name = "RequireComponent", RVA = "0xDE2B0", Offset = "0xDD6B0")]
public class QuickChatLocationSubmenu : MonoBehaviour
{
	// Token: 0x060013BE RID: 5054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BE")]
	[Address(RVA = "0x515F40", Offset = "0x515340", VA = "0x10515F40")]
	private void Awake()
	{
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x516000", Offset = "0x515400", VA = "0x10516000")]
	private void Rebuild()
	{
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public QuickChatLocationSubmenu()
	{
	}

	// Token: 0x04001404 RID: 5124
	[Token(Token = "0x4001404")]
	[FieldOffset(Offset = "0xC")]
	private QuickChatSubmenu menu;

	// Token: 0x04001405 RID: 5125
	[Token(Token = "0x4001405")]
	[FieldOffset(Offset = "0x10")]
	public StringNames[] lobbyLocations;

	// Token: 0x04001406 RID: 5126
	[Token(Token = "0x4001406")]
	[FieldOffset(Offset = "0x14")]
	private string currentMap;

	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x04001407 RID: 5127
		[Token(Token = "0x4001407")]
		[FieldOffset(Offset = "0x8")]
		public QuickChatSubmenu menu;
	}

	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_1
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_1()
		{
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x371650", Offset = "0x370A50", VA = "0x10371650")]
		internal void <Rebuild>b__2()
		{
		}

		// Token: 0x04001408 RID: 5128
		[Token(Token = "0x4001408")]
		[FieldOffset(Offset = "0x8")]
		public QuickChatMenuItem menuItem;

		// Token: 0x04001409 RID: 5129
		[Token(Token = "0x4001409")]
		[FieldOffset(Offset = "0xC")]
		public QuickChatLocationSubmenu.<>c__DisplayClass4_0 CS$<>8__locals1;
	}

	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_2
	{
		// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_2()
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x371650", Offset = "0x370A50", VA = "0x10371650")]
		internal void <Rebuild>b__3()
		{
		}

		// Token: 0x0400140A RID: 5130
		[Token(Token = "0x400140A")]
		[FieldOffset(Offset = "0x8")]
		public QuickChatMenuItem menuItem;

		// Token: 0x0400140B RID: 5131
		[Token(Token = "0x400140B")]
		[FieldOffset(Offset = "0xC")]
		public QuickChatLocationSubmenu.<>c__DisplayClass4_0 CS$<>8__locals2;
	}

	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x799800", Offset = "0x798C00", VA = "0x10799800")]
		internal ValueTuple<string, StringNames> <Rebuild>b__4_0(PlainShipRoom r)
		{
			return default(ValueTuple<string, StringNames>);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x43A620", Offset = "0x439A20", VA = "0x1043A620")]
		internal string <Rebuild>b__4_1(ValueTuple<string, StringNames> s)
		{
			return null;
		}

		// Token: 0x0400140C RID: 5132
		[Token(Token = "0x400140C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly QuickChatLocationSubmenu.<>c <>9;

		// Token: 0x0400140D RID: 5133
		[Token(Token = "0x400140D")]
		[FieldOffset(Offset = "0x4")]
		public static Func<PlainShipRoom, ValueTuple<string, StringNames>> <>9__4_0;

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ValueTuple<string, StringNames>, string> <>9__4_1;
	}
}
