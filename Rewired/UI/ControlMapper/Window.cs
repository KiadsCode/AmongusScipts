using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE6A70", Offset = "0xE5E70")]
	[Attribute(Name = "RequireComponent", RVA = "0xE6A70", Offset = "0xE5E70")]
	public class Window : MonoBehaviour
	{
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x170007C9")]
		public bool hasFocus
		{
			[Token(Token = "0x600246A")]
			[Address(RVA = "0x7BD130", Offset = "0x7BC530", VA = "0x107BD130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x170007CA")]
		public int id
		{
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x277A30", Offset = "0x276E30", VA = "0x10277A30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CB")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x7BD1C0", Offset = "0x7BC5C0", VA = "0x107BD1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CC")]
		public TMP_Text titleText
		{
			[Token(Token = "0x600246D")]
			[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CD")]
		public List<TMP_Text> contentText
		{
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CE")]
		public GameObject defaultUIElement
		{
			[Token(Token = "0x600246F")]
			[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x2D5FB0", Offset = "0x2D53B0", VA = "0x102D5FB0")]
			set
			{
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007CF")]
		public Action<int> updateCallback
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x2D9140", Offset = "0x2D8540", VA = "0x102D9140")]
			set
			{
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D0")]
		public Window.Timer timer
		{
			[Token(Token = "0x6002473")]
			[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0000AEC0 File Offset: 0x000090C0
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D1")]
		public int width
		{
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x7BD250", Offset = "0x7BC650", VA = "0x107BD250")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002475")]
			[Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x107BD300")]
			set
			{
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0000AED8 File Offset: 0x000090D8
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D2")]
		public int height
		{
			[Token(Token = "0x6002476")]
			[Address(RVA = "0x7BD180", Offset = "0x7BC580", VA = "0x107BD180")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002477")]
			[Address(RVA = "0x7BD290", Offset = "0x7BC690", VA = "0x107BD290")]
			set
			{
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x170007D3")]
		protected bool initialized
		{
			[Token(Token = "0x6002478")]
			[Address(RVA = "0x27F3C0", Offset = "0x27E7C0", VA = "0x1027F3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x7BCC10", Offset = "0x7BC010", VA = "0x107BCC10")]
		private void OnEnable()
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x7BD080", Offset = "0x7BC480", VA = "0x107BD080", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x7BCAD0", Offset = "0x7BBED0", VA = "0x107BCAD0", Slot = "5")]
		public virtual void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x7BCE00", Offset = "0x7BC200", VA = "0x107BCE00")]
		public void SetSize(int width, int height)
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x7BC680", Offset = "0x7BBA80", VA = "0x107BC680")]
		public void CreateTitleText(GameObject prefab, Vector2 offset)
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x7BC700", Offset = "0x7BBB00", VA = "0x107BC700")]
		public void CreateTitleText(GameObject prefab, Vector2 offset, string text)
		{
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x7BBC10", Offset = "0x7BB010", VA = "0x107BBC10")]
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x7BBA90", Offset = "0x7BAE90", VA = "0x107BBA90")]
		public void AddContentText(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x7BB950", Offset = "0x7BAD50", VA = "0x107BB950")]
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x7BB950", Offset = "0x7BAD50", VA = "0x107BB950")]
		public void AddContentImage(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string text)
		{
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x7BBEF0", Offset = "0x7BB2F0", VA = "0x107BBEF0")]
		public void CreateButton(GameObject prefab, UIPivot pivot, UIAnchor anchor, Vector2 offset, string buttonText, UnityAction confirmCallback, UnityAction cancelCallback, bool setDefault)
		{
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x7BCA30", Offset = "0x7BBE30", VA = "0x107BCA30")]
		public string GetTitleText(string text)
		{
			return null;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x7BCE50", Offset = "0x7BC250", VA = "0x107BCE50")]
		public void SetTitleText(string text)
		{
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x7BC940", Offset = "0x7BBD40", VA = "0x107BC940")]
		public string GetContentText(int index)
		{
			return null;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x7BC850", Offset = "0x7BBC50", VA = "0x107BC850")]
		public float GetContentTextHeight(int index)
		{
			return 0f;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x7BCD20", Offset = "0x7BC120", VA = "0x107BCD20")]
		public void SetContentText(string text, int index)
		{
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x2D9140", Offset = "0x2D8540", VA = "0x102D9140")]
		public void SetUpdateCallback(Action<int> callback)
		{
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x7BCFA0", Offset = "0x7BC3A0", VA = "0x107BCFA0", Slot = "6")]
		public virtual void TakeInputFocus()
		{
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x7BC820", Offset = "0x7BBC20", VA = "0x107BC820", Slot = "7")]
		public virtual void Enable()
		{
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x7BC7F0", Offset = "0x7BBBF0", VA = "0x107BC7F0", Slot = "8")]
		public virtual void Disable()
		{
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x7BBCA0", Offset = "0x7BB0A0", VA = "0x107BBCA0", Slot = "9")]
		public virtual void Cancel()
		{
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x7BC470", Offset = "0x7BB870", VA = "0x107BC470")]
		private void CreateText(GameObject prefab, ref TMP_Text textComponent, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x7BC350", Offset = "0x7BB750", VA = "0x107BC350")]
		private void CreateImage(GameObject prefab, string name, UIPivot pivot, UIAnchor anchor, Vector2 offset)
		{
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x7BC100", Offset = "0x7BB500", VA = "0x107BC100")]
		private GameObject CreateButton(GameObject prefab, string name, UIAnchor anchor, UIPivot pivot, Vector2 offset, out ButtonInfo buttonInfo)
		{
			return null;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x7BCBC0", Offset = "0x7BBFC0", VA = "0x107BCBC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6B30", Offset = "0xE5F30")]
		private IEnumerator OnEnableAsync()
		{
			return null;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x7BBCD0", Offset = "0x7BB0D0", VA = "0x107BBCD0")]
		private void CheckUISelection()
		{
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x7BCC50", Offset = "0x7BC050", VA = "0x107BCC50")]
		private void RestoreDefaultOrLastUISelection()
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x7BCED0", Offset = "0x7BC2D0", VA = "0x107BCED0")]
		private void SetUISelection(GameObject selection)
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x7BD110", Offset = "0x7BC510", VA = "0x107BD110")]
		public Window()
		{
		}

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0xC")]
		public Image backgroundImage;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x10")]
		public GameObject content;

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x14")]
		private bool _initialized;

		// Token: 0x04002457 RID: 9303
		[Token(Token = "0x4002457")]
		[FieldOffset(Offset = "0x18")]
		private int _id;

		// Token: 0x04002458 RID: 9304
		[Token(Token = "0x4002458")]
		[FieldOffset(Offset = "0x1C")]
		private RectTransform _rectTransform;

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text _titleText;

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x24")]
		private List<TMP_Text> _contentText;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		[FieldOffset(Offset = "0x28")]
		private GameObject _defaultUIElement;

		// Token: 0x0400245C RID: 9308
		[Token(Token = "0x400245C")]
		[FieldOffset(Offset = "0x2C")]
		private Action<int> _updateCallback;

		// Token: 0x0400245D RID: 9309
		[Token(Token = "0x400245D")]
		[FieldOffset(Offset = "0x30")]
		private Func<int, bool> _isFocusedCallback;

		// Token: 0x0400245E RID: 9310
		[Token(Token = "0x400245E")]
		[FieldOffset(Offset = "0x34")]
		private Window.Timer _timer;

		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		[FieldOffset(Offset = "0x3C")]
		public UnityAction cancelCallback;

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x40")]
		private GameObject lastUISelection;

		// Token: 0x020005B3 RID: 1459
		[Token(Token = "0x20005B3")]
		public class Timer
		{
			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06002496 RID: 9366 RVA: 0x0000AF20 File Offset: 0x00009120
			[Token(Token = "0x170007D4")]
			public bool started
			{
				[Token(Token = "0x6002496")]
				[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06002497 RID: 9367 RVA: 0x0000AF38 File Offset: 0x00009138
			[Token(Token = "0x170007D5")]
			public bool finished
			{
				[Token(Token = "0x6002497")]
				[Address(RVA = "0x12FCBE0", Offset = "0x12FBFE0", VA = "0x112FCBE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06002498 RID: 9368 RVA: 0x0000AF50 File Offset: 0x00009150
			[Token(Token = "0x170007D6")]
			public float remaining
			{
				[Token(Token = "0x6002498")]
				[Address(RVA = "0x12FCC20", Offset = "0x12FC020", VA = "0x112FCC20")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002499")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public Timer()
			{
			}

			// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600249A")]
			[Address(RVA = "0x12FCBC0", Offset = "0x12FBFC0", VA = "0x112FCBC0")]
			public void Start(float length)
			{
			}

			// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600249B")]
			[Address(RVA = "0x757F10", Offset = "0x757310", VA = "0x10757F10")]
			public void Stop()
			{
			}

			// Token: 0x04002462 RID: 9314
			[Token(Token = "0x4002462")]
			[FieldOffset(Offset = "0x8")]
			private bool _started;

			// Token: 0x04002463 RID: 9315
			[Token(Token = "0x4002463")]
			[FieldOffset(Offset = "0xC")]
			private float end;
		}

		// Token: 0x020005B4 RID: 1460
		[Token(Token = "0x20005B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <OnEnableAsync>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600249C")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <OnEnableAsync>d__64(int <>1__state)
			{
			}

			// Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600249D")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600249E RID: 9374 RVA: 0x0000AF68 File Offset: 0x00009168
			[Token(Token = "0x600249E")]
			[Address(RVA = "0x1300520", Offset = "0x12FF920", VA = "0x11300520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x0600249F RID: 9375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007D7")]
			private object Current
			{
				[Token(Token = "0x600249F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024A0")]
			[Address(RVA = "0x13006C0", Offset = "0x12FFAC0", VA = "0x113006C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x060024A1 RID: 9377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007D8")]
			private object Current
			{
				[Token(Token = "0x60024A1")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04002464 RID: 9316
			[Token(Token = "0x4002464")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04002465 RID: 9317
			[Token(Token = "0x4002465")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04002466 RID: 9318
			[Token(Token = "0x4002466")]
			[FieldOffset(Offset = "0x10")]
			public Window <>4__this;
		}
	}
}
