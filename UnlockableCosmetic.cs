using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class UnlockableCosmetic : ScriptableObject
{
	// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x4B8600", Offset = "0x4B7A00", VA = "0x104B8600")]
	public string GetProdId()
	{
		return null;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x4B85E0", Offset = "0x4B79E0", VA = "0x104B85E0")]
	public string GetBundleId()
	{
		return null;
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
	public UnlockableCosmetic()
	{
	}

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0xC")]
	public UnlockableCosmetic.UnlockableQuality quality;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x10")]
	public CosmeticData unlockableCosmetic;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x14")]
	public Sprite icon;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x18")]
	public int cost;

	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public enum UnlockableQuality
	{
		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		Nameplate = 1,
		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		Hat,
		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		Visor,
		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		Skin,
		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		Pet,
		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		Kill
	}
}
