using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameCore
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public class HandleEvents : MonoBehaviour
	{
		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000813")]
		public static HandleEvents Instance
		{
			[Token(Token = "0x600264B")]
			[Address(RVA = "0x3B9B10", Offset = "0x3B8F10", VA = "0x103B9B10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x3B9B40", Offset = "0x3B8F40", VA = "0x103B9B40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public HandleEvents()
		{
		}

		// Token: 0x040025D7 RID: 9687
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private static HandleEvents <Instance>k__BackingField;

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0xC")]
		public SpriteRenderer FillScreen;
	}
}
