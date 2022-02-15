using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E0 RID: 992
[Token(Token = "0x20003E0")]
public class DeadBody : MonoBehaviour
{
	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x0600148F RID: 5263 RVA: 0x00006990 File Offset: 0x00004B90
	[Token(Token = "0x170002E4")]
	public Vector2 TruePosition
	{
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x5C3160", Offset = "0x5C2560", VA = "0x105C3160")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x5C2ED0", Offset = "0x5C22D0", VA = "0x105C2ED0")]
	public void OnClick()
	{
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DeadBody()
	{
	}

	// Token: 0x04001536 RID: 5430
	[Token(Token = "0x4001536")]
	[FieldOffset(Offset = "0xC")]
	public bool Reported;

	// Token: 0x04001537 RID: 5431
	[Token(Token = "0x4001537")]
	[FieldOffset(Offset = "0xD")]
	public byte ParentId;

	// Token: 0x04001538 RID: 5432
	[Token(Token = "0x4001538")]
	[FieldOffset(Offset = "0x10")]
	public Collider2D myCollider;

	// Token: 0x04001539 RID: 5433
	[Token(Token = "0x4001539")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer bloodSplatter;

	// Token: 0x0400153A RID: 5434
	[Token(Token = "0x400153A")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer bodyRenderer;
}
