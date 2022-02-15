using System;
using Hazel;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public static class MessageExtensions
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x772A10", Offset = "0x771E10", VA = "0x10772A10")]
		public static void WriteNetObject(this MessageWriter self, InnerNetObject obj)
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		public static T ReadNetObject<T>(this MessageReader self) where T : InnerNetObject
		{
			return null;
		}
	}
}
