using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002F6 RID: 758
[Token(Token = "0x20002F6")]
public class RegionMenu : MonoBehaviour
{
	// Token: 0x060010AE RID: 4270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x4F4F70", Offset = "0x4F4370", VA = "0x104F4F70")]
	private void Awake()
	{
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x4F5170", Offset = "0x4F4570", VA = "0x104F5170")]
	public void OnEnable()
	{
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x4F5990", Offset = "0x4F4D90", VA = "0x104F5990")]
	private void OpenCustomRegion()
	{
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x4F50E0", Offset = "0x4F44E0", VA = "0x104F50E0")]
	public void OnDisable()
	{
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x499D70", Offset = "0x499170", VA = "0x10499D70")]
	public void Open()
	{
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x4F4FD0", Offset = "0x4F43D0", VA = "0x104F4FD0")]
	public void ChooseOption(IRegionInfo region)
	{
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x499D40", Offset = "0x499140", VA = "0x10499D40")]
	public void Close()
	{
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public RegionMenu()
	{
	}

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0xC")]
	public ObjectPoolBehavior ButtonPool;

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro RegionText;

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x18")]
	private UiElement defaultButtonSelected;

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x1C")]
	private List<UiElement> controllerSelectable;

	// Token: 0x020002F7 RID: 759
	[Token(Token = "0x20002F7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x3716A0", Offset = "0x370AA0", VA = "0x103716A0")]
		internal bool <OnEnable>b__1(IRegionInfo d)
		{
			return default(bool);
		}

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x8")]
		public IRegionInfo s;
	}

	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass6_1
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass6_1()
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x371710", Offset = "0x370B10", VA = "0x10371710")]
		internal void <OnEnable>b__2()
		{
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x8")]
		public IRegionInfo region;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0xC")]
		public RegionMenu <>4__this;
	}

	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x370610", Offset = "0x36FA10", VA = "0x10370610")]
		internal uint <OnEnable>b__6_0(IRegionInfo s)
		{
			return 0U;
		}

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RegionMenu.<>c <>9;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x4")]
		public static Func<IRegionInfo, uint> <>9__6_0;
	}
}
