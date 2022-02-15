using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class ScreenJoystick : MonoBehaviour, IVirtualJoystick
{
	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00004B00 File Offset: 0x00002D00
	// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B4")]
	public Vector2 Delta
	{
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x58B8A0", Offset = "0x58ACA0", VA = "0x1058B8A0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x2D5FE0", Offset = "0x2D53E0", VA = "0x102D5FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
	public void ToggleVisuals(bool on)
	{
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x58B500", Offset = "0x58A900", VA = "0x1058B500")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x58B830", Offset = "0x58AC30", VA = "0x1058B830")]
	public ScreenJoystick()
	{
	}

	// Token: 0x04000B8E RID: 2958
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0xC")]
	private Collider2D[] hitBuffer;

	// Token: 0x04000B8F RID: 2959
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Vector2 <Delta>k__BackingField;

	// Token: 0x04000B90 RID: 2960
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x18")]
	private Controller myController;

	// Token: 0x04000B91 RID: 2961
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x1C")]
	private int touchId;
}
