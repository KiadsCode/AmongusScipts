using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
public class DragSlot : MonoBehaviour
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060003EF RID: 1007 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x17000093")]
	public Vector3 TargetPosition
	{
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x469FC0", Offset = "0x4693C0", VA = "0x10469FC0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DragSlot()
	{
	}

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 Offset;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x18")]
	public Behaviour Occupant;
}
