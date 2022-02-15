using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000240")]
public class Scrollbar : PassiveUiElement
{
	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00005100 File Offset: 0x00003300
	[Token(Token = "0x170001E1")]
	public override bool HandleDrag
	{
		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x58CD10", Offset = "0x58C110", VA = "0x1058CD10")]
	public void Toggle(bool on)
	{
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x58CD40", Offset = "0x58C140", VA = "0x1058CD40")]
	public void UpdatePosition(Vector3 position)
	{
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x58CB00", Offset = "0x58BF00", VA = "0x1058CB00", Slot = "14")]
	public override void ReceiveClickDrag(Vector2 dragDelta)
	{
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x58CD90", Offset = "0x58C190", VA = "0x1058CD90")]
	public Scrollbar()
	{
	}

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Scroller parent;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SpriteRenderer graphic;

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool horizontal;

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float dragSpeed;
}
