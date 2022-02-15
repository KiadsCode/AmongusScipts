using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001E0 RID: 480
[Token(Token = "0x20001E0")]
public class ChatController : MonoBehaviour
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x17000199")]
	public bool IsOpen
	{
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x833A90", Offset = "0x832E90", VA = "0x10833A90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x832640", Offset = "0x831A40", VA = "0x10832640")]
	private void Awake()
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x8328A0", Offset = "0x831CA0", VA = "0x108328A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x833270", Offset = "0x832670", VA = "0x10833270")]
	public void Toggle()
	{
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x8330F0", Offset = "0x8324F0", VA = "0x108330F0")]
	public void SetVisible(bool visible)
	{
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x832770", Offset = "0x831B70", VA = "0x10832770")]
	public void ForceClosed()
	{
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x832720", Offset = "0x831B20", VA = "0x10832720")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1230", Offset = "0xE0630")]
	public IEnumerator CoOpen()
	{
		return null;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x8326D0", Offset = "0x831AD0", VA = "0x108326D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1280", Offset = "0xE0680")]
	public IEnumerator CoClose()
	{
		return null;
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x832F90", Offset = "0x832390", VA = "0x10832F90")]
	public void SetPosition(MeetingHud meeting)
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x8334F0", Offset = "0x8328F0", VA = "0x108334F0")]
	public void UpdateCharCount()
	{
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x8337D0", Offset = "0x832BD0", VA = "0x108337D0")]
	private void Update()
	{
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x832920", Offset = "0x831D20", VA = "0x10832920")]
	public void SendChat()
	{
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x832C60", Offset = "0x832060", VA = "0x10832C60")]
	public void SendFreeChat()
	{
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x832D10", Offset = "0x832110", VA = "0x10832D10")]
	public void SendQuickChat()
	{
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x8339C0", Offset = "0x832DC0", VA = "0x108339C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE12D0", Offset = "0xE06D0")]
	public IEnumerator WaitForNameToExist(GameData.PlayerInfo player, Action<GameData.PlayerInfo> onNameExistsCallback)
	{
		return null;
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x831960", Offset = "0x830D60", VA = "0x10831960")]
	public void AddChatNote(GameData.PlayerInfo srcPlayer, ChatNoteTypes noteType)
	{
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x831CC0", Offset = "0x8310C0", VA = "0x10831CC0")]
	public void AddChat(PlayerControl sourcePlayer, string chatText)
	{
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x832DC0", Offset = "0x8321C0", VA = "0x10832DC0")]
	private void SetChatBubbleName(ChatBubble bubble, GameData.PlayerInfo playerInfo, bool isDead, bool didVote, Color nameColor, [Optional] ChatController.GetFormattedNameFunc getFormattedNameFunc)
	{
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x832410", Offset = "0x831810", VA = "0x10832410")]
	private void AlignAllBubbles()
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x832680", Offset = "0x831A80", VA = "0x10832680")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1370", Offset = "0xE0770")]
	private IEnumerator BounceDot()
	{
		return null;
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x832870", Offset = "0x831C70", VA = "0x10832870")]
	public void GiveFocus()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x833A20", Offset = "0x832E20", VA = "0x10833A20")]
	public ChatController()
	{
	}

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	private const float ScreenSizePercent = 0.8f;

	// Token: 0x04000AC7 RID: 2759
	[Token(Token = "0x4000AC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public ObjectPoolBehavior chatBubPool;

	// Token: 0x04000AC8 RID: 2760
	[Token(Token = "0x4000AC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform TypingArea;

	// Token: 0x04000AC9 RID: 2761
	[Token(Token = "0x4000AC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public SpriteRenderer TextBubble;

	// Token: 0x04000ACA RID: 2762
	[Token(Token = "0x4000ACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextBoxTMP TextArea;

	// Token: 0x04000ACB RID: 2763
	[Token(Token = "0x4000ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public TextMeshPro CharCount;

	// Token: 0x04000ACC RID: 2764
	[Token(Token = "0x4000ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaxChat;

	// Token: 0x04000ACD RID: 2765
	[Token(Token = "0x4000ACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Scroller scroller;

	// Token: 0x04000ACE RID: 2766
	[Token(Token = "0x4000ACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Content;

	// Token: 0x04000ACF RID: 2767
	[Token(Token = "0x4000ACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public SpriteRenderer BackgroundImage;

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteRenderer ChatNotifyDot;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public TextMeshPro SendRateMessage;

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 SourcePos;

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 TargetPos;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 MeetingHudPos;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000AD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public AspectPosition AspectPosition;

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000AD6")]
	private const float MaxChatSendRate = 3f;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000AD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float TimeSinceLastMessage;

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000AD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AudioClip MessageSound;

	// Token: 0x04000AD9 RID: 2777
	[Token(Token = "0x4000AD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool animating;

	// Token: 0x04000ADA RID: 2778
	[Token(Token = "0x4000ADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Coroutine notificationRoutine;

	// Token: 0x04000ADB RID: 2779
	[Token(Token = "0x4000ADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public BanMenu BanButton;

	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x4000ADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public QuickChatMenu quickChatMenu;

	// Token: 0x04000ADD RID: 2781
	[Token(Token = "0x4000ADD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public QuickChatNetData quickChatData;

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public GameObject OpenKeyboardButton;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject ChatButton;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000AE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x4000AE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private SpecialInputHandler specialInputHandler;

	// Token: 0x020001E1 RID: 481
	// (Invoke) Token: 0x06000ACD RID: 2765
	[Token(Token = "0x20001E1")]
	private delegate string GetFormattedNameFunc(string name);

	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoOpen>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoOpen>d__37(int <>1__state)
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x3C5230", Offset = "0x3C4630", VA = "0x103C5230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019A")]
		private object Current
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x3C56E0", Offset = "0x3C4AE0", VA = "0x103C56E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019B")]
		private object Current
		{
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChatController <>4__this;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 <scale>5__2;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <targetScale>5__3;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <timer>5__4;
	}

	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoClose>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoClose>d__38(int <>1__state)
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x3C35C0", Offset = "0x3C29C0", VA = "0x103C35C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019C")]
		private object Current
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x3C39C0", Offset = "0x3C2DC0", VA = "0x103C39C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019D")]
		private object Current
		{
			[Token(Token = "0x6000ADB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChatController <>4__this;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 <scale>5__2;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <targetScale>5__3;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float <timer>5__4;
	}

	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForNameToExist>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForNameToExist>d__45(int <>1__state)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x3CAE90", Offset = "0x3CA290", VA = "0x103CAE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019E")]
		private object Current
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x3CAF40", Offset = "0x3CA340", VA = "0x103CAF40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019F")]
		private object Current
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameData.PlayerInfo player;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Action<GameData.PlayerInfo> onNameExistsCallback;
	}

	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass46_0
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass46_0()
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x3CA660", Offset = "0x3C9A60", VA = "0x103CA660")]
		internal string <AddChatNote>b__0(string returnedName)
		{
			return null;
		}

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int rem;
	}

	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass49_0
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass49_0()
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x3CA770", Offset = "0x3C9B70", VA = "0x103CA770")]
		internal void <SetChatBubbleName>b__0(GameData.PlayerInfo player)
		{
		}

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ChatController.GetFormattedNameFunc getFormattedNameFunc;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameData.PlayerInfo playerInfo;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChatBubble bubble;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool isDead;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool didVote;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color nameColor;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ChatController <>4__this;
	}

	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BounceDot>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BounceDot>d__51(int <>1__state)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x3C2D30", Offset = "0x3C2130", VA = "0x103C2D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A0")]
		private object Current
		{
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x3C2E10", Offset = "0x3C2210", VA = "0x103C2E10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A1")]
		private object Current
		{
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ChatController <>4__this;
	}
}
