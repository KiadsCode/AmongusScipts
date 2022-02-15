using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005C3 RID: 1475
	[Token(Token = "0x20005C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CustomControllersTiltDemo : MonoBehaviour
	{
		// Token: 0x0600252C RID: 9516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252C")]
		[Address(RVA = "0x5BF500", Offset = "0x5BE900", VA = "0x105BF500")]
		private void Awake()
		{
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x5BF6A0", Offset = "0x5BEAA0", VA = "0x105BF6A0")]
		private void Update()
		{
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252E")]
		[Address(RVA = "0x5BF610", Offset = "0x5BEA10", VA = "0x105BF610")]
		private void OnInputUpdate()
		{
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252F")]
		[Address(RVA = "0x5BF840", Offset = "0x5BEC40", VA = "0x105BF840")]
		public CustomControllersTiltDemo()
		{
		}

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0xC")]
		public Transform target;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x10")]
		public float speed;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x14")]
		private CustomController controller;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x18")]
		private Player player;
	}
}
