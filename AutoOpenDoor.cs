using System;
using Il2CppDummyDll;

// Token: 0x02000489 RID: 1161
[Token(Token = "0x2000489")]
public class AutoOpenDoor : PlainDoor
{
	// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x54F110", Offset = "0x54E510", VA = "0x1054F110", Slot = "4")]
	public override void SetDoorway(bool open)
	{
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00007BF0 File Offset: 0x00005DF0
	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x54F010", Offset = "0x54E410", VA = "0x1054F010", Slot = "7")]
	public override bool DoUpdate(float dt)
	{
		return default(bool);
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x4AEA20", Offset = "0x4ADE20", VA = "0x104AEA20")]
	public AutoOpenDoor()
	{
	}

	// Token: 0x040018D4 RID: 6356
	[Token(Token = "0x40018D4")]
	private const float ClosedDuration = 10f;

	// Token: 0x040018D5 RID: 6357
	[Token(Token = "0x40018D5")]
	public const float CooldownDuration = 30f;

	// Token: 0x040018D6 RID: 6358
	[Token(Token = "0x40018D6")]
	[FieldOffset(Offset = "0x34")]
	public float ClosedTimer;

	// Token: 0x040018D7 RID: 6359
	[Token(Token = "0x40018D7")]
	[FieldOffset(Offset = "0x38")]
	public float CooldownTimer;
}
