using System;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public static class GameCode
	{
		// Token: 0x0600266C RID: 9836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x3ABED0", Offset = "0x3AB2D0", VA = "0x103ABED0")]
		public static string IntToGameName(int gameId)
		{
			return null;
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x3AB9E0", Offset = "0x3AADE0", VA = "0x103AB9E0")]
		public static int GameNameToInt(string gameId)
		{
			return 0;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x3AB6C0", Offset = "0x3AAAC0", VA = "0x103AB6C0")]
		public static int CreateGameId(int sn, int gn)
		{
			return 0;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x3ABB90", Offset = "0x3AAF90", VA = "0x103ABB90")]
		private static string IntToGameNameV2(int gameId)
		{
			return null;
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x3AB6E0", Offset = "0x3AAAE0", VA = "0x103AB6E0")]
		private static int GameNameToIntV2(string gameId)
		{
			return 0;
		}

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		public const int V2Flag = -2147483648;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		public const int MaxGameNumber = 676;

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int GameCodeV2MinVersion;

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x4")]
		private static readonly string V2;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] V2Map;

		// Token: 0x02000609 RID: 1545
		[Token(Token = "0x2000609")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002673 RID: 9843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002673")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06002674 RID: 9844 RVA: 0x0000B5F8 File Offset: 0x000097F8
			[Token(Token = "0x6002674")]
			[Address(RVA = "0x5B4870", Offset = "0x5B3C70", VA = "0x105B4870")]
			internal bool <IntToGameName>b__3_0(char c)
			{
				return default(bool);
			}

			// Token: 0x06002675 RID: 9845 RVA: 0x0000B610 File Offset: 0x00009810
			[Token(Token = "0x6002675")]
			[Address(RVA = "0x5B4850", Offset = "0x5B3C50", VA = "0x105B4850")]
			internal bool <GameNameToInt>b__4_0(char c)
			{
				return default(bool);
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x0000B628 File Offset: 0x00009828
			[Token(Token = "0x6002676")]
			[Address(RVA = "0x5B4870", Offset = "0x5B3C70", VA = "0x105B4870")]
			internal bool <IntToGameNameV2>b__8_0(char c)
			{
				return default(bool);
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x0000B640 File Offset: 0x00009840
			[Token(Token = "0x6002677")]
			[Address(RVA = "0x5B4870", Offset = "0x5B3C70", VA = "0x105B4870")]
			internal bool <GameNameToIntV2>b__9_0(char c)
			{
				return default(bool);
			}

			// Token: 0x06002678 RID: 9848 RVA: 0x0000B658 File Offset: 0x00009858
			[Token(Token = "0x6002678")]
			[Address(RVA = "0x5B4E20", Offset = "0x5B4220", VA = "0x105B4E20")]
			internal int <.cctor>b__10_0(int v)
			{
				return 0;
			}

			// Token: 0x0400265C RID: 9820
			[Token(Token = "0x400265C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameCode.<>c <>9;

			// Token: 0x0400265D RID: 9821
			[Token(Token = "0x400265D")]
			[FieldOffset(Offset = "0x4")]
			public static Func<char, bool> <>9__3_0;

			// Token: 0x0400265E RID: 9822
			[Token(Token = "0x400265E")]
			[FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__4_0;

			// Token: 0x0400265F RID: 9823
			[Token(Token = "0x400265F")]
			[FieldOffset(Offset = "0xC")]
			public static Func<char, bool> <>9__8_0;

			// Token: 0x04002660 RID: 9824
			[Token(Token = "0x4002660")]
			[FieldOffset(Offset = "0x10")]
			public static Func<char, bool> <>9__9_0;
		}
	}
}
