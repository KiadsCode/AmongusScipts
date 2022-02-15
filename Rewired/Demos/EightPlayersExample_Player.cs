using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005CB RID: 1483
	[Token(Token = "0x20005CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE70F0", Offset = "0xE64F0")]
	[Attribute(Name = "RequireComponent", RVA = "0xE70F0", Offset = "0xE64F0")]
	public class EightPlayersExample_Player : MonoBehaviour
	{
		// Token: 0x06002562 RID: 9570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x475090", Offset = "0x474490", VA = "0x10475090")]
		private void Awake()
		{
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x475170", Offset = "0x474570", VA = "0x10475170")]
		private void Initialize()
		{
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x4754D0", Offset = "0x4748D0", VA = "0x104754D0")]
		private void Update()
		{
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x4750D0", Offset = "0x4744D0", VA = "0x104750D0")]
		private void GetInput()
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x4751E0", Offset = "0x4745E0", VA = "0x104751E0")]
		private void ProcessInput()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x475670", Offset = "0x474A70", VA = "0x10475670")]
		public EightPlayersExample_Player()
		{
		}

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x10")]
		public float moveSpeed;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x14")]
		public float bulletSpeed;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bulletPrefab;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x1C")]
		private Player player;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x20")]
		private CharacterController cc;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 moveVector;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x30")]
		private bool fire;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x31")]
		[NonSerialized]
		private bool initialized;
	}
}
