using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	[Attribute(Name = "RequireComponent", RVA = "0xE68C0", Offset = "0xE5CC0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE68C0", Offset = "0xE5CC0")]
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x06002450 RID: 9296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x4B5040", Offset = "0x4B4440", VA = "0x104B5040")]
		public void SetEnabledState(bool newState)
		{
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x4B5020", Offset = "0x4B4420", VA = "0x104B5020")]
		public void SetEnabledStateColor(Color color)
		{
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x4B5000", Offset = "0x4B4400", VA = "0x104B5000")]
		public void SetDisabledStateColor(Color color)
		{
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x4B4F50", Offset = "0x4B4350", VA = "0x104B4F50")]
		public void Refresh()
		{
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public UIImageHelper()
		{
		}

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private UIImageHelper.State enabledState;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UIImageHelper.State disabledState;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[FieldOffset(Offset = "0x14")]
		private bool currentState;

		// Token: 0x020005AD RID: 1453
		[Token(Token = "0x20005AD")]
		[Serializable]
		private class State
		{
			// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002455")]
			[Address(RVA = "0x12FCB30", Offset = "0x12FBF30", VA = "0x112FCB30")]
			public void Set(Image image)
			{
			}

			// Token: 0x06002456 RID: 9302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002456")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public State()
			{
			}

			// Token: 0x0400244D RID: 9293
			[Token(Token = "0x400244D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Color color;
		}
	}
}
