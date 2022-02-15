using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A7 RID: 1191
[Token(Token = "0x20004A7")]
public class PlainShipRoom : MonoBehaviour
{
	// Token: 0x06001951 RID: 6481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlainShipRoom()
	{
	}

	// Token: 0x04001950 RID: 6480
	[Token(Token = "0x4001950")]
	[FieldOffset(Offset = "0xC")]
	public SystemTypes RoomId;

	// Token: 0x04001951 RID: 6481
	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x10")]
	public SurvCamera survCamera;

	// Token: 0x04001952 RID: 6482
	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x14")]
	public Collider2D roomArea;
}
