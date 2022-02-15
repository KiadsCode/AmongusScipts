using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004EC RID: 1260
[Token(Token = "0x20004EC")]
public class NoOxyTask : SabotageTask
{
	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00008730 File Offset: 0x00006930
	[Token(Token = "0x170003F1")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x7782E0", Offset = "0x7776E0", VA = "0x107782E0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x00008748 File Offset: 0x00006948
	[Token(Token = "0x170003F2")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x778170", Offset = "0x777570", VA = "0x10778170", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x778090", Offset = "0x777490", VA = "0x10778090")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x00008760 File Offset: 0x00006960
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x778270", Offset = "0x777670", VA = "0x10778270", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public override void OnRemove()
	{
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x777FA0", Offset = "0x7773A0", VA = "0x10777FA0", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x777CC0", Offset = "0x7770C0", VA = "0x10777CC0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x3E9CE0", Offset = "0x3E90E0", VA = "0x103E9CE0")]
	public NoOxyTask()
	{
	}

	// Token: 0x04001AF9 RID: 6905
	[Token(Token = "0x4001AF9")]
	[FieldOffset(Offset = "0x30")]
	private bool isComplete;

	// Token: 0x04001AFA RID: 6906
	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x34")]
	private LifeSuppSystemType reactor;

	// Token: 0x04001AFB RID: 6907
	[Token(Token = "0x4001AFB")]
	[FieldOffset(Offset = "0x38")]
	private bool even;

	// Token: 0x04001AFC RID: 6908
	[Token(Token = "0x4001AFC")]
	[FieldOffset(Offset = "0x3C")]
	public int targetNumber;
}
