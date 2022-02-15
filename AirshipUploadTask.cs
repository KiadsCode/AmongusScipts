using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public class AirshipUploadTask : NormalPlayerTask
{
	// Token: 0x0600032D RID: 813 RVA: 0x00002958 File Offset: 0x00000B58
	[Token(Token = "0x600032D")]
	[Address(RVA = "0x546310", Offset = "0x545710", VA = "0x10546310", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x546010", Offset = "0x545410", VA = "0x10546010", Slot = "13")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x546140", Offset = "0x545540", VA = "0x10546140", Slot = "12")]
	public override void UpdateArrow()
	{
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x545E70", Offset = "0x545270", VA = "0x10545E70", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x4B1780", Offset = "0x4B0B80", VA = "0x104B1780")]
	public AirshipUploadTask()
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002970 File Offset: 0x00000B70
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x4B9080", Offset = "0x4B8480", VA = "0x104B9080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__1_0(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x48")]
	public ArrowBehaviour[] Arrows;
}
