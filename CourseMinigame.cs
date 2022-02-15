using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000320 RID: 800
[Token(Token = "0x2000320")]
public class CourseMinigame : Minigame
{
	// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x5B6520", Offset = "0x5B5920", VA = "0x105B6520", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	[Address(RVA = "0x5B6B30", Offset = "0x5B5F30", VA = "0x105B6B30")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x5B7B10", Offset = "0x5B6F10", VA = "0x105B7B10")]
	private void SetLineDivision(float curVec)
	{
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x5B7D20", Offset = "0x5B7120", VA = "0x105B7D20")]
	public CourseMinigame()
	{
	}

	// Token: 0x0400117A RID: 4474
	[Token(Token = "0x400117A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CourseStarBehaviour StarPrefab;

	// Token: 0x0400117B RID: 4475
	[Token(Token = "0x400117B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public CourseStarBehaviour[] Stars;

	// Token: 0x0400117C RID: 4476
	[Token(Token = "0x400117C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public SpriteRenderer DotPrefab;

	// Token: 0x0400117D RID: 4477
	[Token(Token = "0x400117D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Sprite DotLight;

	// Token: 0x0400117E RID: 4478
	[Token(Token = "0x400117E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SpriteRenderer[] Dots;

	// Token: 0x0400117F RID: 4479
	[Token(Token = "0x400117F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Collider2D Ship;

	// Token: 0x04001180 RID: 4480
	[Token(Token = "0x4001180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CourseStarBehaviour Destination;

	// Token: 0x04001181 RID: 4481
	[Token(Token = "0x4001181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3[] PathPoints;

	// Token: 0x04001182 RID: 4482
	[Token(Token = "0x4001182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int NumPoints;

	// Token: 0x04001183 RID: 4483
	[Token(Token = "0x4001183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public FloatRange XRange;

	// Token: 0x04001184 RID: 4484
	[Token(Token = "0x4001184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public FloatRange YRange;

	// Token: 0x04001185 RID: 4485
	[Token(Token = "0x4001185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public LineRenderer Path;

	// Token: 0x04001186 RID: 4486
	[Token(Token = "0x4001186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Controller myController;

	// Token: 0x04001187 RID: 4487
	[Token(Token = "0x4001187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float lineTimer;

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4001188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private CourseMinigame.UIntFloat Converter;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4001189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public AudioClip SetCourseSound;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x400118A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioClip SetCourseLastSound;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x400118B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private TouchpadBehavior touchpad;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x400118C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float initialCurVec;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x400118D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float targetCurVec;

	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	[StructLayout(2)]
	private struct UIntFloat
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x78E3C0", Offset = "0x78D7C0", VA = "0x1078E3C0")]
		public float GetFloat(byte[] bytes)
		{
			return 0f;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x78E330", Offset = "0x78D730", VA = "0x1078E330")]
		public void GetBytes(float value, byte[] bytes)
		{
		}

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float FloatValue;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int IntValue;
	}
}
