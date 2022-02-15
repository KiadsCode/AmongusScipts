using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class InGamePlayerList : MonoBehaviour
{
	// Token: 0x06000B4D RID: 2893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x3EDBB0", Offset = "0x3ECFB0", VA = "0x103EDBB0")]
	private void Awake()
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x3EDD20", Offset = "0x3ED120", VA = "0x103EDD20")]
	private void OnEnable()
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x3EDCF0", Offset = "0x3ED0F0", VA = "0x103EDCF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x3EE020", Offset = "0x3ED420", VA = "0x103EE020")]
	private void RefreshMenu()
	{
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00004A88 File Offset: 0x00002C88
	[Token(Token = "0x170001AF")]
	public bool IsActive
	{
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x3EE390", Offset = "0x3ED790", VA = "0x103EE390")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x3EE220", Offset = "0x3ED620", VA = "0x103EE220")]
	public void ToggleActive()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x3EE0B0", Offset = "0x3ED4B0", VA = "0x103EE0B0")]
	public void SetActive(bool active)
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x3EE300", Offset = "0x3ED700", VA = "0x103EE300")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE17D0", Offset = "0xE0BD0")]
	private IEnumerator TransitionCoroutine(float targetValue)
	{
		return null;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x3EE190", Offset = "0x3ED590", VA = "0x103EE190")]
	public void SetBackgroundMaskLayer(int maskLayer)
	{
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x3EDD90", Offset = "0x3ED190", VA = "0x103EDD90")]
	private void PopulateButtons()
	{
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x3EE360", Offset = "0x3ED760", VA = "0x103EE360")]
	public InGamePlayerList()
	{
	}

	// Token: 0x04000B5F RID: 2911
	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 offsetFromEdge;

	// Token: 0x04000B60 RID: 2912
	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x18")]
	private float windowWidth;

	// Token: 0x04000B61 RID: 2913
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 openPosition;

	// Token: 0x04000B62 RID: 2914
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 closedPosition;

	// Token: 0x04000B63 RID: 2915
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x34")]
	public float openTime;

	// Token: 0x04000B64 RID: 2916
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x38")]
	public float buttonHeight;

	// Token: 0x04000B65 RID: 2917
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x3C")]
	public ObjectPoolBehavior buttonPool;

	// Token: 0x04000B66 RID: 2918
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x40")]
	public ControllerNavMenu controllerNavMenu;

	// Token: 0x04000B67 RID: 2919
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x44")]
	public SpriteRenderer backgroundSprite;

	// Token: 0x04000B68 RID: 2920
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer backgroundSpriteMask;

	// Token: 0x04000B69 RID: 2921
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ChatScreen;

	// Token: 0x04000B6A RID: 2922
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x50")]
	public ControllerButtonBehavior OpenChatButton;

	// Token: 0x04000B6B RID: 2923
	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x54")]
	private InGamePlayerList.ListState currentState;

	// Token: 0x04000B6C RID: 2924
	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x58")]
	private float openLevel;

	// Token: 0x04000B6D RID: 2925
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x0")]
	public static InGamePlayerList instance;

	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	private enum ListState
	{
		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		Closed,
		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		Open,
		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		Opening,
		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		Closing
	}

	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <TransitionCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <TransitionCoroutine>d__24(int <>1__state)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5B4410", Offset = "0x5B3810", VA = "0x105B4410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		private object Current
		{
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x5B4760", Offset = "0x5B3B60", VA = "0x105B4760", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B1")]
		private object Current
		{
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x10")]
		public InGamePlayerList <>4__this;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x14")]
		public float targetValue;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x18")]
		private float <dir>5__2;
	}
}
