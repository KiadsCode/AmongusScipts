using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;

// Token: 0x02000280 RID: 640
[Token(Token = "0x2000280")]
[Skip]
public class StaticRegionInfo : IRegionInfo
{
	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000226")]
	public string Name
	{
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000227")]
	public string PingServer
	{
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000228")]
	public ServerInfo[] Servers
	{
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000E3B RID: 3643 RVA: 0x000057C0 File Offset: 0x000039C0
	[Token(Token = "0x17000229")]
	public StringNames TranslateName
	{
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return StringNames.ExitButton;
		}
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x757AB0", Offset = "0x756EB0", VA = "0x10757AB0")]
	public StaticRegionInfo(string name, StringNames translateName, string pingServer, ServerInfo[] servers)
	{
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x757AE0", Offset = "0x756EE0", VA = "0x10757AE0", Slot = "8")]
	public IRegionInfo Duplicate()
	{
		return null;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x000057D8 File Offset: 0x000039D8
	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x757CD0", Offset = "0x7570D0", VA = "0x10757CD0", Slot = "9")]
	public bool Validate()
	{
		return default(bool);
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x5CA840", Offset = "0x5C9C40", VA = "0x105CA840", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x757C60", Offset = "0x757060", VA = "0x10757C60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x04000E34 RID: 3636
	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly string <Name>k__BackingField;

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly string <PingServer>k__BackingField;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly ServerInfo[] <Servers>k__BackingField;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly StringNames <TranslateName>k__BackingField;

	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x370AB0", Offset = "0x36FEB0", VA = "0x10370AB0")]
		internal bool <Validate>b__14_0(ServerInfo s)
		{
			return default(bool);
		}

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StaticRegionInfo.<>c <>9;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ServerInfo, bool> <>9__14_0;
	}
}
