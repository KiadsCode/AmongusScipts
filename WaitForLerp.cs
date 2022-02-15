using System;
using System.Collections;
using Il2CppDummyDll;

// Token: 0x02000113 RID: 275
[Token(Token = "0x2000113")]
public class WaitForLerp : IEnumerator
{
	// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x7B4F80", Offset = "0x7B4380", VA = "0x107B4F80")]
	public WaitForLerp(float seconds, Action<float> act)
	{
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F4")]
	public object Current
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x7B4EC0", Offset = "0x7B42C0", VA = "0x107B4EC0", Slot = "4")]
	public bool MoveNext()
	{
		return default(bool);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x7B4F70", Offset = "0x7B4370", VA = "0x107B4F70", Slot = "6")]
	public void Reset()
	{
	}

	// Token: 0x04000668 RID: 1640
	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x8")]
	private float duration;

	// Token: 0x04000669 RID: 1641
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0xC")]
	private float timer;

	// Token: 0x0400066A RID: 1642
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x10")]
	private Action<float> act;
}
