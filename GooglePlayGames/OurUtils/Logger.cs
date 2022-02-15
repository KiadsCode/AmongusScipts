using System;
using Il2CppDummyDll;

namespace GooglePlayGames.OurUtils
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	public class Logger
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000837")]
		public static bool DebugLogEnabled
		{
			[Token(Token = "0x6002781")]
			[Address(RVA = "0x6E30F0", Offset = "0x6E24F0", VA = "0x106E30F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002782")]
			[Address(RVA = "0x6E3190", Offset = "0x6E2590", VA = "0x106E3190")]
			set
			{
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x0000BA48 File Offset: 0x00009C48
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000838")]
		public static bool WarningLogEnabled
		{
			[Token(Token = "0x6002783")]
			[Address(RVA = "0x6E3140", Offset = "0x6E2540", VA = "0x106E3140")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002784")]
			[Address(RVA = "0x6E31F0", Offset = "0x6E25F0", VA = "0x106E31F0")]
			set
			{
			}
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x6E2E90", Offset = "0x6E2290", VA = "0x106E2E90")]
		public static void d(string msg)
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x6E3250", Offset = "0x6E2650", VA = "0x106E3250")]
		public static void w(string msg)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x6E3000", Offset = "0x6E2400", VA = "0x106E3000")]
		public static void e(string msg)
		{
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x6E2F80", Offset = "0x6E2380", VA = "0x106E2F80")]
		public static string describe(byte[] b)
		{
			return null;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x6E2AC0", Offset = "0x6E1EC0", VA = "0x106E2AC0")]
		private static string ToLogMessage(string prefix, string logType, string msg)
		{
			return null;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public Logger()
		{
		}

		// Token: 0x0400276A RID: 10090
		[Token(Token = "0x400276A")]
		[FieldOffset(Offset = "0x0")]
		private static bool debugLogEnabled;

		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		[FieldOffset(Offset = "0x1")]
		private static bool warningLogEnabled;

		// Token: 0x0200063D RID: 1597
		[Token(Token = "0x200063D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600278C")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600278D")]
			[Address(RVA = "0x5B5910", Offset = "0x5B4D10", VA = "0x105B5910")]
			internal void <d>b__0()
			{
			}

			// Token: 0x0400276C RID: 10092
			[Token(Token = "0x400276C")]
			[FieldOffset(Offset = "0x8")]
			public string msg;
		}

		// Token: 0x0200063E RID: 1598
		[Token(Token = "0x200063E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600278E RID: 10126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600278F RID: 10127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600278F")]
			[Address(RVA = "0x5B5AD0", Offset = "0x5B4ED0", VA = "0x105B5AD0")]
			internal void <w>b__0()
			{
			}

			// Token: 0x0400276D RID: 10093
			[Token(Token = "0x400276D")]
			[FieldOffset(Offset = "0x8")]
			public string msg;
		}

		// Token: 0x0200063F RID: 1599
		[Token(Token = "0x200063F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06002791 RID: 10129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x5B5000", Offset = "0x5B4400", VA = "0x105B5000")]
			internal void <e>b__0()
			{
			}

			// Token: 0x0400276E RID: 10094
			[Token(Token = "0x400276E")]
			[FieldOffset(Offset = "0x8")]
			public string msg;
		}

		// Token: 0x02000640 RID: 1600
		[Token(Token = "0x2000640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002793")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06002794 RID: 10132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002794")]
			[Address(RVA = "0x5B4CB0", Offset = "0x5B40B0", VA = "0x105B4CB0")]
			internal void <ToLogMessage>b__12_0()
			{
			}

			// Token: 0x0400276F RID: 10095
			[Token(Token = "0x400276F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Logger.<>c <>9;

			// Token: 0x04002770 RID: 10096
			[Token(Token = "0x4002770")]
			[FieldOffset(Offset = "0x4")]
			public static Action <>9__12_0;
		}
	}
}
