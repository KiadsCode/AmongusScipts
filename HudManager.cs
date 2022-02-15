using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class HudManager : DestroyableSingleton<HudManager>
{
	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A2")]
	public Coroutine ReactorFlash
	{
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x3C1630", Offset = "0x3C0A30", VA = "0x103C1630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x392FE0", Offset = "0x3923E0", VA = "0x10392FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A3")]
	public Coroutine OxyFlash
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x3C1640", Offset = "0x3C0A40", VA = "0x103C1640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x3ECC60", Offset = "0x3EC060", VA = "0x103ECC60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000049E0 File Offset: 0x00002BE0
	[Token(Token = "0x170001A4")]
	public bool EmblemVisible
	{
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x3ECC00", Offset = "0x3EC000", VA = "0x103ECC00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x3EC2A0", Offset = "0x3EB6A0", VA = "0x103EC2A0")]
	public void Start()
	{
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x3EC1E0", Offset = "0x3EB5E0", VA = "0x103EC1E0")]
	public void ShowTaskComplete()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x3EB100", Offset = "0x3EA500", VA = "0x103EB100")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1460", Offset = "0xE0860")]
	private IEnumerator CoTaskComplete()
	{
		return null;
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x3EBB00", Offset = "0x3EAF00", VA = "0x103EBB00")]
	public void SetJoystickSize(float size)
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x3EBC90", Offset = "0x3EB090", VA = "0x103EBC90")]
	public void SetTouchType(ControlTypes type)
	{
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x3EB1B0", Offset = "0x3EA5B0", VA = "0x103EB1B0")]
	public void OpenMap()
	{
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x3EC030", Offset = "0x3EB430", VA = "0x103EC030")]
	public void ShowMap(Action<MapBehaviour> mapAction)
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x3EB820", Offset = "0x3EAC20", VA = "0x103EB820")]
	public void SetHudActive(bool isActive)
	{
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x3EC5E0", Offset = "0x3EB9E0", VA = "0x103EC5E0")]
	public void Update()
	{
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x3EBFD0", Offset = "0x3EB3D0", VA = "0x103EBFD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE14B0", Offset = "0xE08B0")]
	public IEnumerator ShowEmblem(bool shhh)
	{
		return null;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x3EC270", Offset = "0x3EB670", VA = "0x103EC270")]
	public void StartReactorFlash()
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x3EC240", Offset = "0x3EB640", VA = "0x103EC240")]
	public void StartOxyFlash()
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x3EC1B0", Offset = "0x3EB5B0", VA = "0x103EC1B0")]
	public void ShowPopUp(string text)
	{
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x3EC3C0", Offset = "0x3EB7C0", VA = "0x103EC3C0")]
	public void StopReactorFlash()
	{
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x3EC360", Offset = "0x3EB760", VA = "0x103EC360")]
	public void StopOxyFlash()
	{
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x3EAFE0", Offset = "0x3EA3E0", VA = "0x103EAFE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1550", Offset = "0xE0950")]
	public IEnumerator CoFadeFullScreen(Color source, Color target, float duration = 0.2f)
	{
		return null;
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x3EB050", Offset = "0x3EA450", VA = "0x103EB050")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE15F0", Offset = "0xE09F0")]
	private IEnumerator CoReactorFlash()
	{
		return null;
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B24")]
	[Address(RVA = "0x3EB0A0", Offset = "0x3EA4A0", VA = "0x103EB0A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1640", Offset = "0xE0A40")]
	public IEnumerator CoShowIntro(List<PlayerControl> yourTeam)
	{
		return null;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x3EB440", Offset = "0x3EA840", VA = "0x103EB440")]
	public void OpenMeetingRoom(PlayerControl reporter)
	{
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x3EB150", Offset = "0x3EA550", VA = "0x103EB150", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x3ECBA0", Offset = "0x3EBFA0", VA = "0x103ECBA0")]
	public HudManager()
	{
	}

	// Token: 0x04000B1D RID: 2845
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x10")]
	public FollowerCamera PlayerCam;

	// Token: 0x04000B1E RID: 2846
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x14")]
	public Camera UICamera;

	// Token: 0x04000B1F RID: 2847
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x18")]
	public MeetingHud MeetingPrefab;

	// Token: 0x04000B20 RID: 2848
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x1C")]
	public KillButton KillButton;

	// Token: 0x04000B21 RID: 2849
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x20")]
	public SabotageButton SabotageButton;

	// Token: 0x04000B22 RID: 2850
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x24")]
	public VentButton ImpostorVentButton;

	// Token: 0x04000B23 RID: 2851
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x28")]
	public UseButton UseButton;

	// Token: 0x04000B24 RID: 2852
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x2C")]
	public AbilityButton AbilityButton;

	// Token: 0x04000B25 RID: 2853
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x30")]
	public ReportButton ReportButton;

	// Token: 0x04000B26 RID: 2854
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x34")]
	public TextMeshPro GameSettings;

	// Token: 0x04000B27 RID: 2855
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TaskStuff;

	// Token: 0x04000B28 RID: 2856
	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x3C")]
	public ChatController Chat;

	// Token: 0x04000B29 RID: 2857
	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x40")]
	public DialogueBox Dialogue;

	// Token: 0x04000B2A RID: 2858
	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x44")]
	public TextMeshPro TaskText;

	// Token: 0x04000B2B RID: 2859
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x48")]
	public Transform TaskCompleteOverlay;

	// Token: 0x04000B2C RID: 2860
	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x4C")]
	private float taskDirtyTimer;

	// Token: 0x04000B2D RID: 2861
	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x50")]
	public MeshRenderer ShadowQuad;

	// Token: 0x04000B2E RID: 2862
	[Token(Token = "0x4000B2E")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer FullScreen;

	// Token: 0x04000B2F RID: 2863
	[Token(Token = "0x4000B2F")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Coroutine <ReactorFlash>k__BackingField;

	// Token: 0x04000B30 RID: 2864
	[Token(Token = "0x4000B30")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Coroutine <OxyFlash>k__BackingField;

	// Token: 0x04000B31 RID: 2865
	[Token(Token = "0x4000B31")]
	[FieldOffset(Offset = "0x60")]
	public SpriteRenderer MapButton;

	// Token: 0x04000B32 RID: 2866
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x64")]
	public KillOverlay KillOverlay;

	// Token: 0x04000B33 RID: 2867
	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x68")]
	public IVirtualJoystick joystick;

	// Token: 0x04000B34 RID: 2868
	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x6C")]
	public MonoBehaviour[] Joysticks;

	// Token: 0x04000B35 RID: 2869
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x70")]
	public DiscussBehaviour discussEmblem;

	// Token: 0x04000B36 RID: 2870
	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x74")]
	public ShhhBehaviour shhhEmblem;

	// Token: 0x04000B37 RID: 2871
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x78")]
	public IntroCutscene IntroPrefab;

	// Token: 0x04000B38 RID: 2872
	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x7C")]
	public OptionsMenuBehaviour GameMenu;

	// Token: 0x04000B39 RID: 2873
	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x80")]
	public NotificationPopper Notifier;

	// Token: 0x04000B3A RID: 2874
	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x84")]
	public RoomTracker roomTracker;

	// Token: 0x04000B3B RID: 2875
	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x88")]
	public AudioClip TaskCompleteSound;

	// Token: 0x04000B3C RID: 2876
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x8C")]
	public AudioClip TaskUpdateSound;

	// Token: 0x04000B3D RID: 2877
	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x90")]
	public Transform consoleUIRoot;

	// Token: 0x04000B3E RID: 2878
	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x94")]
	public GameObject[] consoleUIObjects;

	// Token: 0x04000B3F RID: 2879
	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x98")]
	public GameObject menuNavigationPrompts;

	// Token: 0x04000B40 RID: 2880
	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x9C")]
	[NonSerialized]
	public float consoleUIHorizontalShift;

	// Token: 0x04000B41 RID: 2881
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject playerListPrompt;

	// Token: 0x04000B42 RID: 2882
	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0xA4")]
	private StringBuilder tasksString;

	// Token: 0x04000B43 RID: 2883
	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0xA8")]
	private bool isIntroDisplayed;

	// Token: 0x04000B44 RID: 2884
	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0xAC")]
	private DualshockLightManager.LightOverlayHandle lightFlashHandle;

	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoTaskComplete>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B28 RID: 2856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoTaskComplete>d__50(int <>1__state)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x5AE6F0", Offset = "0x5ADAF0", VA = "0x105AE6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		private object Current
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x5AE990", Offset = "0x5ADD90", VA = "0x105AE990", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A6")]
		private object Current
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x10")]
		public HudManager <>4__this;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}

	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x5B4AC0", Offset = "0x5B3EC0", VA = "0x105B4AC0")]
		internal void <OpenMap>b__53_0(MapBehaviour m)
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5B4C30", Offset = "0x5B4030", VA = "0x105B4C30")]
		internal bool <StopReactorFlash>b__61_0(PlainShipRoom r)
		{
			return default(bool);
		}

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HudManager.<>c <>9;

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		[FieldOffset(Offset = "0x4")]
		public static Action<MapBehaviour> <>9__53_0;

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlainShipRoom, bool> <>9__61_0;
	}

	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowEmblem>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowEmblem>d__57(int <>1__state)
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x5B4130", Offset = "0x5B3530", VA = "0x105B4130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A7")]
		private object Current
		{
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5B4250", Offset = "0x5B3650", VA = "0x105B4250", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A8")]
		private object Current
		{
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		[FieldOffset(Offset = "0x10")]
		public bool shhh;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		[FieldOffset(Offset = "0x14")]
		public HudManager <>4__this;
	}

	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoFadeFullScreen>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoFadeFullScreen>d__63(int <>1__state)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x5AA1B0", Offset = "0x5A95B0", VA = "0x105AA1B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A9")]
		private object Current
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x5AA410", Offset = "0x5A9810", VA = "0x105AA410", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		private object Current
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x10")]
		public HudManager <>4__this;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x14")]
		public Color target;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x24")]
		public Color source;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x34")]
		public float duration;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x38")]
		private float <t>5__2;
	}

	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoReactorFlash>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B3E RID: 2878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoReactorFlash>d__64(int <>1__state)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5ABB50", Offset = "0x5AAF50", VA = "0x105ABB50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AB")]
		private object Current
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5ABDC0", Offset = "0x5AB1C0", VA = "0x105ABDC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AC")]
		private object Current
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x10")]
		public HudManager <>4__this;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x14")]
		private WaitForSeconds <wait>5__2;
	}

	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShowIntro>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShowIntro>d__65(int <>1__state)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x5ACFF0", Offset = "0x5AC3F0", VA = "0x105ACFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AD")]
		private object Current
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x5AD430", Offset = "0x5AC830", VA = "0x105AD430", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AE")]
		private object Current
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x10")]
		public HudManager <>4__this;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0x14")]
		public List<PlayerControl> yourTeam;
	}
}
