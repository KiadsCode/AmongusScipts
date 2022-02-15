using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000587 RID: 1415
	[Token(Token = "0x2000587")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CustomButton : Button, ICustomSelectable, ICancelHandler, IEventSystemHandler
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000710")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x5BE570", Offset = "0x5BD970", VA = "0x105BE570", Slot = "43")]
			get
			{
				return null;
			}
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x5BE6E0", Offset = "0x5BDAE0", VA = "0x105BE6E0", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000711")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x5BE550", Offset = "0x5BD950", VA = "0x105BE550", Slot = "45")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x5BE6C0", Offset = "0x5BDAC0", VA = "0x105BE6C0", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000712")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x5BE580", Offset = "0x5BD980", VA = "0x105BE580", Slot = "47")]
			get
			{
				return null;
			}
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x5BE700", Offset = "0x5BDB00", VA = "0x105BE700", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000713")]
		public bool autoNavUp
		{
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x5BE540", Offset = "0x5BD940", VA = "0x105BE540", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x5BE6A0", Offset = "0x5BDAA0", VA = "0x105BE6A0", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000714")]
		public bool autoNavDown
		{
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x5BE510", Offset = "0x5BD910", VA = "0x105BE510", Slot = "51")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x5BE640", Offset = "0x5BDA40", VA = "0x105BE640", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0000A908 File Offset: 0x00008B08
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000715")]
		public bool autoNavLeft
		{
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x5BE520", Offset = "0x5BD920", VA = "0x105BE520", Slot = "53")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x5BE660", Offset = "0x5BDA60", VA = "0x105BE660", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0000A920 File Offset: 0x00008B20
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000716")]
		public bool autoNavRight
		{
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x5BE530", Offset = "0x5BD930", VA = "0x105BE530", Slot = "55")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x5BE680", Offset = "0x5BDA80", VA = "0x105BE680", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x17000717")]
		private bool isDisabled
		{
			[Token(Token = "0x60022A9")]
			[Address(RVA = "0x5BE590", Offset = "0x5BD990", VA = "0x105BE590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060022AA RID: 8874 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022AB RID: 8875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x60022AA")]
			[Address(RVA = "0x5BE490", Offset = "0x5BD890", VA = "0x105BE490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x60022AB")]
			[Address(RVA = "0x5BE5C0", Offset = "0x5BD9C0", VA = "0x105BE5C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060022AC RID: 8876 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x60022AC")]
			[Address(RVA = "0x5BE490", Offset = "0x5BD890", VA = "0x105BE490", Slot = "57")]
			add
			{
			}
			[Token(Token = "0x60022AD")]
			[Address(RVA = "0x5BE5C0", Offset = "0x5BD9C0", VA = "0x105BE5C0", Slot = "58")]
			remove
			{
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x5BDBC0", Offset = "0x5BCFC0", VA = "0x105BDBC0", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x5BDC80", Offset = "0x5BD080", VA = "0x105BDC80", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x5BDD40", Offset = "0x5BD140", VA = "0x105BDD40", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x5BDB00", Offset = "0x5BCF00", VA = "0x105BDB00", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x5BDE20", Offset = "0x5BD220", VA = "0x105BDE20", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x5BD6D0", Offset = "0x5BCAD0", VA = "0x105BD6D0", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x5BE230", Offset = "0x5BD630", VA = "0x105BE230")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x5BD640", Offset = "0x5BCA40", VA = "0x105BD640")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x5BE310", Offset = "0x5BD710", VA = "0x105BE310")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x5BE0B0", Offset = "0x5BD4B0", VA = "0x105BE0B0", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x5BDF40", Offset = "0x5BD340", VA = "0x105BDF40", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x5BE1D0", Offset = "0x5BD5D0", VA = "0x105BE1D0")]
		private void Press()
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x5BE000", Offset = "0x5BD400", VA = "0x105BE000", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x5BE100", Offset = "0x5BD500", VA = "0x105BE100", Slot = "42")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x5BDFB0", Offset = "0x5BD3B0", VA = "0x105BDFB0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5430", Offset = "0xE4830")]
		private IEnumerator OnFinishSubmit()
		{
			return null;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x5BDA60", Offset = "0x5BCE60", VA = "0x105BDA60")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x5BDE00", Offset = "0x5BD200", VA = "0x105BDE00", Slot = "59")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x5BE470", Offset = "0x5BD870", VA = "0x105BE470")]
		public CustomButton()
		{
		}

		// Token: 0x04002365 RID: 9061
		[Token(Token = "0x4002365")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04002366 RID: 9062
		[Token(Token = "0x4002366")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _disabledHighlightedColor;

		// Token: 0x04002367 RID: 9063
		[Token(Token = "0x4002367")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string _disabledHighlightedTrigger;

		// Token: 0x04002368 RID: 9064
		[Token(Token = "0x4002368")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool _autoNavUp;

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavDown;

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavLeft;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _autoNavRight;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x0")]
		private bool isHighlightDisabled;

		// Token: 0x02000588 RID: 1416
		[Token(Token = "0x2000588")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <OnFinishSubmit>d__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060022C0 RID: 8896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <OnFinishSubmit>d__51(int <>1__state)
			{
			}

			// Token: 0x060022C1 RID: 8897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060022C2 RID: 8898 RVA: 0x0000A950 File Offset: 0x00008B50
			[Token(Token = "0x60022C2")]
			[Address(RVA = "0x788EE0", Offset = "0x7882E0", VA = "0x10788EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000718")]
			private object Current
			{
				[Token(Token = "0x60022C3")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x788FC0", Offset = "0x7883C0", VA = "0x10788FC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000719")]
			private object Current
			{
				[Token(Token = "0x60022C5")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400236E RID: 9070
			[Token(Token = "0x400236E")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x0400236F RID: 9071
			[Token(Token = "0x400236F")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04002370 RID: 9072
			[Token(Token = "0x4002370")]
			[FieldOffset(Offset = "0x10")]
			public CustomButton <>4__this;

			// Token: 0x04002371 RID: 9073
			[Token(Token = "0x4002371")]
			[FieldOffset(Offset = "0x14")]
			private float <fadeTime>5__2;

			// Token: 0x04002372 RID: 9074
			[Token(Token = "0x4002372")]
			[FieldOffset(Offset = "0x18")]
			private float <elapsedTime>5__3;
		}
	}
}
