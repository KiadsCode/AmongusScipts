using System;
using Il2CppDummyDll;

namespace Microsoft.Xbox
{
	// Token: 0x02000670 RID: 1648
	[Token(Token = "0x2000670")]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000867")]
		public string ErrorCode
		{
			[Token(Token = "0x6002817")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002818")]
			[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000868")]
		public string ErrorMessage
		{
			[Token(Token = "0x6002819")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600281A")]
			[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x47BF00", Offset = "0x47B300", VA = "0x1047BF00")]
		public ErrorEventArgs(string errorCode, string errorMessage)
		{
		}

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <ErrorCode>k__BackingField;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <ErrorMessage>k__BackingField;
	}
}
