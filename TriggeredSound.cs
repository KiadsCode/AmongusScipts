using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004D1 RID: 1233
[Token(Token = "0x20004D1")]
public class TriggeredSound : MonoBehaviour
{
	// Token: 0x06001A40 RID: 6720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x4B2CE0", Offset = "0x4B20E0", VA = "0x104B2CE0")]
	public void Start()
	{
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x4B2BB0", Offset = "0x4B1FB0", VA = "0x104B2BB0")]
	public void PlaySound()
	{
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x4B2930", Offset = "0x4B1D30", VA = "0x104B2930")]
	private void GetAmbientSoundVolume(AudioSource player)
	{
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x4B2DA0", Offset = "0x4B21A0", VA = "0x104B2DA0")]
	public TriggeredSound()
	{
	}

	// Token: 0x04001A60 RID: 6752
	[Token(Token = "0x4001A60")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip[] SoundToPlay;

	// Token: 0x04001A61 RID: 6753
	[Token(Token = "0x4001A61")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange PitchRange;

	// Token: 0x04001A62 RID: 6754
	[Token(Token = "0x4001A62")]
	[FieldOffset(Offset = "0x14")]
	private AudioSource Player;

	// Token: 0x04001A63 RID: 6755
	[Token(Token = "0x4001A63")]
	[FieldOffset(Offset = "0x18")]
	public float MaxVolume;

	// Token: 0x04001A64 RID: 6756
	[Token(Token = "0x4001A64")]
	[FieldOffset(Offset = "0x1C")]
	public float MaxDist;

	// Token: 0x04001A65 RID: 6757
	[Token(Token = "0x4001A65")]
	[FieldOffset(Offset = "0x20")]
	public float HitModifier;

	// Token: 0x04001A66 RID: 6758
	[Token(Token = "0x4001A66")]
	[FieldOffset(Offset = "0x24")]
	private RaycastHit2D[] volumeBuffer;
}
