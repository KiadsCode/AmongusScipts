using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE6E60", Offset = "0xE6260")]
	[Attribute(Name = "RequireComponent", RVA = "0xE6E60", Offset = "0xE6260")]
	public class CustomControllerDemo_Player : MonoBehaviour
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F2")]
		private Player player
		{
			[Token(Token = "0x600253B")]
			[Address(RVA = "0x5BF2F0", Offset = "0x5BE6F0", VA = "0x105BF2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x5BEDD0", Offset = "0x5BE1D0", VA = "0x105BEDD0")]
		private void Awake()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x5BEE10", Offset = "0x5BE210", VA = "0x105BEE10")]
		private void Update()
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x5BF2C0", Offset = "0x5BE6C0", VA = "0x105BF2C0")]
		public CustomControllerDemo_Player()
		{
		}

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x10")]
		public float speed;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x14")]
		public float bulletSpeed;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bulletPrefab;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x1C")]
		private Player _player;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x20")]
		private CharacterController cc;
	}
}
