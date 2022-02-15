using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
public class SwitchSystem : ISystemType, IActivatable
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000806 RID: 2054 RVA: 0x00004098 File Offset: 0x00002298
	// (set) Token: 0x06000807 RID: 2055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000136")]
	public bool IsDirty
	{
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x7667C0", Offset = "0x765BC0", VA = "0x107667C0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x39BA10", Offset = "0x39AE10", VA = "0x1039BA10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000808 RID: 2056 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x17000137")]
	public float Level
	{
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x7667D0", Offset = "0x765BD0", VA = "0x107667D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000809 RID: 2057 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x17000138")]
	public bool IsActive
	{
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x7667A0", Offset = "0x765BA0", VA = "0x107667A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080A")]
	[Address(RVA = "0x766720", Offset = "0x765B20", VA = "0x10766720")]
	public SwitchSystem()
	{
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080B")]
	[Address(RVA = "0x766510", Offset = "0x765910", VA = "0x10766510", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080C")]
	[Address(RVA = "0x766650", Offset = "0x765A50", VA = "0x10766650", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080D")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080E")]
	[Address(RVA = "0x7666D0", Offset = "0x765AD0", VA = "0x107666D0", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600080F")]
	[Address(RVA = "0x7664D0", Offset = "0x7658D0", VA = "0x107664D0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x000040E0 File Offset: 0x000022E0
	[Token(Token = "0x6000810")]
	protected static bool HasTask<T>()
	{
		return default(bool);
	}

	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000804")]
	public const byte MaxValue = 255;

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	public const int NumSwitches = 5;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	public const byte DamageSystem = 128;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	public const byte SwitchesMask = 31;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x8")]
	public float DetoriorationTime;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0xC")]
	public byte Value;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x10")]
	private float timer;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x14")]
	public byte ExpectedSwitches;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x15")]
	public byte ActualSwitches;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x16")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;
}
