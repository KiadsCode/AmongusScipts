using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020004CC RID: 1228
[Token(Token = "0x20004CC")]
public class SoundManager : MonoBehaviour
{
	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C9")]
	public static SoundManager Instance
	{
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x4A4230", Offset = "0x4A3630", VA = "0x104A4230")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x4A3660", Offset = "0x4A2A60", VA = "0x104A3660")]
	public void Start()
	{
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x4A4030", Offset = "0x4A3430", VA = "0x104A4030")]
	public void Update()
	{
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x4A3DB0", Offset = "0x4A31B0", VA = "0x104A3DB0")]
	private void UpdateVolume()
	{
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x4A2A90", Offset = "0x4A1E90", VA = "0x104A2A90")]
	public void ChangeSfxVolume(float volume)
	{
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A22")]
	[Address(RVA = "0x4A2970", Offset = "0x4A1D70", VA = "0x104A2970")]
	public void ChangeMusicVolume(float volume)
	{
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A23")]
	[Address(RVA = "0x4A3A70", Offset = "0x4A2E70", VA = "0x104A3A70")]
	public void StopNamedSound(string name)
	{
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x4A3BA0", Offset = "0x4A2FA0", VA = "0x104A3BA0")]
	public void StopSound(AudioClip clip)
	{
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A25")]
	[Address(RVA = "0x4A37E0", Offset = "0x4A2BE0", VA = "0x104A37E0")]
	public void StopAllSound()
	{
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x4A3060", Offset = "0x4A2460", VA = "0x104A3060")]
	public AudioSource PlayNamedSound(string name, AudioClip sound, bool loop, bool playAsSfx = false)
	{
		return null;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x4A2D90", Offset = "0x4A2190", VA = "0x104A2D90")]
	public AudioSource GetNamedAudioSource(string name)
	{
		return null;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x4A2E70", Offset = "0x4A2270", VA = "0x104A2E70")]
	public AudioSource PlayDynamicSound(string name, AudioClip clip, bool loop, DynamicSound.GetDynamicsFunction volumeFunc, bool playAsSfx = false)
	{
		return null;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x4A2BB0", Offset = "0x4A1FB0", VA = "0x104A2BB0")]
	public void CrossFadeSound(string name, AudioClip clip, float maxVolume, float duration = 1.5f)
	{
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x4A3140", Offset = "0x4A2540", VA = "0x104A3140")]
	public AudioSource PlaySoundImmediate(AudioClip clip, bool loop, float volume = 1f, float pitch = 1f)
	{
		return null;
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x000082E0 File Offset: 0x000064E0
	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x4A35E0", Offset = "0x4A29E0", VA = "0x104A35E0")]
	public bool SoundIsPlaying(AudioClip clip)
	{
		return default(bool);
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x4A3390", Offset = "0x4A2790", VA = "0x104A3390")]
	public AudioSource PlaySound(AudioClip clip, bool loop, float volume = 1f)
	{
		return null;
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x4A41A0", Offset = "0x4A35A0", VA = "0x104A41A0")]
	public SoundManager()
	{
	}

	// Token: 0x04001A48 RID: 6728
	[Token(Token = "0x4001A48")]
	[FieldOffset(Offset = "0x0")]
	private static SoundManager _Instance;

	// Token: 0x04001A49 RID: 6729
	[Token(Token = "0x4001A49")]
	[FieldOffset(Offset = "0xC")]
	public AudioMixerGroup musicMixer;

	// Token: 0x04001A4A RID: 6730
	[Token(Token = "0x4001A4A")]
	[FieldOffset(Offset = "0x10")]
	public AudioMixerGroup sfxMixer;

	// Token: 0x04001A4B RID: 6731
	[Token(Token = "0x4001A4B")]
	[FieldOffset(Offset = "0x4")]
	public static float MusicVolume;

	// Token: 0x04001A4C RID: 6732
	[Token(Token = "0x4001A4C")]
	[FieldOffset(Offset = "0x8")]
	public static float SfxVolume;

	// Token: 0x04001A4D RID: 6733
	[Token(Token = "0x4001A4D")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<AudioClip, AudioSource> allSources;

	// Token: 0x04001A4E RID: 6734
	[Token(Token = "0x4001A4E")]
	[FieldOffset(Offset = "0x18")]
	private List<ISoundPlayer> soundPlayers;

	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001A30 RID: 6704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A30")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <PlayNamedSound>b__17_0(AudioSource a, float b)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <GetNamedAudioSource>b__18_0(AudioSource a, float b)
		{
		}

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SoundManager.<>c <>9;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x4")]
		public static DynamicSound.GetDynamicsFunction <>9__17_0;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x8")]
		public static DynamicSound.GetDynamicsFunction <>9__18_0;
	}
}
