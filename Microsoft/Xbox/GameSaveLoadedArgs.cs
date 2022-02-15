using System;
using Il2CppDummyDll;

namespace Microsoft.Xbox
{
	// Token: 0x02000671 RID: 1649
	[Token(Token = "0x2000671")]
	public class GameSaveLoadedArgs : EventArgs
	{
		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000869")]
		public byte[] Data
		{
			[Token(Token = "0x600281C")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600281D")]
			[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x3B20B0", Offset = "0x3B14B0", VA = "0x103B20B0")]
		public GameSaveLoadedArgs(byte[] data)
		{
		}

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private byte[] <Data>k__BackingField;
	}
}
