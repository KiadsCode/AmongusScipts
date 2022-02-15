using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FE RID: 510
[Token(Token = "0x20001FE")]
public class DemoKeyboardStick : VirtualJoystick
{
	// Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x5C5BE0", Offset = "0x5C4FE0", VA = "0x105C5BE0", Slot = "7")]
	public override void UpdateJoystick(FingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x5C5C90", Offset = "0x5C5090", VA = "0x105C5C90")]
	public DemoKeyboardStick()
	{
	}

	// Token: 0x04000B83 RID: 2947
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer UpKey;

	// Token: 0x04000B84 RID: 2948
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer DownKey;

	// Token: 0x04000B85 RID: 2949
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer LeftKey;

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer RightKey;
}
