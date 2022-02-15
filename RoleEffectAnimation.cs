using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000430 RID: 1072
[Token(Token = "0x2000430")]
public class RoleEffectAnimation : MonoBehaviour
{
	// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169B")]
	[Address(RVA = "0x57AEF0", Offset = "0x57A2F0", VA = "0x1057AEF0")]
	public void Play(PlayerControl parent, Action onClipEnded, bool flipX, RoleEffectAnimation.SoundType soundType, float duration = 0f)
	{
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169C")]
	[Address(RVA = "0x57ACE0", Offset = "0x57A0E0", VA = "0x1057ACE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDFDC0", Offset = "0xDF1C0")]
	private IEnumerator CoPlay(PlayerControl parent, Action onClipEnded, bool flipX, RoleEffectAnimation.SoundType soundType, float duration = 0f)
	{
		return null;
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169D")]
	[Address(RVA = "0x57AD60", Offset = "0x57A160", VA = "0x1057AD60")]
	public void MidAnimationCallback()
	{
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169E")]
	[Address(RVA = "0x57AF70", Offset = "0x57A370", VA = "0x1057AF70")]
	public void SetMaterialColor(int colorId)
	{
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169F")]
	[Address(RVA = "0x57ADF0", Offset = "0x57A1F0", VA = "0x1057ADF0")]
	public void PlaySound()
	{
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A0")]
	[Address(RVA = "0x57B120", Offset = "0x57A520", VA = "0x1057B120")]
	public void ToggleRenderer(bool on)
	{
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public RoleEffectAnimation()
	{
	}

	// Token: 0x040016F7 RID: 5879
	[Token(Token = "0x40016F7")]
	[FieldOffset(Offset = "0xC")]
	public RoleEffectAnimation.EffectType effectType;

	// Token: 0x040016F8 RID: 5880
	[Token(Token = "0x40016F8")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip Clip;

	// Token: 0x040016F9 RID: 5881
	[Token(Token = "0x40016F9")]
	[FieldOffset(Offset = "0x14")]
	public SpriteAnim Animator;

	// Token: 0x040016FA RID: 5882
	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x18")]
	public Action MidAnimCB;

	// Token: 0x040016FB RID: 5883
	[Token(Token = "0x40016FB")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer Renderer;

	// Token: 0x040016FC RID: 5884
	[Token(Token = "0x40016FC")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip UseSound;

	// Token: 0x040016FD RID: 5885
	[Token(Token = "0x40016FD")]
	[FieldOffset(Offset = "0x24")]
	public AudioSource AudioSource;

	// Token: 0x040016FE RID: 5886
	[Token(Token = "0x40016FE")]
	[FieldOffset(Offset = "0x28")]
	private PlayerControl parent;

	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public enum SoundType
	{
		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		None,
		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		Local,
		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		Global
	}

	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public enum EffectType
	{
		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		Default,
		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		ProtectLoop,
		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		Shapeshift
	}

	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoPlay>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060016A2 RID: 5794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoPlay>d__11(int <>1__state)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x368210", Offset = "0x367610", VA = "0x10368210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		private object Current
		{
			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x3684D0", Offset = "0x3678D0", VA = "0x103684D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		private object Current
		{
			[Token(Token = "0x60016A7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x10")]
		public RoleEffectAnimation <>4__this;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x14")]
		public PlayerControl parent;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x18")]
		public bool flipX;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x1C")]
		public RoleEffectAnimation.SoundType soundType;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x24")]
		public Action onClipEnded;
	}
}
