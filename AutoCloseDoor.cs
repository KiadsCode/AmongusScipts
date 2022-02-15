using System;
using Il2CppDummyDll;

// Token: 0x02000486 RID: 1158
[Token(Token = "0x2000486")]
public class AutoCloseDoor : PlainDoor
{
	// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x54E640", Offset = "0x54DA40", VA = "0x1054E640", Slot = "4")]
	public override void SetDoorway(bool open)
	{
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00007B78 File Offset: 0x00005D78
	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x54E590", Offset = "0x54D990", VA = "0x1054E590", Slot = "7")]
	public override bool DoUpdate(float dt)
	{
		return default(bool);
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x4AEA20", Offset = "0x4ADE20", VA = "0x104AEA20")]
	public AutoCloseDoor()
	{
	}

	// Token: 0x040018CF RID: 6351
	[Token(Token = "0x40018CF")]
	private const float OpenDuration = 10f;

	// Token: 0x040018D0 RID: 6352
	[Token(Token = "0x40018D0")]
	[FieldOffset(Offset = "0x34")]
	private float OpenTime;
}
