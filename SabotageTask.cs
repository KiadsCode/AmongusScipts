using System;
using Il2CppDummyDll;

// Token: 0x020004F4 RID: 1268
[Token(Token = "0x20004F4")]
public abstract class SabotageTask : PlayerTask
{
	// Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x57F420", Offset = "0x57E820", VA = "0x1057F420")]
	public void MarkContributed()
	{
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x57F430", Offset = "0x57E830", VA = "0x1057F430")]
	protected void SetupArrows()
	{
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x3ED430", Offset = "0x3EC830", VA = "0x103ED430")]
	protected SabotageTask()
	{
	}

	// Token: 0x04001B1B RID: 6939
	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0x28")]
	protected bool didContribute;

	// Token: 0x04001B1C RID: 6940
	[Token(Token = "0x4001B1C")]
	[FieldOffset(Offset = "0x2C")]
	public ArrowBehaviour[] Arrows;
}
