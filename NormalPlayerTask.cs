using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

// Token: 0x020004ED RID: 1261
[Token(Token = "0x20004ED")]
public class NormalPlayerTask : PlayerTask
{
	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00008778 File Offset: 0x00006978
	[Token(Token = "0x170003F3")]
	public override int TaskStep
	{
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x170003F4")]
	public override bool IsComplete
	{
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x77AB30", Offset = "0x779F30", VA = "0x1077AB30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x7792D0", Offset = "0x7786D0", VA = "0x107792D0", Slot = "6")]
	public override void Initialize()
	{
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x779B80", Offset = "0x778F80", VA = "0x10779B80")]
	public void NextStep()
	{
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x77A210", Offset = "0x779610", VA = "0x1077A210", Slot = "12")]
	public virtual void UpdateArrow()
	{
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x779130", Offset = "0x778530", VA = "0x10779130", Slot = "13")]
	protected virtual void FixedUpdate()
	{
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x77A670", Offset = "0x779A70", VA = "0x1077A670", Slot = "8")]
	public override bool ValidConsole(global::Console console)
	{
		return default(bool);
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF8")]
	[Address(RVA = "0x779120", Offset = "0x778520", VA = "0x10779120", Slot = "9")]
	public override void Complete()
	{
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x778E40", Offset = "0x778240", VA = "0x10778E40", Slot = "10")]
	public override void AppendTaskText(StringBuilder sb)
	{
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000087C0 File Offset: 0x000069C0
	[Token(Token = "0x6001AFA")]
	[Address(RVA = "0x77A040", Offset = "0x779440", VA = "0x1077A040")]
	private bool ShouldYellowText()
	{
		return default(bool);
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AFB")]
	[Address(RVA = "0x779E50", Offset = "0x779250", VA = "0x10779E50")]
	private List<global::Console> PickRandomConsoles(TaskTypes taskType, byte[] consoleIds)
	{
		return null;
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0x77AB10", Offset = "0x779F10", VA = "0x1077AB10")]
	public NormalPlayerTask()
	{
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000087D8 File Offset: 0x000069D8
	[Token(Token = "0x6001AFD")]
	[Address(RVA = "0x77A090", Offset = "0x779490", VA = "0x1077A090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Initialize>b__14_0(global::Console v)
	{
		return default(bool);
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000087F0 File Offset: 0x000069F0
	[Token(Token = "0x6001AFE")]
	[Address(RVA = "0x77A0D0", Offset = "0x7794D0", VA = "0x1077A0D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <UpdateArrow>b__16_2(global::Console c)
	{
		return default(bool);
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00008808 File Offset: 0x00006A08
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x77A150", Offset = "0x779550", VA = "0x1077A150")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <UpdateArrow>b__16_3(global::Console c)
	{
		return default(bool);
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00008820 File Offset: 0x00006A20
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x4B9080", Offset = "0x4B8480", VA = "0x104B9080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__18_0(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x00008838 File Offset: 0x00006A38
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x77A190", Offset = "0x779590", VA = "0x1077A190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__18_1(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x00008850 File Offset: 0x00006A50
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x77A1F0", Offset = "0x7795F0", VA = "0x1077A1F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__18_2(TaskTypes tt)
	{
		return default(bool);
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x00008868 File Offset: 0x00006A68
	[Token(Token = "0x6001B03")]
	[Address(RVA = "0x77A1F0", Offset = "0x7795F0", VA = "0x1077A1F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__18_3(TaskTypes tt)
	{
		return default(bool);
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x00008880 File Offset: 0x00006A80
	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x4B9080", Offset = "0x4B8480", VA = "0x104B9080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <ValidConsole>b__18_4(TaskSet set)
	{
		return default(bool);
	}

	// Token: 0x04001AFD RID: 6909
	[Token(Token = "0x4001AFD")]
	[FieldOffset(Offset = "0x28")]
	public int taskStep;

	// Token: 0x04001AFE RID: 6910
	[Token(Token = "0x4001AFE")]
	[FieldOffset(Offset = "0x2C")]
	public int MaxStep;

	// Token: 0x04001AFF RID: 6911
	[Token(Token = "0x4001AFF")]
	[FieldOffset(Offset = "0x30")]
	public bool ShowTaskStep;

	// Token: 0x04001B00 RID: 6912
	[Token(Token = "0x4001B00")]
	[FieldOffset(Offset = "0x31")]
	public bool ShowTaskTimer;

	// Token: 0x04001B01 RID: 6913
	[Token(Token = "0x4001B01")]
	[FieldOffset(Offset = "0x34")]
	public NormalPlayerTask.TimerState TimerStarted;

	// Token: 0x04001B02 RID: 6914
	[Token(Token = "0x4001B02")]
	[FieldOffset(Offset = "0x38")]
	public float TaskTimer;

	// Token: 0x04001B03 RID: 6915
	[Token(Token = "0x4001B03")]
	[FieldOffset(Offset = "0x3C")]
	public byte[] Data;

	// Token: 0x04001B04 RID: 6916
	[Token(Token = "0x4001B04")]
	[FieldOffset(Offset = "0x40")]
	public ArrowBehaviour Arrow;

	// Token: 0x04001B05 RID: 6917
	[Token(Token = "0x4001B05")]
	[FieldOffset(Offset = "0x44")]
	protected bool arrowSuspended;

	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public enum TimerState
	{
		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		NotStarted,
		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		Started,
		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		Finished
	}

	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x79A740", Offset = "0x799B40", VA = "0x1079A740")]
		internal bool <Initialize>b__1(global::Console v)
		{
			return default(bool);
		}

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x8")]
		public byte[] consoleIds;
	}

	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x799C50", Offset = "0x799050", VA = "0x10799C50")]
		internal bool <UpdateArrow>b__16_0(global::Console c)
		{
			return default(bool);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x799CB0", Offset = "0x7990B0", VA = "0x10799CB0")]
		internal bool <UpdateArrow>b__16_1(global::Console console)
		{
			return default(bool);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x799D60", Offset = "0x799160", VA = "0x10799D60")]
		internal bool <ValidConsole>b__18_5(byte b)
		{
			return default(bool);
		}

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NormalPlayerTask.<>c <>9;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		[FieldOffset(Offset = "0x4")]
		public static Func<global::Console, bool> <>9__16_0;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<global::Console, bool> <>9__16_1;

		// Token: 0x04001B0E RID: 6926
		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0xC")]
		public static Predicate<byte> <>9__18_5;
	}

	// Token: 0x020004F1 RID: 1265
	[Token(Token = "0x20004F1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x79A900", Offset = "0x799D00", VA = "0x1079A900")]
		internal bool <PickRandomConsoles>b__0(global::Console t)
		{
			return default(bool);
		}

		// Token: 0x04001B0F RID: 6927
		[Token(Token = "0x4001B0F")]
		[FieldOffset(Offset = "0x8")]
		public TaskTypes taskType;
	}
}
