using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Integration.UnityUI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class CalibrationWindow : Window
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x17000667")]
		private bool axisSelected
		{
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x82EFA0", Offset = "0x82E3A0", VA = "0x1082EFA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000668")]
		private AxisCalibration axisCalibration
		{
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x82EF20", Offset = "0x82E320", VA = "0x1082EF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x82CB50", Offset = "0x82BF50", VA = "0x1082CB50", Slot = "5")]
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x82E660", Offset = "0x82DA60", VA = "0x1082E660")]
		public void SetJoystick(int playerId, Joystick joystick)
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x82E5B0", Offset = "0x82D9B0", VA = "0x1082E5B0")]
		public void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x82C970", Offset = "0x82BD70", VA = "0x1082C970", Slot = "9")]
		public override void Cancel()
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x82EEB0", Offset = "0x82E2B0", VA = "0x1082EEB0", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x82D760", Offset = "0x82CB60", VA = "0x1082D760")]
		public void OnDone()
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x3F9F80", Offset = "0x3F9380", VA = "0x103F9F80")]
		public void OnCancel()
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x82D850", Offset = "0x82CC50", VA = "0x1082D850")]
		public void OnRestoreDefault()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x82D550", Offset = "0x82C950", VA = "0x1082D550")]
		public void OnCalibrate()
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x82D7F0", Offset = "0x82CBF0", VA = "0x1082D7F0")]
		public void OnInvert(bool state)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x82DAE0", Offset = "0x82CEE0", VA = "0x1082DAE0")]
		public void OnZeroValueChange(float value)
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x82DA60", Offset = "0x82CE60", VA = "0x1082DA60")]
		public void OnZeroCancel()
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x82D670", Offset = "0x82CA70", VA = "0x1082D670")]
		public void OnDeadzoneValueChange(float value)
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x82D5E0", Offset = "0x82C9E0", VA = "0x1082D5E0")]
		public void OnDeadzoneCancel()
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x82D920", Offset = "0x82CD20", VA = "0x1082D920")]
		public void OnSensitivityValueChange(float value)
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x82D8B0", Offset = "0x82CCB0", VA = "0x1082D8B0")]
		public void OnSensitivityCancel(float value)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void OnAxisScrollRectScroll(Vector2 pos)
		{
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x82D510", Offset = "0x82C910", VA = "0x1082D510")]
		private void OnAxisSelected(int axisIndex, Button button)
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x82EEA0", Offset = "0x82E2A0", VA = "0x1082EEA0")]
		private void UpdateDisplay()
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x82E050", Offset = "0x82D450", VA = "0x1082E050")]
		private void Redraw()
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x82E070", Offset = "0x82D470", VA = "0x1082E070")]
		private void RefreshControls()
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x82DD10", Offset = "0x82D110", VA = "0x1082DD10")]
		private void RedrawDeadzone()
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x82DC10", Offset = "0x82D010", VA = "0x1082DC10")]
		private void RedrawCalibratedZero()
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x82DE70", Offset = "0x82D270", VA = "0x1082DE70")]
		private void RedrawValueMarkers()
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x82E280", Offset = "0x82D680", VA = "0x1082E280")]
		private void SelectAxis(int index)
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x82EE50", Offset = "0x82E250", VA = "0x1082EE50", Slot = "6")]
		public override void TakeInputFocus()
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x82EC40", Offset = "0x82E040", VA = "0x1082EC40")]
		private void SetMinSensitivity()
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x82D270", Offset = "0x82C670", VA = "0x1082D270")]
		private bool IsMenuAxis(int actionId, int axisIndex)
		{
			return default(bool);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x82CA30", Offset = "0x82BE30", VA = "0x1082CA30")]
		private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x82CAF0", Offset = "0x82BEF0", VA = "0x1082CAF0")]
		private float GetSliderSensitivity(AxisCalibration axisCalibration)
		{
			return 0f;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x82ED60", Offset = "0x82E160", VA = "0x1082ED60")]
		public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x82DB50", Offset = "0x82CF50", VA = "0x1082DB50")]
		private static float ProcessPowerValue(float value, float minValue, float maxValue)
		{
			return 0f;
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x82EEE0", Offset = "0x82E2E0", VA = "0x1082EEE0")]
		public CalibrationWindow()
		{
		}

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		private const float minSensitivityOtherAxes = 0.1f;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		private const float maxDeadzone = 0.8f;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform rightContentContainer;

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform valueDisplayGroup;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private RectTransform calibratedValueMarker;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform rawValueMarker;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RectTransform calibratedZeroMarker;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform deadzoneArea;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Slider deadzoneSlider;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Slider zeroSlider;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Slider sensitivitySlider;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle invertToggle;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private RectTransform axisScrollAreaContent;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button doneButton;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button calibrateButton;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TMP_Text doneButtonLabel;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private TMP_Text cancelButtonLabel;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TMP_Text defaultButtonLabel;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private TMP_Text deadzoneSliderLabel;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TMP_Text zeroSliderLabel;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private TMP_Text sensitivitySliderLabel;

		// Token: 0x04002228 RID: 8744
		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TMP_Text invertToggleLabel;

		// Token: 0x04002229 RID: 8745
		[Token(Token = "0x4002229")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private TMP_Text calibrateButtonLabel;

		// Token: 0x0400222A RID: 8746
		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject axisButtonPrefab;

		// Token: 0x0400222B RID: 8747
		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0x9C")]
		private Joystick joystick;

		// Token: 0x0400222C RID: 8748
		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0xA0")]
		private string origCalibrationData;

		// Token: 0x0400222D RID: 8749
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0xA4")]
		private int selectedAxis;

		// Token: 0x0400222E RID: 8750
		[Token(Token = "0x400222E")]
		[FieldOffset(Offset = "0xA8")]
		private AxisCalibrationData origSelectedAxisCalibrationData;

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		[FieldOffset(Offset = "0xD4")]
		private float displayAreaWidth;

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0xD8")]
		private List<Button> axisButtons;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0xDC")]
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0xE0")]
		private int playerId;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0xE4")]
		private RewiredStandaloneInputModule rewiredStandaloneInputModule;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0xE8")]
		private int menuHorizActionId;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0xEC")]
		private int menuVertActionId;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0xF0")]
		private float minSensitivity;

		// Token: 0x0200055E RID: 1374
		[Token(Token = "0x200055E")]
		public enum ButtonIdentifier
		{
			// Token: 0x04002238 RID: 8760
			[Token(Token = "0x4002238")]
			Done,
			// Token: 0x04002239 RID: 8761
			[Token(Token = "0x4002239")]
			Cancel,
			// Token: 0x0400223A RID: 8762
			[Token(Token = "0x400223A")]
			Default,
			// Token: 0x0400223B RID: 8763
			[Token(Token = "0x400223B")]
			Calibrate
		}

		// Token: 0x0200055F RID: 1375
		[Token(Token = "0x200055F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06002026 RID: 8230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002026")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x3CA610", Offset = "0x3C9A10", VA = "0x103CA610")]
			internal void <SetJoystick>b__0()
			{
			}

			// Token: 0x0400223C RID: 8764
			[Token(Token = "0x400223C")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x0400223D RID: 8765
			[Token(Token = "0x400223D")]
			[FieldOffset(Offset = "0xC")]
			public Button button;

			// Token: 0x0400223E RID: 8766
			[Token(Token = "0x400223E")]
			[FieldOffset(Offset = "0x10")]
			public CalibrationWindow <>4__this;
		}
	}
}
