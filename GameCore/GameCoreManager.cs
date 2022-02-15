using System;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

namespace GameCore
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	public class GameCoreManager : MonoBehaviour
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080E")]
		public static GameCoreManager Instance
		{
			[Token(Token = "0x600263F")]
			[Address(RVA = "0x3AC400", Offset = "0x3AB800", VA = "0x103AC400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002640")]
			[Address(RVA = "0x3AC430", Offset = "0x3AB830", VA = "0x103AC430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080F")]
		public UserManager UserManager
		{
			[Token(Token = "0x6002641")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002642")]
			[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000810")]
		public NetworkManager NetworkManager
		{
			[Token(Token = "0x6002643")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002644")]
			[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000811")]
		public SaveManager SaveManager
		{
			[Token(Token = "0x6002645")]
			[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002646")]
			[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000812")]
		public StoreManager StoreManager
		{
			[Token(Token = "0x6002647")]
			[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002648")]
			[Address(RVA = "0x277A60", Offset = "0x276E60", VA = "0x10277A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002649")]
		[Address(RVA = "0x3AC2B0", Offset = "0x3AB6B0", VA = "0x103AC2B0")]
		private void Awake()
		{
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public GameCoreManager()
		{
		}

		// Token: 0x040025CC RID: 9676
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0xC")]
		public LocalizationProvider LocalizationProvider;

		// Token: 0x040025CD RID: 9677
		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private static GameCoreManager <Instance>k__BackingField;

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private UserManager <UserManager>k__BackingField;

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private NetworkManager <NetworkManager>k__BackingField;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private SaveManager <SaveManager>k__BackingField;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private StoreManager <StoreManager>k__BackingField;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x20")]
		public Action OnSuspend;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x24")]
		public Action<double> OnResume;

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> OnResourceChange;

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		[FieldOffset(Offset = "0x2C")]
		private Thread dispatchJob;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x30")]
		private bool stopExecution;
	}
}
