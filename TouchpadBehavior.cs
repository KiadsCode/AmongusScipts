using System;
using Il2CppDummyDll;
using Rewired.ControllerExtensions;
using UnityEngine;

// Token: 0x02000394 RID: 916
[Token(Token = "0x2000394")]
public class TouchpadBehavior : MonoBehaviour
{
	// Token: 0x06001395 RID: 5013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x4AFEC0", Offset = "0x4AF2C0", VA = "0x104AFEC0")]
	private void Start()
	{
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001396")]
	[Address(RVA = "0x4AFDF0", Offset = "0x4AF1F0", VA = "0x104AFDF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x4AFCC0", Offset = "0x4AF0C0", VA = "0x104AFCC0")]
	private void GetExtension()
	{
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x4B0060", Offset = "0x4AF460", VA = "0x104B0060")]
	private void Update()
	{
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x6001399")]
	[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0")]
	public bool IsTouching()
	{
		return default(bool);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x4AFDE0", Offset = "0x4AF1E0", VA = "0x104AFDE0")]
	public bool IsFirstTouch()
	{
		return default(bool);
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x4AFEB0", Offset = "0x4AF2B0", VA = "0x104AFEB0")]
	public void ResetTouch()
	{
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x000067F8 File Offset: 0x000049F8
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x4AFDA0", Offset = "0x4AF1A0", VA = "0x104AFDA0")]
	public Vector2 GetTouchVector()
	{
		return default(Vector2);
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x4AFC80", Offset = "0x4AF080", VA = "0x104AFC80")]
	public Vector2 GetCenterToTouch()
	{
		return default(Vector2);
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x4B01C0", Offset = "0x4AF5C0", VA = "0x104B01C0")]
	public TouchpadBehavior()
	{
	}

	// Token: 0x040013D6 RID: 5078
	[Token(Token = "0x40013D6")]
	[FieldOffset(Offset = "0xC")]
	private float aspect;

	// Token: 0x040013D7 RID: 5079
	[Token(Token = "0x40013D7")]
	[FieldOffset(Offset = "0x10")]
	private bool touching;

	// Token: 0x040013D8 RID: 5080
	[Token(Token = "0x40013D8")]
	[FieldOffset(Offset = "0x11")]
	private bool firstTouch;

	// Token: 0x040013D9 RID: 5081
	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 toCenter;

	// Token: 0x040013DA RID: 5082
	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 firstTouchPos;

	// Token: 0x040013DB RID: 5083
	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 delta;

	// Token: 0x040013DC RID: 5084
	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 fromCenter;

	// Token: 0x040013DD RID: 5085
	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x34")]
	private IDualShock4Extension ds4;

	// Token: 0x040013DE RID: 5086
	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x38")]
	public float touchpadSensitivity;
}
