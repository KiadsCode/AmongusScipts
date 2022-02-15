using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000561 RID: 1377
	[Token(Token = "0x2000561")]
	[Attribute(Name = "RequireComponent", RVA = "0xE3050", Offset = "0xE2450")]
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202A")]
		[Address(RVA = "0x82F040", Offset = "0x82E440", VA = "0x1082F040")]
		private void OnEnable()
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202B")]
		[Address(RVA = "0x82F260", Offset = "0x82E660", VA = "0x1082F260")]
		private void Update()
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202C")]
		[Address(RVA = "0x82F0E0", Offset = "0x82E4E0", VA = "0x1082F0E0")]
		private void UpdateSize()
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202D")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public CanvasScalerFitter()
		{
		}

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CanvasScalerFitter.BreakPoint[] breakPoints;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x10")]
		private CanvasScalerExt canvasScaler;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x14")]
		private int screenWidth;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x18")]
		private int screenHeight;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x1C")]
		private Action ScreenSizeChanged;

		// Token: 0x02000562 RID: 1378
		[Token(Token = "0x2000562")]
		[Serializable]
		private class BreakPoint
		{
			// Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public BreakPoint()
			{
			}

			// Token: 0x04002244 RID: 8772
			[Token(Token = "0x4002244")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string name;

			// Token: 0x04002245 RID: 8773
			[Token(Token = "0x4002245")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			public float screenAspectRatio;

			// Token: 0x04002246 RID: 8774
			[Token(Token = "0x4002246")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Vector2 referenceResolution;
		}
	}
}
