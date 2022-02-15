using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class SimpleControlRemapping : MonoBehaviour
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FC")]
		private Player player
		{
			[Token(Token = "0x60025BD")]
			[Address(RVA = "0x49DC40", Offset = "0x49D040", VA = "0x1049DC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FD")]
		private ControllerMap controllerMap
		{
			[Token(Token = "0x60025BE")]
			[Address(RVA = "0x49DAF0", Offset = "0x49CEF0", VA = "0x1049DAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FE")]
		private Controller controller
		{
			[Token(Token = "0x60025BF")]
			[Address(RVA = "0x49DC00", Offset = "0x49D000", VA = "0x1049DC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x49CF00", Offset = "0x49C300", VA = "0x1049CF00")]
		private void OnEnable()
		{
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x49CE10", Offset = "0x49C210", VA = "0x1049CE10")]
		private void OnDisable()
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x49D2D0", Offset = "0x49C6D0", VA = "0x1049D2D0")]
		private void RedrawUI()
		{
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x49C5F0", Offset = "0x49B9F0", VA = "0x1049C5F0")]
		private void ClearUI()
		{
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x49C8C0", Offset = "0x49BCC0", VA = "0x1049C8C0")]
		private void InitializeUI()
		{
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x49C700", Offset = "0x49BB00", VA = "0x1049C700")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x49D8B0", Offset = "0x49CCB0", VA = "0x1049D8B0")]
		private void SetSelectedController(ControllerType controllerType)
		{
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C7")]
		[Address(RVA = "0x49CE00", Offset = "0x49C200", VA = "0x1049CE00")]
		public void OnControllerSelected(int controllerType)
		{
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C8")]
		[Address(RVA = "0x49D150", Offset = "0x49C550", VA = "0x1049D150")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025C9")]
		[Address(RVA = "0x49DA10", Offset = "0x49CE10", VA = "0x1049DA10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE76B0", Offset = "0xE6AB0")]
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x49CDE0", Offset = "0x49C1E0", VA = "0x1049CDE0")]
		private void OnControllerChanged(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x49D220", Offset = "0x49C620", VA = "0x1049D220")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x49D240", Offset = "0x49C640", VA = "0x1049D240")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x49DA70", Offset = "0x49CE70", VA = "0x1049DA70")]
		public SimpleControlRemapping()
		{
		}

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		private const string category = "Default";

		// Token: 0x04002545 RID: 9541
		[Token(Token = "0x4002545")]
		private const string layout = "Default";

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		private const string uiCategory = "UI";

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0xC")]
		private InputMapper inputMapper;

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0x10")]
		public GameObject buttonPrefab;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0x14")]
		public GameObject textPrefab;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform fieldGroupTransform;

		// Token: 0x0400254B RID: 9547
		[Token(Token = "0x400254B")]
		[FieldOffset(Offset = "0x1C")]
		public RectTransform actionGroupTransform;

		// Token: 0x0400254C RID: 9548
		[Token(Token = "0x400254C")]
		[FieldOffset(Offset = "0x20")]
		public Text controllerNameUIText;

		// Token: 0x0400254D RID: 9549
		[Token(Token = "0x400254D")]
		[FieldOffset(Offset = "0x24")]
		public Text statusUIText;

		// Token: 0x0400254E RID: 9550
		[Token(Token = "0x400254E")]
		[FieldOffset(Offset = "0x28")]
		private ControllerType selectedControllerType;

		// Token: 0x0400254F RID: 9551
		[Token(Token = "0x400254F")]
		[FieldOffset(Offset = "0x2C")]
		private int selectedControllerId;

		// Token: 0x04002550 RID: 9552
		[Token(Token = "0x4002550")]
		[FieldOffset(Offset = "0x30")]
		private List<SimpleControlRemapping.Row> rows;

		// Token: 0x020005DC RID: 1500
		[Token(Token = "0x20005DC")]
		private class Row
		{
			// Token: 0x060025CE RID: 9678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025CE")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public Row()
			{
			}

			// Token: 0x04002551 RID: 9553
			[Token(Token = "0x4002551")]
			[FieldOffset(Offset = "0x8")]
			public InputAction action;

			// Token: 0x04002552 RID: 9554
			[Token(Token = "0x4002552")]
			[FieldOffset(Offset = "0xC")]
			public AxisRange actionRange;

			// Token: 0x04002553 RID: 9555
			[Token(Token = "0x4002553")]
			[FieldOffset(Offset = "0x10")]
			public Button button;

			// Token: 0x04002554 RID: 9556
			[Token(Token = "0x4002554")]
			[FieldOffset(Offset = "0x14")]
			public Text text;
		}

		// Token: 0x020005DD RID: 1501
		[Token(Token = "0x20005DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x060025CF RID: 9679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025CF")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x060025D0 RID: 9680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025D0")]
			[Address(RVA = "0x371150", Offset = "0x370550", VA = "0x10371150")]
			internal void <RedrawUI>b__0()
			{
			}

			// Token: 0x04002555 RID: 9557
			[Token(Token = "0x4002555")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x04002556 RID: 9558
			[Token(Token = "0x4002556")]
			[FieldOffset(Offset = "0xC")]
			public int actionElementMapId;

			// Token: 0x04002557 RID: 9559
			[Token(Token = "0x4002557")]
			[FieldOffset(Offset = "0x10")]
			public SimpleControlRemapping <>4__this;
		}

		// Token: 0x020005DE RID: 1502
		[Token(Token = "0x20005DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <StartListeningDelayed>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025D1")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <StartListeningDelayed>d__28(int <>1__state)
			{
			}

			// Token: 0x060025D2 RID: 9682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025D2")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060025D3 RID: 9683 RVA: 0x0000B340 File Offset: 0x00009540
			[Token(Token = "0x60025D3")]
			[Address(RVA = "0x36FD50", Offset = "0x36F150", VA = "0x1036FD50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007FF")]
			private object Current
			{
				[Token(Token = "0x60025D4")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025D5")]
			[Address(RVA = "0x36FF70", Offset = "0x36F370", VA = "0x1036FF70", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x060025D6 RID: 9686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000800")]
			private object Current
			{
				[Token(Token = "0x60025D6")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04002558 RID: 9560
			[Token(Token = "0x4002558")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04002559 RID: 9561
			[Token(Token = "0x4002559")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x0400255A RID: 9562
			[Token(Token = "0x400255A")]
			[FieldOffset(Offset = "0x10")]
			public SimpleControlRemapping <>4__this;

			// Token: 0x0400255B RID: 9563
			[Token(Token = "0x400255B")]
			[FieldOffset(Offset = "0x14")]
			public int index;

			// Token: 0x0400255C RID: 9564
			[Token(Token = "0x400255C")]
			[FieldOffset(Offset = "0x18")]
			public int actionElementMapToReplaceId;
		}
	}
}
