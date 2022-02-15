using System;
using Il2CppDummyDll;

namespace GameCore
{
	// Token: 0x020005F8 RID: 1528
	[Token(Token = "0x20005F8")]
	public class NetworkManager
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x0000B580 File Offset: 0x00009780
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000814")]
		public bool IsInviteHandled
		{
			[Token(Token = "0x6002652")]
			[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002653")]
			[Address(RVA = "0x2D4E60", Offset = "0x2D4260", VA = "0x102D4E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000815")]
		public string ConnectionString
		{
			[Token(Token = "0x6002654")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002655")]
			[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x777C50", Offset = "0x777050", VA = "0x10777C50")]
		public NetworkManager()
		{
		}

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x8")]
		public NetworkManager.OnInvitedCallback OnInvited;

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <IsInviteHandled>k__BackingField;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <ConnectionString>k__BackingField;

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x06002658 RID: 9816
		[Token(Token = "0x20005F9")]
		public delegate void OnInvitedCallback(string connectionString);
	}
}
