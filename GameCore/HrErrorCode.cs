using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameCore
{
	// Token: 0x020005F4 RID: 1524
	[Token(Token = "0x20005F4")]
	public static class HrErrorCode
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264E")]
		[Address(RVA = "0x3EA650", Offset = "0x3E9A50", VA = "0x103EA650")]
		public static string GetHrErrorCode(int hresult)
		{
			return null;
		}

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x3D8D3D85")]
		private static Dictionary<uint, string> ErrorMessages;

		// Token: 0x020005F5 RID: 1525
		[Token(Token = "0x20005F5")]
		public enum ErrorCode : uint
		{
			// Token: 0x040025DB RID: 9691
			[Token(Token = "0x40025DB")]
			E_GAMERUNTIME_NOT_INITIALIZED = 2300838144U,
			// Token: 0x040025DC RID: 9692
			[Token(Token = "0x40025DC")]
			E_GAMERUNTIME_DLL_NOT_FOUND,
			// Token: 0x040025DD RID: 9693
			[Token(Token = "0x40025DD")]
			E_GAMERUNTIME_VERSION_MISMATCH,
			// Token: 0x040025DE RID: 9694
			[Token(Token = "0x40025DE")]
			E_GAMEUSER_MAX_USERS_ADDED = 2300858624U,
			// Token: 0x040025DF RID: 9695
			[Token(Token = "0x40025DF")]
			E_GAMEUSER_SIGNED_OUT,
			// Token: 0x040025E0 RID: 9696
			[Token(Token = "0x40025E0")]
			E_GAMEUSER_RESOLVE_USER_ISSUE_REQUIRED,
			// Token: 0x040025E1 RID: 9697
			[Token(Token = "0x40025E1")]
			E_GAMEUSER_DEFERRAL_NOT_AVAILABLE,
			// Token: 0x040025E2 RID: 9698
			[Token(Token = "0x40025E2")]
			E_GAMEUSER_USER_NOT_FOUND,
			// Token: 0x040025E3 RID: 9699
			[Token(Token = "0x40025E3")]
			E_GAMEUSER_NO_TOKEN_REQUIRED,
			// Token: 0x040025E4 RID: 9700
			[Token(Token = "0x40025E4")]
			E_GAMEUSER_NO_DEFAULT_USER,
			// Token: 0x040025E5 RID: 9701
			[Token(Token = "0x40025E5")]
			E_GAMEUSER_FAILED_TO_RESOLVE,
			// Token: 0x040025E6 RID: 9702
			[Token(Token = "0x40025E6")]
			E_GAMEUSER_NO_TITLE_ID,
			// Token: 0x040025E7 RID: 9703
			[Token(Token = "0x40025E7")]
			E_GAMEUSER_UNKNOWN_GAME_IDENTITY,
			// Token: 0x040025E8 RID: 9704
			[Token(Token = "0x40025E8")]
			E_GAMEUSER_NO_PACKAGE_IDENTITY = 2300858640U,
			// Token: 0x040025E9 RID: 9705
			[Token(Token = "0x40025E9")]
			E_GAMEUSER_FAILED_TO_GET_TOKEN,
			// Token: 0x040025EA RID: 9706
			[Token(Token = "0x40025EA")]
			E_GAMEPACKAGE_APP_NOT_PACKAGED = 2300858880U,
			// Token: 0x040025EB RID: 9707
			[Token(Token = "0x40025EB")]
			E_GAMEPACKAGE_NO_INSTALLED_LANGUAGES,
			// Token: 0x040025EC RID: 9708
			[Token(Token = "0x40025EC")]
			E_GAMESTORE_LICENSE_ACTION_NOT_APPLICABLE_TO_PRODUCT = 2300859136U,
			// Token: 0x040025ED RID: 9709
			[Token(Token = "0x40025ED")]
			E_GAMESTORE_NETWORK_ERROR,
			// Token: 0x040025EE RID: 9710
			[Token(Token = "0x40025EE")]
			E_GAMESTORE_SERVER_ERROR,
			// Token: 0x040025EF RID: 9711
			[Token(Token = "0x40025EF")]
			E_GAMESTORE_INSUFFICIENT_QUANTITY,
			// Token: 0x040025F0 RID: 9712
			[Token(Token = "0x40025F0")]
			E_GAMESTORE_ALREADY_PURCHASED,
			// Token: 0x040025F1 RID: 9713
			[Token(Token = "0x40025F1")]
			E_GAMESTREAMING_NOT_INITIALIZED = 2300859392U,
			// Token: 0x040025F2 RID: 9714
			[Token(Token = "0x40025F2")]
			E_GAMESTREAMING_CLIENT_NOT_CONNECTED,
			// Token: 0x040025F3 RID: 9715
			[Token(Token = "0x40025F3")]
			E_GAMESTREAMING_NO_DATA,
			// Token: 0x040025F4 RID: 9716
			[Token(Token = "0x40025F4")]
			E_GAMESTREAMING_NO_DATACENTER,
			// Token: 0x040025F5 RID: 9717
			[Token(Token = "0x40025F5")]
			E_GAMESTREAMING_NOT_STREAMING_CONTROLLER,
			// Token: 0x040025F6 RID: 9718
			[Token(Token = "0x40025F6")]
			E_UNKNOWN_ERROR = 2151637255U
		}
	}
}
