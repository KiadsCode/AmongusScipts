using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004CF RID: 1231
[Token(Token = "0x20004CF")]
public class TagAmbientSoundPlayer : MonoBehaviour
{
	// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x767250", Offset = "0x766650", VA = "0x10767250")]
	public void Start()
	{
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x7670F0", Offset = "0x7664F0", VA = "0x107670F0")]
	private void Dynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x767160", Offset = "0x766560", VA = "0x10767160")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x767200", Offset = "0x766600", VA = "0x10767200")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0B10", Offset = "0xDFF10")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x767380", Offset = "0x766780", VA = "0x10767380")]
	public TagAmbientSoundPlayer()
	{
	}

	// Token: 0x04001A56 RID: 6742
	[Token(Token = "0x4001A56")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip AmbientSound;

	// Token: 0x04001A57 RID: 6743
	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0x10")]
	public float MaxVolume;

	// Token: 0x04001A58 RID: 6744
	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0x14")]
	public string TargetTag;

	// Token: 0x04001A59 RID: 6745
	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0x18")]
	private float targetVolume;

	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__7(int <>1__state)
		{
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x36F510", Offset = "0x36E910", VA = "0x1036F510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		private object Current
		{
			[Token(Token = "0x6001A3D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x36F760", Offset = "0x36EB60", VA = "0x1036F760", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CB")]
		private object Current
		{
			[Token(Token = "0x6001A3F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x10")]
		public TagAmbientSoundPlayer <>4__this;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x14")]
		private ContactFilter2D <filter>5__2;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D[] <buffer>5__3;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x34")]
		private WaitForSeconds <wait>5__4;
	}
}
