using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using InnerNet;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20002A8")]
public class AmongUsClient : InnerNetClient
{
	// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F0F")]
	[Address(RVA = "0x548430", Offset = "0x547830", VA = "0x10548430")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE54D0", Offset = "0xE48D0")]
	public IEnumerator CoCreateOnlineGame()
	{
		return null;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x548510", Offset = "0x547910", VA = "0x10548510")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5570", Offset = "0xE4970")]
	public IEnumerator CoJoinOnlineGameDirect(int gameId, string ipAddress, ushort port)
	{
		return null;
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x548580", Offset = "0x547980", VA = "0x10548580")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE55C0", Offset = "0xE49C0")]
	public IEnumerator CoJoinOnlineGameFromCode(int gameId)
	{
		return null;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x5484C0", Offset = "0x5478C0", VA = "0x105484C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5610", Offset = "0xE4A10")]
	public IEnumerator CoFindGame()
	{
		return null;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x5483C0", Offset = "0x5477C0", VA = "0x105483C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5660", Offset = "0xE4A60")]
	private IEnumerator CoConnectToGameServer(MatchMakerModes mode, string ipAddress, ushort port)
	{
		return null;
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x548240", Offset = "0x547640", VA = "0x10548240")]
	public void Awake()
	{
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x54A6D0", Offset = "0x549AD0", VA = "0x1054A6D0")]
	public void StartGame()
	{
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x548CC0", Offset = "0x5480C0", VA = "0x10548CC0")]
	public void ExitGame(DisconnectReasons reason = DisconnectReasons.ExitGame)
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x548BA0", Offset = "0x547FA0", VA = "0x10548BA0")]
	public void ExitCurrentGameToMoveToADifferentOne(DisconnectReasons reason = DisconnectReasons.ExitGame)
	{
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x549B00", Offset = "0x548F00", VA = "0x10549B00", Slot = "18")]
	protected override void OnGetGameList(InnerNetClient.TotalGameData totalGames, List<GameListing> availableGames)
	{
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "16")]
	protected override void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason)
	{
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	protected override void OnGameCreated(string gameIdString)
	{
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x54A610", Offset = "0x549A10", VA = "0x1054A610", Slot = "9")]
	protected override void OnWaitForHost(string gameIdString)
	{
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x548640", Offset = "0x547A40", VA = "0x10548640", Slot = "10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE56B0", Offset = "0xE4AB0")]
	protected override IEnumerator CoStartGame()
	{
		return null;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x548DE0", Offset = "0x5481E0", VA = "0x10548DE0", Slot = "12")]
	protected override void OnBecomeHost()
	{
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x549110", Offset = "0x548510", VA = "0x10549110", Slot = "11")]
	protected override void OnGameEnd(EndGameResult endGameResult)
	{
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x548480", Offset = "0x547880", VA = "0x10548480")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5700", Offset = "0xE4B00")]
	public IEnumerator CoEndGame()
	{
		return null;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x549CA0", Offset = "0x5490A0", VA = "0x10549CA0", Slot = "13")]
	protected override void OnPlayerJoined(ClientData data)
	{
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x549920", Offset = "0x548D20", VA = "0x10549920", Slot = "8")]
	protected override void OnGameJoined(string gameIdString, ClientData data)
	{
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x549D30", Offset = "0x549130", VA = "0x10549D30", Slot = "15")]
	protected override void OnPlayerLeft(ClientData data, DisconnectReasons reason)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x5490B0", Offset = "0x5484B0", VA = "0x105490B0", Slot = "17")]
	protected override void OnDisconnected()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x5485E0", Offset = "0x5479E0", VA = "0x105485E0", Slot = "14")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE57A0", Offset = "0xE4BA0")]
	protected override IEnumerator CoOnPlayerChangedScene(ClientData client, string currentScene)
	{
		return null;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x548690", Offset = "0x547A90", VA = "0x10548690")]
	private void CreatePlayer(ClientData clientData)
	{
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x548370", Offset = "0x547770", VA = "0x10548370")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE57F0", Offset = "0xE4BF0")]
	private IEnumerator CoBroadcastManager()
	{
		return null;
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x54A6F0", Offset = "0x549AF0", VA = "0x1054A6F0")]
	public AmongUsClient()
	{
	}

	// Token: 0x04000F0C RID: 3852
	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x0")]
	public static AmongUsClient Instance;

	// Token: 0x04000F0D RID: 3853
	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x8C")]
	public string OnlineScene;

	// Token: 0x04000F0E RID: 3854
	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x90")]
	public string MainMenuScene;

	// Token: 0x04000F0F RID: 3855
	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x94")]
	public GameData GameDataPrefab;

	// Token: 0x04000F10 RID: 3856
	[Token(Token = "0x4000F10")]
	[FieldOffset(Offset = "0x98")]
	public PlayerControl PlayerPrefab;

	// Token: 0x04000F11 RID: 3857
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x9C")]
	public List<AssetReference> ShipPrefabs;

	// Token: 0x04000F12 RID: 3858
	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0xA0")]
	public int TutorialMapId;

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0xA4")]
	public float SpawnRadius;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0xA8")]
	public DiscoveryState discoverState;

	// Token: 0x04000F15 RID: 3861
	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0xAC")]
	public List<IDisconnectHandler> DisconnectHandlers;

	// Token: 0x04000F16 RID: 3862
	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0xB0")]
	public List<IGameListHandler> GameListHandlers;

	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass0_0
	{
		// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass0_0()
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
		internal void <CoCreateOnlineGame>b__0(HttpMatchmakerManager.HostServer host)
		{
		}

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x8")]
		public HttpMatchmakerManager.HostServer hostServer;
	}

	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoCreateOnlineGame>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F2A RID: 3882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoCreateOnlineGame>d__0(int <>1__state)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x3C3DB0", Offset = "0x3C31B0", VA = "0x103C3DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000247")]
		private object Current
		{
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x3C3FF0", Offset = "0x3C33F0", VA = "0x103C3FF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000248")]
		private object Current
		{
			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x14")]
		private AmongUsClient.<>c__DisplayClass0_0 <>8__1;
	}

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoJoinOnlineGameDirect>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoJoinOnlineGameDirect>d__1(int <>1__state)
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x3C4AA0", Offset = "0x3C3EA0", VA = "0x103C4AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		private object Current
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x3C4B10", Offset = "0x3C3F10", VA = "0x103C4B10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024A")]
		private object Current
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x14")]
		public int gameId;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x18")]
		public string ipAddress;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x1C")]
		public ushort port;
	}

	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
		internal void <CoJoinOnlineGameFromCode>b__0(HttpMatchmakerManager.HostServer host)
		{
		}

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x8")]
		public HttpMatchmakerManager.HostServer hostServer;
	}

	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoJoinOnlineGameFromCode>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoJoinOnlineGameFromCode>d__2(int <>1__state)
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x3C4B40", Offset = "0x3C3F40", VA = "0x103C4B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024B")]
		private object Current
		{
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x3C4DE0", Offset = "0x3C41E0", VA = "0x103C4DE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024C")]
		private object Current
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x14")]
		public int gameId;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x18")]
		private AmongUsClient.<>c__DisplayClass2_0 <>8__1;
	}

	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoFindGame>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoFindGame>d__3(int <>1__state)
		{
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x3C4460", Offset = "0x3C3860", VA = "0x103C4460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		private object Current
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x3C46B0", Offset = "0x3C3AB0", VA = "0x103C46B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024E")]
		private object Current
		{
			[Token(Token = "0x6000F43")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;
	}

	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoConnectToGameServer>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoConnectToGameServer>d__4(int <>1__state)
		{
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x3C39F0", Offset = "0x3C2DF0", VA = "0x103C39F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		private object Current
		{
			[Token(Token = "0x6000F47")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x3C3B50", Offset = "0x3C2F50", VA = "0x103C3B50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		private object Current
		{
			[Token(Token = "0x6000F49")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x14")]
		public string ipAddress;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x18")]
		public ushort port;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x1C")]
		public MatchMakerModes mode;
	}

	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartGame>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartGame>d__24(int <>1__state)
		{
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x3C5E60", Offset = "0x3C5260", VA = "0x103C5E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		private object Current
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x3C7060", Offset = "0x3C6460", VA = "0x103C7060", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000252")]
		private object Current
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x18")]
		private bool <stopWaiting>5__3;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x1C")]
		private AsyncOperationHandle<GameObject> <shipPrefab>5__4;
	}

	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoEndGame>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoEndGame>d__27(int <>1__state)
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x3C4330", Offset = "0x3C3730", VA = "0x103C4330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		private object Current
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x3C4430", Offset = "0x3C3830", VA = "0x103C4430", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		private object Current
		{
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoOnPlayerChangedScene>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoOnPlayerChangedScene>d__32(int <>1__state)
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x3C4E10", Offset = "0x3C4210", VA = "0x103C4E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		private object Current
		{
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x3C5200", Offset = "0x3C4600", VA = "0x103C5200", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		private object Current
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x10")]
		public ClientData client;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x14")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x18")]
		public string currentScene;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x1C")]
		private AsyncOperationHandle<GameObject> <shipPrefab>5__2;
	}

	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBroadcastManager>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBroadcastManager>d__34(int <>1__state)
		{
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x3C3310", Offset = "0x3C2710", VA = "0x103C3310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		private object Current
		{
			[Token(Token = "0x6000F5F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x3C3590", Offset = "0x3C2990", VA = "0x103C3590", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000258")]
		private object Current
		{
			[Token(Token = "0x6000F61")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x10")]
		public AmongUsClient <>4__this;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x14")]
		private int <lastPlayerCount>5__2;
	}
}
