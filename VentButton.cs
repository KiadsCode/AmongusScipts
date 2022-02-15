using System;
using Il2CppDummyDll;

// Token: 0x020001DC RID: 476
[Token(Token = "0x20001DC")]
public class VentButton : ActionButton
{
	// Token: 0x06000AA8 RID: 2728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x7A9E10", Offset = "0x7A9210", VA = "0x107A9E10")]
	public void SetTarget(Vent target)
	{
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x7A9CD0", Offset = "0x7A90D0", VA = "0x107A9CD0", Slot = "4")]
	public override void DoClick()
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public VentButton()
	{
	}

	// Token: 0x04000AB7 RID: 2743
	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x2C")]
	private Vent currentTarget;
}
