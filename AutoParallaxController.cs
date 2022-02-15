using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public class AutoParallaxController : MonoBehaviour
{
	// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x54F140", Offset = "0x54E540", VA = "0x1054F140")]
	public void Start()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x54F180", Offset = "0x54E580", VA = "0x1054F180")]
	public void Update()
	{
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x3E9200", Offset = "0x3E8600", VA = "0x103E9200")]
	public AutoParallaxController()
	{
	}

	// Token: 0x04000496 RID: 1174
	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0xC")]
	public ParallaxChild[] Children;

	// Token: 0x04000497 RID: 1175
	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x10")]
	public float XScale;

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x14")]
	public float YScale;
}
