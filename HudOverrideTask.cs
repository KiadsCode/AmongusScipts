using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004EA RID: 1258
[Token(Token = "0x20004EA")]
public class HudOverrideTask : SabotageTask, IHudOverrideTask
{
	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x000086A0 File Offset: 0x000068A0
	[Token(Token = "0x170003ED")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x3E9CF0", Offset = "0x3E90F0", VA = "0x103E9CF0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000086B8 File Offset: 0x000068B8
	[Token(Token = "0x170003EE")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x3ED060", Offset = "0x3EC460", VA = "0x103ED060", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x3ED020", Offset = "0x3EC420", VA = "0x103ED020")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000086D0 File Offset: 0x000068D0
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x3ED120", Offset = "0x3EC520", VA = "0x103ED120", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x3ECF30", Offset = "0x3EC330", VA = "0x103ECF30", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x3ECDD0", Offset = "0x3EC1D0", VA = "0x103ECDD0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x3E9CE0", Offset = "0x3E90E0", VA = "0x103E9CE0")]
	public HudOverrideTask()
	{
	}

	// Token: 0x04001AF5 RID: 6901
	[Token(Token = "0x4001AF5")]
	[FieldOffset(Offset = "0x30")]
	private bool isComplete;

	// Token: 0x04001AF6 RID: 6902
	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x34")]
	private HudOverrideSystemType system;

	// Token: 0x04001AF7 RID: 6903
	[Token(Token = "0x4001AF7")]
	[FieldOffset(Offset = "0x38")]
	private bool even;
}
