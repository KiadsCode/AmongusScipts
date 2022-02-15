using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Epic.OnlineServices.KWS;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class AccountManager : DestroyableSingleton<AccountManager>
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000003")]
	public bool AccountTabActive
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x53D9D0", Offset = "0x53CDD0", VA = "0x1053D9D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x53D6D0", Offset = "0x53CAD0", VA = "0x1053D6D0")]
	public void UpdateKidAccountDisplay()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x278730", Offset = "0x277B30", VA = "0x10278730")]
	public void SetChatModeButtonForUpdates(IChatModeDisplay modeCycle)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x53D5E0", Offset = "0x53C9E0", VA = "0x1053D5E0")]
	public void UpdateAccountInfoDisplays()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x53D050", Offset = "0x53C450", VA = "0x1053D050")]
	public void ShowGuardianEmailSentConfirm()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x53D080", Offset = "0x53C480", VA = "0x1053D080")]
	public void ShowPermissionsRequestForm()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x53CB50", Offset = "0x53BF50", VA = "0x1053CB50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1A30", Offset = "0xE0E30")]
	public IEnumerator EditGuardianEmail()
	{
		return null;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x53D610", Offset = "0x53CA10", VA = "0x1053D610")]
	public void UpdateGuardianEmailDisplay()
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x53D000", Offset = "0x53C400", VA = "0x1053D000")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1A80", Offset = "0xE0E80")]
	public IEnumerator ShowAgeGate()
	{
		return null;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x53CAC0", Offset = "0x53BEC0", VA = "0x1053CAC0")]
	public void CheckAndRegenerateName()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x53C990", Offset = "0x53BD90", VA = "0x1053C990")]
	public bool CanMinorSetCustomDisplayName()
	{
		return default(bool);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x53CC60", Offset = "0x53C060", VA = "0x1053CC60")]
	public bool HasMinorsGuardianEverUpdatedAnything()
	{
		return default(bool);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x53C880", Offset = "0x53BC80", VA = "0x1053C880")]
	public void AskToUnlinkAccount()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x53C820", Offset = "0x53BC20", VA = "0x1053C820")]
	public void AskToLinkExistingAccount()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x53CC80", Offset = "0x53C080", VA = "0x1053CC80")]
	public void LinkExistingAccountRequestPin()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x53CC40", Offset = "0x53C040", VA = "0x1053CC40")]
	public bool HasGuardianRejectedEverything()
	{
		return default(bool);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x53CE70", Offset = "0x53C270", VA = "0x1053CE70")]
	public void RandomizeName()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x53CBA0", Offset = "0x53BFA0", VA = "0x1053CBA0")]
	public string GetRandomName()
	{
		return null;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x53D900", Offset = "0x53CD00", VA = "0x1053D900")]
	private bool ValidateRandomName()
	{
		return default(bool);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x53C8E0", Offset = "0x53BCE0", VA = "0x1053C8E0", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x53CCF0", Offset = "0x53C0F0", VA = "0x1053CCF0", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x53CDA0", Offset = "0x53C1A0", VA = "0x1053CDA0")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x53D350", Offset = "0x53C750", VA = "0x1053D350")]
	public void SignInSuccess(Action callback)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x53D0B0", Offset = "0x53C4B0", VA = "0x1053D0B0")]
	public void SignInFail(EOSManager.EOS_ERRORS error, Action callback)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x53CF70", Offset = "0x53C370", VA = "0x1053CF70")]
	public void SetDLLErrorMode()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x53D850", Offset = "0x53CC50", VA = "0x1053D850")]
	public void UpdateVisuals()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x53D820", Offset = "0x53CC20", VA = "0x1053D820")]
	public void UpdatePlayerCustomizationVisuals()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x53C9F0", Offset = "0x53BDF0", VA = "0x1053C9F0")]
	public bool CanPlayOnline()
	{
		return default(bool);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x53D980", Offset = "0x53CD80", VA = "0x1053D980")]
	public AccountManager()
	{
	}

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private AccountTab accountTab;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private PermissionsRequest enterGuardianEmailWindow;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UpdateGuardianEmail updateGuardianEmailWindow;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private InfoTextBox guardianEmailConfirmWindow;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private InfoTextBox genericInfoDisplayBox;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private AgeGateScreen enterDateOfBirthScreen;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject waitingText;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject postLoadWaiting;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject privacyPolicyBg;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x34")]
	public SignInGuestOfflineChoice signInGuestOffline;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x38")]
	public LinkAccountChoice linkAccountChoice;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x3C")]
	public PrivacyPolicyScreen PrivacyPolicy;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x40")]
	private IChatModeDisplay chatModeMenuScreen;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x44")]
	public KWSPermissionStatus freeChatAllowed;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x48")]
	public KWSPermissionStatus customDisplayName;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x4C")]
	public Action OnLoggedInStatusChange;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x50")]
	private EOSManager.AccountLoginStatus prevLoggedInStatus;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <EditGuardianEmail>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <EditGuardianEmail>d__24(int <>1__state)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3C7170", Offset = "0x3C6570", VA = "0x103C7170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		private object Current
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3C71E0", Offset = "0x3C65E0", VA = "0x103C71E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		private object Current
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public AccountManager <>4__this;
	}

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowAgeGate>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowAgeGate>d__26(int <>1__state)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3C9AF0", Offset = "0x3C8EF0", VA = "0x103C9AF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		private object Current
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3C9B50", Offset = "0x3C8F50", VA = "0x103C9B50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		private object Current
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public AccountManager <>4__this;
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3CA5E0", Offset = "0x3C99E0", VA = "0x103CA5E0")]
		internal void <SignInSuccess>b__0()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x8")]
		public Action callback;
	}

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass41_0
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass41_0()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x3CA5E0", Offset = "0x3C99E0", VA = "0x103CA5E0")]
		internal void <SignInFail>b__0()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		public Action callback;
	}
}
