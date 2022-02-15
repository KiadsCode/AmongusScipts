using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200046D RID: 1133
[Token(Token = "0x200046D")]
public class ResolutionSlider : MonoBehaviour
{
	// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x4F6410", Offset = "0x4F5810", VA = "0x104F6410")]
	public void OnEnable()
	{
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x4F68D0", Offset = "0x4F5CD0", VA = "0x104F68D0")]
	public void ToggleVSync()
	{
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x4F68A0", Offset = "0x4F5CA0", VA = "0x104F68A0")]
	public void ToggleFullscreen()
	{
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x4F6700", Offset = "0x4F5B00", VA = "0x104F6700")]
	public void OnResChange()
	{
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x4F6860", Offset = "0x4F5C60", VA = "0x104F6860")]
	public void SaveChange()
	{
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ResolutionSlider()
	{
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x00007980 File Offset: 0x00005B80
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x4F6990", Offset = "0x4F5D90", VA = "0x104F6990")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <OnEnable>b__8_1(Resolution e)
	{
		return default(bool);
	}

	// Token: 0x04001852 RID: 6226
	[Token(Token = "0x4001852")]
	[FieldOffset(Offset = "0xC")]
	private int targetIdx;

	// Token: 0x04001853 RID: 6227
	[Token(Token = "0x4001853")]
	[FieldOffset(Offset = "0x10")]
	private Resolution targetResolution;

	// Token: 0x04001854 RID: 6228
	[Token(Token = "0x4001854")]
	[FieldOffset(Offset = "0x1C")]
	private bool targetFullscreen;

	// Token: 0x04001855 RID: 6229
	[Token(Token = "0x4001855")]
	[FieldOffset(Offset = "0x20")]
	private Resolution[] allResolutions;

	// Token: 0x04001856 RID: 6230
	[Token(Token = "0x4001856")]
	[FieldOffset(Offset = "0x24")]
	public SlideBar slider;

	// Token: 0x04001857 RID: 6231
	[Token(Token = "0x4001857")]
	[FieldOffset(Offset = "0x28")]
	public ToggleButtonBehaviour Fullscreen;

	// Token: 0x04001858 RID: 6232
	[Token(Token = "0x4001858")]
	[FieldOffset(Offset = "0x2C")]
	public ToggleButtonBehaviour VSync;

	// Token: 0x04001859 RID: 6233
	[Token(Token = "0x4001859")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro Display;

	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x370760", Offset = "0x36FB60", VA = "0x10370760")]
		internal bool <OnEnable>b__8_0(Resolution r)
		{
			return default(bool);
		}

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ResolutionSlider.<>c <>9;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x4")]
		public static Func<Resolution, bool> <>9__8_0;
	}
}
