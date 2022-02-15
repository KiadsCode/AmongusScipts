using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class FallbackJoystickIdentificationDemo : MonoBehaviour
	{
		// Token: 0x06002568 RID: 9576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x3A5490", Offset = "0x3A4890", VA = "0x103A5490")]
		private void Awake()
		{
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x3A5850", Offset = "0x3A4C50", VA = "0x103A5850")]
		private void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x3A5850", Offset = "0x3A4C50", VA = "0x103A5850")]
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x3A5750", Offset = "0x3A4B50", VA = "0x103A5750")]
		public void IdentifyAllJoysticks()
		{
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x3A5AE0", Offset = "0x3A4EE0", VA = "0x103A5AE0")]
		private void SetInputDelay()
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x3A5870", Offset = "0x3A4C70", VA = "0x103A5870")]
		private void OnGUI()
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x3A5590", Offset = "0x3A4990", VA = "0x103A5590")]
		private void DrawDialogWindow(int windowId)
		{
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256F")]
		[Address(RVA = "0x3A5AC0", Offset = "0x3A4EC0", VA = "0x103A5AC0")]
		private void Reset()
		{
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public FallbackJoystickIdentificationDemo()
		{
		}

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		private const float windowWidth = 250f;

		// Token: 0x040024F6 RID: 9462
		[Token(Token = "0x40024F6")]
		private const float windowHeight = 250f;

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		private const float inputDelay = 1f;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0xC")]
		private bool identifyRequired;

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x10")]
		private Queue<Joystick> joysticksToIdentify;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x14")]
		private float nextInputAllowedTime;

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x18")]
		private GUIStyle style;
	}
}
