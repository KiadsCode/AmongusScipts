using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000285 RID: 645
[Token(Token = "0x2000285")]
public class CrystalMinigame : Minigame
{
	// Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x5BB070", Offset = "0x5BA470", VA = "0x105BB070")]
	public void Start()
	{
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x5BB240", Offset = "0x5BA640", VA = "0x105BB240")]
	public void Update()
	{
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x5BAAB0", Offset = "0x5B9EB0", VA = "0x105BAAB0")]
	private void CheckSolution(int startAt)
	{
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x5BBEA0", Offset = "0x5BB2A0", VA = "0x105BBEA0")]
	public CrystalMinigame()
	{
	}

	// Token: 0x04000E50 RID: 3664
	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x30")]
	public CrystalBehaviour[] CrystalPieces;

	// Token: 0x04000E51 RID: 3665
	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x34")]
	private CrystalBehaviour[] Shuffed;

	// Token: 0x04000E52 RID: 3666
	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x38")]
	public Transform[] CrystalSlots;

	// Token: 0x04000E53 RID: 3667
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x3C")]
	public FloatRange XRange;

	// Token: 0x04000E54 RID: 3668
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x40")]
	public float TrayY;

	// Token: 0x04000E55 RID: 3669
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip[] PickUpSounds;

	// Token: 0x04000E56 RID: 3670
	[Token(Token = "0x4000E56")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip AttachSound;

	// Token: 0x04000E57 RID: 3671
	[Token(Token = "0x4000E57")]
	[FieldOffset(Offset = "0x4C")]
	private Controller myController;

	// Token: 0x04000E58 RID: 3672
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x50")]
	private bool prevHadStick;

	// Token: 0x04000E59 RID: 3673
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x51")]
	private bool prevHadButton;

	// Token: 0x04000E5A RID: 3674
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x54")]
	private int prevSelectedCrystal;

	// Token: 0x04000E5B RID: 3675
	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x58")]
	private int selectedCrystal;

	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x78D1F0", Offset = "0x78C5F0", VA = "0x1078D1F0")]
		internal bool <CheckSolution>b__14_0(CrystalBehaviour c)
		{
			return default(bool);
		}

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CrystalMinigame.<>c <>9;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x4")]
		public static Func<CrystalBehaviour, bool> <>9__14_0;
	}
}
