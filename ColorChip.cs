using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class ColorChip : MonoBehaviour
{
	// Token: 0x06000FF5 RID: 4085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x420740", Offset = "0x41FB40", VA = "0x10420740")]
	public void ShowSelected()
	{
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x420710", Offset = "0x41FB10", VA = "0x10420710")]
	public void Deselect()
	{
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ColorChip()
	{
	}

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0xC")]
	public HatParent Inner;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x10")]
	public GameObject PlayerEquippedForeground;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InUseForeground;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x18")]
	public PassiveButton Button;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer SelectionHighlight;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x20")]
	public object Tag;
}
