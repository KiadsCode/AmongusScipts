using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
public class ServerManager : DestroyableSingleton<ServerManager>
{
	// Token: 0x06000DEE RID: 3566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x5911E0", Offset = "0x5905E0", VA = "0x105911E0")]
	internal void AddOrUpdateRegion(IRegionInfo newRegion)
	{
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000212")]
	public IRegionInfo CurrentRegion
	{
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000213")]
	public ServerInfo CurrentUdpServer
	{
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00005598 File Offset: 0x00003798
	[Token(Token = "0x17000214")]
	public bool IsHttp
	{
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x592880", Offset = "0x591C80", VA = "0x10592880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000215")]
	public IRegionInfo[] AvailableRegions
	{
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000216")]
	private ServerInfo[] AvailableServers
	{
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x592830", Offset = "0x591C30", VA = "0x10592830")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000217")]
	public string UdpNetAddress
	{
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x58BDD0", Offset = "0x58B1D0", VA = "0x1058BDD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x000055B0 File Offset: 0x000037B0
	[Token(Token = "0x17000218")]
	public ushort UdpNetPort
	{
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x592900", Offset = "0x591D00", VA = "0x10592900")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000055C8 File Offset: 0x000037C8
	[Token(Token = "0x17000219")]
	public bool UdpUseDtls
	{
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x592920", Offset = "0x591D20", VA = "0x10592920")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x5914C0", Offset = "0x5908C0", VA = "0x105914C0", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x591610", Offset = "0x590A10", VA = "0x10591610")]
	private void HandleUpnp()
	{
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x591BA0", Offset = "0x590FA0", VA = "0x10591BA0")]
	[Attribute(Name = "ContextMenu", RVA = "0xE48A0", Offset = "0xE3CA0")]
	internal void ReselectServer()
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x591B50", Offset = "0x590F50", VA = "0x10591B50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE48D0", Offset = "0xE3CD0")]
	public IEnumerator ReselectRegionFromDefaults()
	{
		return null;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x592550", Offset = "0x591950", VA = "0x10592550")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE49A0", Offset = "0xE3DA0")]
	public IEnumerator WaitForServers()
	{
		return null;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x5921E0", Offset = "0x5915E0", VA = "0x105921E0")]
	internal void SetRegion(IRegionInfo region)
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x592010", Offset = "0x591410", VA = "0x10592010")]
	public void SaveServers()
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x591820", Offset = "0x590C20", VA = "0x10591820")]
	public void LoadServers()
	{
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x000055E0 File Offset: 0x000037E0
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x592210", Offset = "0x591610", VA = "0x10592210")]
	internal bool TrackServerFailure(string networkAddress)
	{
		return default(bool);
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x5927C0", Offset = "0x591BC0", VA = "0x105927C0")]
	public ServerManager()
	{
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x5924E0", Offset = "0x5918E0", VA = "0x105924E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <SaveServers>b__32_0(IRegionInfo r)
	{
		return default(bool);
	}

	// Token: 0x04000E11 RID: 3601
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x0")]
	public static readonly IRegionInfo[] DefaultRegions;

	// Token: 0x04000E12 RID: 3602
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private IRegionInfo <CurrentRegion>k__BackingField;

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private ServerInfo <CurrentUdpServer>k__BackingField;

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private IRegionInfo[] <AvailableRegions>k__BackingField;

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x1C")]
	private string serverInfoFileJson;

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x20")]
	private UpdateState state;

	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	[Skip]
	[Attribute(Name = "JsonObjectAttribute", RVA = "0xDD9C0", Offset = "0xDCDC0")]
	private struct JsonServerData
	{
		// Token: 0x06000E06 RID: 3590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x364650", Offset = "0x363A50", VA = "0x10364650")]
		internal void CleanAndMerge(IRegionInfo[] defaultRegions)
		{
		}

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x0")]
		public int CurrentRegionIdx;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x4")]
		public IRegionInfo[] Regions;

		// Token: 0x02000275 RID: 629
		[Token(Token = "0x2000275")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06000E07 RID: 3591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E07")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06000E08 RID: 3592 RVA: 0x00005610 File Offset: 0x00003810
			[Token(Token = "0x6000E08")]
			[Address(RVA = "0x13026B0", Offset = "0x1301AB0", VA = "0x113026B0")]
			internal bool <CleanAndMerge>b__1(IRegionInfo r)
			{
				return default(bool);
			}

			// Token: 0x04000E19 RID: 3609
			[Token(Token = "0x4000E19")]
			[FieldOffset(Offset = "0x8")]
			public IRegionInfo region;
		}

		// Token: 0x02000276 RID: 630
		[Token(Token = "0x2000276")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000E0A RID: 3594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06000E0B RID: 3595 RVA: 0x00005628 File Offset: 0x00003828
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x1302000", Offset = "0x1301400", VA = "0x11302000")]
			internal bool <CleanAndMerge>b__2_0(IRegionInfo r)
			{
				return default(bool);
			}

			// Token: 0x04000E1A RID: 3610
			[Token(Token = "0x4000E1A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ServerManager.JsonServerData.<>c <>9;

			// Token: 0x04000E1B RID: 3611
			[Token(Token = "0x4000E1B")]
			[FieldOffset(Offset = "0x4")]
			public static Func<IRegionInfo, bool> <>9__2_0;
		}
	}

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	private struct PingWrapper
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x2B0980", Offset = "0x2AFD80", VA = "0x102B0980")]
		public PingWrapper(IRegionInfo region, Ping ping)
		{
		}

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x0")]
		public IRegionInfo Region;

		// Token: 0x04000E1D RID: 3613
		[Token(Token = "0x4000E1D")]
		[FieldOffset(Offset = "0x4")]
		public Ping Ping;
	}

	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass1_0
	{
		// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x370FC0", Offset = "0x3703C0", VA = "0x10370FC0")]
		internal bool <AddOrUpdateRegion>b__0(IRegionInfo r)
		{
			return default(bool);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x371040", Offset = "0x370440", VA = "0x10371040")]
		internal bool <AddOrUpdateRegion>b__1(IRegionInfo r)
		{
			return default(bool);
		}

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x8")]
		public IRegionInfo newRegion;
	}

	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E11 RID: 3601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x370870", Offset = "0x36FC70", VA = "0x10370870")]
		internal bool <ReselectServer>b__28_0(ServerInfo s)
		{
			return default(bool);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x370890", Offset = "0x36FC90", VA = "0x10370890")]
		internal int <ReselectServer>b__28_1(ServerInfo s)
		{
			return 0;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x3708B0", Offset = "0x36FCB0", VA = "0x103708B0")]
		internal int <ReselectServer>b__28_2(ServerInfo s)
		{
			return 0;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x370830", Offset = "0x36FC30", VA = "0x10370830")]
		internal bool <ReselectRegionFromDefaults>b__29_0(ServerManager.PingWrapper p)
		{
			return default(bool);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x3708B0", Offset = "0x36FCB0", VA = "0x103708B0")]
		internal int <TrackServerFailure>b__34_1(ServerInfo s)
		{
			return 0;
		}

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ServerManager.<>c <>9;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ServerInfo, bool> <>9__28_0;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ServerInfo, int> <>9__28_1;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0xC")]
		public static Func<ServerInfo, int> <>9__28_2;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ServerManager.PingWrapper, bool> <>9__29_0;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x14")]
		public static Func<ServerInfo, int> <>9__34_1;
	}

	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ReselectRegionFromDefaults>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E17 RID: 3607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ReselectRegionFromDefaults>d__29(int <>1__state)
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x36D720", Offset = "0x36CB20", VA = "0x1036D720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021A")]
		private object Current
		{
			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x36DBA0", Offset = "0x36CFA0", VA = "0x1036DBA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021B")]
		private object Current
		{
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x10")]
		public ServerManager <>4__this;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x14")]
		private ServerManager.PingWrapper[] <pings>5__2;
	}

	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForServers>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForServers>d__30(int <>1__state)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x372970", Offset = "0x371D70", VA = "0x10372970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021C")]
		private object Current
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x3729C0", Offset = "0x371DC0", VA = "0x103729C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021D")]
		private object Current
		{
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x10")]
		public ServerManager <>4__this;
	}

	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x371390", Offset = "0x370790", VA = "0x10371390")]
		internal bool <TrackServerFailure>b__0(ServerInfo s)
		{
			return default(bool);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x3713C0", Offset = "0x3707C0", VA = "0x103713C0")]
		internal bool <TrackServerFailure>b__2(ServerInfo s)
		{
			return default(bool);
		}

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x8")]
		public string networkAddress;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		[FieldOffset(Offset = "0xC")]
		public ServerInfo srv;
	}
}
