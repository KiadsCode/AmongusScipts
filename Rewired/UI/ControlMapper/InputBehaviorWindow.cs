using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class InputBehaviorWindow : Window
	{
		// Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002318")]
		[Address(RVA = "0x3F9B50", Offset = "0x3F8F50", VA = "0x103F9B50", Slot = "5")]
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x3FA1E0", Offset = "0x3F95E0", VA = "0x103FA1E0")]
		public void SetData(int playerId, ControlMapper.InputBehaviorSettings[] data)
		{
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x3FA130", Offset = "0x3F9530", VA = "0x103FA130")]
		public void SetButtonCallback(InputBehaviorWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x3F9620", Offset = "0x3F8A20", VA = "0x103F9620", Slot = "9")]
		public override void Cancel()
		{
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x3F9FA0", Offset = "0x3F93A0", VA = "0x103F9FA0")]
		public void OnDone()
		{
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x3F9F80", Offset = "0x3F9380", VA = "0x103F9F80")]
		public void OnCancel()
		{
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x3FA020", Offset = "0x3F9420", VA = "0x103FA020")]
		public void OnRestoreDefault()
		{
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x3F9ED0", Offset = "0x3F92D0", VA = "0x103F9ED0")]
		private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x3F9F40", Offset = "0x3F9340", VA = "0x103F9F40")]
		private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x3F9EA0", Offset = "0x3F92A0", VA = "0x103F9EA0")]
		private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x3F9F10", Offset = "0x3F9310", VA = "0x103F9F10")]
		private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x3FA680", Offset = "0x3F9A80", VA = "0x103FA680", Slot = "6")]
		public override void TakeInputFocus()
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x3F97B0", Offset = "0x3F8BB0", VA = "0x103F97B0")]
		private UIControlSet CreateControlSet()
		{
			return null;
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x3F9860", Offset = "0x3F8C60", VA = "0x103F9860")]
		private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback)
		{
			return null;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x3F9AE0", Offset = "0x3F8EE0", VA = "0x103F9AE0")]
		private InputBehavior GetInputBehavior(int id)
		{
			return null;
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x3F9A20", Offset = "0x3F8E20", VA = "0x103F9A20")]
		private InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
		{
			return null;
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x3FA690", Offset = "0x3F9A90", VA = "0x103FA690")]
		public InputBehaviorWindow()
		{
		}

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		private const float minSensitivity = 0.1f;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform spawnTransform;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button doneButton;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button cancelButton;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button defaultButton;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TMP_Text doneButtonLabel;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TMP_Text cancelButtonLabel;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TMP_Text defaultButtonLabel;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject uiControlSetPrefab;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private GameObject uiSliderControlPrefab;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x68")]
		private List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo;

		// Token: 0x04002390 RID: 9104
		[Token(Token = "0x4002390")]
		[FieldOffset(Offset = "0x6C")]
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04002391 RID: 9105
		[Token(Token = "0x4002391")]
		[FieldOffset(Offset = "0x70")]
		private int playerId;

		// Token: 0x0200058D RID: 1421
		[Token(Token = "0x200058D")]
		private class InputBehaviorInfo
		{
			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06002329 RID: 9001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000731")]
			public InputBehavior inputBehavior
			{
				[Token(Token = "0x6002329")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000732")]
			public UIControlSet controlSet
			{
				[Token(Token = "0x600232A")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600232B RID: 9003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x5A6A70", Offset = "0x5A5E70", VA = "0x105A6A70")]
			public InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty)
			{
			}

			// Token: 0x0600232C RID: 9004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x5A6A40", Offset = "0x5A5E40", VA = "0x105A6A40")]
			public void RestorePreviousData()
			{
			}

			// Token: 0x0600232D RID: 9005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x5A6A10", Offset = "0x5A5E10", VA = "0x105A6A10")]
			public void RestoreDefaultData()
			{
			}

			// Token: 0x0600232E RID: 9006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x5A68F0", Offset = "0x5A5CF0", VA = "0x105A68F0")]
			public void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId)
			{
			}

			// Token: 0x0600232F RID: 9007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600232F")]
			[Address(RVA = "0x5A66D0", Offset = "0x5A5AD0", VA = "0x105A66D0")]
			public void RefreshControls()
			{
			}

			// Token: 0x04002392 RID: 9106
			[Token(Token = "0x4002392")]
			[FieldOffset(Offset = "0x8")]
			private InputBehavior _inputBehavior;

			// Token: 0x04002393 RID: 9107
			[Token(Token = "0x4002393")]
			[FieldOffset(Offset = "0xC")]
			private UIControlSet _controlSet;

			// Token: 0x04002394 RID: 9108
			[Token(Token = "0x4002394")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty;

			// Token: 0x04002395 RID: 9109
			[Token(Token = "0x4002395")]
			[FieldOffset(Offset = "0x14")]
			private InputBehavior copyOfOriginal;
		}

		// Token: 0x0200058E RID: 1422
		[Token(Token = "0x200058E")]
		public enum ButtonIdentifier
		{
			// Token: 0x04002397 RID: 9111
			[Token(Token = "0x4002397")]
			Done,
			// Token: 0x04002398 RID: 9112
			[Token(Token = "0x4002398")]
			Cancel,
			// Token: 0x04002399 RID: 9113
			[Token(Token = "0x4002399")]
			Default
		}

		// Token: 0x0200058F RID: 1423
		[Token(Token = "0x200058F")]
		private enum PropertyType
		{
			// Token: 0x0400239B RID: 9115
			[Token(Token = "0x400239B")]
			JoystickAxisSensitivity,
			// Token: 0x0400239C RID: 9116
			[Token(Token = "0x400239C")]
			MouseXYAxisSensitivity
		}

		// Token: 0x02000590 RID: 1424
		[Token(Token = "0x2000590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06002330 RID: 9008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002330")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x06002331 RID: 9009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002331")]
			[Address(RVA = "0x5B56A0", Offset = "0x5B4AA0", VA = "0x105B56A0")]
			internal void <CreateSlider>b__0(int cId, float value)
			{
			}

			// Token: 0x06002332 RID: 9010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x5B5700", Offset = "0x5B4B00", VA = "0x105B5700")]
			internal void <CreateSlider>b__1(int cId)
			{
			}

			// Token: 0x0400239D RID: 9117
			[Token(Token = "0x400239D")]
			[FieldOffset(Offset = "0x8")]
			public Action<int, int, float> valueChangedCallback;

			// Token: 0x0400239E RID: 9118
			[Token(Token = "0x400239E")]
			[FieldOffset(Offset = "0xC")]
			public int inputBehaviorId;

			// Token: 0x0400239F RID: 9119
			[Token(Token = "0x400239F")]
			[FieldOffset(Offset = "0x10")]
			public Action<int, int> cancelCallback;
		}
	}
}
