using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using InnerNet;
using UnityEngine.Networking;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x20002C5")]
public class HttpMatchmakerManager : DestroyableSingleton<HttpMatchmakerManager>
{
	// Token: 0x17000261 RID: 609
	// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000261")]
	public string Base64Token
	{
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000262")]
	public MatchmakerToken Token
	{
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x3EAC60", Offset = "0x3EA060", VA = "0x103EAC60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6070", Offset = "0xE5470")]
	public IEnumerator CoRefreshToken()
	{
		return null;
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x3EAD70", Offset = "0x3EA170", VA = "0x103EAD70")]
	private bool TryReadCachedToken()
	{
		return default(bool);
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x3EAC10", Offset = "0x3EA010", VA = "0x103EAC10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6110", Offset = "0xE5510")]
	private IEnumerator CoRefreshTokenInternal()
	{
		return null;
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x3EABB0", Offset = "0x3E9FB0", VA = "0x103EABB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6160", Offset = "0xE5560")]
	public IEnumerator CoFindGameCode(int gameId, Action<HttpMatchmakerManager.HostServer> onGameHost)
	{
		return null;
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x3EAD10", Offset = "0x3EA110", VA = "0x103EAD10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE61B0", Offset = "0xE55B0")]
	public IEnumerator FindHostServer(Action<HttpMatchmakerManager.HostServer> onGameHost)
	{
		return null;
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x3EACB0", Offset = "0x3EA0B0", VA = "0x103EACB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6200", Offset = "0xE5600")]
	public IEnumerator CoRequestGameList(GameOptionsData gameSearchOptions, Action<InnerNetClient.TotalGameData, List<GameListing>> onGameList)
	{
		return null;
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x3EAE70", Offset = "0x3EA270", VA = "0x103EAE70")]
	public HttpMatchmakerManager()
	{
	}

	// Token: 0x04000F87 RID: 3975
	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private string <Base64Token>k__BackingField;

	// Token: 0x04000F88 RID: 3976
	[Token(Token = "0x4000F88")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private MatchmakerToken <Token>k__BackingField;

	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	public class CertAccept : CertificateHandler
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "5")]
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return default(bool);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x5A63A0", Offset = "0x5A57A0", VA = "0x105A63A0")]
		public CertAccept()
		{
		}
	}

	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	public class MatchmakerResponse
	{
		// Token: 0x06000FBE RID: 4030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public MatchmakerResponse()
		{
		}

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x8")]
		public HttpMatchmakerManager.MatchmakerError[] Errors;
	}

	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	public class MatchmakerError
	{
		// Token: 0x06000FBF RID: 4031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public MatchmakerError()
		{
		}

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x8")]
		public DisconnectReasons Reason;
	}

	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class UserTokenRequestData
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000263")]
		public string Puid
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000264")]
		public string Username
		{
			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FC3")]
			[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00005B68 File Offset: 0x00003D68
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000265")]
		public int ClientVersion
		{
			[Token(Token = "0x6000FC4")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000FC5")]
			[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000266")]
		public SupportedLangs Language
		{
			[Token(Token = "0x6000FC6")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return SupportedLangs.English;
			}
			[Token(Token = "0x6000FC7")]
			[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public UserTokenRequestData()
		{
		}

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <Puid>k__BackingField;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <Username>k__BackingField;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private int <ClientVersion>k__BackingField;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private SupportedLangs <Language>k__BackingField;
	}

	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class HostServer
	{
		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x5A6650", Offset = "0x5A5A50", VA = "0x105A6650")]
		public HostServer(long ip, ushort port)
		{
		}

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Ip;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0xC")]
		public readonly ushort Port;
	}

	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRefreshToken>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRefreshToken>d__8(int <>1__state)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x5AC4B0", Offset = "0x5AB8B0", VA = "0x105AC4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		private object Current
		{
			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x5AC510", Offset = "0x5AB910", VA = "0x105AC510", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000268")]
		private object Current
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x10")]
		public HttpMatchmakerManager <>4__this;
	}

	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRefreshTokenInternal>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRefreshTokenInternal>d__10(int <>1__state)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x5ABDF0", Offset = "0x5AB1F0", VA = "0x105ABDF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000269")]
		private object Current
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x5AC480", Offset = "0x5AB880", VA = "0x105AC480", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		private object Current
		{
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x10")]
		public HttpMatchmakerManager <>4__this;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x14")]
		private UnityWebRequest <request>5__2;
	}

	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoFindGameCode>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoFindGameCode>d__11(int <>1__state)
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x5AA440", Offset = "0x5A9840", VA = "0x105AA440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026B")]
		private object Current
		{
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x5AA910", Offset = "0x5A9D10", VA = "0x105AA910", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026C")]
		private object Current
		{
			[Token(Token = "0x6000FDB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x10")]
		public int gameId;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x14")]
		public HttpMatchmakerManager <>4__this;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x18")]
		public Action<HttpMatchmakerManager.HostServer> onGameHost;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x1C")]
		private string <uri>5__2;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x20")]
		private UnityWebRequest <request>5__3;
	}

	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <FindHostServer>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FDC RID: 4060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <FindHostServer>d__12(int <>1__state)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x5B0550", Offset = "0x5AF950", VA = "0x105B0550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026D")]
		private object Current
		{
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x5B0A10", Offset = "0x5AFE10", VA = "0x105B0A10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026E")]
		private object Current
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x10")]
		public HttpMatchmakerManager <>4__this;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x14")]
		public Action<HttpMatchmakerManager.HostServer> onGameHost;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x18")]
		private string <uri>5__2;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x1C")]
		private UnityWebRequest <request>5__3;
	}

	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRequestGameList>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRequestGameList>d__13(int <>1__state)
		{
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x5AC540", Offset = "0x5AB940", VA = "0x105AC540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026F")]
		private object Current
		{
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x5ACB60", Offset = "0x5ABF60", VA = "0x105ACB60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000270")]
		private object Current
		{
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x10")]
		public GameOptionsData gameSearchOptions;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x14")]
		public HttpMatchmakerManager <>4__this;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x18")]
		public Action<InnerNetClient.TotalGameData, List<GameListing>> onGameList;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x1C")]
		private string <uri>5__2;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x20")]
		private UnityWebRequest <request>5__3;
	}
}
