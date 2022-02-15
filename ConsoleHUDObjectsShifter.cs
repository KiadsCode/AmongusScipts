using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E8 RID: 488
[Token(Token = "0x20001E8")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xDD960", Offset = "0xDCD60")]
public class ConsoleHUDObjectsShifter : MonoBehaviour
{
	// Token: 0x06000AEC RID: 2796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x4216A0", Offset = "0x420AA0", VA = "0x104216A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x4215D0", Offset = "0x4209D0", VA = "0x104215D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x4216F0", Offset = "0x420AF0", VA = "0x104216F0")]
	private void Update()
	{
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ConsoleHUDObjectsShifter()
	{
	}

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[FieldOffset(Offset = "0xC")]
	private Camera cam;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x10")]
	private Vector2 screenBounds;

	// Token: 0x04000B01 RID: 2817
	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0x0")]
	private static int instanceCount;
}
