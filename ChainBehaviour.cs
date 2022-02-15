using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000481 RID: 1153
[Token(Token = "0x2000481")]
public class ChainBehaviour : MonoBehaviour
{
	// Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001890")]
	[Address(RVA = "0x830830", Offset = "0x82FC30", VA = "0x10830830")]
	public void Awake()
	{
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001891")]
	[Address(RVA = "0x8308D0", Offset = "0x82FCD0", VA = "0x108308D0")]
	public void Update()
	{
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001892")]
	[Address(RVA = "0x830980", Offset = "0x82FD80", VA = "0x10830980")]
	public ChainBehaviour()
	{
	}

	// Token: 0x040018B7 RID: 6327
	[Token(Token = "0x40018B7")]
	[FieldOffset(Offset = "0xC")]
	public FloatRange SwingRange;

	// Token: 0x040018B8 RID: 6328
	[Token(Token = "0x40018B8")]
	[FieldOffset(Offset = "0x10")]
	public float SwingPeriod;

	// Token: 0x040018B9 RID: 6329
	[Token(Token = "0x40018B9")]
	[FieldOffset(Offset = "0x14")]
	public float swingTime;

	// Token: 0x040018BA RID: 6330
	[Token(Token = "0x40018BA")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 vec;
}
