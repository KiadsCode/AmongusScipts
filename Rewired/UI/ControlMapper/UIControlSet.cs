using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005A8 RID: 1448
	[Token(Token = "0x20005A8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C4")]
		private Dictionary<int, UIControl> controls
		{
			[Token(Token = "0x600243F")]
			[Address(RVA = "0x4B4AC0", Offset = "0x4B3EC0", VA = "0x104B4AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x4B4A40", Offset = "0x4B3E40", VA = "0x104B4A40")]
		public void SetTitle(string text)
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002441")]
		public T GetControl<T>(int uniqueId) where T : UIControl
		{
			return null;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x4B4670", Offset = "0x4B3A70", VA = "0x104B4670")]
		public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
		{
			return null;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public UIControlSet()
		{
		}

		// Token: 0x0400243F RID: 9279
		[Token(Token = "0x400243F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TMP_Text title;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, UIControl> _controls;

		// Token: 0x020005A9 RID: 1449
		[Token(Token = "0x20005A9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06002444 RID: 9284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002444")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06002445 RID: 9285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002445")]
			[Address(RVA = "0x1302870", Offset = "0x1301C70", VA = "0x11302870")]
			internal void <CreateSlider>b__0(float value)
			{
			}

			// Token: 0x06002446 RID: 9286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x13028D0", Offset = "0x1301CD0", VA = "0x113028D0")]
			internal void <CreateSlider>b__1()
			{
			}

			// Token: 0x04002441 RID: 9281
			[Token(Token = "0x4002441")]
			[FieldOffset(Offset = "0x8")]
			public Action<int, float> valueChangedCallback;

			// Token: 0x04002442 RID: 9282
			[Token(Token = "0x4002442")]
			[FieldOffset(Offset = "0xC")]
			public UISliderControl control;

			// Token: 0x04002443 RID: 9283
			[Token(Token = "0x4002443")]
			[FieldOffset(Offset = "0x10")]
			public Action<int> cancelCallback;
		}
	}
}
