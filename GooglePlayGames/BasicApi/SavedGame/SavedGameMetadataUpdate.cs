using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.SavedGame
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public struct SavedGameMetadataUpdate
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x589FD0", Offset = "0x5893D0", VA = "0x10589FD0")]
		private SavedGameMetadataUpdate(SavedGameMetadataUpdate.Builder builder)
		{
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x17000847")]
		public bool IsDescriptionUpdated
		{
			[Token(Token = "0x60027DE")]
			[Address(RVA = "0x4069E0", Offset = "0x405DE0", VA = "0x104069E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000848")]
		public string UpdatedDescription
		{
			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x273A70", Offset = "0x272E70", VA = "0x10273A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x17000849")]
		public bool IsCoverImageUpdated
		{
			[Token(Token = "0x60027E0")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084A")]
		public byte[] UpdatedPngCoverImage
		{
			[Token(Token = "0x60027E1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x1700084B")]
		public bool IsPlayedTimeUpdated
		{
			[Token(Token = "0x60027E2")]
			[Address(RVA = "0x58A000", Offset = "0x589400", VA = "0x1058A000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x1700084C")]
		public TimeSpan? UpdatedPlayedTime
		{
			[Token(Token = "0x60027E3")]
			[Address(RVA = "0x44AFB0", Offset = "0x44A3B0", VA = "0x1044AFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool mDescriptionUpdated;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x4")]
		private readonly string mNewDescription;

		// Token: 0x040027F2 RID: 10226
		[Token(Token = "0x40027F2")]
		[FieldOffset(Offset = "0x8")]
		private readonly bool mCoverImageUpdated;

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0xC")]
		private readonly byte[] mNewPngCoverImage;

		// Token: 0x040027F4 RID: 10228
		[Token(Token = "0x40027F4")]
		[FieldOffset(Offset = "0x10")]
		private readonly TimeSpan? mNewPlayedTime;

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		public struct Builder
		{
			// Token: 0x060027E4 RID: 10212 RVA: 0x0000BC40 File Offset: 0x00009E40
			[Token(Token = "0x60027E4")]
			[Address(RVA = "0x363A30", Offset = "0x362E30", VA = "0x10363A30")]
			public SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060027E5 RID: 10213 RVA: 0x0000BC58 File Offset: 0x00009E58
			[Token(Token = "0x60027E5")]
			[Address(RVA = "0x363B50", Offset = "0x362F50", VA = "0x10363B50")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060027E6 RID: 10214 RVA: 0x0000BC70 File Offset: 0x00009E70
			[Token(Token = "0x60027E6")]
			[Address(RVA = "0x363A80", Offset = "0x362E80", VA = "0x10363A80")]
			public SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(SavedGameMetadataUpdate.Builder);
			}

			// Token: 0x060027E7 RID: 10215 RVA: 0x0000BC88 File Offset: 0x00009E88
			[Token(Token = "0x60027E7")]
			[Address(RVA = "0x3639F0", Offset = "0x362DF0", VA = "0x103639F0")]
			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}

			// Token: 0x040027F5 RID: 10229
			[Token(Token = "0x40027F5")]
			[FieldOffset(Offset = "0x0")]
			internal bool mDescriptionUpdated;

			// Token: 0x040027F6 RID: 10230
			[Token(Token = "0x40027F6")]
			[FieldOffset(Offset = "0x4")]
			internal string mNewDescription;

			// Token: 0x040027F7 RID: 10231
			[Token(Token = "0x40027F7")]
			[FieldOffset(Offset = "0x8")]
			internal bool mCoverImageUpdated;

			// Token: 0x040027F8 RID: 10232
			[Token(Token = "0x40027F8")]
			[FieldOffset(Offset = "0xC")]
			internal byte[] mNewPngCoverImage;

			// Token: 0x040027F9 RID: 10233
			[Token(Token = "0x40027F9")]
			[FieldOffset(Offset = "0x10")]
			internal TimeSpan? mNewPlayedTime;
		}
	}
}
