using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020003F9 RID: 1017
[Token(Token = "0x20003F9")]
public class PetBehaviour : MonoBehaviour
{
	// Token: 0x170002F5 RID: 757
	// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002F5")]
	public bool Visible
	{
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x65A1F0", Offset = "0x6595F0", VA = "0x1065A1F0")]
		set
		{
		}
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x659D50", Offset = "0x659150", VA = "0x10659D50")]
	public void Start()
	{
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x659D80", Offset = "0x659180", VA = "0x10659D80")]
	public void Update()
	{
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x659CF0", Offset = "0x6590F0", VA = "0x10659CF0")]
	public void SetMourning()
	{
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x659C60", Offset = "0x659060", VA = "0x10659C60")]
	private void LateUpdate()
	{
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x659BC0", Offset = "0x658FC0", VA = "0x10659BC0")]
	private Vector2 GetTruePosition()
	{
		return default(Vector2);
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x65A1D0", Offset = "0x6595D0", VA = "0x1065A1D0")]
	public PetBehaviour()
	{
	}

	// Token: 0x0400159E RID: 5534
	[Token(Token = "0x400159E")]
	private const float SnapDistance = 2f;

	// Token: 0x0400159F RID: 5535
	[Token(Token = "0x400159F")]
	[FieldOffset(Offset = "0xC")]
	public PetData Data;

	// Token: 0x040015A0 RID: 5536
	[Token(Token = "0x40015A0")]
	[FieldOffset(Offset = "0x10")]
	public PlayerControl Source;

	// Token: 0x040015A1 RID: 5537
	[Token(Token = "0x40015A1")]
	public const float MinDistance = 0.2f;

	// Token: 0x040015A2 RID: 5538
	[Token(Token = "0x40015A2")]
	public const float damping = 0.7f;

	// Token: 0x040015A3 RID: 5539
	[Token(Token = "0x40015A3")]
	public const float Easing = 0.2f;

	// Token: 0x040015A4 RID: 5540
	[Token(Token = "0x40015A4")]
	public const float Speed = 5f;

	// Token: 0x040015A5 RID: 5541
	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x14")]
	public float YOffset;

	// Token: 0x040015A6 RID: 5542
	[Token(Token = "0x40015A6")]
	[FieldOffset(Offset = "0x18")]
	public SpriteAnim animator;

	// Token: 0x040015A7 RID: 5543
	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer rend;

	// Token: 0x040015A8 RID: 5544
	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer shadowRend;

	// Token: 0x040015A9 RID: 5545
	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x24")]
	public Rigidbody2D body;

	// Token: 0x040015AA RID: 5546
	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D Collider;

	// Token: 0x040015AB RID: 5547
	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x2C")]
	public AnimationClip idleClip;

	// Token: 0x040015AC RID: 5548
	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x30")]
	public AnimationClip sadClip;

	// Token: 0x040015AD RID: 5549
	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x34")]
	public AnimationClip scaredClip;

	// Token: 0x040015AE RID: 5550
	[Token(Token = "0x40015AE")]
	[FieldOffset(Offset = "0x38")]
	public AnimationClip walkClip;
}
