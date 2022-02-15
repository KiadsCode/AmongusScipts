using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004EB RID: 1259
[Token(Token = "0x20004EB")]
public class ImportantTextTask : PlayerTask
{
	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000086E8 File Offset: 0x000068E8
	[Token(Token = "0x170003EF")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00008700 File Offset: 0x00006900
	[Token(Token = "0x170003F0")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00008718 File Offset: 0x00006918
	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x3ED3C0", Offset = "0x3EC7C0", VA = "0x103ED3C0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x3ED430", Offset = "0x3EC830", VA = "0x103ED430")]
	public ImportantTextTask()
	{
	}

	// Token: 0x04001AF8 RID: 6904
	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x28")]
	public string Text;
}
