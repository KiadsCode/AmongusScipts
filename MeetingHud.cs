using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using TMPro;
using UnityEngine;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
public class MeetingHud : InnerNetObject, IDisconnectHandler
{
	// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x76FC50", Offset = "0x76F050", VA = "0x1076FC50")]
	public void RpcClose()
	{
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x76E630", Offset = "0x76DA30", VA = "0x1076E630")]
	public void CmdCastVote(byte playerId, byte suspectIdx)
	{
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x76FCD0", Offset = "0x76F0D0", VA = "0x1076FCD0")]
	private void RpcVotingComplete(MeetingHud.VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x76FBD0", Offset = "0x76EFD0", VA = "0x1076FBD0")]
	private void RpcClearVote(int clientId)
	{
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x6000C0B")]
	[Address(RVA = "0x76FFC0", Offset = "0x76F3C0", VA = "0x1076FFC0", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x76EBA0", Offset = "0x76DFA0", VA = "0x1076EBA0", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x76F470", Offset = "0x76E870", VA = "0x1076F470", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x76F680", Offset = "0x76EA80", VA = "0x1076F680")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x76D8B0", Offset = "0x76CCB0", VA = "0x1076D8B0")]
	private void Awake()
	{
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x7705A0", Offset = "0x76F9A0", VA = "0x107705A0")]
	private void Start()
	{
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x76F600", Offset = "0x76EA00", VA = "0x1076F600", Slot = "7")]
	public override void OnDestroy()
	{
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x7700D0", Offset = "0x76F4D0", VA = "0x107700D0")]
	private void SetForegroundForDead()
	{
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x770AB0", Offset = "0x76FEB0", VA = "0x10770AB0")]
	public void Update()
	{
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x76E6F0", Offset = "0x76DAF0", VA = "0x1076E6F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2210", Offset = "0xE1610")]
	public IEnumerator CoIntro(GameData.PlayerInfo reporter, GameData.PlayerInfo reportedBody, GameData.PlayerInfo[] deadBodies)
	{
		return null;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x76E760", Offset = "0x76DB60", VA = "0x1076E760")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2260", Offset = "0xE1660")]
	private IEnumerator CoStartCutscene()
	{
		return null;
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x7700A0", Offset = "0x76F4A0", VA = "0x107700A0")]
	public void ServerStart(byte reporter)
	{
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x76E4E0", Offset = "0x76D8E0", VA = "0x1076E4E0")]
	public void Close()
	{
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x771450", Offset = "0x770850", VA = "0x10771450")]
	private void VotingComplete(MeetingHud.VoterState[] states, GameData.PlayerInfo exiled, bool tie)
	{
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00004D28 File Offset: 0x00002F28
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x76FE00", Offset = "0x76F200", VA = "0x1076FE00")]
	public bool Select(int suspectStateIdx)
	{
		return default(bool);
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x76E7B0", Offset = "0x76DBB0", VA = "0x1076E7B0")]
	public void Confirm(byte suspectStateIdx)
	{
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x76EFE0", Offset = "0x76E3E0", VA = "0x1076EFE0", Slot = "11")]
	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "12")]
	public void HandleDisconnect()
	{
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x76EDD0", Offset = "0x76E1D0", VA = "0x1076EDD0")]
	private void ForceSkipAll()
	{
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x76DD30", Offset = "0x76D130", VA = "0x1076DD30")]
	public void CastVote(byte srcPlayerId, byte suspectPlayerId)
	{
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x76E440", Offset = "0x76D840", VA = "0x1076E440")]
	public void ClearVote()
	{
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x76DF70", Offset = "0x76D370", VA = "0x1076DF70")]
	private void CheckForEndVoting()
	{
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x76DC10", Offset = "0x76D010", VA = "0x1076DC10")]
	private Dictionary<byte, int> CalculateVotes()
	{
		return null;
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x76F340", Offset = "0x76E740", VA = "0x1076F340")]
	public void HandleProceed()
	{
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x770150", Offset = "0x76F550", VA = "0x10770150")]
	private void SetupProceedButton()
	{
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x76F950", Offset = "0x76ED50", VA = "0x1076F950")]
	private void PopulateResults(MeetingHud.VoterState[] states)
	{
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x76D9A0", Offset = "0x76CDA0", VA = "0x1076D9A0")]
	private void BloopAVoteIcon(GameData.PlayerInfo voterPlayer, int index, Transform parent)
	{
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x7708D0", Offset = "0x76FCD0", VA = "0x107708D0")]
	private void UpdateButtons()
	{
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x76F6F0", Offset = "0x76EAF0", VA = "0x1076F6F0")]
	private void PopulateButtons(byte reporter)
	{
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x7702D0", Offset = "0x76F6D0", VA = "0x107702D0")]
	private void SortButtons()
	{
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x76E9F0", Offset = "0x76DDF0", VA = "0x1076E9F0")]
	private PlayerVoteArea CreateButton(GameData.PlayerInfo playerInfo)
	{
		return null;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00004D40 File Offset: 0x00002F40
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x76ED10", Offset = "0x76E110", VA = "0x1076ED10")]
	public bool DidVote(byte playerId)
	{
		return default(bool);
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00004D58 File Offset: 0x00002F58
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x76EE60", Offset = "0x76E260", VA = "0x1076EE60")]
	public int GetVotesRemaining()
	{
		return 0;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x771A80", Offset = "0x770E80", VA = "0x10771A80")]
	public MeetingHud()
	{
	}

	// Token: 0x04000C01 RID: 3073
	[Token(Token = "0x4000C01")]
	private const int NumColumns = 3;

	// Token: 0x04000C02 RID: 3074
	[Token(Token = "0x4000C02")]
	private const float ResultsTime = 5f;

	// Token: 0x04000C03 RID: 3075
	[Token(Token = "0x4000C03")]
	private const float Depth = 0f;

	// Token: 0x04000C04 RID: 3076
	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x0")]
	public static MeetingHud Instance;

	// Token: 0x04000C05 RID: 3077
	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer BlackBackground;

	// Token: 0x04000C06 RID: 3078
	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer[] PlayerColoredParts;

	// Token: 0x04000C07 RID: 3079
	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x2C")]
	public MeetingIntroAnimation MeetingIntro;

	// Token: 0x04000C08 RID: 3080
	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0x30")]
	public Transform ButtonParent;

	// Token: 0x04000C09 RID: 3081
	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro TitleText;

	// Token: 0x04000C0A RID: 3082
	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 VoteOrigin;

	// Token: 0x04000C0B RID: 3083
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 VoteButtonOffsets;

	// Token: 0x04000C0C RID: 3084
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x50")]
	public PlayerVoteArea SkipVoteButton;

	// Token: 0x04000C0D RID: 3085
	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x54")]
	private PlayerVoteArea[] playerStates;

	// Token: 0x04000C0E RID: 3086
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x58")]
	public PlayerVoteArea PlayerButtonPrefab;

	// Token: 0x04000C0F RID: 3087
	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x5C")]
	public SpriteRenderer PlayerVotePrefab;

	// Token: 0x04000C10 RID: 3088
	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x60")]
	public Sprite CrackedGlass;

	// Token: 0x04000C11 RID: 3089
	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer Glass;

	// Token: 0x04000C12 RID: 3090
	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x68")]
	public PassiveButton ProceedButton;

	// Token: 0x04000C13 RID: 3091
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x6C")]
	public AudioClip VoteSound;

	// Token: 0x04000C14 RID: 3092
	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip VoteLockinSound;

	// Token: 0x04000C15 RID: 3093
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip VoteEndingSound;

	// Token: 0x04000C16 RID: 3094
	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x78")]
	private MeetingHud.VoteStates state;

	// Token: 0x04000C17 RID: 3095
	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject SkippedVoting;

	// Token: 0x04000C18 RID: 3096
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x80")]
	public SpriteRenderer HostIcon;

	// Token: 0x04000C19 RID: 3097
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x84")]
	private GameData.PlayerInfo exiledPlayer;

	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x88")]
	private bool wasTie;

	// Token: 0x04000C1B RID: 3099
	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x8C")]
	public TextMeshPro TimerText;

	// Token: 0x04000C1C RID: 3100
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x90")]
	public float discussionTimer;

	// Token: 0x04000C1D RID: 3101
	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x94")]
	private byte reporterId;

	// Token: 0x04000C1E RID: 3102
	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0x95")]
	private bool amDead;

	// Token: 0x04000C1F RID: 3103
	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x98")]
	private float resultsStartedAt;

	// Token: 0x04000C20 RID: 3104
	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0x9C")]
	private int lastSecond;

	// Token: 0x04000C21 RID: 3105
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000C22 RID: 3106
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0xA4")]
	public UiElement ProceedButtonUi;

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0xA8")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	private struct VoterState
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x170001CA")]
		public bool AmDead
		{
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x79DB80", Offset = "0x79CF80", VA = "0x1079DB80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x170001CB")]
		public bool SkippedVote
		{
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x79DB90", Offset = "0x79CF90", VA = "0x1079DB90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x79DB00", Offset = "0x79CF00", VA = "0x1079DB00")]
		public static MeetingHud.VoterState Deserialize(MessageReader reader)
		{
			return default(MeetingHud.VoterState);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x79DB40", Offset = "0x79CF40", VA = "0x1079DB40")]
		public void Serialize(MessageWriter writer)
		{
		}

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x0")]
		public byte VoterId;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x1")]
		public byte VotedForId;
	}

	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	public enum VoteStates
	{
		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		Animating,
		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		Discussion,
		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		NotVoted,
		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		Voted,
		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		Results,
		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		Proceeding
	}

	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x79ADF0", Offset = "0x79A1F0", VA = "0x1079ADF0")]
		internal bool <Deserialize>b__0(PlayerVoteArea ps)
		{
			return default(bool);
		}

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x8")]
		public MessageReader msg;
	}

	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoIntro>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoIntro>d__50(int <>1__state)
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x793800", Offset = "0x792C00", VA = "0x10793800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		private object Current
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x793C00", Offset = "0x793000", VA = "0x10793C00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		private object Current
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x10")]
		public MeetingHud <>4__this;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x14")]
		public GameData.PlayerInfo reportedBody;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x18")]
		public GameData.PlayerInfo reporter;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x1C")]
		public GameData.PlayerInfo[] deadBodies;
	}

	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartCutscene>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartCutscene>d__51(int <>1__state)
		{
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x795870", Offset = "0x794C70", VA = "0x10795870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		private object Current
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x795A90", Offset = "0x794E90", VA = "0x10795A90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		private object Current
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x10")]
		public MeetingHud <>4__this;
	}

	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x799D80", Offset = "0x799180", VA = "0x10799D80")]
		internal bool <VotingComplete>b__54_0(MeetingHud.VoterState s)
		{
			return default(bool);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x799650", Offset = "0x798A50", VA = "0x10799650")]
		internal bool <CheckForEndVoting>b__62_0(PlayerVoteArea ps)
		{
			return default(bool);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x799BE0", Offset = "0x798FE0", VA = "0x10799BE0")]
		internal int <SortButtons>b__70_0(PlayerVoteArea p)
		{
			return 0;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x799C00", Offset = "0x799000", VA = "0x10799C00")]
		internal byte <SortButtons>b__70_1(PlayerVoteArea p)
		{
			return 0;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x799770", Offset = "0x798B70", VA = "0x10799770")]
		internal bool <GetVotesRemaining>b__73_0(PlayerVoteArea ps)
		{
			return default(bool);
		}

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MeetingHud.<>c <>9;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0x4")]
		public static Func<MeetingHud.VoterState, bool> <>9__54_0;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlayerVoteArea, bool> <>9__62_0;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0xC")]
		public static Func<PlayerVoteArea, int> <>9__70_0;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x10")]
		public static Func<PlayerVoteArea, byte> <>9__70_1;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x14")]
		public static Func<PlayerVoteArea, bool> <>9__73_0;
	}

	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass57_0
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass57_0()
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x79ADC0", Offset = "0x79A1C0", VA = "0x1079ADC0")]
		internal bool <HandleDisconnect>b__0(PlayerVoteArea pv)
		{
			return default(bool);
		}

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x8")]
		public PlayerControl pc;
	}

	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass60_0
	{
		// Token: 0x06000C48 RID: 3144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass60_0()
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x79AE70", Offset = "0x79A270", VA = "0x1079AE70")]
		internal bool <CastVote>b__0(PlayerVoteArea pv)
		{
			return default(bool);
		}

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x8")]
		public byte srcPlayerId;
	}

	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x79AE90", Offset = "0x79A290", VA = "0x1079AE90")]
		internal bool <CheckForEndVoting>b__1(GameData.PlayerInfo v)
		{
			return default(bool);
		}

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x8")]
		public bool tie;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0xC")]
		public KeyValuePair<byte, int> max;
	}

	// Token: 0x02000226 RID: 550
	[Token(Token = "0x2000226")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x79AE70", Offset = "0x79A270", VA = "0x1079AE70")]
		internal bool <DidVote>b__0(PlayerVoteArea p)
		{
			return default(bool);
		}

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x8")]
		public byte playerId;
	}
}
