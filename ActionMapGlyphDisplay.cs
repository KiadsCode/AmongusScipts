using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000359")]
[Attribute(Name = "RequireComponent", RVA = "0xDD720", Offset = "0xDCB20")]
public class ActionMapGlyphDisplay : MonoBehaviour
{
	// Token: 0x060012B5 RID: 4789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x541440", Offset = "0x540840", VA = "0x10541440")]
	private void Awake()
	{
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x541520", Offset = "0x540920", VA = "0x10541520")]
	private void OnDestroy()
	{
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x541660", Offset = "0x540A60", VA = "0x10541660")]
	public void UpdateGlyphDisplay()
	{
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x5415E0", Offset = "0x5409E0", VA = "0x105415E0")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ActionMapGlyphDisplay()
	{
	}

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0xC")]
	public RewiredConstsEnum.Action actionToDisplayMappedGlyphFor;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x10")]
	private SpriteRenderer sr;
}
