using System;
using System.Text;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x02000450 RID: 1104
[Token(Token = "0x2000450")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	// Token: 0x17000369 RID: 873
	// (get) Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000369")]
	protected static SteamManager Instance
	{
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x75AFA0", Offset = "0x75A3A0", VA = "0x1075AFA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06001786 RID: 6022 RVA: 0x000077B8 File Offset: 0x000059B8
	[Token(Token = "0x1700036A")]
	public static bool Initialized
	{
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x75AE40", Offset = "0x75A240", VA = "0x1075AE40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x75ADD0", Offset = "0x75A1D0", VA = "0x1075ADD0")]
	[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xE0060", Offset = "0xDF460")]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x75ABA0", Offset = "0x759FA0", VA = "0x1075ABA0")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xE00B0", Offset = "0xDF4B0")]
	private static void InitOnPlayMode()
	{
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x75A780", Offset = "0x759B80", VA = "0x1075A780", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x75ACD0", Offset = "0x75A0D0", VA = "0x1075ACD0", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x75AC00", Offset = "0x75A000", VA = "0x1075AC00", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x75AE20", Offset = "0x75A220", VA = "0x1075AE20", Slot = "7")]
	protected virtual void Update()
	{
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SteamManager()
	{
	}

	// Token: 0x040017A1 RID: 6049
	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x0")]
	protected static bool s_EverInitialized;

	// Token: 0x040017A2 RID: 6050
	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x4")]
	protected static SteamManager s_instance;

	// Token: 0x040017A3 RID: 6051
	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0xC")]
	protected bool m_bInitialized;

	// Token: 0x040017A4 RID: 6052
	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x10")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;
}
