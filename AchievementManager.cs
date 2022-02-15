using System;
using System.Collections.Generic;
using Epic.OnlineServices;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.Stats;
using Il2CppDummyDll;

// Token: 0x02000046 RID: 70
[Token(Token = "0x2000046")]
public class AchievementManager : DestroyableSingleton<AchievementManager>
{
	// Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x540790", Offset = "0x53FB90", VA = "0x10540790")]
	public void UpdateAchievementProgressImpl(string key, int progress, int total)
	{
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x540380", Offset = "0x53F780", VA = "0x10540380")]
	public void UnlockAchievementImpl(string key)
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x53F530", Offset = "0x53E930", VA = "0x1053F530", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x53F570", Offset = "0x53E970", VA = "0x1053F570")]
	private void InitializeAchievementProgressDictionary()
	{
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x540B00", Offset = "0x53FF00", VA = "0x10540B00")]
	public void UpdateAchievementsAndStats()
	{
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x5401A0", Offset = "0x53F5A0", VA = "0x105401A0")]
	public void QueryStats(Action callback)
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x53FE30", Offset = "0x53F230", VA = "0x1053FE30")]
	public void OnMatchStart(RoleTypes myRole)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020F")]
	[Address(RVA = "0x2996E0", Offset = "0x298AE0", VA = "0x102996E0")]
	public void SetWinMap(int mapIndex)
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x53F980", Offset = "0x53ED80", VA = "0x1053F980")]
	public void OnMatchEnd(GameOverReason reason, bool didWin)
	{
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000211")]
	[Address(RVA = "0x53F910", Offset = "0x53ED10", VA = "0x1053F910")]
	public void OnConsoleUse(IUsable console)
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x5402D0", Offset = "0x53F6D0", VA = "0x105402D0")]
	public void SabotageCalledLocally()
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x540060", Offset = "0x53F460", VA = "0x10540060")]
	public void OnSabotageCleared()
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x540080", Offset = "0x53F480", VA = "0x10540080")]
	public void OnSabotageFixed(bool didContribute)
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x53FED0", Offset = "0x53F2D0", VA = "0x1053FED0")]
	public void OnMurder(bool amKiller, bool amVictim)
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000216")]
	[Address(RVA = "0x53FE70", Offset = "0x53F270", VA = "0x1053FE70")]
	public void OnMeetingCalled()
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000217")]
	[Address(RVA = "0x53FE90", Offset = "0x53F290", VA = "0x1053FE90")]
	public void OnMeetingVote(GameData.PlayerInfo self, GameData.PlayerInfo target)
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000218")]
	[Address(RVA = "0x5400D0", Offset = "0x53F4D0", VA = "0x105400D0")]
	public void OnTaskComplete(TaskTypes taskType)
	{
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000219")]
	[Address(RVA = "0x540180", Offset = "0x53F580", VA = "0x10540180")]
	public void OnTaskFailure(TaskTypes taskType)
	{
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x600021A")]
	[Address(RVA = "0x53F880", Offset = "0x53EC80", VA = "0x1053F880")]
	private bool IsTaskOpen(TaskTypes taskType)
	{
		return default(bool);
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x600021B")]
	private bool TryGetSystemOfType<T>(SystemTypes sysType, out T output) where T : class, ISystemType
	{
		return default(bool);
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x5408C0", Offset = "0x53FCC0", VA = "0x105408C0")]
	public void UpdateAchievementProgress(string statName, int progress)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x5404B0", Offset = "0x53F8B0", VA = "0x105404B0")]
	public void UnlockAchievement(string key)
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x540D10", Offset = "0x540110", VA = "0x10540D10")]
	public AchievementManager()
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x5402E0", Offset = "0x53F6E0", VA = "0x105402E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <UpdateAchievementsAndStats>b__54_0(OnQueryDefinitionsCompleteCallbackInfo data)
	{
	}

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	private const string TasksCompleteEasyKey = "task_complete_easy";

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	private const int TasksCompleteEasy = 10;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	private const string TasksCompleteMediumKey = "task_complete_medium";

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	private const int TasksCompleteMedium = 100;

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	private const string TasksCompleteHardKey = "task_complete_hard";

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	private const int TasksCompleteHard = 500;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	private const string CardSwipeFirstTryKey = "card_first_try";

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	private const string KillDuringLightsKey = "kill_during_lights";

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	private const string NoVentsImpostorWinKey = "no_vents_impostor_win";

	// Token: 0x0400017E RID: 382
	[Token(Token = "0x400017E")]
	private const string FirstKillKey = "kills_first";

	// Token: 0x0400017F RID: 383
	[Token(Token = "0x400017F")]
	private const int KillsFirst = 1;

	// Token: 0x04000180 RID: 384
	[Token(Token = "0x4000180")]
	private const string KillsEasyKey = "kills_easy";

	// Token: 0x04000181 RID: 385
	[Token(Token = "0x4000181")]
	private const int KillsEasy = 5;

	// Token: 0x04000182 RID: 386
	[Token(Token = "0x4000182")]
	private const string KillsMediumKey = "kills_medium";

	// Token: 0x04000183 RID: 387
	[Token(Token = "0x4000183")]
	private const int KillsMedium = 50;

	// Token: 0x04000184 RID: 388
	[Token(Token = "0x4000184")]
	private const string KillsHardKey = "kills_hard";

	// Token: 0x04000185 RID: 389
	[Token(Token = "0x4000185")]
	private const int KillsHard = 150;

	// Token: 0x04000186 RID: 390
	[Token(Token = "0x4000186")]
	private const int MapWins = 3;

	// Token: 0x04000187 RID: 391
	[Token(Token = "0x4000187")]
	private const string SkeldWinsKey = "wins_skeld";

	// Token: 0x04000188 RID: 392
	[Token(Token = "0x4000188")]
	private const string MiraWinsKey = "wins_mira";

	// Token: 0x04000189 RID: 393
	[Token(Token = "0x4000189")]
	private const string PolusWinsKey = "wins_polus";

	// Token: 0x0400018A RID: 394
	[Token(Token = "0x400018A")]
	private const string AirshipWinsKey = "wins_airship";

	// Token: 0x0400018B RID: 395
	[Token(Token = "0x400018B")]
	private const string TwoImpsSurviveKey = "survive_two_impostors";

	// Token: 0x0400018C RID: 396
	[Token(Token = "0x400018C")]
	private const string TasksWinKey = "win_all_tasks";

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	private const string SabotageWinKey = "win_sabotage";

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	private const string ImpostorKillWinKey = "win_kills";

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	private const string ImpostorVoteWinKey = "win_impostor_vote";

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	private const string CrewmateSurviveWinKey = "survive_crewmate";

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	private const string DieDuringMedScanKey = "die_during_medscan";

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	private const string FixOwnSabotageKey = "fix_own_sabotage";

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	private const string ThreeKillsBeforeMeetingKey = "three_kills_before_meeting";

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	private const string WinAlwaysCorrectVotesKey = "win_always_correct_votes";

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	private const string StatNameImpostorKills = "impostorKills";

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	private const string StatNameTasksCompleted = "tasksCompleted";

	// Token: 0x04000197 RID: 407
	[Token(Token = "0x4000197")]
	private const string StatNameMapWinsSkeld = "MapWinsSkeld";

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000198")]
	private const string StatNameMapWinsPolus = "MapWinsPolus";

	// Token: 0x04000199 RID: 409
	[Token(Token = "0x4000199")]
	private const string StatNameMapWinsMira = "MapWinsMira";

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x400019A")]
	private const string StatNameMapWinsAirship = "MapWinsAirship";

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x10")]
	private bool gameStarted;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x12")]
	private RoleTypes myRole;

	// Token: 0x0400019D RID: 413
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x14")]
	private int cardSwipesThisMatch;

	// Token: 0x0400019E RID: 414
	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x18")]
	private int ventsUsedThisMatch;

	// Token: 0x0400019F RID: 415
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x1C")]
	private bool meetingCalledThisMatch;

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x20")]
	private int killsThisMatch;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x24")]
	private bool sabotageCalledLocally;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x28")]
	private int timesVoted;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x2C")]
	private int timesVotedForImp;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x30")]
	private int winMap;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, List<AchievementManager.AchievementProgressValue>> statName2AchievementProgressValues;

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	private struct AchievementProgressValue
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2B0980", Offset = "0x2AFD80", VA = "0x102B0980")]
		public AchievementProgressValue(string achievementName, int achievementMaxProgress)
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x4")]
		public int maxProgress;
	}

	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x06000221 RID: 545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x3CA810", Offset = "0x3C9C10", VA = "0x103CA810")]
		internal void <QueryStats>b__0(OnQueryStatsCompleteCallbackInfo data)
		{
		}

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x8")]
		public Action callback;
	}

	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3CA230", Offset = "0x3C9630", VA = "0x103CA230")]
		internal bool <OnMatchEnd>b__58_0(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x3CA260", Offset = "0x3C9660", VA = "0x103CA260")]
		internal bool <OnMatchEnd>b__58_1(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AchievementManager.<>c <>9;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameData.PlayerInfo, bool> <>9__58_0;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameData.PlayerInfo, bool> <>9__58_1;
	}

	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass70_0
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass70_0()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x3CA8F0", Offset = "0x3C9CF0", VA = "0x103CA8F0")]
		internal void <UpdateAchievementProgress>b__0(IngestStatCompleteCallbackInfo data)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x3CA9F0", Offset = "0x3C9DF0", VA = "0x103CA9F0")]
		internal void <UpdateAchievementProgress>b__1()
		{
		}

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x8")]
		public AchievementManager <>4__this;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xC")]
		public ProductUserId userId;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x10")]
		public string statName;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x14")]
		public Action <>9__1;
	}

	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x3CAC10", Offset = "0x3CA010", VA = "0x103CAC10")]
		internal void <UnlockAchievement>b__0(OnUnlockAchievementsCompleteCallbackInfo data)
		{
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x8")]
		public DefinitionV2 playerAchievement;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xC")]
		public AchievementManager <>4__this;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x10")]
		public string key;
	}
}
