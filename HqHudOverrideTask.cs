using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004E9 RID: 1257
[Token(Token = "0x20004E9")]
public class HqHudOverrideTask : SabotageTask, IHudOverrideTask
{
	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00008658 File Offset: 0x00006858
	[Token(Token = "0x170003EB")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x3E9CF0", Offset = "0x3E90F0", VA = "0x103E9CF0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x170003EC")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x3E9BD0", Offset = "0x3E8FD0", VA = "0x103E9BD0", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x3E9B70", Offset = "0x3E8F70", VA = "0x103E9B70")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x3E9C90", Offset = "0x3E9090", VA = "0x103E9C90", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x3E99F0", Offset = "0x3E8DF0", VA = "0x103E99F0", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x3E9810", Offset = "0x3E8C10", VA = "0x103E9810", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x3E9CE0", Offset = "0x3E90E0", VA = "0x103E9CE0")]
	public HqHudOverrideTask()
	{
	}

	// Token: 0x04001AF2 RID: 6898
	[Token(Token = "0x4001AF2")]
	[FieldOffset(Offset = "0x30")]
	private bool isComplete;

	// Token: 0x04001AF3 RID: 6899
	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x34")]
	private HqHudSystemType system;

	// Token: 0x04001AF4 RID: 6900
	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x38")]
	private bool even;
}
