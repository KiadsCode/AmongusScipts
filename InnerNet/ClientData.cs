using System;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x02000605 RID: 1541
	[Token(Token = "0x2000605")]
	[Serializable]
	public class ClientData
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x41EE60", Offset = "0x41E260", VA = "0x1041EE60")]
		public ClientData(int id, string playerName, PlatformSpecificData platformData, uint playerLevel)
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x277A60", Offset = "0x276E60", VA = "0x10277A60")]
		public void UpdatePlayerName(string playerName)
		{
		}

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0xC")]
		public bool InScene;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0xD")]
		public bool IsReady;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0xE")]
		public bool HasBeenReported;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl Character;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x14")]
		public readonly uint PlayerLevel;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x18")]
		public readonly PlatformSpecificData PlatformData;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x1C")]
		public string PlayerName;

		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		[FieldOffset(Offset = "0x20")]
		public int ColorId;
	}
}
