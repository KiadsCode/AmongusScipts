using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000414 RID: 1044
[Token(Token = "0x2000414")]
public class PoolablePlayer : MonoBehaviour
{
	// Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x50C380", Offset = "0x50B780", VA = "0x1050C380")]
	public void ResetCosmetics()
	{
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x50C980", Offset = "0x50BD80", VA = "0x1050C980")]
	public void SetSkin(string skinId)
	{
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x50C910", Offset = "0x50BD10", VA = "0x1050C910")]
	public void SetSkin(SkinData skin)
	{
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x50C6C0", Offset = "0x50BAC0", VA = "0x1050C6C0")]
	public void SetFlipX(bool flipped)
	{
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x50C440", Offset = "0x50B840", VA = "0x1050C440")]
	public void SetDeadFlipX(bool flipped)
	{
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x50CA40", Offset = "0x50BE40", VA = "0x1050CA40")]
	internal void UpdateFromLocalPlayer()
	{
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x50CFD0", Offset = "0x50C3D0", VA = "0x1050CFD0")]
	internal void UpdateFromSaveManager()
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x50CAF0", Offset = "0x50BEF0", VA = "0x1050CAF0")]
	internal void UpdateFromPlayerData(GameData.PlayerInfo pData, PlayerOutfitType outfitType)
	{
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x50CB50", Offset = "0x50BF50", VA = "0x1050CB50")]
	internal void UpdateFromPlayerOutfit(GameData.PlayerOutfit outfit, bool isDead)
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PoolablePlayer()
	{
	}

	// Token: 0x04001645 RID: 5701
	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Body;

	// Token: 0x04001646 RID: 5702
	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer[] Hands;

	// Token: 0x04001647 RID: 5703
	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x14")]
	public HatParent HatSlot;

	// Token: 0x04001648 RID: 5704
	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x18")]
	public SkinLayer Skin;

	// Token: 0x04001649 RID: 5705
	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x1C")]
	public VisorLayer VisorSlot;

	// Token: 0x0400164A RID: 5706
	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer PetSlot;

	// Token: 0x0400164B RID: 5707
	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x24")]
	public TextMeshPro NameText;

	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x060015F9 RID: 5625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x79A7A0", Offset = "0x799BA0", VA = "0x1079A7A0")]
		internal void <UpdateFromPlayerOutfit>b__0(SpriteRenderer b)
		{
		}

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x8")]
		public GameData.PlayerOutfit outfit;
	}
}
