using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000238 RID: 568
[Token(Token = "0x2000238")]
public class PassiveButtonManager : DestroyableSingleton<PassiveButtonManager>
{
	// Token: 0x06000CB4 RID: 3252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x657FE0", Offset = "0x6573E0", VA = "0x10657FE0")]
	public void RegisterOne(PassiveUiElement button)
	{
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x658030", Offset = "0x657430", VA = "0x10658030")]
	public void RemoveOne(PassiveUiElement passiveButton)
	{
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x657F90", Offset = "0x657390", VA = "0x10657F90")]
	public void RegisterOne(IFocusHolder focusHolder)
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x658080", Offset = "0x657480", VA = "0x10658080")]
	public void RemoveOne(IFocusHolder focusHolder)
	{
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x6580D0", Offset = "0x6574D0", VA = "0x106580D0")]
	public void Update()
	{
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x6575D0", Offset = "0x6569D0", VA = "0x106575D0")]
	private void HandleFocus(Vector2 pt)
	{
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x657E80", Offset = "0x657280", VA = "0x10657E80")]
	public void LoseFocusForAll()
	{
	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x6579B0", Offset = "0x656DB0", VA = "0x106579B0")]
	private void HandleMouseOut()
	{
	}

	// Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x657B40", Offset = "0x656F40", VA = "0x10657B40")]
	private void HandleMouseOver(PassiveUiElement button, Collider2D col)
	{
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x00004FE0 File Offset: 0x000031E0
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x6574F0", Offset = "0x6568F0", VA = "0x106574F0")]
	private Vector2 GetTouch(bool getDownTouch)
	{
		return default(Vector2);
	}

	// Token: 0x06000CBE RID: 3262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x6589B0", Offset = "0x657DB0", VA = "0x106589B0")]
	public PassiveButtonManager()
	{
	}

	// Token: 0x04000CA7 RID: 3239
	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0x10")]
	public List<PassiveUiElement> Buttons;

	// Token: 0x04000CA8 RID: 3240
	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x14")]
	private List<IFocusHolder> FocusHolders;

	// Token: 0x04000CA9 RID: 3241
	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x18")]
	private PassiveUiElement currentOver;

	// Token: 0x04000CAA RID: 3242
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x1C")]
	public Controller controller;

	// Token: 0x04000CAB RID: 3243
	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0x20")]
	private PassiveButtonManager.ButtonStates currentState;

	// Token: 0x04000CAC RID: 3244
	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x24")]
	private Collider2D[] results;

	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	private enum ButtonStates
	{
		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		Up,
		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		Down,
		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		Drag
	}

	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	private class DepthComparer : IComparer<PassiveUiElement>
	{
		// Token: 0x06000CBF RID: 3263 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x78E910", Offset = "0x78DD10", VA = "0x1078E910", Slot = "4")]
		public int Compare(PassiveUiElement x, PassiveUiElement y)
		{
			return 0;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public DepthComparer()
		{
		}

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x3313330B")]
		public static readonly PassiveButtonManager.DepthComparer Instance;
	}

	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x799F10", Offset = "0x799310", VA = "0x10799F10")]
		internal bool <Update>b__0(PassiveUiElement b2)
		{
			return default(bool);
		}

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x8")]
		public Collider2D col;
	}

	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x79A050", Offset = "0x799450", VA = "0x1079A050")]
		internal bool <HandleFocus>b__1(Collider2D c)
		{
			return default(bool);
		}

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 pt;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x10")]
		public Func<Collider2D, bool> <>9__1;
	}

	// Token: 0x0200023D RID: 573
	[Token(Token = "0x200023D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass12_1
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass12_1()
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x79A110", Offset = "0x799510", VA = "0x1079A110")]
		internal bool <HandleFocus>b__0(PassiveUiElement top)
		{
			return default(bool);
		}

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x8")]
		public float depth;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0xC")]
		public PassiveButtonManager.<>c__DisplayClass12_0 CS$<>8__locals1;
	}

	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x79A6F0", Offset = "0x799AF0", VA = "0x1079A6F0")]
		internal bool <HandleMouseOut>b__0(Collider2D c)
		{
			return default(bool);
		}

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x8")]
		public Controller.TouchState pt;
	}
}
