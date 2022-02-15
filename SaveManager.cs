using System;
using System.Collections.Generic;
using System.IO;
using Assets.InnerNet;
using Il2CppDummyDll;
using InnerNet;

// Token: 0x0200044E RID: 1102
[Token(Token = "0x200044E")]
public static class SaveManager
{
	// Token: 0x17000343 RID: 835
	// (get) Token: 0x0600171A RID: 5914 RVA: 0x00007500 File Offset: 0x00005700
	// (set) Token: 0x0600171B RID: 5915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000343")]
	public static Announcement LastAnnouncement
	{
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x588470", Offset = "0x587870", VA = "0x10588470")]
		get
		{
			return default(Announcement);
		}
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x589610", Offset = "0x588A10", VA = "0x10589610")]
		set
		{
		}
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171C")]
	[Address(RVA = "0x583EF0", Offset = "0x5832F0", VA = "0x10583EF0")]
	public static void DeleteAll()
	{
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x584370", Offset = "0x583770", VA = "0x10584370")]
	private static string GetPrefsName()
	{
		return null;
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x0600171E RID: 5918 RVA: 0x00007518 File Offset: 0x00005718
	[Token(Token = "0x17000344")]
	public static bool BoughtNoAds
	{
		[Token(Token = "0x600171E")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x00007530 File Offset: 0x00005730
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x584420", Offset = "0x583820", VA = "0x10584420")]
	public static bool GetPurchase(string itemKey, string bundleKey)
	{
		return default(bool);
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x5839B0", Offset = "0x582DB0", VA = "0x105839B0")]
	public static void ClearAllPurchases()
	{
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x587520", Offset = "0x586920", VA = "0x10587520")]
	public static void SetPurchased(string key)
	{
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x583DF0", Offset = "0x5831F0", VA = "0x10583DF0")]
	public static void ClearPurchase(string key)
	{
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x585CC0", Offset = "0x5850C0", VA = "0x10585CC0")]
	public static void SaveLocalDoB(int year, int mo, int day)
	{
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x00007548 File Offset: 0x00005748
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x584090", Offset = "0x583490", VA = "0x10584090")]
	public static bool GetLocalDoB()
	{
		return default(bool);
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x5856C0", Offset = "0x584AC0", VA = "0x105856C0")]
	private static void LoadSecureData()
	{
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x587450", Offset = "0x586850", VA = "0x10587450")]
	public static void SaveSecureData(bool saveNow = false)
	{
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06001727 RID: 5927 RVA: 0x00007560 File Offset: 0x00005760
	// (set) Token: 0x06001728 RID: 5928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000345")]
	public static bool VSync
	{
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x588C60", Offset = "0x588060", VA = "0x10588C60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x589E80", Offset = "0x589280", VA = "0x10589E80")]
		set
		{
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06001729 RID: 5929 RVA: 0x00007578 File Offset: 0x00005778
	// (set) Token: 0x0600172A RID: 5930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000346")]
	public static QuickChatModes ChatModeType
	{
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x588020", Offset = "0x587420", VA = "0x10588020")]
		get
		{
			return (QuickChatModes)0;
		}
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x589170", Offset = "0x588570", VA = "0x10589170")]
		set
		{
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x0600172B RID: 5931 RVA: 0x00007590 File Offset: 0x00005790
	// (set) Token: 0x0600172C RID: 5932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000347")]
	public static bool CensorChat
	{
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x587FC0", Offset = "0x5873C0", VA = "0x10587FC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x589100", Offset = "0x588500", VA = "0x10589100")]
		set
		{
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x0600172D RID: 5933 RVA: 0x000075A8 File Offset: 0x000057A8
	// (set) Token: 0x0600172E RID: 5934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000348")]
	public static ShowAdsState ShowAdsScreen
	{
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x588B40", Offset = "0x587F40", VA = "0x10588B40")]
		get
		{
			return ShowAdsState.NotAccepted;
		}
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x589D30", Offset = "0x589130", VA = "0x10589D30")]
		set
		{
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x0600172F RID: 5935 RVA: 0x000075C0 File Offset: 0x000057C0
	// (set) Token: 0x06001730 RID: 5936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000349")]
	public static int AcceptedPrivacyPolicy
	{
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x587CC0", Offset = "0x5870C0", VA = "0x10587CC0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x588D80", Offset = "0x588180", VA = "0x10588D80")]
		set
		{
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06001731 RID: 5937 RVA: 0x000075D8 File Offset: 0x000057D8
	// (set) Token: 0x06001732 RID: 5938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034A")]
	public static EOSManager.AccountLoginStatus AccountLoginStatus
	{
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x587D20", Offset = "0x587120", VA = "0x10587D20")]
		get
		{
			return EOSManager.AccountLoginStatus.Offline;
		}
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x588DF0", Offset = "0x5881F0", VA = "0x10588DF0")]
		set
		{
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001733 RID: 5939 RVA: 0x000075F0 File Offset: 0x000057F0
	// (set) Token: 0x06001734 RID: 5940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034B")]
	public static bool AskRedeemDLC
	{
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x587D80", Offset = "0x587180", VA = "0x10587D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x588E60", Offset = "0x588260", VA = "0x10588E60")]
		set
		{
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001735 RID: 5941 RVA: 0x00007608 File Offset: 0x00005808
	// (set) Token: 0x06001736 RID: 5942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034C")]
	public static int BirthDateMonth
	{
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x587E40", Offset = "0x587240", VA = "0x10587E40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x588F40", Offset = "0x588340", VA = "0x10588F40")]
		set
		{
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06001737 RID: 5943 RVA: 0x00007620 File Offset: 0x00005820
	// (set) Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034D")]
	public static int BirthDateDay
	{
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x587DE0", Offset = "0x5871E0", VA = "0x10587DE0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x588ED0", Offset = "0x5882D0", VA = "0x10588ED0")]
		set
		{
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06001739 RID: 5945 RVA: 0x00007638 File Offset: 0x00005838
	// (set) Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034E")]
	public static int BirthDateYear
	{
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x587F00", Offset = "0x587300", VA = "0x10587F00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x589020", Offset = "0x588420", VA = "0x10589020")]
		set
		{
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x0600173B RID: 5947 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700034F")]
	public static string BirthDateSetDate
	{
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x587EA0", Offset = "0x5872A0", VA = "0x10587EA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x588FB0", Offset = "0x5883B0", VA = "0x10588FB0")]
		set
		{
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x0600173D RID: 5949 RVA: 0x00007650 File Offset: 0x00005850
	// (set) Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000350")]
	public static bool ShowMinPlayerWarning
	{
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x588BA0", Offset = "0x587FA0", VA = "0x10588BA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x589DA0", Offset = "0x5891A0", VA = "0x10589DA0")]
		set
		{
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x0600173F RID: 5951 RVA: 0x00007668 File Offset: 0x00005868
	// (set) Token: 0x06001740 RID: 5952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000351")]
	public static bool ShowOnlineHelp
	{
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x588C00", Offset = "0x588000", VA = "0x10588C00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x589E10", Offset = "0x589210", VA = "0x10589E10")]
		set
		{
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06001741 RID: 5953 RVA: 0x00007680 File Offset: 0x00005880
	// (set) Token: 0x06001742 RID: 5954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000352")]
	public static bool WarnedAboutGuestModeProgression
	{
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x588CC0", Offset = "0x5880C0", VA = "0x10588CC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x589EF0", Offset = "0x5892F0", VA = "0x10589EF0")]
		set
		{
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06001743 RID: 5955 RVA: 0x00007698 File Offset: 0x00005898
	// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000353")]
	public static float SfxVolume
	{
		[Token(Token = "0x6001743")]
		[Address(RVA = "0x588AC0", Offset = "0x587EC0", VA = "0x10588AC0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x589CB0", Offset = "0x5890B0", VA = "0x10589CB0")]
		set
		{
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x06001745 RID: 5957 RVA: 0x000076B0 File Offset: 0x000058B0
	// (set) Token: 0x06001746 RID: 5958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000354")]
	public static float MusicVolume
	{
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x588800", Offset = "0x587C00", VA = "0x10588800")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x589990", Offset = "0x588D90", VA = "0x10589990")]
		set
		{
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x06001747 RID: 5959 RVA: 0x000076C8 File Offset: 0x000058C8
	// (set) Token: 0x06001748 RID: 5960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000355")]
	public static ControlTypes ControlMode
	{
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x5880D0", Offset = "0x5874D0", VA = "0x105880D0")]
		get
		{
			return ControlTypes.VirtualJoystick;
		}
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x5891E0", Offset = "0x5885E0", VA = "0x105891E0")]
		set
		{
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x06001749 RID: 5961 RVA: 0x000076E0 File Offset: 0x000058E0
	// (set) Token: 0x0600174A RID: 5962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000356")]
	public static float JoystickSize
	{
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x588410", Offset = "0x587810", VA = "0x10588410")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x5895A0", Offset = "0x5889A0", VA = "0x105895A0")]
		set
		{
		}
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174B")]
	[Address(RVA = "0x584030", Offset = "0x583430", VA = "0x10584030")]
	private static string GetDefaultName()
	{
		return null;
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x0600174C RID: 5964 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600174D RID: 5965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000357")]
	public static string PlayerName
	{
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x5888E0", Offset = "0x587CE0", VA = "0x105888E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x589A80", Offset = "0x588E80", VA = "0x10589A80")]
		set
		{
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x0600174E RID: 5966 RVA: 0x000076F8 File Offset: 0x000058F8
	// (set) Token: 0x0600174F RID: 5967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000358")]
	public static uint PlayerLevel
	{
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x588880", Offset = "0x587C80", VA = "0x10588880")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x589A10", Offset = "0x588E10", VA = "0x10589A10")]
		set
		{
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x06001750 RID: 5968 RVA: 0x00007710 File Offset: 0x00005910
	// (set) Token: 0x06001751 RID: 5969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000359")]
	public static uint PlayerXp
	{
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x588A00", Offset = "0x587E00", VA = "0x10588A00")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001751")]
		[Address(RVA = "0x589AF0", Offset = "0x588EF0", VA = "0x10589AF0")]
		set
		{
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x06001752 RID: 5970 RVA: 0x00007728 File Offset: 0x00005928
	// (set) Token: 0x06001753 RID: 5971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035A")]
	public static uint XpRequiredForNextLevel
	{
		[Token(Token = "0x6001752")]
		[Address(RVA = "0x588D20", Offset = "0x588120", VA = "0x10588D20")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x589F60", Offset = "0x589360", VA = "0x10589F60")]
		set
		{
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x06001754 RID: 5972 RVA: 0x00007740 File Offset: 0x00005940
	// (set) Token: 0x06001755 RID: 5973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035B")]
	public static bool CrossplayAllPlatforms
	{
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x588130", Offset = "0x587530", VA = "0x10588130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x589250", Offset = "0x588650", VA = "0x10589250")]
		set
		{
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x06001756 RID: 5974 RVA: 0x00007758 File Offset: 0x00005958
	// (set) Token: 0x06001757 RID: 5975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035C")]
	public static bool EnableMouseMovement
	{
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x588180", Offset = "0x587580", VA = "0x10588180")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x5892E0", Offset = "0x5886E0", VA = "0x105892E0")]
		set
		{
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001759 RID: 5977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035D")]
	public static string GuardianEmail
	{
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x5883B0", Offset = "0x5877B0", VA = "0x105883B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x589530", Offset = "0x588930", VA = "0x10589530")]
		set
		{
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600175B RID: 5979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035E")]
	public static string LastPet
	{
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x5886E0", Offset = "0x587AE0", VA = "0x105886E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x589840", Offset = "0x588C40", VA = "0x10589840")]
		set
		{
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700035F")]
	public static string LastHat
	{
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x588530", Offset = "0x587930", VA = "0x10588530")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x5896F0", Offset = "0x588AF0", VA = "0x105896F0")]
		set
		{
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600175F RID: 5983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000360")]
	public static string LastSkin
	{
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x588740", Offset = "0x587B40", VA = "0x10588740")]
		get
		{
			return null;
		}
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x5898B0", Offset = "0x588CB0", VA = "0x105898B0")]
		set
		{
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06001760 RID: 5984 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001761 RID: 5985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000361")]
	public static string LastVisor
	{
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x5887A0", Offset = "0x587BA0", VA = "0x105887A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x589920", Offset = "0x588D20", VA = "0x10589920")]
		set
		{
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001763 RID: 5987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000362")]
	public static string LastNamePlate
	{
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x588680", Offset = "0x587A80", VA = "0x10588680")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x5897D0", Offset = "0x588BD0", VA = "0x105897D0")]
		set
		{
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001765 RID: 5989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000363")]
	public static string LastCosmicube
	{
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x5884D0", Offset = "0x5878D0", VA = "0x105884D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x589680", Offset = "0x588A80", VA = "0x10589680")]
		set
		{
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x06001766 RID: 5990 RVA: 0x00007770 File Offset: 0x00005970
	// (set) Token: 0x06001767 RID: 5991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000364")]
	public static uint LastLanguage
	{
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x588590", Offset = "0x587990", VA = "0x10588590")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x589760", Offset = "0x588B60", VA = "0x10589760")]
		set
		{
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x06001768 RID: 5992 RVA: 0x00007788 File Offset: 0x00005988
	// (set) Token: 0x06001769 RID: 5993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000365")]
	public static byte BodyColor
	{
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x587F60", Offset = "0x587360", VA = "0x10587F60")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x589090", Offset = "0x588490", VA = "0x10589090")]
		set
		{
		}
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600176B RID: 5995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000366")]
	public static GameOptionsData GameHostOptions
	{
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x5881E0", Offset = "0x5875E0", VA = "0x105881E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x589350", Offset = "0x588750", VA = "0x10589350")]
		set
		{
		}
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600176D RID: 5997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000367")]
	public static GameOptionsData GameSearchOptions
	{
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x5882F0", Offset = "0x5876F0", VA = "0x105882F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x589440", Offset = "0x588840", VA = "0x10589440")]
		set
		{
		}
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x584710", Offset = "0x583B10", VA = "0x10584710")]
	private static GameOptionsData LoadGameOptions(string filename)
	{
		return null;
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x585C30", Offset = "0x585030", VA = "0x10585C30")]
	public static void SaveGameOptions(GameOptionsData data, string filename, bool saveNow = false)
	{
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x584530", Offset = "0x583930", VA = "0x10584530")]
	private static void LoadAnnouncement()
	{
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001771")]
	[Address(RVA = "0x585A60", Offset = "0x584E60", VA = "0x10585A60")]
	public static void SaveAnnouncement(bool saveNow = false)
	{
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001772")]
	[Address(RVA = "0x584940", Offset = "0x583D40", VA = "0x10584940")]
	public static void LoadPlayerPrefs(bool overrideLoad = false)
	{
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001773")]
	[Address(RVA = "0x586100", Offset = "0x585500", VA = "0x10586100")]
	public static void SavePlayerPrefs(bool saveNow = false)
	{
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x06001774 RID: 6004 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000368")]
	public static string[] QuickChatFavorites
	{
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x588A60", Offset = "0x587E60", VA = "0x10588A60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x589B60", Offset = "0x588F60", VA = "0x10589B60")]
		set
		{
		}
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001776")]
	[Address(RVA = "0x585400", Offset = "0x584800", VA = "0x10585400")]
	public static void LoadQuickChatFavorites()
	{
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001777")]
	[Address(RVA = "0x587350", Offset = "0x586750", VA = "0x10587350")]
	public static void SaveQuickChatFavorites(bool saveNow = false)
	{
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001778")]
	[Address(RVA = "0x587680", Offset = "0x586A80", VA = "0x10587680")]
	private static void TryGetBool(string[] parts, int index, out bool value, bool @default = false)
	{
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001779")]
	[Address(RVA = "0x587720", Offset = "0x586B20", VA = "0x10587720")]
	private static void TryGetByte(string[] parts, int index, out byte value)
	{
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177A")]
	[Address(RVA = "0x587820", Offset = "0x586C20", VA = "0x10587820")]
	private static void TryGetFloat(string[] parts, int index, out float value, float @default = 0f)
	{
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x587760", Offset = "0x586B60", VA = "0x10587760")]
	private static void TryGetDateTime(string[] parts, int index, out DateTime value)
	{
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x5878B0", Offset = "0x586CB0", VA = "0x105878B0")]
	private static void TryGetInt(string[] parts, int index, out int value)
	{
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177D")]
	[Address(RVA = "0x587930", Offset = "0x586D30", VA = "0x10587930")]
	private static void TryGetUint(string[] parts, int index, out uint value, uint @default = 0U)
	{
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177E")]
	[Address(RVA = "0x587970", Offset = "0x586D70", VA = "0x10587970")]
	private static void TryGetUlong(string[] parts, int index, out ulong value, ulong @default = 0UL)
	{
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x5878F0", Offset = "0x586CF0", VA = "0x105878F0")]
	private static void TryGetString(string[] parts, int index, out string value, string @default = "")
	{
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x000077A0 File Offset: 0x000059A0
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x5859C0", Offset = "0x584DC0", VA = "0x105859C0")]
	private static bool RunMigrations()
	{
		return default(bool);
	}

	// Token: 0x0400176D RID: 5997
	[Token(Token = "0x400176D")]
	private const int schemaVersion = 1;

	// Token: 0x0400176E RID: 5998
	[Token(Token = "0x400176E")]
	[FieldOffset(Offset = "0x0")]
	private static bool loaded;

	// Token: 0x0400176F RID: 5999
	[Token(Token = "0x400176F")]
	[FieldOffset(Offset = "0x1")]
	private static bool loadedStats;

	// Token: 0x04001770 RID: 6000
	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0x2")]
	private static bool loadedAnnounce;

	// Token: 0x04001771 RID: 6001
	[Token(Token = "0x4001771")]
	[FieldOffset(Offset = "0x3")]
	private static bool loadedQCFavorites;

	// Token: 0x04001772 RID: 6002
	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0x4")]
	private static string lastPlayerName;

	// Token: 0x04001773 RID: 6003
	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0x8")]
	private static byte sfxVolume;

	// Token: 0x04001774 RID: 6004
	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0x9")]
	private static byte musicVolume;

	// Token: 0x04001775 RID: 6005
	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0xA")]
	private static bool showMinPlayerWarning;

	// Token: 0x04001776 RID: 6006
	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0xB")]
	private static bool showOnlineHelp;

	// Token: 0x04001777 RID: 6007
	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0xC")]
	private static byte showAdsScreen;

	// Token: 0x04001778 RID: 6008
	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0x10")]
	private static int privacyPolicyVersion;

	// Token: 0x04001779 RID: 6009
	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x14")]
	private static int birthDateDay;

	// Token: 0x0400177A RID: 6010
	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x18")]
	private static int birthDateMonth;

	// Token: 0x0400177B RID: 6011
	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x1C")]
	private static int birthDateYear;

	// Token: 0x0400177C RID: 6012
	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0x20")]
	private static string birthDateSetDate;

	// Token: 0x0400177D RID: 6013
	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0x24")]
	private static string epicAccountId;

	// Token: 0x0400177E RID: 6014
	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0x28")]
	private static bool vsync;

	// Token: 0x0400177F RID: 6015
	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0x29")]
	private static bool censorChat;

	// Token: 0x04001780 RID: 6016
	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0x2C")]
	private static int chatModeType;

	// Token: 0x04001781 RID: 6017
	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0x30")]
	private static bool isGuest;

	// Token: 0x04001782 RID: 6018
	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0x31")]
	private static bool hasLoggedIn;

	// Token: 0x04001783 RID: 6019
	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0x34")]
	private static string guardianEmail;

	// Token: 0x04001784 RID: 6020
	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0x38")]
	private static int accountLoginStatus;

	// Token: 0x04001785 RID: 6021
	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0x3C")]
	private static bool askRedeemDLC;

	// Token: 0x04001786 RID: 6022
	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0x3D")]
	private static bool warnedAboutGuestModeProgression;

	// Token: 0x04001787 RID: 6023
	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0x40")]
	private static ControlTypes touchConfig;

	// Token: 0x04001788 RID: 6024
	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0x44")]
	private static float joyStickSize;

	// Token: 0x04001789 RID: 6025
	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0x48")]
	private static uint colorConfig;

	// Token: 0x0400178A RID: 6026
	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0x4C")]
	private static string lastPet;

	// Token: 0x0400178B RID: 6027
	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0x50")]
	private static string lastHat;

	// Token: 0x0400178C RID: 6028
	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x54")]
	private static string lastSkin;

	// Token: 0x0400178D RID: 6029
	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x58")]
	private static string lastVisor;

	// Token: 0x0400178E RID: 6030
	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x5C")]
	private static string lastNamePlate;

	// Token: 0x0400178F RID: 6031
	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0x60")]
	private static string lastCosmicube;

	// Token: 0x04001790 RID: 6032
	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x64")]
	private static uint lastLanguage;

	// Token: 0x04001791 RID: 6033
	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0x68")]
	private static GameOptionsData hostOptionsData;

	// Token: 0x04001792 RID: 6034
	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x6C")]
	private static GameOptionsData searchOptionsData;

	// Token: 0x04001793 RID: 6035
	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x70")]
	private static int lastSchemaVersion;

	// Token: 0x04001794 RID: 6036
	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x74")]
	private static uint playerLevel;

	// Token: 0x04001795 RID: 6037
	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x78")]
	private static uint playerXp;

	// Token: 0x04001796 RID: 6038
	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0x7C")]
	private static uint playerXpRequiredForNextLevel;

	// Token: 0x04001797 RID: 6039
	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x80")]
	private static bool crossplayAllPlatforms;

	// Token: 0x04001798 RID: 6040
	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x81")]
	private static bool enableMouseMovement;

	// Token: 0x04001799 RID: 6041
	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0x84")]
	private static Announcement lastAnnounce;

	// Token: 0x0400179A RID: 6042
	[Token(Token = "0x400179A")]
	public const int quickChatFavoriteSlots = 20;

	// Token: 0x0400179B RID: 6043
	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x8C")]
	private static string[] quickChatFavorites;

	// Token: 0x0400179C RID: 6044
	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x90")]
	private static SecureDataFile purchaseFile;

	// Token: 0x0400179D RID: 6045
	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x94")]
	private static HashSet<string> purchases;

	// Token: 0x0400179E RID: 6046
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x98")]
	private static string dobInfo;

	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x370470", Offset = "0x36F870", VA = "0x10370470")]
		internal void <LoadSecureData>b__63_0(BinaryReader reader)
		{
		}

		// Token: 0x0400179F RID: 6047
		[Token(Token = "0x400179F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SaveManager.<>c <>9;

		// Token: 0x040017A0 RID: 6048
		[Token(Token = "0x40017A0")]
		[FieldOffset(Offset = "0x4")]
		public static Action<BinaryReader> <>9__63_0;
	}
}
