using System;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004FD RID: 1277
[Token(Token = "0x20004FD")]
public class WeatherNodeTask : NormalPlayerTask
{
	// Token: 0x06001B47 RID: 6983 RVA: 0x00008AA8 File Offset: 0x00006CA8
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x7BA580", Offset = "0x7B9980", VA = "0x107BA580", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x7BA560", Offset = "0x7B9960", VA = "0x107BA560", Slot = "11")]
	public override Minigame GetMinigamePrefab()
	{
		return null;
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x7BA330", Offset = "0x7B9730", VA = "0x107BA330", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x4B1780", Offset = "0x4B0B80", VA = "0x104B1780")]
	public WeatherNodeTask()
	{
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00008AC0 File Offset: 0x00006CC0
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x5CA600", Offset = "0x5C9A00", VA = "0x105CA600")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__2_0(TaskSet t)
	{
		return default(bool);
	}

	// Token: 0x04001B64 RID: 7012
	[Token(Token = "0x4001B64")]
	[FieldOffset(Offset = "0x48")]
	public int NodeId;

	// Token: 0x04001B65 RID: 7013
	[Token(Token = "0x4001B65")]
	[FieldOffset(Offset = "0x4C")]
	public Minigame Stage2Prefab;
}
