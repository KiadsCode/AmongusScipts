using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class Bullet : MonoBehaviour
	{
		// Token: 0x060025A5 RID: 9637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x829DD0", Offset = "0x8291D0", VA = "0x10829DD0")]
		private void Start()
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x829E10", Offset = "0x829210", VA = "0x10829E10")]
		private void Update()
		{
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x829E90", Offset = "0x829290", VA = "0x10829E90")]
		public Bullet()
		{
		}

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0xC")]
		public float lifeTime;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x10")]
		private bool die;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x14")]
		private float deathTime;
	}
}
