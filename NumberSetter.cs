using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
public class NumberSetter : MonoBehaviour
{
	// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x77B770", Offset = "0x77AB70", VA = "0x1077B770")]
	private void OnEnable()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x77B6F0", Offset = "0x77AAF0", VA = "0x1077B6F0")]
	private void OnDisable()
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x77BB70", Offset = "0x77AF70", VA = "0x1077BB70")]
	public void Start()
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x77B8C0", Offset = "0x77ACC0", VA = "0x1077B8C0")]
	public void SetData(NumberButton selected)
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x77C270", Offset = "0x77B670", VA = "0x1077C270")]
	public void UpdateDays()
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x77C430", Offset = "0x77B830", VA = "0x1077C430")]
	public NumberSetter()
	{
	}

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0xC")]
	public NumberButton ButtonPrefab;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x10")]
	public Scroller ButtonParent;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x14")]
	public float ButtonStart;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x18")]
	public float ButtonHeight;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x1C")]
	private NumberButton[] AllButtons;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x20")]
	public NumberMenu parent;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x24")]
	public NumberSetter dayNumberSetter;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x28")]
	public NumberSetter.DateType dateType;

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UiElement> selectableObjects;

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x30")]
	public UiElement backButton;

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public enum DateType
	{
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		DAYS,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		YEARS,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		MONTHS
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x79A210", Offset = "0x799610", VA = "0x1079A210")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x8")]
		public NumberButton button;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xC")]
		public NumberSetter <>4__this;
	}
}
