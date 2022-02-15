using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class PlayerTab : InventoryTab
{
	// Token: 0x0600105D RID: 4189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x508680", Offset = "0x507A80", VA = "0x10508680", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x508F50", Offset = "0x508350", VA = "0x10508F50")]
	public void Update()
	{
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x508B00", Offset = "0x507F00", VA = "0x10508B00")]
	private void SelectColor(int colorId)
	{
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x5085C0", Offset = "0x5079C0", VA = "0x105085C0", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x508420", Offset = "0x507820", VA = "0x10508420", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x2D9A20", Offset = "0x2D8E20", VA = "0x102D9A20", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x508D80", Offset = "0x508180", VA = "0x10508D80")]
	private void UpdateAvailableColors()
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00005D48 File Offset: 0x00003F48
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x508500", Offset = "0x507900", VA = "0x10508500")]
	private int GetCurrentColorId()
	{
		return 0;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x5090D0", Offset = "0x5084D0", VA = "0x105090D0")]
	public PlayerTab()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x508C20", Offset = "0x508020", VA = "0x10508C20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__5_1()
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001067")]
	[Address(RVA = "0x3BC350", Offset = "0x3BB750", VA = "0x103BC350")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <OnEnable>b__5_2()
	{
	}

	// Token: 0x0400101F RID: 4127
	[Token(Token = "0x400101F")]
	private const int Columns = 4;

	// Token: 0x04001020 RID: 4128
	[Token(Token = "0x4001020")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ColorTabArea;

	// Token: 0x04001021 RID: 4129
	[Token(Token = "0x4001021")]
	[FieldOffset(Offset = "0x30")]
	private HashSet<int> AvailableColors;

	// Token: 0x04001022 RID: 4130
	[Token(Token = "0x4001022")]
	[FieldOffset(Offset = "0x34")]
	private bool currentColorIsEquipped;

	// Token: 0x04001023 RID: 4131
	[Token(Token = "0x4001023")]
	[FieldOffset(Offset = "0x38")]
	private int currentColor;

	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x79AE40", Offset = "0x79A240", VA = "0x1079AE40")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x79AE40", Offset = "0x79A240", VA = "0x1079AE40")]
		internal void <OnEnable>b__3()
		{
		}

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x8")]
		public int j;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0xC")]
		public PlayerTab <>4__this;
	}
}
