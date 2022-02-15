using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
public class LoadingMarquee : MonoBehaviour
{
	// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019C")]
	[Address(RVA = "0x6E24B0", Offset = "0x6E18B0", VA = "0x106E24B0")]
	public void Start()
	{
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019D")]
	[Address(RVA = "0x6E25C0", Offset = "0x6E19C0", VA = "0x106E25C0")]
	public void Update()
	{
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600019E")]
	[Address(RVA = "0x6E2690", Offset = "0x6E1A90", VA = "0x106E2690")]
	public LoadingMarquee()
	{
	}

	// Token: 0x04000128 RID: 296
	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0xC")]
	public float duration;

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x10")]
	public float distanceFromBottom;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x14")]
	private FloatRange XRange;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x18")]
	private float timer;
}
