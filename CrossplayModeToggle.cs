using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class CrossplayModeToggle : MonoBehaviour
{
	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x5BA300", Offset = "0x5B9700", VA = "0x105BA300")]
	public void OnEnable()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x5BA310", Offset = "0x5B9710", VA = "0x105BA310")]
	public void SetAll()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x5BA370", Offset = "0x5B9770", VA = "0x105BA370")]
	public void SetCurrent()
	{
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x5BA3D0", Offset = "0x5B97D0", VA = "0x105BA3D0")]
	public void UpdateDisplay()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CrossplayModeToggle()
	{
	}

	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x4000B04")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer allPlatformsSprite;

	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x4000B05")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer currentPlatformSprite;
}
