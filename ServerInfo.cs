using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using Newtonsoft.Json;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
[Skip]
public class ServerInfo
{
	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700022A")]
	[JsonIgnore]
	public string HttpUrl
	{
		[Token(Token = "0x6000E44")]
		[Address(RVA = "0x5910C0", Offset = "0x5904C0", VA = "0x105910C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x591060", Offset = "0x590460", VA = "0x10591060")]
	public ServerInfo(string name, string ip, ushort port, bool useDtls = true)
	{
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x590EA0", Offset = "0x5902A0", VA = "0x10590EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00005838 File Offset: 0x00003A38
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x590E70", Offset = "0x590270", VA = "0x10590E70", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x590DE0", Offset = "0x5901E0", VA = "0x10590DE0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0x8")]
	public readonly string Name;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0xC")]
	public readonly string Ip;

	// Token: 0x04000E3C RID: 3644
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x10")]
	public readonly ushort Port;

	// Token: 0x04000E3D RID: 3645
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x12")]
	public readonly bool UseDtls;

	// Token: 0x04000E3E RID: 3646
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x14")]
	public int Players;

	// Token: 0x04000E3F RID: 3647
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x18")]
	public int ConnectionFailures;
}
