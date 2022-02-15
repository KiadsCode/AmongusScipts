using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CustomControllerDemo : MonoBehaviour
	{
		// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x5BE720", Offset = "0x5BDB20", VA = "0x105BE720")]
		private void Awake()
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x5BE8F0", Offset = "0x5BDCF0", VA = "0x105BE8F0")]
		private void Initialize()
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x5BF450", Offset = "0x5BE850", VA = "0x105BF450")]
		private void Update()
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x5BEC00", Offset = "0x5BE000", VA = "0x105BEC00")]
		private void OnInputSourceUpdate()
		{
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x5BE7E0", Offset = "0x5BDBE0", VA = "0x105BE7E0")]
		private void GetSourceAxisValues()
		{
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x5BE870", Offset = "0x5BDC70", VA = "0x105BE870")]
		private void GetSourceButtonValues()
		{
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002536")]
		[Address(RVA = "0x5BF360", Offset = "0x5BE760", VA = "0x105BF360")]
		private void SetControllerAxisValues()
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x5BF3E0", Offset = "0x5BE7E0", VA = "0x105BF3E0")]
		private void SetControllerButtonValues()
		{
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x5BE760", Offset = "0x5BDB60", VA = "0x105BE760")]
		private float GetAxisValueCallback(int index)
		{
			return 0f;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x5BE7A0", Offset = "0x5BDBA0", VA = "0x105BE7A0")]
		private bool GetButtonValueCallback(int index)
		{
			return default(bool);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public CustomControllerDemo()
		{
		}

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0xC")]
		public int playerId;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x10")]
		public string controllerTag;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x14")]
		public bool useUpdateCallbacks;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x18")]
		private int buttonCount;

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x1C")]
		private int axisCount;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x20")]
		private float[] axisValues;

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x24")]
		private bool[] buttonValues;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x28")]
		private TouchJoystickExample[] joysticks;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x2C")]
		private TouchButtonExample[] buttons;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x30")]
		private CustomController controller;

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x34")]
		[NonSerialized]
		private bool initialized;
	}
}
