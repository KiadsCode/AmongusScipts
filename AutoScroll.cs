using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
public class AutoScroll : MonoBehaviour
{
	// Token: 0x0600043D RID: 1085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x54F380", Offset = "0x54E780", VA = "0x1054F380")]
	private void Start()
	{
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x54F380", Offset = "0x54E780", VA = "0x1054F380")]
	private void OnEnable()
	{
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x54F3E0", Offset = "0x54E7E0", VA = "0x1054F3E0")]
	private void Update()
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x54F5F0", Offset = "0x54E9F0", VA = "0x1054F5F0")]
	public AutoScroll()
	{
	}

	// Token: 0x04000499 RID: 1177
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0xC")]
	public Transform t;

	// Token: 0x0400049A RID: 1178
	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x10")]
	public float speed;

	// Token: 0x0400049B RID: 1179
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x14")]
	public float stoppingPoint;

	// Token: 0x0400049C RID: 1180
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x18")]
	public float initialDelay;
}
