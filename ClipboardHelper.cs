using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000257 RID: 599
[Token(Token = "0x2000257")]
public static class ClipboardHelper
{
	// Token: 0x06000D6F RID: 3439
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x41F4A0", Offset = "0x41E8A0", VA = "0x1041F4A0")]
	[PreserveSig]
	private static extern bool IsClipboardFormatAvailable(uint format);

	// Token: 0x06000D70 RID: 3440
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x41F510", Offset = "0x41E910", VA = "0x1041F510")]
	[PreserveSig]
	private static extern bool OpenClipboard(IntPtr hWndNewOwner);

	// Token: 0x06000D71 RID: 3441
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x41EEC0", Offset = "0x41E2C0", VA = "0x1041EEC0")]
	[PreserveSig]
	private static extern bool CloseClipboard();

	// Token: 0x06000D72 RID: 3442
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x41EF20", Offset = "0x41E320", VA = "0x1041EF20")]
	[PreserveSig]
	private static extern IntPtr GetClipboardData(uint format);

	// Token: 0x06000D73 RID: 3443
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x41F380", Offset = "0x41E780", VA = "0x1041F380")]
	[PreserveSig]
	private static extern IntPtr GlobalLock(IntPtr hMem);

	// Token: 0x06000D74 RID: 3444
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x41F440", Offset = "0x41E840", VA = "0x1041F440")]
	[PreserveSig]
	private static extern bool GlobalUnlock(IntPtr hMem);

	// Token: 0x06000D75 RID: 3445
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x41F3E0", Offset = "0x41E7E0", VA = "0x1041F3E0")]
	[PreserveSig]
	private static extern int GlobalSize(IntPtr hMem);

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x41EF80", Offset = "0x41E380", VA = "0x1041EF80")]
	public static string GetClipboardString()
	{
		return null;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x41F570", Offset = "0x41E970", VA = "0x1041F570")]
	public static void PutClipboardString(string str)
	{
	}

	// Token: 0x04000D4E RID: 3406
	[Token(Token = "0x4000D4E")]
	private const uint CF_TEXT = 1U;
}
