using System;
using System.Collections.Generic;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006E RID: 110
[Token(Token = "0x200006E")]
public class HeliSabotageSystem : MonoBehaviour, ISystemType, ICriticalSabotage, IActivatable
{
	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060002D6 RID: 726 RVA: 0x00002778 File Offset: 0x00000978
	// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000069")]
	public float Countdown
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x328150", Offset = "0x327550", VA = "0x10328150", Slot = "11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x3281A0", Offset = "0x3275A0", VA = "0x103281A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x1700006A")]
	public bool IsActive
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x3E8440", Offset = "0x3E7840", VA = "0x103E8440", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x1700006B")]
	public float PercentActive
	{
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x3E8480", Offset = "0x3E7880", VA = "0x103E8480")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060002DA RID: 730 RVA: 0x000027C0 File Offset: 0x000009C0
	// (set) Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006C")]
	public int TargetCode
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2D9140", Offset = "0x2D8540", VA = "0x102D9140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060002DC RID: 732 RVA: 0x000027D8 File Offset: 0x000009D8
	// (set) Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700006D")]
	public bool IsDirty
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2D91B0", Offset = "0x2D85B0", VA = "0x102D91B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060002DE RID: 734 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x1700006E")]
	public int UserCount
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "12")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x3E8350", Offset = "0x3E7750", VA = "0x103E8350")]
	public HeliSabotageSystem()
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x3E7850", Offset = "0x3E6C50", VA = "0x103E7850", Slot = "13")]
	public void ClearSabotage()
	{
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x3E7A20", Offset = "0x3E6E20", VA = "0x103E7A20", Slot = "5")]
	public void Detoriorate(float deltaTime)
	{
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x3E8110", Offset = "0x3E7510", VA = "0x103E8110")]
	private void UpdateHeliSize()
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3E7C00", Offset = "0x3E7000", VA = "0x103E7C00")]
	internal bool IsConsoleActive(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x3E7CB0", Offset = "0x3E70B0", VA = "0x103E7CB0")]
	internal bool IsConsoleOkay(int consoleId)
	{
		return default(bool);
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x3E7D00", Offset = "0x3E7100", VA = "0x103E7D00", Slot = "6")]
	public void RepairDamage(PlayerControl player, byte amount)
	{
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public void UpdateSystem(PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x3E7EA0", Offset = "0x3E72A0", VA = "0x103E7EA0", Slot = "8")]
	public void Serialize(MessageWriter writer, bool initialState)
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x3E78C0", Offset = "0x3E6CC0", VA = "0x103E78C0", Slot = "9")]
	public void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	public const float CountdownStopped = 10000f;

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	public const byte TagMask = 240;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	public const byte IdMask = 15;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Helicopter;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve ScaleCurve;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	private const float CharlesDuration = 90f;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	private const float CodeActiveDuration = 10f;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	private const float SyncRate = 1f;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<HeliSabotageSystem.ActiveConsoleData> ActiveConsoles;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<byte> CompletedConsoles;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x1C")]
	private float codeResetTimer;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x20")]
	private float syncTimer;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x24")]
	private bool wasActive;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private float <Countdown>k__BackingField;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private int <TargetCode>k__BackingField;

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <IsDirty>k__BackingField;

	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	private struct ActiveConsoleData
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x5A5F10", Offset = "0x5A5310", VA = "0x105A5F10")]
		public ActiveConsoleData(byte playerId, byte consoleId)
		{
		}

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x0")]
		public readonly byte PlayerId;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x1")]
		public readonly byte ConsoleId;
	}

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public enum Tags
	{
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		DamageBit = 128,
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		ActiveBit = 64,
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		DeactiveBit = 32,
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		FixBit = 16
	}

	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x5B5780", Offset = "0x5B4B80", VA = "0x105B5780")]
		internal bool <IsConsoleActive>b__0(HeliSabotageSystem.ActiveConsoleData s)
		{
			return default(bool);
		}

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x8")]
		public int consoleId;
	}
}
