using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200047C RID: 1148
[Token(Token = "0x200047C")]
public class OneWayShadows : MonoBehaviour
{
	// Token: 0x0600187E RID: 6270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187E")]
	[Address(RVA = "0x77CD00", Offset = "0x77C100", VA = "0x1077CD00")]
	public void OnEnable()
	{
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x77CC80", Offset = "0x77C080", VA = "0x1077CC80")]
	public void OnDisable()
	{
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x00007A88 File Offset: 0x00005C88
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x77CB70", Offset = "0x77BF70", VA = "0x1077CB70")]
	public bool IsIgnored(LightSource lightSource)
	{
		return default(bool);
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public OneWayShadows()
	{
	}

	// Token: 0x040018A9 RID: 6313
	[Token(Token = "0x40018A9")]
	[FieldOffset(Offset = "0xC")]
	public Collider2D RoomCollider;

	// Token: 0x040018AA RID: 6314
	[Token(Token = "0x40018AA")]
	[FieldOffset(Offset = "0x10")]
	public bool IgnoreImpostor;
}
