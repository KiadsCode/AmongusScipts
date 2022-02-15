using System;
using Il2CppDummyDll;
using InnerNet;
using TMPro;
using UnityEngine;

// Token: 0x02000392 RID: 914
[Token(Token = "0x2000392")]
[Attribute(Name = "RequireComponent", RVA = "0xDE080", Offset = "0xDD480")]
public class PlatformIdentifier : MonoBehaviour
{
	// Token: 0x06001387 RID: 4999 RVA: 0x000067B0 File Offset: 0x000049B0
	[Token(Token = "0x6001387")]
	[Address(RVA = "0x65ECA0", Offset = "0x65E0A0", VA = "0x1065ECA0")]
	public static bool SupportsPlatformUsername(Platforms platformTypeID)
	{
		return default(bool);
	}

	// Token: 0x170002D8 RID: 728
	// (set) Token: 0x06001388 RID: 5000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D8")]
	private bool Visible
	{
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x65F150", Offset = "0x65E550", VA = "0x1065F150")]
		set
		{
		}
	}

	// Token: 0x170002D9 RID: 729
	// (set) Token: 0x06001389 RID: 5001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D9")]
	private bool UsernameVisible
	{
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x65F110", Offset = "0x65E510", VA = "0x1065F110")]
		set
		{
		}
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x65E8D0", Offset = "0x65DCD0", VA = "0x1065E8D0")]
	public void Awake()
	{
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138B")]
	[Address(RVA = "0x65EB20", Offset = "0x65DF20", VA = "0x1065EB20")]
	public void SetInfo(ClientData clientData)
	{
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138C")]
	[Address(RVA = "0x65EB00", Offset = "0x65DF00", VA = "0x1065EB00")]
	public void SetInfo(GameListing gameListingData)
	{
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x65EB80", Offset = "0x65DF80", VA = "0x1065EB80")]
	public void SetInfo(Platforms platform, string platformName)
	{
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x65E960", Offset = "0x65DD60", VA = "0x1065E960")]
	private void SetIcon(Platforms platform)
	{
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x65ECC0", Offset = "0x65E0C0", VA = "0x1065ECC0")]
	[Attribute(Name = "ContextMenu", RVA = "0xDE0D0", Offset = "0xDD4D0")]
	public void UpdatePosition()
	{
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001390")]
	[Address(RVA = "0x65E900", Offset = "0x65DD00", VA = "0x1065E900")]
	private Sprite GetPrevalidationIcon(Platforms platform)
	{
		return null;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x65F040", Offset = "0x65E440", VA = "0x1065F040")]
	private Sprite ValidateIcon(Sprite icon)
	{
		return null;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001392")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlatformIdentifier()
	{
	}

	// Token: 0x040013CD RID: 5069
	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer iconRenderer;

	// Token: 0x040013CE RID: 5070
	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro platformIDText;

	// Token: 0x040013CF RID: 5071
	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x14")]
	public bool isOnHUD;

	// Token: 0x040013D0 RID: 5072
	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x18")]
	public Sprite genericConsole;

	// Token: 0x040013D1 RID: 5073
	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x1C")]
	public Sprite mobile;

	// Token: 0x040013D2 RID: 5074
	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x20")]
	public Sprite pc;

	// Token: 0x040013D3 RID: 5075
	[Token(Token = "0x40013D3")]
	[FieldOffset(Offset = "0x24")]
	public Sprite nSwitch;

	// Token: 0x040013D4 RID: 5076
	[Token(Token = "0x40013D4")]
	[FieldOffset(Offset = "0x28")]
	public Sprite ps4;

	// Token: 0x040013D5 RID: 5077
	[Token(Token = "0x40013D5")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite xbox;
}
