using System;
using Il2CppDummyDll;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
public static class ResolutionManager
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
	// (remove) Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x14000001")]
	public static event Action<float> ResolutionChanged
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4F62F0", Offset = "0x4F56F0", VA = "0x104F62F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		add
		{
		}
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4F6380", Offset = "0x4F5780", VA = "0x104F6380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		remove
		{
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000631")]
	[Address(RVA = "0x4F6120", Offset = "0x4F5520", VA = "0x104F6120")]
	public static void SetResolution(int width, int height, bool fullscreen)
	{
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x4F6190", Offset = "0x4F5590", VA = "0x104F6190")]
	public static void ToggleFullscreen()
	{
	}
}
