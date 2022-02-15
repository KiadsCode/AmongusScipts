using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002D4 RID: 724
[Token(Token = "0x20002D4")]
public class CubesTab : InventoryTab
{
	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x5BC8A0", Offset = "0x5BBCA0", VA = "0x105BC8A0", Slot = "5")]
	public override void OnEnable()
	{
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x5BCEB0", Offset = "0x5BC2B0", VA = "0x105BCEB0")]
	private void Update()
	{
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x5BCC70", Offset = "0x5BC070", VA = "0x105BCC70")]
	private void SelectCube(ColorChip chip, Cosmicube cube)
	{
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x5BC850", Offset = "0x5BBC50", VA = "0x105BC850", Slot = "7")]
	public override ColorChip GetDefaultSelectable()
	{
		return null;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x5BD1B0", Offset = "0x5BC5B0", VA = "0x105BD1B0")]
	public void ViewCube()
	{
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x5BC600", Offset = "0x5BBA00", VA = "0x105BC600", Slot = "4")]
	public override void ClickEquip()
	{
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00005C28 File Offset: 0x00003E28
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "8")]
	public override bool IsSelectedItemEquipped()
	{
		return default(bool);
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x5BC430", Offset = "0x5BB830", VA = "0x105BC430")]
	private void ActivateCube()
	{
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x5BC680", Offset = "0x5BBA80", VA = "0x105BC680")]
	private void DeactivateCube()
	{
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x3BC630", Offset = "0x3BBA30", VA = "0x103BC630")]
	public CubesTab()
	{
	}

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x2C")]
	public CosmicubeMenu cosmicubeMenu;

	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0x30")]
	private Cosmicube currentCube;

	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x34")]
	private string cubeId;

	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject viewButton;

	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject activateButton;

	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshPro activateText;

	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0x44")]
	public TextMeshPro itemName;

	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer podIcon;

	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06001002 RID: 4098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x78D9F0", Offset = "0x78CDF0", VA = "0x1078D9F0")]
		internal void <OnEnable>b__0()
		{
		}

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x8")]
		public ColorChip chip;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0xC")]
		public Cosmicube cube;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x10")]
		public CubesTab <>4__this;
	}
}
