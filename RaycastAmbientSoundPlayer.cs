using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004CB RID: 1227
[Token(Token = "0x20004CB")]
public class RaycastAmbientSoundPlayer : MonoBehaviour
{
	// Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x4F1000", Offset = "0x4F0400", VA = "0x104F1000")]
	private void OnEnable()
	{
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x4F0F80", Offset = "0x4F0380", VA = "0x104F0F80")]
	private void OnDisable()
	{
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x4F1070", Offset = "0x4F0470", VA = "0x104F1070")]
	public void Start()
	{
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x4F0CD0", Offset = "0x4F00D0", VA = "0x104F0CD0")]
	private void GetAmbientSoundVolume(AudioSource player, float dt)
	{
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x4F1240", Offset = "0x4F0640", VA = "0x104F1240")]
	public RaycastAmbientSoundPlayer()
	{
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x4F11C0", Offset = "0x4F05C0", VA = "0x104F11C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Start>b__9_0(AudioSource player, float dt)
	{
	}

	// Token: 0x04001A40 RID: 6720
	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip AmbientSound;

	// Token: 0x04001A41 RID: 6721
	[Token(Token = "0x4001A41")]
	[FieldOffset(Offset = "0x10")]
	public float AmbientVolume;

	// Token: 0x04001A42 RID: 6722
	[Token(Token = "0x4001A42")]
	[FieldOffset(Offset = "0x14")]
	public float AmbientMaxDist;

	// Token: 0x04001A43 RID: 6723
	[Token(Token = "0x4001A43")]
	[FieldOffset(Offset = "0x18")]
	public float HitModifier;

	// Token: 0x04001A44 RID: 6724
	[Token(Token = "0x4001A44")]
	[FieldOffset(Offset = "0x0")]
	public static List<RaycastAmbientSoundPlayer> players;

	// Token: 0x04001A45 RID: 6725
	[Token(Token = "0x4001A45")]
	[FieldOffset(Offset = "0x1C")]
	public float ambientVolume;

	// Token: 0x04001A46 RID: 6726
	[Token(Token = "0x4001A46")]
	[FieldOffset(Offset = "0x20")]
	public float t;

	// Token: 0x04001A47 RID: 6727
	[Token(Token = "0x4001A47")]
	[FieldOffset(Offset = "0x24")]
	private RaycastHit2D[] volumeBuffer;
}
