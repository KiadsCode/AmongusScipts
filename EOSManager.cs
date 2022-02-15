using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Assets.InnerNet;
using Epic.OnlineServices;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Logging;
using Epic.OnlineServices.Platform;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
[DisallowMultipleComponent]
public class EOSManager : DestroyableSingleton<EOSManager>
{
	// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x46EC40", Offset = "0x46E040", VA = "0x1046EC40")]
	private void AuthWithCorrectPlatformImpl()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x4722D0", Offset = "0x4716D0", VA = "0x104722D0")]
	private void OnSteamEncryptedAppTicketLoginCallback(EncryptedAppTicketResponse_t pCallback, bool bIOFailure)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x471D00", Offset = "0x471100", VA = "0x10471D00")]
	private void LoginWithCorrectPlatformImpl(OnLoginCallback successCallback)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x471BF0", Offset = "0x470FF0", VA = "0x10471BF0")]
	public void LoginSilentlyImpl()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x4725F0", Offset = "0x4719F0", VA = "0x104725F0")]
	private void RetryAuthAndLoginImpl(OnLoginCallback successCallback)
	{
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000009")]
	public string ProductName
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000A")]
	public string ProductVersion
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000B")]
	public string ProductId
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000C")]
	public string SandboxId
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000D")]
	public string DeploymentId
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000E")]
	public string ClientId
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000F")]
	public string ClientSecret
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000010")]
	public PlatformInterface PlatformInterface
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3C16E0", Offset = "0x3C0AE0", VA = "0x103C16E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000011")]
	public string ProductUserId
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x473E40", Offset = "0x473240", VA = "0x10473E40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000012")]
	public string UserToken
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x473EC0", Offset = "0x4732C0", VA = "0x10473EC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x46ED80", Offset = "0x46E180", VA = "0x1046ED80", Slot = "4")]
	public override void Awake()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x472CC0", Offset = "0x4720C0", VA = "0x10472CC0")]
	public void ShowTimeout()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x4706D0", Offset = "0x46FAD0", VA = "0x104706D0")]
	public void HideTimeout()
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x470590", Offset = "0x46F990", VA = "0x10470590")]
	public void PlayOffline()
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x472780", Offset = "0x471B80", VA = "0x10472780")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1BE0", Offset = "0xE0FE0")]
	public IEnumerator RunLogin()
	{
		return null;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x470710", Offset = "0x46FB10", VA = "0x10470710")]
	public void InitializePlatformInterface()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x472140", Offset = "0x471540", VA = "0x10472140")]
	private void OnAuthExpirationCallback(AuthExpirationCallbackInfo data)
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x470160", Offset = "0x46F560", VA = "0x10470160")]
	private void EOSConnectPlatformSilentLoginCallback(LoginCallbackInfo loginCallbackInfo)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x472240", Offset = "0x471640", VA = "0x10472240")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x473620", Offset = "0x472A20", VA = "0x10473620")]
	private void UpdateMappings()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x4705A0", Offset = "0x46F9A0", VA = "0x104705A0")]
	private void HandleEosLogging(LogMessage msg)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x471A80", Offset = "0x470E80", VA = "0x10471A80")]
	public void LoginForKWS(bool allowOffline = true)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x46EEA0", Offset = "0x46E2A0", VA = "0x1046EEA0")]
	public void BeginLoginFlow()
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x471880", Offset = "0x470C80", VA = "0x10471880")]
	private void LogInToDeviceIDOnStartupCallback(LoginCallbackInfo loginCallbackInfo)
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x4725E0", Offset = "0x4719E0", VA = "0x104725E0")]
	public void ReallyBeginFlow()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x4724D0", Offset = "0x4718D0", VA = "0x104724D0")]
	private void PlatformAuthReturn(bool success)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x46F2E0", Offset = "0x46E6E0", VA = "0x1046F2E0")]
	private void ContinueInOfflineMode()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x470BE0", Offset = "0x46FFE0", VA = "0x10470BE0")]
	private void IsAllowedOnline(bool canOnline)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x470190", Offset = "0x46F590", VA = "0x10470190")]
	private GameObject FindPlayOnlineButton()
	{
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x472D00", Offset = "0x472100", VA = "0x10472D00")]
	private void StartAgeGateQuery()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x471070", Offset = "0x470470", VA = "0x10471070")]
	private void KWSQueryAgeGateCallback(QueryAgeGateCallbackInfo ageGateCallbackInfo)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x4728C0", Offset = "0x471CC0", VA = "0x104728C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1C30", Offset = "0xE1030")]
	private IEnumerator ShowAgePrompt()
	{
		return null;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x471BE0", Offset = "0x470FE0", VA = "0x10471BE0")]
	public void LoginFromAccountTab()
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x471CF0", Offset = "0x4710F0", VA = "0x10471CF0")]
	public void LoginToGuestModeFromAccountTab()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x470590", Offset = "0x46F990", VA = "0x10470590")]
	public void LogOutOfGuestModeFromAccountTab()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x470590", Offset = "0x46F990", VA = "0x10470590")]
	public void GoOfflineFromPermissionsWindow()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x470590", Offset = "0x46F990", VA = "0x10470590")]
	public void GoOfflineFromPlatformSignout()
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x471ED0", Offset = "0x4712D0", VA = "0x10471ED0")]
	public void LoginWithCorrectPlatform()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x46EF60", Offset = "0x46E360", VA = "0x1046EF60")]
	private void CheckAgeAndLoginStatus()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x472960", Offset = "0x471D60", VA = "0x10472960")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1C80", Offset = "0xE1080")]
	private IEnumerator ShowSignInGuestOfflineWindow()
	{
		return null;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x4729B0", Offset = "0x471DB0", VA = "0x104729B0")]
	private void ShowSignInScreen()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x46EA20", Offset = "0x46DE20", VA = "0x1046EA20")]
	public void AskToLinkToExistingAccount()
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void AskToLinkAccountWithMerge()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x4704D0", Offset = "0x46F8D0", VA = "0x104704D0")]
	public string GetContinuanceToken()
	{
		return null;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x46F510", Offset = "0x46E910", VA = "0x1046F510")]
	public void CreateKWSUer()
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x46F930", Offset = "0x46ED30", VA = "0x1046F930")]
	private void CreateKWSUserCallback(Epic.OnlineServices.KWS.CreateUserCallbackInfo createUserCallbackInfo)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x471780", Offset = "0x470B80", VA = "0x10471780")]
	public void LogInToDeviceIDForGuestMode()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x46FCA0", Offset = "0x46F0A0", VA = "0x1046FCA0")]
	private void EOSConnectDeviceIDLoginForGuestModeCallback(LoginCallbackInfo loginCallbackInfo)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x46F040", Offset = "0x46E440", VA = "0x1046F040")]
	private void CheckKWSPermissionsOnPlatformLogin()
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x471320", Offset = "0x470720", VA = "0x10471320")]
	private void KWSQueryPermissionsOnPlatformLoginCallback(QueryPermissionsCallbackInfo permissionsCallbackInfo)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x470FE0", Offset = "0x4703E0", VA = "0x10470FE0")]
	private void KWSPermissionsUpdatedCallback(PermissionsUpdateReceivedCallbackInfo permissionsCallbackInfo)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x470300", Offset = "0x46F700", VA = "0x10470300")]
	private void FinishLoginFlow()
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x473C80", Offset = "0x473080", VA = "0x10473C80")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1D20", Offset = "0xE1120")]
	private IEnumerator UpdatePlayerStorageManager()
	{
		return null;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x46F290", Offset = "0x46E690", VA = "0x1046F290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1E00", Offset = "0xE1200")]
	private IEnumerator CoUpdateInventoryOrValidateReceipts()
	{
		return null;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x46E6F0", Offset = "0x46DAF0", VA = "0x1046E6F0")]
	public void AskDLCRedemptionPopup(Action callbackProceed, Action callbackNotYet)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x471F80", Offset = "0x471380", VA = "0x10471F80")]
	public void MarkOldDLCRedeemed()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x4727D0", Offset = "0x471BD0", VA = "0x104727D0")]
	public bool ShouldAskToRedeemOldDLC()
	{
		return default(bool);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x470500", Offset = "0x46F900", VA = "0x10470500")]
	private ExternalAccountInfo GetExternalAccountInfo()
	{
		return null;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x4735D0", Offset = "0x4729D0", VA = "0x104735D0")]
	public void UpdateInventory()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x4701C0", Offset = "0x46F5C0", VA = "0x104701C0")]
	public void FinishLoginFlowPart2()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x46F3B0", Offset = "0x46E7B0", VA = "0x1046F3B0")]
	public void CreateAccountWithPlatformAuth()
	{
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x46FB30", Offset = "0x46EF30", VA = "0x1046FB30")]
	private void EOSConnectCreateUserCallback(Epic.OnlineServices.Connect.CreateUserCallbackInfo createUserCallbackInfo)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x46FE40", Offset = "0x46F240", VA = "0x1046FE40")]
	private void EOSConnectPlatformLoginCallback(LoginCallbackInfo loginCallbackInfo)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x46F230", Offset = "0x46E630", VA = "0x1046F230")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1E90", Offset = "0xE1290")]
	public IEnumerator CoRequestPin(PinRequest requestData, Action<PinRequestResponse> resultCallback)
	{
		return null;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x46F1D0", Offset = "0x46E5D0", VA = "0x1046F1D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1EE0", Offset = "0xE12E0")]
	public IEnumerator CoHasAccountFinishedLinking(string pin, Action<LinkStatusResponse> resultCallback)
	{
		return null;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x471A20", Offset = "0x470E20", VA = "0x10471A20")]
	public void LoginAndThenPopupLinkWindow()
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x4700A0", Offset = "0x46F4A0", VA = "0x104700A0")]
	private void EOSConnectPlatformLoginFromLinkingExistingAccountsCallback(LoginCallbackInfo loginCallbackInfo)
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x46F140", Offset = "0x46E540", VA = "0x1046F140")]
	public void ClearAuthToken()
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x3C16C0", Offset = "0x3C0AC0", VA = "0x103C16C0")]
	public string GetPlatformAuthToken()
	{
		return null;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x473770", Offset = "0x472B70", VA = "0x10473770")]
	private void UpdatePermissionKeys(bool isLoggingIn)
	{
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x4734E0", Offset = "0x4728E0", VA = "0x104734E0")]
	public void UpdateGuardianEmail()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x473440", Offset = "0x472840", VA = "0x10473440")]
	private void UpdateGuardianEmailSettingsCallback(UpdateParentEmailCallbackInfo updateParentEmailCallbackInfo)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x470F00", Offset = "0x470300", VA = "0x10470F00")]
	public bool IsMinor()
	{
		return default(bool);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x470E30", Offset = "0x470230", VA = "0x10470E30")]
	public bool IsFreechatAllowed()
	{
		return default(bool);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x473D50", Offset = "0x473150", VA = "0x10473D50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1F30", Offset = "0xE1330")]
	public IEnumerator WaitForLoginFlow()
	{
		return null;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x470670", Offset = "0x46FA70", VA = "0x10470670")]
	public bool HasFinishedLoginFlow()
	{
		return default(bool);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x46F170", Offset = "0x46E570", VA = "0x1046F170")]
	private void CloseStartupWaitScreen()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x472910", Offset = "0x471D10", VA = "0x10472910")]
	private void ShowCallbackWaitAnim()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x470680", Offset = "0x46FA80", VA = "0x10470680")]
	private void HideCallbackWaitAnim()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	private void OnEnable()
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x472160", Offset = "0x471560", VA = "0x10472160")]
	private new void OnDestroy()
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x473CD0", Offset = "0x4730D0", VA = "0x10473CD0")]
	private void Update()
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x46FAE0", Offset = "0x46EEE0", VA = "0x1046FAE0")]
	[Attribute(Name = "ContextMenu", RVA = "0xE1F80", Offset = "0xE1380")]
	private void DoShutdown()
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x46F950", Offset = "0x46ED50", VA = "0x1046F950")]
	[Attribute(Name = "ContextMenu", RVA = "0xE1FB0", Offset = "0xE13B0")]
	public void DeleteDeviceID()
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x473DA0", Offset = "0x4731A0", VA = "0x10473DA0")]
	public EOSManager()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x4731E0", Offset = "0x4725E0", VA = "0x104731E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <UpdateMappings>b__69_0(QueryProductUserIdMappingsCallbackInfo result)
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x472DF0", Offset = "0x4721F0", VA = "0x10472DF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <BeginLoginFlow>b__72_0(CreateDeviceIdCallbackInfo createDeviceIDCallbackInfo)
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x473090", Offset = "0x472490", VA = "0x10473090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <LogInToDeviceIDOnStartupCallback>b__74_0(Epic.OnlineServices.Connect.CreateUserCallbackInfo createUserCallback)
	{
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x472F40", Offset = "0x472340", VA = "0x10472F40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <LogInToDeviceIDForGuestMode>b__97_0(CreateDeviceIdCallbackInfo createDeviceIDCallbackIngo)
	{
	}

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x10")]
	private CallResult<EncryptedAppTicketResponse_t> OnEncryptedAppTicketResponseCallResult;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private string productName;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string productVersion;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private string productId;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string sandboxId;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x24")]
	private string deploymentId;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string clientId;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private string clientSecret;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x30")]
	private bool hasRunLoginFlow;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	private const float platformTickInterval = 0.1f;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x34")]
	private float platformTickTimer;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x38")]
	private bool platformInitialized;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x39")]
	private bool loginFlowFinished;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x3A")]
	private bool stopTimeOutCheck;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject TimeOutPopup;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x40")]
	public float TimeOutTime;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x44")]
	public bool FinishedAssets;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x48")]
	private PlatformInterface platformInterface;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x4C")]
	private ProductUserId userId;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x50")]
	private ProductUserId deviceIDuserID;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x54")]
	public bool announcementsVisible;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x55")]
	private bool hasShownSigninScreen;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x56")]
	private bool attemptAuthAgain;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x58")]
	private uint numLinkedAccounts;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x5C")]
	public List<ExternalAccountInfo> linkedExternalAccounts;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x60")]
	public RedeemDLCChoice redeemDLCChoice;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x64")]
	private int ageOfConsent;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x68")]
	private string kwsUserId;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x6C")]
	private ContinuanceToken continuanceToken;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x70")]
	public string exchangeToken;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x74")]
	private string platformAuthToken;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x78")]
	private bool authExpiredCallbackTriggered;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x79")]
	private bool silentLoginFailed;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x7A")]
	private bool hasTriedStartupDeviceID;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x7C")]
	public CompletionToken<PurchaseStates> validateOldDLC;

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x80")]
	public bool isRedeemingDLC;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x84")]
	private PlatformInterface s_eosPlatformInterface;

	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public enum AccountLoginStatus
	{
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		Offline,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		Guest,
		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		LoggedIn,
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		WaitingForParent
	}

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public enum EOS_ERRORS
	{
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		FailedEpicAuthToken,
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		UnsupportedPlatform,
		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		LinkAccountFail,
		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		SteamworksAppTicketFail,
		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		SteamworksAuthFail,
		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		iOSAuthFail,
		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		GoogleAuthFail,
		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		GoogleAuthNoToken,
		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		NullContinuanceToken,
		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		MismatchedProductUserIDs,
		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		GenericLoginError,
		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		XboxUserAddError,
		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		XboxGetTokenError,
		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		AccountCreationFail,
		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		InterfaceInitFail,
		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		InvalidParentEmail,
		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		GuestModeAuthFail,
		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		PlatformNotSupported,
		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		NintendoAuthFailed,
		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		PlayStationAuthFailed,
		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		AccountLinkFail,
		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		NoConnectionError,
		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		ItchIOAuthFail,
		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		UnlinkAccountFail
	}

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <RunLogin>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <RunLogin>d__62(int <>1__state)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x789F80", Offset = "0x789380", VA = "0x10789F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		private object Current
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x78A230", Offset = "0x789630", VA = "0x1078A230", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		private object Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;
	}

	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowAgePrompt>d__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowAgePrompt>d__82(int <>1__state)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x78B8C0", Offset = "0x78ACC0", VA = "0x1078B8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		private object Current
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x78B9C0", Offset = "0x78ADC0", VA = "0x1078B9C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		private object Current
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;
	}

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowSignInGuestOfflineWindow>d__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowSignInGuestOfflineWindow>d__90(int <>1__state)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x78C470", Offset = "0x78B870", VA = "0x1078C470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		private object Current
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x78C530", Offset = "0x78B930", VA = "0x1078C530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		private object Current
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <UpdatePlayerStorageManager>d__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <UpdatePlayerStorageManager>d__103(int <>1__state)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x78DF50", Offset = "0x78D350", VA = "0x1078DF50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		private object Current
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x78E010", Offset = "0x78D410", VA = "0x1078E010", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		private object Current
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;
	}

	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x78D340", Offset = "0x78C740", VA = "0x1078D340")]
		internal bool <CoUpdateInventoryOrValidateReceipts>b__106_0(string x)
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x78D160", Offset = "0x78C560", VA = "0x1078D160")]
		internal void <AskDLCRedemptionPopup>b__107_0()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x78D3A0", Offset = "0x78C7A0", VA = "0x1078D3A0")]
		internal void <DeleteDeviceID>b__137_0(DeleteDeviceIdCallbackInfo data)
		{
		}

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EOSManager.<>c <>9;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x4")]
		public static Func<string, bool> <>9__106_0;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__107_0;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xC")]
		public static OnDeleteDeviceIdCallback <>9__137_0;
	}

	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoUpdateInventoryOrValidateReceipts>d__106 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoUpdateInventoryOrValidateReceipts>d__106(int <>1__state)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x786EF0", Offset = "0x7862F0", VA = "0x10786EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		private object Current
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7875C0", Offset = "0x7869C0", VA = "0x107875C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		private object Current
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x14")]
		private PlayerStorageManager.CloudPlayerPrefs <prefs>5__2;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x24")]
		private uint <platformFlag>5__3;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x28")]
		private CompletionToken<PurchaseStates> <validateSpecialItems>5__4;
	}

	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoRequestPin>d__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoRequestPin>d__116(int <>1__state)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x786080", Offset = "0x785480", VA = "0x10786080", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x785BF0", Offset = "0x784FF0", VA = "0x10785BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x786190", Offset = "0x785590", VA = "0x10786190")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x7861E0", Offset = "0x7855E0", VA = "0x107861E0")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		private object Current
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x786050", Offset = "0x785450", VA = "0x10786050", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		private object Current
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x10")]
		public PinRequest requestData;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x14")]
		public Action<PinRequestResponse> resultCallback;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		private HttpClient <http>5__2;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x1C")]
		private Task<HttpResponseMessage> <responseTask>5__3;
	}

	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoHasAccountFinishedLinking>d__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoHasAccountFinishedLinking>d__117(int <>1__state)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x784B40", Offset = "0x783F40", VA = "0x10784B40", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x784740", Offset = "0x783B40", VA = "0x10784740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x784C50", Offset = "0x784050", VA = "0x10784C50")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x784CA0", Offset = "0x7840A0", VA = "0x10784CA0")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		private object Current
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x784B10", Offset = "0x783F10", VA = "0x10784B10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		private object Current
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		public string pin;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x14")]
		public Action<LinkStatusResponse> resultCallback;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		private LinkStatusResponse.LinkStatus <linkStatus>5__2;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x1C")]
		private HttpClient <http>5__3;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private Task<HttpResponseMessage> <responseTask>5__4;
	}

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForLoginFlow>d__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForLoginFlow>d__127(int <>1__state)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x78E0C0", Offset = "0x78D4C0", VA = "0x1078E0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		private object Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x78E110", Offset = "0x78D510", VA = "0x1078E110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		private object Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x10")]
		public EOSManager <>4__this;
	}
}
