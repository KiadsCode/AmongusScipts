using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004F3 RID: 1267
[Token(Token = "0x20004F3")]
public class ReactorTask : SabotageTask
{
	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00008988 File Offset: 0x00006B88
	[Token(Token = "0x170003FB")]
	public override int TaskStep
	{
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x4F35F0", Offset = "0x4F29F0", VA = "0x104F35F0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06001B27 RID: 6951 RVA: 0x000089A0 File Offset: 0x00006BA0
	[Token(Token = "0x170003FC")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x4F3570", Offset = "0x4F2970", VA = "0x104F3570", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x4F3240", Offset = "0x4F2640", VA = "0x104F3240")]
	public void Awake()
	{
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0x4F3500", Offset = "0x4F2900", VA = "0x104F3500")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000089B8 File Offset: 0x00006BB8
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x4F35A0", Offset = "0x4F29A0", VA = "0x104F35A0", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public override void OnRemove()
	{
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x4F3410", Offset = "0x4F2810", VA = "0x104F3410", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x4F2FD0", Offset = "0x4F23D0", VA = "0x104F2FD0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x3E9CE0", Offset = "0x3E90E0", VA = "0x103E9CE0")]
	public ReactorTask()
	{
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x000089D0 File Offset: 0x00006BD0
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x4F3580", Offset = "0x4F2980", VA = "0x104F3580")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Awake>b__8_0(PlainShipRoom r)
	{
		return default(bool);
	}

	// Token: 0x04001B18 RID: 6936
	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0x30")]
	private bool isComplete;

	// Token: 0x04001B19 RID: 6937
	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x34")]
	private ICriticalSabotage reactor;

	// Token: 0x04001B1A RID: 6938
	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x38")]
	private bool even;
}
