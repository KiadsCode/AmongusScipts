using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class Request<T>
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		public Request()
		{
		}

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF020", Offset = "0xDE420")]
		public Request<T>.RequestData Data;

		// Token: 0x0200067E RID: 1662
		[Token(Token = "0x200067E")]
		public class RequestData
		{
			// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002850")]
			public RequestData()
			{
			}

			// Token: 0x04002843 RID: 10307
			[Token(Token = "0x4002843")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF050", Offset = "0xDE450")]
			public T Attributes;

			// Token: 0x04002844 RID: 10308
			[Token(Token = "0x4002844")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "JsonPropertyAttribute", RVA = "0xDF080", Offset = "0xDE480")]
			public string Type;
		}
	}
}
