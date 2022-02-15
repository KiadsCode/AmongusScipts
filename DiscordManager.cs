using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Discord;
using Il2CppDummyDll;
using UnityEngine.SceneManagement;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public class DiscordManager : DestroyableSingleton<DiscordManager>
{
	// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000795")]
	[Address(RVA = "0x5C8E60", Offset = "0x5C8260", VA = "0x105C8E60")]
	public void Start()
	{
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000796")]
	[Address(RVA = "0x5C8190", Offset = "0x5C7590", VA = "0x105C8190")]
	private void OnSceneChange(string name)
	{
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000797")]
	[Address(RVA = "0x5C7F00", Offset = "0x5C7300", VA = "0x105C7F00")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x6000798")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70")]
	public bool HasValidPartyID()
	{
		return default(bool);
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x6000799")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70")]
	public bool CanLoginWithDiscord()
	{
		return default(bool);
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079A")]
	[Address(RVA = "0x5C80E0", Offset = "0x5C74E0", VA = "0x105C80E0")]
	public void LoginWithDiscord()
	{
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079B")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void Logout()
	{
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079C")]
	[Address(RVA = "0x5C8AF0", Offset = "0x5C7EF0", VA = "0x105C8AF0")]
	public void SetInMenus()
	{
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079D")]
	[Address(RVA = "0x5C8C40", Offset = "0x5C8040", VA = "0x105C8C40")]
	public void SetPlayingGame()
	{
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079E")]
	[Address(RVA = "0x5C8490", Offset = "0x5C7890", VA = "0x105C8490")]
	public void SetHowToPlay()
	{
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600079F")]
	[Address(RVA = "0x5C85E0", Offset = "0x5C79E0", VA = "0x105C85E0")]
	public void SetInLobbyClient(int numPlayers, int maxPlayers, int gameId)
	{
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x5C7DC0", Offset = "0x5C71C0", VA = "0x105C7DC0")]
	private void ClearPresence()
	{
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A1")]
	[Address(RVA = "0x5C8830", Offset = "0x5C7C30", VA = "0x105C8830")]
	public void SetInLobbyHost(int numPlayers, int maxPlayers, int gameId)
	{
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70")]
	public bool CanShareGameOnDiscord()
	{
		return default(bool);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void ShareGameOnDiscord()
	{
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x5C7FE0", Offset = "0x5C73E0", VA = "0x105C7FE0")]
	private void HandleJoinRequest(string joinSecret)
	{
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x5C7EB0", Offset = "0x5C72B0", VA = "0x105C7EB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDF550", Offset = "0xDE950")]
	private IEnumerator CoJoinGame(string joinSecret)
	{
		return null;
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x5C8360", Offset = "0x5C7760", VA = "0x105C8360")]
	public void RequestRespondYes(long userId)
	{
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x5C8220", Offset = "0x5C7620", VA = "0x105C8220")]
	public void RequestRespondNo(long userId)
	{
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x5C8140", Offset = "0x5C7540", VA = "0x105C8140", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x5C8450", Offset = "0x5C7850", VA = "0x105C8450")]
	private static string ReverseString(string source)
	{
		return null;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x5C90E0", Offset = "0x5C84E0", VA = "0x105C90E0")]
	private static long ToUnixTime(DateTime time)
	{
		return 0L;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x5C92A0", Offset = "0x5C86A0", VA = "0x105C92A0")]
	public DiscordManager()
	{
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x5C9190", Offset = "0x5C8590", VA = "0x105C9190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <Start>b__6_0(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x04000795 RID: 1941
	[Token(Token = "0x4000795")]
	private const long ClientId = 477175586805252107L;

	// Token: 0x04000796 RID: 1942
	[Token(Token = "0x4000796")]
	private const string DeeplinkScheme = "amongus";

	// Token: 0x04000797 RID: 1943
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x0")]
	private static readonly DateTime epoch;

	// Token: 0x04000798 RID: 1944
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x10")]
	public GenericPopup discordPopup;

	// Token: 0x04000799 RID: 1945
	[Token(Token = "0x4000799")]
	[FieldOffset(Offset = "0x14")]
	[NonSerialized]
	private Discord presence;

	// Token: 0x0400079A RID: 1946
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x18")]
	private DateTime? StartTime;

	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <SetInMenus>b__13_0(Result r)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <SetPlayingGame>b__14_0(Result r)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <SetHowToPlay>b__15_0(Result r)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <SetInLobbyClient>b__16_0(Result r)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <ClearPresence>b__17_0(Result r)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <SetInLobbyHost>b__18_0(Result r)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <RequestRespondYes>b__23_0(Result r)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		internal void <RequestRespondNo>b__24_0(Result r)
		{
		}

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DiscordManager.<>c <>9;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x4")]
		public static ActivityManager.UpdateActivityHandler <>9__13_0;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x8")]
		public static ActivityManager.UpdateActivityHandler <>9__14_0;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0xC")]
		public static ActivityManager.UpdateActivityHandler <>9__15_0;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x10")]
		public static ActivityManager.UpdateActivityHandler <>9__16_0;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x14")]
		public static ActivityManager.ClearActivityHandler <>9__17_0;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x18")]
		public static ActivityManager.UpdateActivityHandler <>9__18_0;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x1C")]
		public static ActivityManager.SendRequestReplyHandler <>9__23_0;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x20")]
		public static ActivityManager.SendRequestReplyHandler <>9__24_0;
	}

	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoJoinGame>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoJoinGame>d__22(int <>1__state)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x785140", Offset = "0x784540", VA = "0x10785140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		private object Current
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x785480", Offset = "0x784880", VA = "0x10785480", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		private object Current
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x10")]
		public string joinSecret;
	}
}
