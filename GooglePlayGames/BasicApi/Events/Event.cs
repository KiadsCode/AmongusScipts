using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Events
{
	// Token: 0x0200066B RID: 1643
	[Token(Token = "0x200066B")]
	internal class Event : IEvent
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x47BF60", Offset = "0x47B360", VA = "0x1047BF60")]
		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085B")]
		public string Id
		{
			[Token(Token = "0x6002807")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085C")]
		public string Name
		{
			[Token(Token = "0x6002808")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085D")]
		public string Description
		{
			[Token(Token = "0x6002809")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085E")]
		public string ImageUrl
		{
			[Token(Token = "0x600280A")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x1700085F")]
		public ulong CurrentCount
		{
			[Token(Token = "0x600280B")]
			[Address(RVA = "0x2D5F90", Offset = "0x2D5390", VA = "0x102D5F90", Slot = "8")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x17000860")]
		public EventVisibility Visibility
		{
			[Token(Token = "0x600280C")]
			[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00", Slot = "9")]
			get
			{
				return (EventVisibility)0;
			}
		}

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x8")]
		private string mId;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0xC")]
		private string mName;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x10")]
		private string mDescription;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0x14")]
		private string mImageUrl;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x18")]
		private ulong mCurrentCount;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x20")]
		private EventVisibility mVisibility;
	}
}
