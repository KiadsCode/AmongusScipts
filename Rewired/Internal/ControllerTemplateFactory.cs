using System;
using Il2CppDummyDll;

namespace Rewired.Internal
{
	// Token: 0x02000551 RID: 1361
	[Token(Token = "0x2000551")]
	public static class ControllerTemplateFactory
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000633")]
		public static Type[] templateTypes
		{
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x7FBC30", Offset = "0x7FB030", VA = "0x107FBC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000634")]
		public static Type[] templateInterfaceTypes
		{
			[Token(Token = "0x6001F53")]
			[Address(RVA = "0x7FBBE0", Offset = "0x7FAFE0", VA = "0x107FBBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x7FB300", Offset = "0x7FA700", VA = "0x107FB300")]
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			return null;
		}

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] _defaultTemplateTypes;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Type[] _defaultTemplateInterfaceTypes;
	}
}
