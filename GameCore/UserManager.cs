using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameCore
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	public class UserManager
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000816")]
		public UserManager.UserData PrimaryUser
		{
			[Token(Token = "0x600265D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600265E")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
			private set
			{
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x7A86F0", Offset = "0x7A7AF0", VA = "0x107A86F0")]
		public UserManager()
		{
		}

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		private const int E_GAMEUSER_NO_DEFAULT_USER = -1994108666;

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		public const bool isSingleUserGame = true;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x8")]
		public List<UserManager.UserData> UserDataList;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0xC")]
		private UserManager.UserData primaryUser;

		// Token: 0x020005FD RID: 1533
		[Token(Token = "0x20005FD")]
		public enum UserOpResult
		{
			// Token: 0x04002605 RID: 9733
			[Token(Token = "0x4002605")]
			Success,
			// Token: 0x04002606 RID: 9734
			[Token(Token = "0x4002606")]
			NoDefaultUser,
			// Token: 0x04002607 RID: 9735
			[Token(Token = "0x4002607")]
			ResolveUserIssueRequired,
			// Token: 0x04002608 RID: 9736
			[Token(Token = "0x4002608")]
			UnclearedVetoes,
			// Token: 0x04002609 RID: 9737
			[Token(Token = "0x4002609")]
			UnknownError
		}

		// Token: 0x020005FE RID: 1534
		[Token(Token = "0x20005FE")]
		private enum State
		{
			// Token: 0x0400260B RID: 9739
			[Token(Token = "0x400260B")]
			Initializing,
			// Token: 0x0400260C RID: 9740
			[Token(Token = "0x400260C")]
			GetContext,
			// Token: 0x0400260D RID: 9741
			[Token(Token = "0x400260D")]
			WaitForAddingUser,
			// Token: 0x0400260E RID: 9742
			[Token(Token = "0x400260E")]
			GetBasicInfo,
			// Token: 0x0400260F RID: 9743
			[Token(Token = "0x400260F")]
			InitializeNetwork,
			// Token: 0x04002610 RID: 9744
			[Token(Token = "0x4002610")]
			GrabAchievements,
			// Token: 0x04002611 RID: 9745
			[Token(Token = "0x4002611")]
			UserDisplayImage,
			// Token: 0x04002612 RID: 9746
			[Token(Token = "0x4002612")]
			ReturnMuteList,
			// Token: 0x04002613 RID: 9747
			[Token(Token = "0x4002613")]
			ReturnAvoidList,
			// Token: 0x04002614 RID: 9748
			[Token(Token = "0x4002614")]
			UserPermissionsCheck,
			// Token: 0x04002615 RID: 9749
			[Token(Token = "0x4002615")]
			WaitForNextTask,
			// Token: 0x04002616 RID: 9750
			[Token(Token = "0x4002616")]
			Error,
			// Token: 0x04002617 RID: 9751
			[Token(Token = "0x4002617")]
			Idle,
			// Token: 0x04002618 RID: 9752
			[Token(Token = "0x4002618")]
			End
		}

		// Token: 0x020005FF RID: 1535
		[Token(Token = "0x20005FF")]
		public class UserData
		{
			// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public UserData()
			{
			}
		}

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x06002662 RID: 9826
		[Token(Token = "0x2000600")]
		public delegate void AddUserCompletedDelegate(UserManager.UserOpResult result);
	}
}
