using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004E7 RID: 1255
[Token(Token = "0x20004E7")]
public class ElectricTask : SabotageTask
{
	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00008610 File Offset: 0x00006810
	[Token(Token = "0x170003E9")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x3E9CF0", Offset = "0x3E90F0", VA = "0x103E9CF0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x170003EA")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x4766E0", Offset = "0x475AE0", VA = "0x104766E0", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x4766A0", Offset = "0x475AA0", VA = "0x104766A0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x00008640 File Offset: 0x00006840
	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x4767A0", Offset = "0x475BA0", VA = "0x104767A0", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x4765B0", Offset = "0x4759B0", VA = "0x104765B0", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x4763E0", Offset = "0x4757E0", VA = "0x104763E0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x3E9CE0", Offset = "0x3E90E0", VA = "0x103E9CE0")]
	public ElectricTask()
	{
	}

	// Token: 0x04001AEF RID: 6895
	[Token(Token = "0x4001AEF")]
	[FieldOffset(Offset = "0x30")]
	private bool isComplete;

	// Token: 0x04001AF0 RID: 6896
	[Token(Token = "0x4001AF0")]
	[FieldOffset(Offset = "0x34")]
	private SwitchSystem system;

	// Token: 0x04001AF1 RID: 6897
	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x38")]
	private bool even;
}
