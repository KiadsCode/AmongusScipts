using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DC RID: 732
[Token(Token = "0x20002DC")]
public class InventoryTab : MonoBehaviour
{
	// Token: 0x06001024 RID: 4132 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x6D2FA0", Offset = "0x6D23A0", VA = "0x106D2FA0")]
	protected bool HasLocalPlayer()
	{
		return default(bool);
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "4")]
	public virtual void ClickEquip()
	{
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x6D3110", Offset = "0x6D2510", VA = "0x106D3110", Slot = "5")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x6D3020", Offset = "0x6D2420", VA = "0x106D3020", Slot = "6")]
	public virtual void OnDisable()
	{
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x6D2F50", Offset = "0x6D2350", VA = "0x106D2F50", Slot = "7")]
	public virtual ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00005C70 File Offset: 0x00003E70
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "8")]
	public virtual bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x6D3200", Offset = "0x6D2600", VA = "0x106D3200")]
	public InventoryTab()
	{
	}

	// Token: 0x04000FEC RID: 4076
	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0xC")]
	public ColorChip ColorTabPrefab;

	// Token: 0x04000FED RID: 4077
	[Token(Token = "0x4000FED")]
	[FieldOffset(Offset = "0x10")]
	public PoolablePlayer PlayerPreview;

	// Token: 0x04000FEE RID: 4078
	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x14")]
	public FloatRange XRange;

	// Token: 0x04000FEF RID: 4079
	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x18")]
	public float YStart;

	// Token: 0x04000FF0 RID: 4080
	[Token(Token = "0x4000FF0")]
	[FieldOffset(Offset = "0x1C")]
	public float YOffset;

	// Token: 0x04000FF1 RID: 4081
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x20")]
	public int NumPerRow;

	// Token: 0x04000FF2 RID: 4082
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x24")]
	public Scroller scroller;

	// Token: 0x04000FF3 RID: 4083
	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<ColorChip> ColorChips;
}
