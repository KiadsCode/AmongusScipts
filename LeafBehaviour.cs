using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000292 RID: 658
[Token(Token = "0x2000292")]
public class LeafBehaviour : MonoBehaviour
{
	// Token: 0x06000E93 RID: 3731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x6DA680", Offset = "0x6D9A80", VA = "0x106DA680")]
	public void Start()
	{
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x6DA620", Offset = "0x6D9A20", VA = "0x106DA620")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x6DA930", Offset = "0x6D9D30", VA = "0x106DA930")]
	public LeafBehaviour()
	{
	}

	// Token: 0x04000EA5 RID: 3749
	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0xC")]
	public Sprite[] Images;

	// Token: 0x04000EA6 RID: 3750
	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x10")]
	public FloatRange SpinSpeed;

	// Token: 0x04000EA7 RID: 3751
	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x14")]
	public Vector2Range StartVel;

	// Token: 0x04000EA8 RID: 3752
	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x24")]
	public float AccelRate;

	// Token: 0x04000EA9 RID: 3753
	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public LeafMinigame Parent;

	// Token: 0x04000EAA RID: 3754
	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x2C")]
	public bool Held;

	// Token: 0x04000EAB RID: 3755
	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x0")]
	private static RandomFill<Sprite> ImageFiller;

	// Token: 0x04000EAC RID: 3756
	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Rigidbody2D body;
}
