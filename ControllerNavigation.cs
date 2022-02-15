using System;
using Il2CppDummyDll;

// Token: 0x0200037B RID: 891
[Token(Token = "0x200037B")]
[Serializable]
public struct ControllerNavigation
{
	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x06001340 RID: 4928 RVA: 0x000066D8 File Offset: 0x000048D8
	[Token(Token = "0x170002D2")]
	public static ControllerNavigation defaultNavigation
	{
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x7FB2C0", Offset = "0x7FA6C0", VA = "0x107FB2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(ControllerNavigation);
		}
	}

	// Token: 0x0400137C RID: 4988
	[Token(Token = "0x400137C")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private static readonly ControllerNavigation <defaultNavigation>k__BackingField;

	// Token: 0x0400137D RID: 4989
	[Token(Token = "0x400137D")]
	[FieldOffset(Offset = "0x0")]
	public ControllerNavigation.Mode mode;

	// Token: 0x0400137E RID: 4990
	[Token(Token = "0x400137E")]
	[FieldOffset(Offset = "0x4")]
	public UiElement selectOnUp;

	// Token: 0x0400137F RID: 4991
	[Token(Token = "0x400137F")]
	[FieldOffset(Offset = "0x8")]
	public UiElement selectOnDown;

	// Token: 0x04001380 RID: 4992
	[Token(Token = "0x4001380")]
	[FieldOffset(Offset = "0xC")]
	public UiElement selectOnLeft;

	// Token: 0x04001381 RID: 4993
	[Token(Token = "0x4001381")]
	[FieldOffset(Offset = "0x10")]
	public UiElement selectOnRight;

	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public enum Mode
	{
		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		Automatic,
		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		Explicit
	}
}
