using System;
using Hazel;
using Il2CppDummyDll;

// Token: 0x0200049B RID: 1179
[Token(Token = "0x200049B")]
internal class HudOverrideSystemType : ISystemType, IActivatable
{
	// Token: 0x17000394 RID: 916
	// (get) Token: 0x0600190E RID: 6414 RVA: 0x00007DA0 File Offset: 0x00005FA0
	// (set) Token: 0x0600190F RID: 6415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000394")]
	public bool IsActive
	{
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x28A640", Offset = "0x289A40", VA = "0x1028A640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x06001910 RID: 6416 RVA: 0x00007DB8 File Offset: 0x00005FB8
	// (set) Token: 0x06001911 RID: 6417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000395")]
	public bool IsDirty
	{
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x3ECDB0", Offset = "0x3EC1B0", VA = "0x103ECDB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x3ECDC0", Offset = "0x3EC1C0", VA = "0x103ECDC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001912")]
	[Address(RVA = "0x3ECCA0", Offset = "0x3EC0A0", VA = "0x103ECCA0", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x3ECD60", Offset = "0x3EC160", VA = "0x103ECD60", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x3ECD80", Offset = "0x3EC180", VA = "0x103ECD80", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x3ECC70", Offset = "0x3EC070", VA = "0x103ECC70", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
	public HudOverrideSystemType()
	{
	}

	// Token: 0x04001921 RID: 6433
	[Token(Token = "0x4001921")]
	public const byte DamageBit = 128;

	// Token: 0x04001922 RID: 6434
	[Token(Token = "0x4001922")]
	public const byte TaskMask = 127;

	// Token: 0x04001923 RID: 6435
	[Token(Token = "0x4001923")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsActive>k__BackingField;

	// Token: 0x04001924 RID: 6436
	[Token(Token = "0x4001924")]
	[FieldOffset(Offset = "0x9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;
}
