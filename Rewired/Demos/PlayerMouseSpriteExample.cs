using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class PlayerMouseSpriteExample : MonoBehaviour
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x501570", Offset = "0x500970", VA = "0x10501570")]
		private void Awake()
		{
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x501CA0", Offset = "0x5010A0", VA = "0x10501CA0")]
		private void Update()
		{
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x501B00", Offset = "0x500F00", VA = "0x10501B00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x501940", Offset = "0x500D40", VA = "0x10501940")]
		private void CreateClickEffect(Color color)
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x501BF0", Offset = "0x500FF0", VA = "0x10501BF0")]
		private void OnScreenPositionChanged(Vector2 position)
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x501F60", Offset = "0x501360", VA = "0x10501F60")]
		public PlayerMouseSpriteExample()
		{
		}

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0xC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7200", Offset = "0xE6600")]
		public int playerId;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7230", Offset = "0xE6630")]
		public string horizontalAction;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7260", Offset = "0xE6660")]
		public string verticalAction;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7290", Offset = "0xE6690")]
		public string wheelAction;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE72C0", Offset = "0xE66C0")]
		public string leftButtonAction;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE72F0", Offset = "0xE66F0")]
		public string rightButtonAction;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7320", Offset = "0xE6720")]
		public string middleButtonAction;

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7350", Offset = "0xE6750")]
		public float distanceFromCamera;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7380", Offset = "0xE6780")]
		public float spriteScale;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE73B0", Offset = "0xE67B0")]
		public GameObject pointerPrefab;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE73E0", Offset = "0xE67E0")]
		public GameObject clickEffectPrefab;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE7410", Offset = "0xE6810")]
		public bool hideHardwarePointer;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0x3C")]
		[NonSerialized]
		private GameObject pointer;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private PlayerMouse mouse;
	}
}
