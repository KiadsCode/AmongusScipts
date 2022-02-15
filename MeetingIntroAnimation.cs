using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000227 RID: 551
[Token(Token = "0x2000227")]
public class MeetingIntroAnimation : MonoBehaviour
{
	// Token: 0x06000C4E RID: 3150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x7721B0", Offset = "0x7715B0", VA = "0x107721B0")]
	public void Start()
	{
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x771B60", Offset = "0x770F60", VA = "0x10771B60")]
	public void Init(GameData.PlayerInfo reporter, GameData.PlayerInfo[] deadBodies)
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x771B10", Offset = "0x770F10", VA = "0x10771B10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE22B0", Offset = "0xE16B0")]
	public IEnumerator CoRun()
	{
		return null;
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x772450", Offset = "0x771850", VA = "0x10772450")]
	public MeetingIntroAnimation()
	{
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x772360", Offset = "0x771760", VA = "0x10772360")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CoRun>b__17_0(float t)
	{
	}

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0xC")]
	public Transform VoteButtonParent;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x10")]
	public Transform OverlayParent;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x14")]
	public Transform DeadParent;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ProtectedRecently;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro DeadBodiesText;

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer BloodSplat;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 VoteButtonParentPos;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 ReporterPos;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer background;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve SlamCurve;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x44")]
	public PlayerVoteArea VoteAreaPrefab;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip PlayerDeadSound;

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x4C")]
	public AudioClip ProtectedRecentlySound;

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x50")]
	private List<PlayerVoteArea> deadCards;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer[] OutsideMasks;

	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06000C53 RID: 3155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x79A810", Offset = "0x799C10", VA = "0x1079A810")]
		internal void <Init>b__0(PlayerControl pc)
		{
		}

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[FieldOffset(Offset = "0x8")]
		public bool someoneWasProtected;
	}

	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRun>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRun>d__17(int <>1__state)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x793C30", Offset = "0x793030", VA = "0x10793C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D0")]
		private object Current
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x794170", Offset = "0x793570", VA = "0x10794170", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		private object Current
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[FieldOffset(Offset = "0x10")]
		public MeetingIntroAnimation <>4__this;
	}
}
