using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005AF RID: 1455
	[Token(Token = "0x20005AF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class UISliderControl : UIControl
	{
		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0000AE00 File Offset: 0x00009000
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C7")]
		public bool showIcon
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x314740", Offset = "0x313B40", VA = "0x10314740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x4B63A0", Offset = "0x4B57A0", VA = "0x104B63A0")]
			set
			{
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0000AE18 File Offset: 0x00009018
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C8")]
		public bool showSlider
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x314750", Offset = "0x313B50", VA = "0x10314750")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600245C")]
			[Address(RVA = "0x4B6430", Offset = "0x4B5830", VA = "0x104B6430")]
			set
			{
			}
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x4B6060", Offset = "0x4B5460", VA = "0x104B6060", Slot = "4")]
		public override void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public UISliderControl()
		{
		}

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		[FieldOffset(Offset = "0x18")]
		public Image iconImage;

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		[FieldOffset(Offset = "0x1C")]
		public Slider slider;

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		[FieldOffset(Offset = "0x20")]
		private bool _showIcon;

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x21")]
		private bool _showSlider;

		// Token: 0x020005B0 RID: 1456
		[Token(Token = "0x20005B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600245F")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06002460 RID: 9312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002460")]
			[Address(RVA = "0x3CA5E0", Offset = "0x3C99E0", VA = "0x103CA5E0")]
			internal void <SetCancelCallback>b__0()
			{
			}

			// Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002461")]
			[Address(RVA = "0x13021A0", Offset = "0x13015A0", VA = "0x113021A0")]
			internal void <SetCancelCallback>b__1(BaseEventData data)
			{
			}

			// Token: 0x04002453 RID: 9299
			[Token(Token = "0x4002453")]
			[FieldOffset(Offset = "0x8")]
			public Action cancelCallback;
		}
	}
}
