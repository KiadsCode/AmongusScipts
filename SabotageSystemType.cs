using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;

// Token: 0x020004AB RID: 1195
[Token(Token = "0x20004AB")]
public class SabotageSystemType : ISystemType
{
	// Token: 0x170003AC RID: 940
	// (get) Token: 0x0600195E RID: 6494 RVA: 0x00007F68 File Offset: 0x00006168
	// (set) Token: 0x0600195F RID: 6495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003AC")]
	public float Timer
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x273760", Offset = "0x272B60", VA = "0x10273760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x2737C0", Offset = "0x272BC0", VA = "0x102737C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06001960 RID: 6496 RVA: 0x00007F80 File Offset: 0x00006180
	[Token(Token = "0x170003AD")]
	public float PercentCool
	{
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x57F400", Offset = "0x57E800", VA = "0x1057F400")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06001961 RID: 6497 RVA: 0x00007F98 File Offset: 0x00006198
	[Token(Token = "0x170003AE")]
	public bool AnyActive
	{
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x57F310", Offset = "0x57E710", VA = "0x1057F310")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06001962 RID: 6498 RVA: 0x00007FB0 File Offset: 0x000061B0
	// (set) Token: 0x06001963 RID: 6499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003AF")]
	public bool IsDirty
	{
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x274D00", Offset = "0x274100", VA = "0x10274D00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x57F190", Offset = "0x57E590", VA = "0x1057F190")]
	public SabotageSystemType(IActivatable[] specials)
	{
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x57EDC0", Offset = "0x57E1C0", VA = "0x1057EDC0", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x57EF00", Offset = "0x57E300", VA = "0x1057EF00")]
	public void ForceSabTime(float t)
	{
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x57EF20", Offset = "0x57E320", VA = "0x1057EF20", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001968")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x57F150", Offset = "0x57E550", VA = "0x1057F150", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x57ED90", Offset = "0x57E190", VA = "0x1057ED90", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x04001973 RID: 6515
	[Token(Token = "0x4001973")]
	public const float SpecialSabDelay = 30f;

	// Token: 0x04001974 RID: 6516
	[Token(Token = "0x4001974")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <Timer>k__BackingField;

	// Token: 0x04001975 RID: 6517
	[Token(Token = "0x4001975")]
	[FieldOffset(Offset = "0xC")]
	private List<IActivatable> specials;

	// Token: 0x04001976 RID: 6518
	[Token(Token = "0x4001976")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x04001977 RID: 6519
	[Token(Token = "0x4001977")]
	[FieldOffset(Offset = "0x14")]
	private SabotageSystemType.DummySab dummy;

	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public class DummySab : IActivatable
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x170003B0")]
		public bool IsActive
		{
			[Token(Token = "0x600196B")]
			[Address(RVA = "0x364200", Offset = "0x363600", VA = "0x10364200", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public DummySab()
		{
		}

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0x8")]
		public float timer;
	}

	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x370CA0", Offset = "0x3700A0", VA = "0x10370CA0")]
		internal bool <get_AnyActive>b__9_0(IActivatable s)
		{
			return default(bool);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x370C60", Offset = "0x370060", VA = "0x10370C60")]
		internal bool <.ctor>b__16_0(IActivatable d)
		{
			return default(bool);
		}

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SabotageSystemType.<>c <>9;

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x4")]
		public static Func<IActivatable, bool> <>9__9_0;

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<IActivatable> <>9__16_0;
	}
}
