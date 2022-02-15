using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000327 RID: 807
[Token(Token = "0x2000327")]
[Attribute(Name = "RequireComponent", RVA = "0xE7700", Offset = "0xE6B00")]
public class OpenHyperlinks : MonoBehaviour
{
	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A9")]
	public string Text
	{
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x77D460", Offset = "0x77C860", VA = "0x1077D460")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x77D490", Offset = "0x77C890", VA = "0x1077D490")]
		set
		{
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000062A0 File Offset: 0x000044A0
	// (set) Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AA")]
	public Color LinkColor
	{
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x44AFB0", Offset = "0x44A3B0", VA = "0x1044AFB0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x46E120", Offset = "0x46D520", VA = "0x1046E120")]
		set
		{
		}
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000062B8 File Offset: 0x000044B8
	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x77D1E0", Offset = "0x77C5E0", VA = "0x1077D1E0")]
	public bool GetWordPosition(string text, out Vector3 bottomLeft, out Vector3 topRight)
	{
		return default(bool);
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x77D200", Offset = "0x77C600", VA = "0x1077D200")]
	public void SetLinkColor()
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x77D2F0", Offset = "0x77C6F0", VA = "0x1077D2F0")]
	public void UpdateTMPMesh()
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x77D340", Offset = "0x77C740", VA = "0x1077D340")]
	public void Update()
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public OpenHyperlinks()
	{
	}

	// Token: 0x040011AD RID: 4525
	[Token(Token = "0x40011AD")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private TextMeshPro pTextMeshPro;

	// Token: 0x040011AE RID: 4526
	[Token(Token = "0x40011AE")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Color linkColor;
}
