using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Newtonsoft.Json;

// Token: 0x02000267 RID: 615
[Token(Token = "0x2000267")]
[Skip]
public class DnsRegionInfo : IRegionInfo
{
	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020B")]
	public string Name
	{
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020C")]
	[JsonIgnore]
	public string PingServer
	{
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x5CAC00", Offset = "0x5CA000", VA = "0x105CAC00", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700020D")]
	[JsonIgnore]
	public ServerInfo[] Servers
	{
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x5CAC80", Offset = "0x5CA080", VA = "0x105CAC80", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00005430 File Offset: 0x00003630
	[Token(Token = "0x1700020E")]
	public StringNames TranslateName
	{
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return StringNames.ExitButton;
		}
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x5CAB70", Offset = "0x5C9F70", VA = "0x105CAB70")]
	public DnsRegionInfo(string fqdn, string name, StringNames translateName, string defaultIp, ushort port, bool useDtls = true)
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x5CA870", Offset = "0x5C9C70", VA = "0x105CA870")]
	private void PopulateServers()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x5CABC0", Offset = "0x5C9FC0", VA = "0x105CABC0")]
	private DnsRegionInfo(string fqdn, string name, StringNames translateName, ServerInfo[] servers)
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00005448 File Offset: 0x00003648
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x5CAB50", Offset = "0x5C9F50", VA = "0x105CAB50", Slot = "9")]
	public bool Validate()
	{
		return default(bool);
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x5CA6F0", Offset = "0x5C9AF0", VA = "0x105CA6F0", Slot = "8")]
	public IRegionInfo Duplicate()
	{
		return null;
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x5CA840", Offset = "0x5C9C40", VA = "0x105CA840", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x5CA780", Offset = "0x5C9B80", VA = "0x105CA780", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly string <Name>k__BackingField;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private readonly StringNames <TranslateName>k__BackingField;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x10")]
	public readonly string Fqdn;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x14")]
	public readonly string DefaultIp;

	// Token: 0x04000DBC RID: 3516
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x18")]
	public readonly ushort Port;

	// Token: 0x04000DBD RID: 3517
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x1A")]
	public readonly bool UseDtls;

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x1C")]
	private ServerInfo[] cachedServers;
}
