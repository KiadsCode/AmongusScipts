using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	public class SignInHelper
	{
		// Token: 0x060027AB RID: 10155 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x499EB0", Offset = "0x4992B0", VA = "0x10499EB0")]
		public static SignInStatus ToSignInStatus(int code)
		{
			return SignInStatus.Success;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x499DA0", Offset = "0x4991A0", VA = "0x10499DA0")]
		public static void SetPromptUiSignIn(bool value)
		{
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x499E40", Offset = "0x499240", VA = "0x10499E40")]
		public static bool ShouldPromptUiSignIn()
		{
			return default(bool);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public SignInHelper()
		{
		}

		// Token: 0x040027BD RID: 10173
		[Token(Token = "0x40027BD")]
		[FieldOffset(Offset = "0x0")]
		private static int True;

		// Token: 0x040027BE RID: 10174
		[Token(Token = "0x40027BE")]
		[FieldOffset(Offset = "0x4")]
		private static int False;

		// Token: 0x040027BF RID: 10175
		[Token(Token = "0x40027BF")]
		private const string PromptSignInKey = "prompt_sign_in";
	}
}
