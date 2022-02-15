using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035E RID: 862
[Token(Token = "0x200035E")]
public class ConditionalMove : MonoBehaviour
{
	// Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x4209C0", Offset = "0x41FDC0", VA = "0x104209C0")]
	private void Awake()
	{
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x420AD0", Offset = "0x41FED0", VA = "0x10420AD0")]
	public ConditionalMove()
	{
	}

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0xC")]
	public ConditionalMove.MoveForPlatforms[] moveForPlatforms;

	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	[Serializable]
	public struct MoveForPlatforms
	{
		// Token: 0x0400130C RID: 4876
		[Token(Token = "0x400130C")]
		[FieldOffset(Offset = "0x0")]
		public RuntimePlatform runtimePlatform;

		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 offset;
	}
}
