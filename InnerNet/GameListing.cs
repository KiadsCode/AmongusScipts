using System;
using Hazel;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	[Serializable]
	public struct GameListing
	{
		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000833")]
		public string IPString
		{
			[Token(Token = "0x6002749")]
			[Address(RVA = "0x3AEA60", Offset = "0x3ADE60", VA = "0x103AEA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x3AE9A0", Offset = "0x3ADDA0", VA = "0x103AE9A0")]
		public static GameListing DeserializeV2(MessageReader reader)
		{
			return default(GameListing);
		}

		// Token: 0x0400270A RID: 9994
		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x0")]
		public uint IP;

		// Token: 0x0400270B RID: 9995
		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x4")]
		public ushort Port;

		// Token: 0x0400270C RID: 9996
		[Token(Token = "0x400270C")]
		[FieldOffset(Offset = "0x8")]
		public int GameId;

		// Token: 0x0400270D RID: 9997
		[Token(Token = "0x400270D")]
		[FieldOffset(Offset = "0xC")]
		public byte PlayerCount;

		// Token: 0x0400270E RID: 9998
		[Token(Token = "0x400270E")]
		[FieldOffset(Offset = "0x10")]
		public string HostName;

		// Token: 0x0400270F RID: 9999
		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x14")]
		public string HostPlatformName;

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x18")]
		public Platforms Platform;

		// Token: 0x04002711 RID: 10001
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x1C")]
		public int Age;

		// Token: 0x04002712 RID: 10002
		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x20")]
		public int MaxPlayers;

		// Token: 0x04002713 RID: 10003
		[Token(Token = "0x4002713")]
		[FieldOffset(Offset = "0x24")]
		public int NumImpostors;

		// Token: 0x04002714 RID: 10004
		[Token(Token = "0x4002714")]
		[FieldOffset(Offset = "0x28")]
		public byte MapId;
	}
}
