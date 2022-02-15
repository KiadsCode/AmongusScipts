using System;
using Assets.InnerNet;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x20002F5")]
public class PurchaseButton : MonoBehaviour
{
	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000278")]
	public StoreMenu Parent
	{
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x5144F0", Offset = "0x5138F0", VA = "0x105144F0", Slot = "4")]
	protected virtual void Start()
	{
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x513370", Offset = "0x512770", VA = "0x10513370")]
	public void SetItem(IBuyable product, string productId, string name, string price, bool purchased, CurrencyTypes currency)
	{
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x512F70", Offset = "0x512370", VA = "0x10512F70")]
	private void SetDoubleBig()
	{
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x512BD0", Offset = "0x511FD0", VA = "0x10512BD0")]
	private void SetBig()
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x5143F0", Offset = "0x5137F0", VA = "0x105143F0")]
	private void SetSquare()
	{
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x512BB0", Offset = "0x511FB0", VA = "0x10512BB0")]
	public void DoPurchase()
	{
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PurchaseButton()
	{
	}

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x400104F")]
	private const float normalSize = 1.75f;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private StoreMenu <Parent>k__BackingField;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer PurchasedIcon;

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro NameText;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro PriceText;

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer CrewHeadImage;

	// Token: 0x04001055 RID: 4181
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x20")]
	public HatParent HatImage;

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x24")]
	public VisorLayer VisorLayer;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x28")]
	public Sprite MannequinFrame;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer Background;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer SelectionHighlight;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer GlassSprite;

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer GlassMask;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PriceLabel;

	// Token: 0x0400105D RID: 4189
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x40")]
	public BoxCollider2D clickCollider;

	// Token: 0x0400105E RID: 4190
	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x44")]
	public PassiveButton PassiveButton;

	// Token: 0x0400105F RID: 4191
	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x48")]
	public IBuyable Product;

	// Token: 0x04001060 RID: 4192
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x4C")]
	public bool Purchased;

	// Token: 0x04001061 RID: 4193
	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x50")]
	public string Name;

	// Token: 0x04001062 RID: 4194
	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x54")]
	public string Price;

	// Token: 0x04001063 RID: 4195
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x58")]
	public string ProductId;

	// Token: 0x04001064 RID: 4196
	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x5C")]
	public SpriteRenderer ImageMask;

	// Token: 0x04001065 RID: 4197
	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer LabelMask;

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x64")]
	public SpriteRenderer LabelBackground;

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x68")]
	public SpriteRenderer LabelGlass;
}
