using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001D9 RID: 473
[Token(Token = "0x20001D9")]
public class UseButton : ActionButton
{
	// Token: 0x06000A9E RID: 2718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x4B91B0", Offset = "0x4B85B0", VA = "0x104B91B0")]
	public void Awake()
	{
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x4B94B0", Offset = "0x4B88B0", VA = "0x104B94B0")]
	public void SetTarget(IUsable target)
	{
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x4B92A0", Offset = "0x4B86A0", VA = "0x104B92A0", Slot = "4")]
	public override void DoClick()
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x4B9380", Offset = "0x4B8780", VA = "0x104B9380")]
	public void Refresh()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x4B93A0", Offset = "0x4B87A0", VA = "0x104B93A0")]
	private void SetFromSettings(UseButtonSettings settings)
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public UseButton()
	{
	}

	// Token: 0x04000AAE RID: 2734
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x2C")]
	public UseButtonSettings[] UseSettings;

	// Token: 0x04000AAF RID: 2735
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ImageNames, UseButtonSettings> fastUseSettings;

	// Token: 0x04000AB0 RID: 2736
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x34")]
	private IUsable currentTarget;

	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x3700E0", Offset = "0x36F4E0", VA = "0x103700E0")]
		internal ImageNames <Awake>b__3_0(UseButtonSettings t)
		{
			return ImageNames.LocalButton;
		}

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UseButton.<>c <>9;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x4")]
		public static Func<UseButtonSettings, ImageNames> <>9__3_0;
	}
}
