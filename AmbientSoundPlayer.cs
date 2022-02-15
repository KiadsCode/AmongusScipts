using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C6 RID: 1222
[Token(Token = "0x20004C6")]
public class AmbientSoundPlayer : MonoBehaviour
{
	// Token: 0x060019FB RID: 6651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x548130", Offset = "0x547530", VA = "0x10548130")]
	public void Start()
	{
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x547DF0", Offset = "0x5471F0", VA = "0x10547DF0")]
	private void Dynamics(AudioSource source, float dt)
	{
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x548090", Offset = "0x547490", VA = "0x10548090")]
	public void OnDestroy()
	{
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x548210", Offset = "0x547610", VA = "0x10548210")]
	public AmbientSoundPlayer()
	{
	}

	// Token: 0x04001A31 RID: 6705
	[Token(Token = "0x4001A31")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip AmbientSound;

	// Token: 0x04001A32 RID: 6706
	[Token(Token = "0x4001A32")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D[] HitAreas;

	// Token: 0x04001A33 RID: 6707
	[Token(Token = "0x4001A33")]
	[FieldOffset(Offset = "0x14")]
	public float MaxVolume;

	// Token: 0x04001A34 RID: 6708
	[Token(Token = "0x4001A34")]
	[FieldOffset(Offset = "0x18")]
	public float DistanceFallOff;

	// Token: 0x04001A35 RID: 6709
	[Token(Token = "0x4001A35")]
	[FieldOffset(Offset = "0x1C")]
	public float FallOffRate;
}
