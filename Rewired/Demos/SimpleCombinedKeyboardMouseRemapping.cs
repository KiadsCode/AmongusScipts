using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F9")]
		private Player player
		{
			[Token(Token = "0x60025A8")]
			[Address(RVA = "0x49C590", Offset = "0x49B990", VA = "0x1049C590")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x49BBA0", Offset = "0x49AFA0", VA = "0x1049BBA0")]
		private void OnEnable()
		{
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AA")]
		[Address(RVA = "0x49BB40", Offset = "0x49AF40", VA = "0x1049BB40")]
		private void OnDisable()
		{
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x49C0D0", Offset = "0x49B4D0", VA = "0x1049C0D0")]
		private void RedrawUI()
		{
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x49B380", Offset = "0x49A780", VA = "0x1049B380")]
		private void ClearUI()
		{
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x49B620", Offset = "0x49AA20", VA = "0x1049B620")]
		private void InitializeUI()
		{
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x49B460", Offset = "0x49A860", VA = "0x1049B460")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AF")]
		[Address(RVA = "0x49BE40", Offset = "0x49B240", VA = "0x1049BE40")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B0")]
		[Address(RVA = "0x49C480", Offset = "0x49B880", VA = "0x1049C480")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7610", Offset = "0xE6A10")]
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B1")]
		[Address(RVA = "0x49BFD0", Offset = "0x49B3D0", VA = "0x1049BFD0")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x49C040", Offset = "0x49B440", VA = "0x1049C040")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x49C4F0", Offset = "0x49B8F0", VA = "0x1049C4F0")]
		public SimpleCombinedKeyboardMouseRemapping()
		{
		}

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		private const string category = "Default";

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		private const string layout = "Default";

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		private const string uiCategory = "UI";

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0xC")]
		private InputMapper inputMapper_keyboard;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x10")]
		private InputMapper inputMapper_mouse;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x14")]
		public GameObject buttonPrefab;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x18")]
		public GameObject textPrefab;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x1C")]
		public RectTransform fieldGroupTransform;

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform actionGroupTransform;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0x24")]
		public Text controllerNameUIText;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x28")]
		public Text statusUIText;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0x2C")]
		private List<SimpleCombinedKeyboardMouseRemapping.Row> rows;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0x30")]
		private SimpleCombinedKeyboardMouseRemapping.TargetMapping _replaceTargetMapping;

		// Token: 0x020005D7 RID: 1495
		[Token(Token = "0x20005D7")]
		private class Row
		{
			// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public Row()
			{
			}

			// Token: 0x04002534 RID: 9524
			[Token(Token = "0x4002534")]
			[FieldOffset(Offset = "0x8")]
			public InputAction action;

			// Token: 0x04002535 RID: 9525
			[Token(Token = "0x4002535")]
			[FieldOffset(Offset = "0xC")]
			public AxisRange actionRange;

			// Token: 0x04002536 RID: 9526
			[Token(Token = "0x4002536")]
			[FieldOffset(Offset = "0x10")]
			public Button button;

			// Token: 0x04002537 RID: 9527
			[Token(Token = "0x4002537")]
			[FieldOffset(Offset = "0x14")]
			public Text text;
		}

		// Token: 0x020005D8 RID: 1496
		[Token(Token = "0x20005D8")]
		private struct TargetMapping
		{
			// Token: 0x04002538 RID: 9528
			[Token(Token = "0x4002538")]
			[FieldOffset(Offset = "0x0")]
			public ControllerMap controllerMap;

			// Token: 0x04002539 RID: 9529
			[Token(Token = "0x4002539")]
			[FieldOffset(Offset = "0x4")]
			public int actionElementMapId;
		}

		// Token: 0x020005D9 RID: 1497
		[Token(Token = "0x20005D9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x060025B5 RID: 9653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B5")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B6")]
			[Address(RVA = "0x370F90", Offset = "0x370390", VA = "0x10370F90")]
			internal void <RedrawUI>b__0()
			{
			}

			// Token: 0x0400253A RID: 9530
			[Token(Token = "0x400253A")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x0400253B RID: 9531
			[Token(Token = "0x400253B")]
			[FieldOffset(Offset = "0xC")]
			public int actionElementMapId;

			// Token: 0x0400253C RID: 9532
			[Token(Token = "0x400253C")]
			[FieldOffset(Offset = "0x10")]
			public SimpleCombinedKeyboardMouseRemapping <>4__this;
		}

		// Token: 0x020005DA RID: 1498
		[Token(Token = "0x20005DA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <StartListeningDelayed>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060025B7 RID: 9655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B7")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <StartListeningDelayed>d__22(int <>1__state)
			{
			}

			// Token: 0x060025B8 RID: 9656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B8")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060025B9 RID: 9657 RVA: 0x0000B328 File Offset: 0x00009528
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x36FA00", Offset = "0x36EE00", VA = "0x1036FA00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007FA")]
			private object Current
			{
				[Token(Token = "0x60025BA")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025BB")]
			[Address(RVA = "0x36FD20", Offset = "0x36F120", VA = "0x1036FD20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007FB")]
			private object Current
			{
				[Token(Token = "0x60025BC")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400253D RID: 9533
			[Token(Token = "0x400253D")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x0400253E RID: 9534
			[Token(Token = "0x400253E")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x0400253F RID: 9535
			[Token(Token = "0x400253F")]
			[FieldOffset(Offset = "0x10")]
			public SimpleCombinedKeyboardMouseRemapping <>4__this;

			// Token: 0x04002540 RID: 9536
			[Token(Token = "0x4002540")]
			[FieldOffset(Offset = "0x14")]
			public int index;

			// Token: 0x04002541 RID: 9537
			[Token(Token = "0x4002541")]
			[FieldOffset(Offset = "0x18")]
			public ControllerMap keyboardMap;

			// Token: 0x04002542 RID: 9538
			[Token(Token = "0x4002542")]
			[FieldOffset(Offset = "0x1C")]
			public int actionElementMapToReplaceId;

			// Token: 0x04002543 RID: 9539
			[Token(Token = "0x4002543")]
			[FieldOffset(Offset = "0x20")]
			public ControllerMap mouseMap;
		}
	}
}
