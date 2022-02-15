using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x20005D4")]
	[Attribute(Name = "RequireComponent", RVA = "0xE75A0", Offset = "0xE69A0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE75A0", Offset = "0xE69A0")]
	public class PressStartToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F8")]
		private Player player
		{
			[Token(Token = "0x600259F")]
			[Address(RVA = "0x50EE10", Offset = "0x50E210", VA = "0x1050EE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A0")]
		[Address(RVA = "0x50E980", Offset = "0x50DD80", VA = "0x1050E980")]
		private void OnEnable()
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x50ECB0", Offset = "0x50E0B0", VA = "0x1050ECB0")]
		private void Update()
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x50E8D0", Offset = "0x50DCD0", VA = "0x1050E8D0")]
		private void GetInput()
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x50E9C0", Offset = "0x50DDC0", VA = "0x1050E9C0")]
		private void ProcessInput()
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x475670", Offset = "0x474A70", VA = "0x10475670")]
		public PressStartToJoinExample_GamePlayer()
		{
		}

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0xC")]
		public int gamePlayerId;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x10")]
		public float moveSpeed;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x14")]
		public float bulletSpeed;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bulletPrefab;

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x1C")]
		private CharacterController cc;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 moveVector;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x2C")]
		private bool fire;
	}
}
