using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004FB RID: 1275
[Token(Token = "0x20004FB")]
public class UploadDataTask : NormalPlayerTask
{
	// Token: 0x06001B40 RID: 6976 RVA: 0x00008A60 File Offset: 0x00006C60
	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x4B90C0", Offset = "0x4B84C0", VA = "0x104B90C0", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x4B8EA0", Offset = "0x4B82A0", VA = "0x104B8EA0", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x4B9190", Offset = "0x4B8590", VA = "0x104B9190")]
	public UploadDataTask()
	{
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x00008A78 File Offset: 0x00006C78
	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x4B9080", Offset = "0x4B8480", VA = "0x104B9080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__1_0(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x04001B63 RID: 7011
	[Token(Token = "0x4001B63")]
	[FieldOffset(Offset = "0x48")]
	public SystemTypes EndAt;
}
