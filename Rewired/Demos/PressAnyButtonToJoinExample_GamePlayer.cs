using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE7530", Offset = "0xE6930")]
	[Attribute(Name = "RequireComponent", RVA = "0xE7530", Offset = "0xE6930")]
	public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F7")]
		private Player player
		{
			[Token(Token = "0x6002592")]
			[Address(RVA = "0x50E230", Offset = "0x50D630", VA = "0x1050E230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x50DDB0", Offset = "0x50D1B0", VA = "0x1050DDB0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x50E0E0", Offset = "0x50D4E0", VA = "0x1050E0E0")]
		private void Update()
		{
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x50DD00", Offset = "0x50D100", VA = "0x1050DD00")]
		private void GetInput()
		{
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x50DDF0", Offset = "0x50D1F0", VA = "0x1050DDF0")]
		private void ProcessInput()
		{
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x475670", Offset = "0x474A70", VA = "0x10475670")]
		public PressAnyButtonToJoinExample_GamePlayer()
		{
		}

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x4002510")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x10")]
		public float moveSpeed;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x14")]
		public float bulletSpeed;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bulletPrefab;

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x1C")]
		private CharacterController cc;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 moveVector;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x2C")]
		private bool fire;
	}
}
