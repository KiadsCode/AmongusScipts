using System;
using Il2CppDummyDll;

// Token: 0x020004F5 RID: 1269
[Token(Token = "0x20004F5")]
[Serializable]
public class TaskSet
{
	// Token: 0x06001B34 RID: 6964 RVA: 0x000089E8 File Offset: 0x00006BE8
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x769CA0", Offset = "0x7690A0", VA = "0x10769CA0")]
	public bool Contains(PlayerTask t)
	{
		return default(bool);
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x769CF0", Offset = "0x7690F0", VA = "0x10769CF0")]
	public TaskSet()
	{
	}

	// Token: 0x04001B1D RID: 6941
	[Token(Token = "0x4001B1D")]
	[FieldOffset(Offset = "0x8")]
	public TaskTypes taskType;

	// Token: 0x04001B1E RID: 6942
	[Token(Token = "0x4001B1E")]
	[FieldOffset(Offset = "0xC")]
	public IntRange taskStep;
}
