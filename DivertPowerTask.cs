using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004E6 RID: 1254
[Token(Token = "0x20004E6")]
public class DivertPowerTask : NormalPlayerTask
{
	// Token: 0x06001AC5 RID: 6853 RVA: 0x000085E0 File Offset: 0x000067E0
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x5CA620", Offset = "0x5C9A20", VA = "0x105CA620", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x5CA350", Offset = "0x5C9750", VA = "0x105CA350", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x4B1780", Offset = "0x4B0B80", VA = "0x104B1780")]
	public DivertPowerTask()
	{
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x000085F8 File Offset: 0x000067F8
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x5CA600", Offset = "0x5C9A00", VA = "0x105CA600")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__1_0(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x04001AEE RID: 6894
	[Token(Token = "0x4001AEE")]
	[FieldOffset(Offset = "0x48")]
	public SystemTypes TargetSystem;
}
