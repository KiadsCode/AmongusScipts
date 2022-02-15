using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	public class InnerslothReceipt
	{
		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public InnerslothReceipt()
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		public InnerslothReceipt(string[] items)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x3F95C0", Offset = "0x3F89C0", VA = "0x103F95C0")]
		public InnerslothReceipt(List<string> items)
		{
		}

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF2B0", Offset = "0xDE6B0")]
		public string[] Items;
	}
}
