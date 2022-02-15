using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class PressStartToJoinExample_Assigner : MonoBehaviour
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x50E5A0", Offset = "0x50D9A0", VA = "0x1050E5A0")]
		public static Player GetRewiredPlayer(int gamePlayerId)
		{
			return null;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x50E510", Offset = "0x50D910", VA = "0x1050E510")]
		private void Awake()
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x50E7D0", Offset = "0x50DBD0", VA = "0x1050E7D0")]
		private void Update()
		{
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x50E300", Offset = "0x50D700", VA = "0x1050E300")]
		private void AssignNextPlayer(int rewiredPlayerId)
		{
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x600259C")]
		[Address(RVA = "0x50E580", Offset = "0x50D980", VA = "0x1050E580")]
		private int GetNextGamePlayerId()
		{
			return 0;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259D")]
		[Address(RVA = "0x50E8B0", Offset = "0x50DCB0", VA = "0x1050E8B0")]
		public PressStartToJoinExample_Assigner()
		{
		}

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		[FieldOffset(Offset = "0x0")]
		private static PressStartToJoinExample_Assigner instance;

		// Token: 0x04002518 RID: 9496
		[Token(Token = "0x4002518")]
		[FieldOffset(Offset = "0xC")]
		public int maxPlayers;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x10")]
		private List<PressStartToJoinExample_Assigner.PlayerMap> playerMap;

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x400251A")]
		[FieldOffset(Offset = "0x14")]
		private int gamePlayerIdCounter;

		// Token: 0x020005D3 RID: 1491
		[Token(Token = "0x20005D3")]
		private class PlayerMap
		{
			// Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600259E")]
			[Address(RVA = "0x399E90", Offset = "0x399290", VA = "0x10399E90")]
			public PlayerMap(int rewiredPlayerId, int gamePlayerId)
			{
			}

			// Token: 0x0400251B RID: 9499
			[Token(Token = "0x400251B")]
			[FieldOffset(Offset = "0x8")]
			public int rewiredPlayerId;

			// Token: 0x0400251C RID: 9500
			[Token(Token = "0x400251C")]
			[FieldOffset(Offset = "0xC")]
			public int gamePlayerId;
		}
	}
}
