using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class PlayerVoteArea : MonoBehaviour
{
	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D2")]
	public MeetingHud Parent
	{
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x170001D3")]
	public bool DidVote
	{
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x50AC60", Offset = "0x50A060", VA = "0x1050AC60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x47A200", Offset = "0x479600", VA = "0x1047A200")]
	public void Start()
	{
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x50A830", Offset = "0x509C30", VA = "0x1050A830")]
	public void SetTargetPlayerId(byte targetId)
	{
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x50A6E0", Offset = "0x509AE0", VA = "0x1050A6E0")]
	public void SetMaskLayer(int maskLayer)
	{
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x50A4E0", Offset = "0x5098E0", VA = "0x1050A4E0")]
	public void SetDead(bool didReport, bool isDead, bool isGuardian = false)
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x50A580", Offset = "0x509980", VA = "0x1050A580")]
	public void SetDisabled()
	{
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x50A630", Offset = "0x509A30", VA = "0x1050A630")]
	public void SetEnabled()
	{
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x50AA90", Offset = "0x509E90", VA = "0x1050AA90")]
	public void UpdateOverlay()
	{
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x509B60", Offset = "0x508F60", VA = "0x10509B60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE2520", Offset = "0xE1920")]
	public IEnumerator CoAnimateOverlay()
	{
		return null;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x50AA00", Offset = "0x509E00", VA = "0x1050AA00")]
	private static float TriangleWave(float t)
	{
		return 0f;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x50A9D0", Offset = "0x509DD0", VA = "0x1050A9D0")]
	internal void SetVote(byte suspectIdx)
	{
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x50AA60", Offset = "0x509E60", VA = "0x1050AA60")]
	public void UnsetVote()
	{
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x509B00", Offset = "0x508F00", VA = "0x10509B00")]
	public void ClearButtons()
	{
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x509B30", Offset = "0x508F30", VA = "0x10509B30")]
	public void ClearForResults()
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x50ABB0", Offset = "0x509FB0", VA = "0x1050ABB0")]
	public void VoteForMe()
	{
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x509F80", Offset = "0x509380", VA = "0x10509F80")]
	public void Select()
	{
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x509A70", Offset = "0x508E70", VA = "0x10509A70")]
	public void Cancel()
	{
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x50A300", Offset = "0x509700", VA = "0x1050A300")]
	public void Serialize(MessageWriter writer)
	{
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x509BB0", Offset = "0x508FB0", VA = "0x10509BB0")]
	public void Deserialize(MessageReader reader)
	{
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x50A340", Offset = "0x509740", VA = "0x1050A340")]
	public void SetCosmetics(GameData.PlayerInfo playerInfo)
	{
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x509CD0", Offset = "0x5090D0", VA = "0x10509CD0")]
	public void PreviewNameplate(string plateID)
	{
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x509C40", Offset = "0x509040", VA = "0x10509C40")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x50AC40", Offset = "0x50A040", VA = "0x1050AC40")]
	public PlayerVoteArea()
	{
	}

	// Token: 0x04000C58 RID: 3160
	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private MeetingHud <Parent>k__BackingField;

	// Token: 0x04000C59 RID: 3161
	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x10")]
	public byte TargetPlayerId;

	// Token: 0x04000C5A RID: 3162
	[Token(Token = "0x4000C5A")]
	public const byte HasNotVoted = 255;

	// Token: 0x04000C5B RID: 3163
	[Token(Token = "0x4000C5B")]
	public const byte MissedVote = 254;

	// Token: 0x04000C5C RID: 3164
	[Token(Token = "0x4000C5C")]
	public const byte SkippedVote = 253;

	// Token: 0x04000C5D RID: 3165
	[Token(Token = "0x4000C5D")]
	public const byte DeadVote = 252;

	// Token: 0x04000C5E RID: 3166
	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Buttons;

	// Token: 0x04000C5F RID: 3167
	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x18")]
	public UiElement ConfirmButton;

	// Token: 0x04000C60 RID: 3168
	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x1C")]
	public UiElement CancelButton;

	// Token: 0x04000C61 RID: 3169
	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x20")]
	public UiElement PlayerButton;

	// Token: 0x04000C62 RID: 3170
	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x24")]
	public PoolablePlayer PlayerIcon;

	// Token: 0x04000C63 RID: 3171
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Background;

	// Token: 0x04000C64 RID: 3172
	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer MaskArea;

	// Token: 0x04000C65 RID: 3173
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Flag;

	// Token: 0x04000C66 RID: 3174
	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer Megaphone;

	// Token: 0x04000C67 RID: 3175
	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer Overlay;

	// Token: 0x04000C68 RID: 3176
	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer XMark;

	// Token: 0x04000C69 RID: 3177
	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer GAIcon;

	// Token: 0x04000C6A RID: 3178
	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x44")]
	public TextMeshPro NameText;

	// Token: 0x04000C6B RID: 3179
	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro LevelNumberText;

	// Token: 0x04000C6C RID: 3180
	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x4C")]
	public bool AnimateButtonsFromLeft;

	// Token: 0x04000C6D RID: 3181
	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0x4D")]
	public bool AmDead;

	// Token: 0x04000C6E RID: 3182
	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0x4E")]
	public bool DidReport;

	// Token: 0x04000C6F RID: 3183
	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0x4F")]
	public byte VotedFor;

	// Token: 0x04000C70 RID: 3184
	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0x50")]
	public bool voteComplete;

	// Token: 0x04000C71 RID: 3185
	[Token(Token = "0x4000C71")]
	[FieldOffset(Offset = "0x51")]
	public bool resultsShowing;

	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOverlay>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOverlay>d__38(int <>1__state)
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x10791E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		private object Current
		{
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x7920B0", Offset = "0x7914B0", VA = "0x107920B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D5")]
		private object Current
		{
			[Token(Token = "0x6000C7F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x10")]
		public PlayerVoteArea <>4__this;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x14")]
		private float <duration>5__2;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x18")]
		private float <time>5__3;
	}

	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass45_0
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass45_0()
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x79AB00", Offset = "0x799F00", VA = "0x1079AB00")]
		internal void <Select>b__0(float t)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x79AC60", Offset = "0x79A060", VA = "0x1079AC60")]
		internal void <Select>b__1(float t)
		{
		}

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x8")]
		public PlayerVoteArea <>4__this;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0xC")]
		public float startPos;
	}
}
