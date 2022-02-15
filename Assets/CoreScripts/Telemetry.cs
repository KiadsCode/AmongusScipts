using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Assets.CoreScripts
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	public class Telemetry : DestroyableSingleton<Telemetry>
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x76A050", Offset = "0x769450", VA = "0x1076A050")]
		public void Init()
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x76A330", Offset = "0x769730", VA = "0x1076A330")]
		public void StartGame(bool isHost, int playerCount, int impostorCount, GameModes gameMode, uint timesImpostor, uint gamesPlayed, uint crewStreak)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x76A0A0", Offset = "0x7694A0", VA = "0x1076A0A0")]
		public void StartGameCosmetics(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId)
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x76AA80", Offset = "0x769E80", VA = "0x1076AA80")]
		public void WriteMeetingStarted(bool isEmergency)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x76A9B0", Offset = "0x769DB0", VA = "0x1076A9B0")]
		public void WriteMeetingEnded(float duration)
		{
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void WritePosition(byte playerNum, Vector2 worldPos)
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x76AB40", Offset = "0x769F40", VA = "0x1076AB40")]
		public void WriteMurder()
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x76AB80", Offset = "0x769F80", VA = "0x1076AB80")]
		public void WriteSabotageUsed(SystemTypes systemType)
		{
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x769E20", Offset = "0x769220", VA = "0x10769E20")]
		public void CardSwipeComplete(int attempts)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x76AC40", Offset = "0x76A040", VA = "0x1076AC40")]
		public void WriteUse(byte playerNum, TaskTypes taskType, Vector3 worldPos)
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x76A830", Offset = "0x769C30", VA = "0x1076A830")]
		public void WriteCompleteTask(TaskTypes taskType)
		{
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x76A8F0", Offset = "0x769CF0", VA = "0x1076A8F0")]
		internal void WriteDisconnect(DisconnectReasons reason)
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x769EE0", Offset = "0x7692E0", VA = "0x10769EE0")]
		public void EndGame(GameOverReason endReason)
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x76A060", Offset = "0x769460", VA = "0x1076A060")]
		public void SendWho()
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x76A590", Offset = "0x769990", VA = "0x1076A590")]
		public void WonGame(int colorId, string hatId, string skinId, string petId, string visorId, string nameplateId)
		{
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x76B530", Offset = "0x76A930", VA = "0x1076B530")]
		public Telemetry()
		{
		}

		// Token: 0x0400282B RID: 10283
		[Token(Token = "0x400282B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] ColorNames;

		// Token: 0x0400282C RID: 10284
		[Token(Token = "0x400282C")]
		[FieldOffset(Offset = "0x10")]
		private bool amHost;

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[FieldOffset(Offset = "0x11")]
		private bool gameStarted;

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x18")]
		private DateTime timeStarted;
	}
}
