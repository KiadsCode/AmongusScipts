using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
public class EngineBehaviour : MonoBehaviour
{
	// Token: 0x060008B1 RID: 2225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x47AC20", Offset = "0x47A020", VA = "0x1047AC20")]
	public void PlayElectricSound()
	{
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x47AD30", Offset = "0x47A130", VA = "0x1047AD30")]
	public void PlaySteamSound()
	{
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x47AA80", Offset = "0x479E80", VA = "0x1047AA80")]
	private void GetSoundDistance(AudioSource player, float dt)
	{
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x47A8E0", Offset = "0x479CE0", VA = "0x1047A8E0")]
	private void GetSoundDistance(AudioSource player, float dt, float pitch)
	{
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x47AF50", Offset = "0x47A350", VA = "0x1047AF50")]
	public EngineBehaviour()
	{
	}

	// Token: 0x040008BB RID: 2235
	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip ElectricSound;

	// Token: 0x040008BC RID: 2236
	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x10")]
	public AudioClip SteamSound;

	// Token: 0x040008BD RID: 2237
	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0x14")]
	public float SoundDistance;

	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x78D7D0", Offset = "0x78CBD0", VA = "0x1078D7D0")]
		internal void <PlaySteamSound>b__0(AudioSource p, float d)
		{
		}

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x8")]
		public EngineBehaviour <>4__this;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0xC")]
		public float pitch;
	}
}
