using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PowerTools
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public class SpriteAnimNodeSync : MonoBehaviour
	{
		// Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x4A67D0", Offset = "0x4A5BD0", VA = "0x104A67D0")]
		public void LateUpdate()
		{
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public SpriteAnimNodeSync()
		{
		}

		// Token: 0x040025AC RID: 9644
		[Token(Token = "0x40025AC")]
		[FieldOffset(Offset = "0xC")]
		public int NodeId;

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		[FieldOffset(Offset = "0x10")]
		public SpriteAnimNodes Parent;

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		[FieldOffset(Offset = "0x14")]
		public SpriteRenderer ParentRenderer;

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer Renderer;
	}
}
