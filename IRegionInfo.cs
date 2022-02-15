using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
[Skip]
public interface IRegionInfo
{
	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000E32 RID: 3634
	[Token(Token = "0x17000222")]
	string Name { [Token(Token = "0x6000E32")] get; }

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000E33 RID: 3635
	[Token(Token = "0x17000223")]
	string PingServer { [Token(Token = "0x6000E33")] get; }

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000E34 RID: 3636
	[Token(Token = "0x17000224")]
	ServerInfo[] Servers { [Token(Token = "0x6000E34")] get; }

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000E35 RID: 3637
	[Token(Token = "0x17000225")]
	StringNames TranslateName { [Token(Token = "0x6000E35")] get; }

	// Token: 0x06000E36 RID: 3638
	[Token(Token = "0x6000E36")]
	IRegionInfo Duplicate();

	// Token: 0x06000E37 RID: 3639
	[Token(Token = "0x6000E37")]
	bool Validate();
}
