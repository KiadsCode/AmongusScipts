using System;
using Il2CppDummyDll;

namespace Assets.InnerNet
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class Response<T>
	{
		// Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284D")]
		public Response()
		{
		}

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x0")]
		public Response<T>.ResponseData Data;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x0")]
		public ResponseError[] Errors;

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x0")]
		public ResponseError[] Warnings;

		// Token: 0x0200067C RID: 1660
		[Token(Token = "0x200067C")]
		public class ResponseData
		{
			// Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600284E")]
			public ResponseData()
			{
			}

			// Token: 0x04002840 RID: 10304
			[Token(Token = "0x4002840")]
			[FieldOffset(Offset = "0x0")]
			public string Type;

			// Token: 0x04002841 RID: 10305
			[Token(Token = "0x4002841")]
			[FieldOffset(Offset = "0x0")]
			public T Attributes;
		}
	}
}
