using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
[Skip]
public class StaticHttpRegionInfo : IRegionInfo
{
	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021E")]
	public string Name
	{
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021F")]
	public string PingServer
	{
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000220")]
	public ServerInfo[] Servers
	{
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x17000221")]
	public StringNames TranslateName
	{
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return StringNames.ExitButton;
		}
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x757AB0", Offset = "0x756EB0", VA = "0x10757AB0")]
	public StaticHttpRegionInfo(string name, StringNames translateName, string pingServer, ServerInfo[] servers)
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x7577C0", Offset = "0x756BC0", VA = "0x107577C0", Slot = "8")]
	public IRegionInfo Duplicate()
	{
		return null;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x7579B0", Offset = "0x756DB0", VA = "0x107579B0", Slot = "9")]
	public bool Validate()
	{
		return default(bool);
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x5CA840", Offset = "0x5C9C40", VA = "0x105CA840", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x757940", Offset = "0x756D40", VA = "0x10757940", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly string <Name>k__BackingField;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly string <PingServer>k__BackingField;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly ServerInfo[] <Servers>k__BackingField;

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly StringNames <TranslateName>k__BackingField;

	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E30 RID: 3632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x370AB0", Offset = "0x36FEB0", VA = "0x10370AB0")]
		internal bool <Validate>b__14_0(ServerInfo s)
		{
			return default(bool);
		}

		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StaticHttpRegionInfo.<>c <>9;

		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ServerInfo, bool> <>9__14_0;
	}
}
