using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x4AD8B0", Offset = "0x4ACCB0", VA = "0x104AD8B0")]
		public void Apply(ThemedElement.ElementInfo[] elementInfo)
		{
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x4AD1B0", Offset = "0x4AC5B0", VA = "0x104AD1B0")]
		private void Apply(string themeClass, Component component)
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x4ACEF0", Offset = "0x4AC2F0", VA = "0x104ACEF0")]
		private void Apply(string themeClass, Selectable item)
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x4AD930", Offset = "0x4ACD30", VA = "0x104AD930")]
		private void Apply(string themeClass, Image item)
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x4AD600", Offset = "0x4ACA00", VA = "0x104AD600")]
		private void Apply(string themeClass, TMP_Text item)
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x4ADC80", Offset = "0x4AD080", VA = "0x104ADC80")]
		private void Apply(string themeClass, UIImageHelper item)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x4ADDC0", Offset = "0x4AD1C0", VA = "0x104ADDC0")]
		private static FontStyles GetFontStyle(ThemeSettings.FontStyleOverride style)
		{
			return FontStyles.Normal;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
		public ThemeSettings()
		{
		}

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		// Token: 0x040023F2 RID: 9202
		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ThemeSettings.ImageSettings _areaBackground;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ThemeSettings.SelectableSettings _selectableSettings;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ThemeSettings.SelectableSettings _buttonSettings;

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ThemeSettings.SliderSettings _sliderSettings;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ThemeSettings.ImageSettings _invertToggle;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _invertToggleDisabledColor;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationBackground;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		// Token: 0x040023FD RID: 9213
		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationZeroMarker;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ThemeSettings.ImageSettings _calibrationDeadzone;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ThemeSettings.TextSettings _textSettings;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ThemeSettings.TextSettings _buttonTextSettings;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		// Token: 0x0200059A RID: 1434
		[Token(Token = "0x200059A")]
		[Serializable]
		private abstract class SelectableSettings_Base
		{
			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0000AB30 File Offset: 0x00008D30
			[Token(Token = "0x17000792")]
			public Selectable.Transition transition
			{
				[Token(Token = "0x60023E0")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return Selectable.Transition.None;
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0000AB48 File Offset: 0x00008D48
			[Token(Token = "0x17000793")]
			public ThemeSettings.CustomColorBlock selectableColors
			{
				[Token(Token = "0x60023E1")]
				[Address(RVA = "0x365900", Offset = "0x364D00", VA = "0x10365900")]
				get
				{
					return default(ThemeSettings.CustomColorBlock);
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0000AB60 File Offset: 0x00008D60
			[Token(Token = "0x17000794")]
			public ThemeSettings.CustomSpriteState spriteState
			{
				[Token(Token = "0x60023E2")]
				[Address(RVA = "0x365920", Offset = "0x364D20", VA = "0x10365920")]
				get
				{
					return default(ThemeSettings.CustomSpriteState);
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000795")]
			public ThemeSettings.CustomAnimationTriggers animationTriggers
			{
				[Token(Token = "0x60023E3")]
				[Address(RVA = "0x3658F0", Offset = "0x364CF0", VA = "0x103658F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023E4")]
			[Address(RVA = "0x365490", Offset = "0x364890", VA = "0x10365490", Slot = "4")]
			public virtual void Apply(Selectable item)
			{
			}

			// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023E5")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			protected SelectableSettings_Base()
			{
			}

			// Token: 0x04002404 RID: 9220
			[Token(Token = "0x4002404")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			protected Selectable.Transition _transition;

			// Token: 0x04002405 RID: 9221
			[Token(Token = "0x4002405")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			protected ThemeSettings.CustomColorBlock _colors;

			// Token: 0x04002406 RID: 9222
			[Token(Token = "0x4002406")]
			[FieldOffset(Offset = "0x74")]
			[SerializeField]
			protected ThemeSettings.CustomSpriteState _spriteState;

			// Token: 0x04002407 RID: 9223
			[Token(Token = "0x4002407")]
			[FieldOffset(Offset = "0x88")]
			[SerializeField]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		// Token: 0x0200059B RID: 1435
		[Token(Token = "0x200059B")]
		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x060023E6 RID: 9190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000796")]
			public ThemeSettings.ImageSettings imageSettings
			{
				[Token(Token = "0x60023E6")]
				[Address(RVA = "0x365380", Offset = "0x364780", VA = "0x10365380")]
				get
				{
					return null;
				}
			}

			// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023E7")]
			[Address(RVA = "0x3653B0", Offset = "0x3647B0", VA = "0x103653B0", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023E8")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public SelectableSettings()
			{
			}

			// Token: 0x04002408 RID: 9224
			[Token(Token = "0x4002408")]
			[FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		// Token: 0x0200059C RID: 1436
		[Token(Token = "0x200059C")]
		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000797")]
			public ThemeSettings.ImageSettings handleImageSettings
			{
				[Token(Token = "0x60023E9")]
				[Address(RVA = "0x365380", Offset = "0x364780", VA = "0x10365380")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000798")]
			public ThemeSettings.ImageSettings fillImageSettings
			{
				[Token(Token = "0x60023EA")]
				[Address(RVA = "0x365370", Offset = "0x364770", VA = "0x10365370")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x060023EB RID: 9195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000799")]
			public ThemeSettings.ImageSettings backgroundImageSettings
			{
				[Token(Token = "0x60023EB")]
				[Address(RVA = "0x365BF0", Offset = "0x364FF0", VA = "0x10365BF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x3659D0", Offset = "0x364DD0", VA = "0x103659D0")]
			private void Apply(Slider item)
			{
			}

			// Token: 0x060023ED RID: 9197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0x365940", Offset = "0x364D40", VA = "0x10365940", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023EE")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public SliderSettings()
			{
			}

			// Token: 0x04002409 RID: 9225
			[Token(Token = "0x4002409")]
			[FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x0400240A RID: 9226
			[Token(Token = "0x400240A")]
			[FieldOffset(Offset = "0x90")]
			[SerializeField]
			private ThemeSettings.ImageSettings _fillImageSettings;

			// Token: 0x0400240B RID: 9227
			[Token(Token = "0x400240B")]
			[FieldOffset(Offset = "0x94")]
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x0200059D RID: 1437
		[Token(Token = "0x200059D")]
		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x060023EF RID: 9199 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700079A")]
			public ThemeSettings.ImageSettings handle
			{
				[Token(Token = "0x60023EF")]
				[Address(RVA = "0x365380", Offset = "0x364780", VA = "0x10365380")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x060023F0 RID: 9200 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700079B")]
			public ThemeSettings.ImageSettings background
			{
				[Token(Token = "0x60023F0")]
				[Address(RVA = "0x365370", Offset = "0x364770", VA = "0x10365370")]
				get
				{
					return null;
				}
			}

			// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x365250", Offset = "0x364650", VA = "0x10365250")]
			private void Apply(UnityEngine.UI.Scrollbar item)
			{
			}

			// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F2")]
			[Address(RVA = "0x3650D0", Offset = "0x3644D0", VA = "0x103650D0", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023F3")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public ScrollbarSettings()
			{
			}

			// Token: 0x0400240C RID: 9228
			[Token(Token = "0x400240C")]
			[FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x0400240D RID: 9229
			[Token(Token = "0x400240D")]
			[FieldOffset(Offset = "0x90")]
			[SerializeField]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x0200059E RID: 1438
		[Token(Token = "0x200059E")]
		[Serializable]
		private class ImageSettings
		{
			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0000AB78 File Offset: 0x00008D78
			[Token(Token = "0x1700079C")]
			public Color color
			{
				[Token(Token = "0x60023F4")]
				[Address(RVA = "0x364630", Offset = "0x363A30", VA = "0x10364630")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x060023F5 RID: 9205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700079D")]
			public Sprite sprite
			{
				[Token(Token = "0x60023F5")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x060023F6 RID: 9206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700079E")]
			public Material materal
			{
				[Token(Token = "0x60023F6")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0000AB90 File Offset: 0x00008D90
			[Token(Token = "0x1700079F")]
			public Image.Type type
			{
				[Token(Token = "0x60023F7")]
				[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
				get
				{
					return Image.Type.Simple;
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0000ABA8 File Offset: 0x00008DA8
			[Token(Token = "0x170007A0")]
			public bool preserveAspect
			{
				[Token(Token = "0x60023F8")]
				[Address(RVA = "0x2D5F70", Offset = "0x2D5370", VA = "0x102D5F70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0000ABC0 File Offset: 0x00008DC0
			[Token(Token = "0x170007A1")]
			public bool fillCenter
			{
				[Token(Token = "0x60023F9")]
				[Address(RVA = "0x31AB20", Offset = "0x319F20", VA = "0x1031AB20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x060023FA RID: 9210 RVA: 0x0000ABD8 File Offset: 0x00008DD8
			[Token(Token = "0x170007A2")]
			public Image.FillMethod fillMethod
			{
				[Token(Token = "0x60023FA")]
				[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
				get
				{
					return Image.FillMethod.Horizontal;
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x060023FB RID: 9211 RVA: 0x0000ABF0 File Offset: 0x00008DF0
			[Token(Token = "0x170007A3")]
			public float fillAmout
			{
				[Token(Token = "0x60023FB")]
				[Address(RVA = "0x328170", Offset = "0x327570", VA = "0x10328170")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x060023FC RID: 9212 RVA: 0x0000AC08 File Offset: 0x00008E08
			[Token(Token = "0x170007A4")]
			public bool fillClockwise
			{
				[Token(Token = "0x60023FC")]
				[Address(RVA = "0x2D8E10", Offset = "0x2D8210", VA = "0x102D8E10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x060023FD RID: 9213 RVA: 0x0000AC20 File Offset: 0x00008E20
			[Token(Token = "0x170007A5")]
			public int fillOrigin
			{
				[Token(Token = "0x60023FD")]
				[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023FE")]
			[Address(RVA = "0x3644F0", Offset = "0x3638F0", VA = "0x103644F0", Slot = "4")]
			public virtual void CopyTo(Image image)
			{
			}

			// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023FF")]
			[Address(RVA = "0x364600", Offset = "0x363A00", VA = "0x10364600")]
			public ImageSettings()
			{
			}

			// Token: 0x0400240E RID: 9230
			[Token(Token = "0x400240E")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Color _color;

			// Token: 0x0400240F RID: 9231
			[Token(Token = "0x400240F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Sprite _sprite;

			// Token: 0x04002410 RID: 9232
			[Token(Token = "0x4002410")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private Material _materal;

			// Token: 0x04002411 RID: 9233
			[Token(Token = "0x4002411")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image.Type _type;

			// Token: 0x04002412 RID: 9234
			[Token(Token = "0x4002412")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private bool _preserveAspect;

			// Token: 0x04002413 RID: 9235
			[Token(Token = "0x4002413")]
			[FieldOffset(Offset = "0x25")]
			[SerializeField]
			private bool _fillCenter;

			// Token: 0x04002414 RID: 9236
			[Token(Token = "0x4002414")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image.FillMethod _fillMethod;

			// Token: 0x04002415 RID: 9237
			[Token(Token = "0x4002415")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _fillAmout;

			// Token: 0x04002416 RID: 9238
			[Token(Token = "0x4002416")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private bool _fillClockwise;

			// Token: 0x04002417 RID: 9239
			[Token(Token = "0x4002417")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private int _fillOrigin;
		}

		// Token: 0x0200059F RID: 1439
		[Token(Token = "0x200059F")]
		[Serializable]
		private struct CustomColorBlock
		{
			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06002400 RID: 9216 RVA: 0x0000AC38 File Offset: 0x00008E38
			// (set) Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007A6")]
			public float colorMultiplier
			{
				[Token(Token = "0x6002400")]
				[Address(RVA = "0x273740", Offset = "0x272B40", VA = "0x10273740")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6002401")]
				[Address(RVA = "0x273780", Offset = "0x272B80", VA = "0x10273780")]
				set
				{
				}
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06002402 RID: 9218 RVA: 0x0000AC50 File Offset: 0x00008E50
			// (set) Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007A7")]
			public Color disabledColor
			{
				[Token(Token = "0x6002402")]
				[Address(RVA = "0x364070", Offset = "0x363470", VA = "0x10364070")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x6002403")]
				[Address(RVA = "0x364180", Offset = "0x363580", VA = "0x10364180")]
				set
				{
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06002404 RID: 9220 RVA: 0x0000AC68 File Offset: 0x00008E68
			// (set) Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007A8")]
			public float fadeDuration
			{
				[Token(Token = "0x6002404")]
				[Address(RVA = "0x273A20", Offset = "0x272E20", VA = "0x10273A20")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6002405")]
				[Address(RVA = "0x273A50", Offset = "0x272E50", VA = "0x10273A50")]
				set
				{
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06002406 RID: 9222 RVA: 0x0000AC80 File Offset: 0x00008E80
			// (set) Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007A9")]
			public Color highlightedColor
			{
				[Token(Token = "0x6002406")]
				[Address(RVA = "0x3640B0", Offset = "0x3634B0", VA = "0x103640B0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x6002407")]
				[Address(RVA = "0x3641A0", Offset = "0x3635A0", VA = "0x103641A0")]
				set
				{
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06002408 RID: 9224 RVA: 0x0000AC98 File Offset: 0x00008E98
			// (set) Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AA")]
			public Color normalColor
			{
				[Token(Token = "0x6002408")]
				[Address(RVA = "0x3640D0", Offset = "0x3634D0", VA = "0x103640D0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x6002409")]
				[Address(RVA = "0x3641B0", Offset = "0x3635B0", VA = "0x103641B0")]
				set
				{
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x0600240A RID: 9226 RVA: 0x0000ACB0 File Offset: 0x00008EB0
			// (set) Token: 0x0600240B RID: 9227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AB")]
			public Color pressedColor
			{
				[Token(Token = "0x600240A")]
				[Address(RVA = "0x3640F0", Offset = "0x3634F0", VA = "0x103640F0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x600240B")]
				[Address(RVA = "0x3641C0", Offset = "0x3635C0", VA = "0x103641C0")]
				set
				{
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x0600240C RID: 9228 RVA: 0x0000ACC8 File Offset: 0x00008EC8
			// (set) Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AC")]
			public Color selectedColor
			{
				[Token(Token = "0x600240C")]
				[Address(RVA = "0x364110", Offset = "0x363510", VA = "0x10364110")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x600240D")]
				[Address(RVA = "0x3641D0", Offset = "0x3635D0", VA = "0x103641D0")]
				set
				{
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x0600240E RID: 9230 RVA: 0x0000ACE0 File Offset: 0x00008EE0
			// (set) Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AD")]
			public Color disabledHighlightedColor
			{
				[Token(Token = "0x600240E")]
				[Address(RVA = "0x364090", Offset = "0x363490", VA = "0x10364090")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x600240F")]
				[Address(RVA = "0x364190", Offset = "0x363590", VA = "0x10364190")]
				set
				{
				}
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x0000ACF8 File Offset: 0x00008EF8
			[Token(Token = "0x6002410")]
			[Address(RVA = "0x364130", Offset = "0x363530", VA = "0x10364130")]
			public static implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
			{
				return default(ColorBlock);
			}

			// Token: 0x04002418 RID: 9240
			[Token(Token = "0x4002418")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private float m_ColorMultiplier;

			// Token: 0x04002419 RID: 9241
			[Token(Token = "0x4002419")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private Color m_DisabledColor;

			// Token: 0x0400241A RID: 9242
			[Token(Token = "0x400241A")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float m_FadeDuration;

			// Token: 0x0400241B RID: 9243
			[Token(Token = "0x400241B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Color m_HighlightedColor;

			// Token: 0x0400241C RID: 9244
			[Token(Token = "0x400241C")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Color m_NormalColor;

			// Token: 0x0400241D RID: 9245
			[Token(Token = "0x400241D")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Color m_PressedColor;

			// Token: 0x0400241E RID: 9246
			[Token(Token = "0x400241E")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Color m_SelectedColor;

			// Token: 0x0400241F RID: 9247
			[Token(Token = "0x400241F")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Color m_DisabledHighlightedColor;
		}

		// Token: 0x020005A0 RID: 1440
		[Token(Token = "0x20005A0")]
		[Serializable]
		private struct CustomSpriteState
		{
			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002412 RID: 9234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AE")]
			public Sprite disabledSprite
			{
				[Token(Token = "0x6002411")]
				[Address(RVA = "0x273B70", Offset = "0x272F70", VA = "0x10273B70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002412")]
				[Address(RVA = "0x27F490", Offset = "0x27E890", VA = "0x1027F490")]
				set
				{
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007AF")]
			public Sprite highlightedSprite
			{
				[Token(Token = "0x6002413")]
				[Address(RVA = "0x273A70", Offset = "0x272E70", VA = "0x10273A70")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002414")]
				[Address(RVA = "0x273080", Offset = "0x272480", VA = "0x10273080")]
				set
				{
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06002415 RID: 9237 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B0")]
			public Sprite pressedSprite
			{
				[Token(Token = "0x6002415")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002416")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				set
				{
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06002417 RID: 9239 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002418 RID: 9240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B1")]
			public Sprite selectedSprite
			{
				[Token(Token = "0x6002417")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002418")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600241A RID: 9242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B2")]
			public Sprite disabledHighlightedSprite
			{
				[Token(Token = "0x6002419")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600241A")]
				[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
				set
				{
				}
			}

			// Token: 0x0600241B RID: 9243 RVA: 0x0000AD10 File Offset: 0x00008F10
			[Token(Token = "0x600241B")]
			[Address(RVA = "0x3641E0", Offset = "0x3635E0", VA = "0x103641E0")]
			public static implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
			{
				return default(SpriteState);
			}

			// Token: 0x04002420 RID: 9248
			[Token(Token = "0x4002420")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Sprite m_DisabledSprite;

			// Token: 0x04002421 RID: 9249
			[Token(Token = "0x4002421")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private Sprite m_HighlightedSprite;

			// Token: 0x04002422 RID: 9250
			[Token(Token = "0x4002422")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Sprite m_PressedSprite;

			// Token: 0x04002423 RID: 9251
			[Token(Token = "0x4002423")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Sprite m_SelectedSprite;

			// Token: 0x04002424 RID: 9252
			[Token(Token = "0x4002424")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Sprite m_DisabledHighlightedSprite;
		}

		// Token: 0x020005A1 RID: 1441
		[Token(Token = "0x20005A1")]
		[Serializable]
		private class CustomAnimationTriggers
		{
			// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600241C")]
			[Address(RVA = "0x363F70", Offset = "0x363370", VA = "0x10363F70")]
			public CustomAnimationTriggers()
			{
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B3")]
			public string disabledTrigger
			{
				[Token(Token = "0x600241D")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600241E")]
				[Address(RVA = "0x273EF0", Offset = "0x2732F0", VA = "0x10273EF0")]
				set
				{
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x0600241F RID: 9247 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B4")]
			public string highlightedTrigger
			{
				[Token(Token = "0x600241F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002420")]
				[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
				set
				{
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B5")]
			public string normalTrigger
			{
				[Token(Token = "0x6002421")]
				[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002422")]
				[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
				set
				{
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B6")]
			public string pressedTrigger
			{
				[Token(Token = "0x6002423")]
				[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002424")]
				[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
				set
				{
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06002425 RID: 9253 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B7")]
			public string selectedTrigger
			{
				[Token(Token = "0x6002425")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002426")]
				[Address(RVA = "0x277A50", Offset = "0x276E50", VA = "0x10277A50")]
				set
				{
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007B8")]
			public string disabledHighlightedTrigger
			{
				[Token(Token = "0x6002427")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002428")]
				[Address(RVA = "0x277A60", Offset = "0x276E60", VA = "0x10277A60")]
				set
				{
				}
			}

			// Token: 0x06002429 RID: 9257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002429")]
			[Address(RVA = "0x364000", Offset = "0x363400", VA = "0x10364000")]
			public static implicit operator AnimationTriggers(ThemeSettings.CustomAnimationTriggers item)
			{
				return null;
			}

			// Token: 0x04002425 RID: 9253
			[Token(Token = "0x4002425")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string m_DisabledTrigger;

			// Token: 0x04002426 RID: 9254
			[Token(Token = "0x4002426")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private string m_HighlightedTrigger;

			// Token: 0x04002427 RID: 9255
			[Token(Token = "0x4002427")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string m_NormalTrigger;

			// Token: 0x04002428 RID: 9256
			[Token(Token = "0x4002428")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private string m_PressedTrigger;

			// Token: 0x04002429 RID: 9257
			[Token(Token = "0x4002429")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string m_SelectedTrigger;

			// Token: 0x0400242A RID: 9258
			[Token(Token = "0x400242A")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private string m_DisabledHighlightedTrigger;
		}

		// Token: 0x020005A2 RID: 1442
		[Token(Token = "0x20005A2")]
		[Serializable]
		private class TextSettings
		{
			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x0600242A RID: 9258 RVA: 0x0000AD28 File Offset: 0x00008F28
			[Token(Token = "0x170007B9")]
			public Color color
			{
				[Token(Token = "0x600242A")]
				[Address(RVA = "0x364630", Offset = "0x363A30", VA = "0x10364630")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007BA")]
			public TMP_FontAsset font
			{
				[Token(Token = "0x600242B")]
				[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x0600242C RID: 9260 RVA: 0x0000AD40 File Offset: 0x00008F40
			[Token(Token = "0x170007BB")]
			public ThemeSettings.FontStyleOverride style
			{
				[Token(Token = "0x600242C")]
				[Address(RVA = "0x277A40", Offset = "0x276E40", VA = "0x10277A40")]
				get
				{
					return ThemeSettings.FontStyleOverride.Default;
				}
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x0600242D RID: 9261 RVA: 0x0000AD58 File Offset: 0x00008F58
			[Token(Token = "0x170007BC")]
			public float sizeMultiplier
			{
				[Token(Token = "0x600242D")]
				[Address(RVA = "0x365CD0", Offset = "0x3650D0", VA = "0x10365CD0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x0000AD70 File Offset: 0x00008F70
			[Token(Token = "0x170007BD")]
			public float lineSpacing
			{
				[Token(Token = "0x600242E")]
				[Address(RVA = "0x365CC0", Offset = "0x3650C0", VA = "0x10365CC0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x0600242F RID: 9263 RVA: 0x0000AD88 File Offset: 0x00008F88
			[Token(Token = "0x170007BE")]
			public float chracterSpacing
			{
				[Token(Token = "0x600242F")]
				[Address(RVA = "0x328150", Offset = "0x327550", VA = "0x10328150")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x06002430 RID: 9264 RVA: 0x0000ADA0 File Offset: 0x00008FA0
			[Token(Token = "0x170007BF")]
			public float wordSpacing
			{
				[Token(Token = "0x6002430")]
				[Address(RVA = "0x328170", Offset = "0x327570", VA = "0x10328170")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002431")]
			[Address(RVA = "0x365C70", Offset = "0x365070", VA = "0x10365C70")]
			public TextSettings()
			{
			}

			// Token: 0x0400242B RID: 9259
			[Token(Token = "0x400242B")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Color _color;

			// Token: 0x0400242C RID: 9260
			[Token(Token = "0x400242C")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TMP_FontAsset _font;

			// Token: 0x0400242D RID: 9261
			[Token(Token = "0x400242D")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private ThemeSettings.FontStyleOverride _style;

			// Token: 0x0400242E RID: 9262
			[Token(Token = "0x400242E")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _sizeMultiplier;

			// Token: 0x0400242F RID: 9263
			[Token(Token = "0x400242F")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _lineSpacing;

			// Token: 0x04002430 RID: 9264
			[Token(Token = "0x4002430")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _characterSpacing;

			// Token: 0x04002431 RID: 9265
			[Token(Token = "0x4002431")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _wordSpacing;
		}

		// Token: 0x020005A3 RID: 1443
		[Token(Token = "0x20005A3")]
		private enum FontStyleOverride
		{
			// Token: 0x04002433 RID: 9267
			[Token(Token = "0x4002433")]
			Default,
			// Token: 0x04002434 RID: 9268
			[Token(Token = "0x4002434")]
			Normal,
			// Token: 0x04002435 RID: 9269
			[Token(Token = "0x4002435")]
			Bold,
			// Token: 0x04002436 RID: 9270
			[Token(Token = "0x4002436")]
			Italic,
			// Token: 0x04002437 RID: 9271
			[Token(Token = "0x4002437")]
			BoldAndItalic
		}
	}
}
