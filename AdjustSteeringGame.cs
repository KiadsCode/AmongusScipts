using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007B RID: 123
[Token(Token = "0x200007B")]
public class AdjustSteeringGame : Minigame
{
	// Token: 0x06000322 RID: 802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000322")]
	[Address(RVA = "0x5428C0", Offset = "0x541CC0", VA = "0x105428C0")]
	public void HonkHorn()
	{
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x542590", Offset = "0x541990", VA = "0x10542590", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000324")]
	[Address(RVA = "0x542940", Offset = "0x541D40", VA = "0x10542940")]
	private void OnDisable()
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x542A00", Offset = "0x541E00", VA = "0x10542A00")]
	private void UpdateControllerIsDualshock()
	{
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x542B90", Offset = "0x541F90", VA = "0x10542B90")]
	public void Update()
	{
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000327")]
	[Address(RVA = "0x543680", Offset = "0x542A80", VA = "0x10543680")]
	public AdjustSteeringGame()
	{
	}

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	private const float ArrowOffset = -3.25f;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	private const float ThrustOffset = -2.15f;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly FloatRange ThrustRange;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x4")]
	private static readonly FloatRange SteeringRange;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x30")]
	public Collider2D Thrust;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x34")]
	public Collider2D Steering;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer ThrustTarget;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x3C")]
	public SpriteRenderer SteeringTarget;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x40")]
	private Controller controller;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x44")]
	private float TargetThrustY;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x48")]
	private float TargetSteeringRot;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x4C")]
	private bool thrustLocked;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x4D")]
	private bool steeringLocked;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x50")]
	private float startAngle;

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip HornSound;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x58")]
	private bool prevHadLeftInput;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x59")]
	private bool prevHadRightInput;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 prevRightStickInput;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x64")]
	private bool prevThrustWasGood;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x65")]
	private bool prevSteeringWasGood;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x66")]
	private bool playerHasDualshock;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	private const float rotationSensitivity = 0.035f;

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	private const float hintVibrationIntensity = 0.5f;
}
