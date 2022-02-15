using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Rewired;
using Rewired.Internal;
using UnityEngine;

// Token: 0x0200042F RID: 1071
[Token(Token = "0x200042F")]
public class DebugTest : MonoBehaviour
{
	// Token: 0x06001693 RID: 5779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001693")]
	[Address(RVA = "0x5C3210", Offset = "0x5C2610", VA = "0x105C3210")]
	private void Awake()
	{
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001694")]
	[Address(RVA = "0x5C3B50", Offset = "0x5C2F50", VA = "0x105C3B50")]
	private void Update()
	{
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x5C33B0", Offset = "0x5C27B0", VA = "0x105C33B0")]
	private void Log(object text)
	{
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x5C33E0", Offset = "0x5C27E0", VA = "0x105C33E0")]
	private void Log(byte[] buffer)
	{
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001697")]
	[Address(RVA = "0x5C32B0", Offset = "0x5C26B0", VA = "0x105C32B0")]
	private void LogLine([Optional] object text)
	{
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x5C3310", Offset = "0x5C2710", VA = "0x105C3310")]
	private void LogLine(string prefix, object text)
	{
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x5C3470", Offset = "0x5C2870", VA = "0x105C3470")]
	private void Log(Joystick joy)
	{
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x5C3E70", Offset = "0x5C3270", VA = "0x105C3E70")]
	public DebugTest()
	{
	}

	// Token: 0x040016F4 RID: 5876
	[Token(Token = "0x40016F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private GUIText _guiText;

	// Token: 0x040016F5 RID: 5877
	[Token(Token = "0x40016F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private StringBuilder _sb;

	// Token: 0x040016F6 RID: 5878
	[Token(Token = "0x40016F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private byte[] deviceIdBuffer;
}
