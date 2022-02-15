using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C4 RID: 452
[Token(Token = "0x20001C4")]
public class AspectPosition : MonoBehaviour
{
	// Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0x54C940", Offset = "0x54BD40", VA = "0x1054C940")]
	public void Update()
	{
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0x54C770", Offset = "0x54BB70", VA = "0x1054C770")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0x54C830", Offset = "0x54BC30", VA = "0x1054C830")]
	internal void SetNormalizedX(float nx, float widthPadding)
	{
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0x54C700", Offset = "0x54BB00", VA = "0x1054C700")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3F")]
	[Address(RVA = "0x54C240", Offset = "0x54B640", VA = "0x1054C240")]
	public void AdjustPosition()
	{
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x54C120", Offset = "0x54B520", VA = "0x1054C120")]
	public void AdjustPosition(float aspect)
	{
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x54C5C0", Offset = "0x54B9C0", VA = "0x1054C5C0")]
	public static Vector3 ComputeWorldPosition(Camera cam, AspectPosition.EdgeAlignments alignment, Vector3 relativePos)
	{
		return default(Vector3);
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x54C4A0", Offset = "0x54B8A0", VA = "0x1054C4A0")]
	public static Vector3 ComputePosition(AspectPosition.EdgeAlignments alignment, Vector3 relativePos)
	{
		return default(Vector3);
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x54C420", Offset = "0x54B820", VA = "0x1054C420")]
	public static Vector3 ComputePosition(AspectPosition.EdgeAlignments alignment, Vector3 relativePos, float cHeight, float aspect)
	{
		return default(Vector3);
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public AspectPosition()
	{
	}

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0xC")]
	public Camera parentCam;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	private const int LeftFlag = 1;

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	private const int RightFlag = 2;

	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	private const int BottomFlag = 4;

	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	private const int TopFlag = 8;

	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x10")]
	public bool updateAlways;

	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 DistanceFromEdge;

	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x20")]
	public AspectPosition.EdgeAlignments Alignment;

	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	public enum EdgeAlignments
	{
		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		RightBottom = 6,
		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		LeftBottom = 5,
		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		RightTop = 10,
		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		Left = 1,
		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		Right,
		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		Top = 8,
		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		Bottom = 4,
		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		LeftTop = 9
	}
}
