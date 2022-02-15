using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class DualShock4SpecialFeaturesExample : MonoBehaviour
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F5")]
		private Player player
		{
			[Token(Token = "0x6002553")]
			[Address(RVA = "0x46D6D0", Offset = "0x46CAD0", VA = "0x1046D6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x46C030", Offset = "0x46B430", VA = "0x1046C030")]
		private void Awake()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x46D0A0", Offset = "0x46C4A0", VA = "0x1046D0A0")]
		private void Update()
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x46C990", Offset = "0x46BD90", VA = "0x1046C990")]
		private void OnGUI()
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x46CE20", Offset = "0x46C220", VA = "0x1046CE20")]
		private void ResetOrientation()
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x46CE70", Offset = "0x46C270", VA = "0x1046CE70")]
		private void SetRandomLightColor()
		{
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x46CFD0", Offset = "0x46C3D0", VA = "0x1046CFD0")]
		private void StartLightFlash()
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x46D040", Offset = "0x46C440", VA = "0x1046D040")]
		private void StopLightFlash()
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x46C040", Offset = "0x46B440", VA = "0x1046C040")]
		private IDualShock4Extension GetFirstDS4(Player player)
		{
			return null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x46C780", Offset = "0x46BB80", VA = "0x1046C780")]
		private void InitializeTouchObjects()
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x46C2D0", Offset = "0x46B6D0", VA = "0x1046C2D0")]
		private void HandleTouchpad(IDualShock4Extension ds4)
		{
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public DualShock4SpecialFeaturesExample()
		{
		}

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		private const int maxTouches = 2;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		[FieldOffset(Offset = "0x10")]
		public Transform touchpadTransform;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x14")]
		public GameObject lightObject;

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x18")]
		public Transform accelerometerTransform;

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x1C")]
		private List<DualShock4SpecialFeaturesExample.Touch> touches;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x20")]
		private Queue<DualShock4SpecialFeaturesExample.Touch> unusedTouches;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x24")]
		private bool isFlashing;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x28")]
		private GUIStyle textStyle;

		// Token: 0x020005C9 RID: 1481
		[Token(Token = "0x20005C9")]
		private class Touch
		{
			// Token: 0x0600255F RID: 9567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x781740", Offset = "0x780B40", VA = "0x10781740")]
			public Touch()
			{
			}

			// Token: 0x040024E9 RID: 9449
			[Token(Token = "0x40024E9")]
			[FieldOffset(Offset = "0x8")]
			public GameObject go;

			// Token: 0x040024EA RID: 9450
			[Token(Token = "0x40024EA")]
			[FieldOffset(Offset = "0xC")]
			public int touchId;
		}

		// Token: 0x020005CA RID: 1482
		[Token(Token = "0x20005CA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06002560 RID: 9568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002560")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06002561 RID: 9569 RVA: 0x0000B2C8 File Offset: 0x000094C8
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x5B57A0", Offset = "0x5B4BA0", VA = "0x105B57A0")]
			internal bool <HandleTouchpad>b__0(DualShock4SpecialFeaturesExample.Touch x)
			{
				return default(bool);
			}

			// Token: 0x040024EB RID: 9451
			[Token(Token = "0x40024EB")]
			[FieldOffset(Offset = "0x8")]
			public int touchId;
		}
	}
}
