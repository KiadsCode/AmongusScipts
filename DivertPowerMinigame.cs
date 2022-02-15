using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class DivertPowerMinigame : Minigame
{
	// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x5C9720", Offset = "0x5C8B20", VA = "0x105C9720", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x5C99D0", Offset = "0x5C8DD0", VA = "0x105C99D0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x5CA290", Offset = "0x5C9690", VA = "0x105CA290")]
	public DivertPowerMinigame()
	{
	}

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x30")]
	public SystemTypes[] SliderOrder;

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x34")]
	public Collider2D[] Sliders;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x38")]
	public LineRenderer[] Wires;

	// Token: 0x040007D7 RID: 2007
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x3C")]
	public VerticalGauge[] Gauges;

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x40")]
	private int sliderId;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x44")]
	public FloatRange SliderY;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x48")]
	private Controller myController;

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x4C")]
	public ActionMapGlyphDisplay glyphDisplay;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x50")]
	private int inputJoystick;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x54")]
	private bool prevHadInput;

	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x78DA80", Offset = "0x78CE80", VA = "0x1078DA80")]
		internal bool <Begin>b__0(SystemTypes t)
		{
			return default(bool);
		}

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x8")]
		public DivertPowerTask powerTask;
	}
}
