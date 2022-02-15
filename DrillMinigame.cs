using System;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x02000338 RID: 824
[Token(Token = "0x2000338")]
public class DrillMinigame : Minigame
{
	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001203")]
	[Address(RVA = "0x46BBD0", Offset = "0x46AFD0", VA = "0x1046BBD0")]
	public void Start()
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x46B5F0", Offset = "0x46A9F0", VA = "0x1046B5F0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x46BC60", Offset = "0x46B060", VA = "0x1046BC60")]
	private void Update()
	{
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001206")]
	[Address(RVA = "0x46B800", Offset = "0x46AC00", VA = "0x1046B800")]
	public void FixButton(SpriteAnim button)
	{
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001207")]
	[Address(RVA = "0x46BE60", Offset = "0x46B260", VA = "0x1046BE60")]
	public DrillMinigame()
	{
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00006360 File Offset: 0x00004560
	[Token(Token = "0x6001208")]
	[Address(RVA = "0x46BC40", Offset = "0x46B040", VA = "0x1046BC40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Begin>b__8_0(int s)
	{
		return default(bool);
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x6001209")]
	[Address(RVA = "0x46BC40", Offset = "0x46B040", VA = "0x1046BC40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <FixButton>b__13_0(int ss)
	{
		return default(bool);
	}

	// Token: 0x040011F4 RID: 4596
	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer CaseImage;

	// Token: 0x040011F5 RID: 4597
	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro statusText;

	// Token: 0x040011F6 RID: 4598
	[Token(Token = "0x40011F6")]
	[FieldOffset(Offset = "0x38")]
	public SpriteAnim[] Buttons;

	// Token: 0x040011F7 RID: 4599
	[Token(Token = "0x40011F7")]
	[FieldOffset(Offset = "0x3C")]
	public AnimationClip BadAnim;

	// Token: 0x040011F8 RID: 4600
	[Token(Token = "0x40011F8")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip ButtonSound;

	// Token: 0x040011F9 RID: 4601
	[Token(Token = "0x40011F9")]
	[FieldOffset(Offset = "0x44")]
	private int MaxState;

	// Token: 0x040011FA RID: 4602
	[Token(Token = "0x40011FA")]
	[FieldOffset(Offset = "0x48")]
	private int[] states;

	// Token: 0x040011FB RID: 4603
	[Token(Token = "0x40011FB")]
	[FieldOffset(Offset = "0x4C")]
	private SpriteAnim prevFixedButton;

	// Token: 0x040011FC RID: 4604
	[Token(Token = "0x40011FC")]
	[FieldOffset(Offset = "0x50")]
	private float changeButtonDelay;

	// Token: 0x040011FD RID: 4605
	[Token(Token = "0x40011FD")]
	[FieldOffset(Offset = "0x54")]
	private int[] drillButtonMaps;
}
