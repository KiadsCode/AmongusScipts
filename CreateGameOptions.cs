using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020002B7 RID: 695
[Token(Token = "0x20002B7")]
public class CreateGameOptions : MonoBehaviour, IConnectButton
{
	// Token: 0x06000F6E RID: 3950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x5B8040", Offset = "0x5B7440", VA = "0x105B8040")]
	public void Show()
	{
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x5B7EA0", Offset = "0x5B72A0", VA = "0x105B7EA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5C80", Offset = "0xE5080")]
	private IEnumerator CoShow()
	{
		return null;
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x5B81F0", Offset = "0x5B75F0", VA = "0x105B81F0", Slot = "4")]
	public void StartIcon()
	{
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x5B8270", Offset = "0x5B7670", VA = "0x105B8270", Slot = "5")]
	public void StopIcon()
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x5B7FE0", Offset = "0x5B73E0", VA = "0x105B7FE0")]
	public void Hide()
	{
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x5B7E50", Offset = "0x5B7250", VA = "0x105B7E50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5CD0", Offset = "0xE50D0")]
	private IEnumerator CoHide()
	{
		return null;
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x5B7F40", Offset = "0x5B7340", VA = "0x105B7F40")]
	public void Confirm()
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x5B7EF0", Offset = "0x5B72F0", VA = "0x105B7EF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5D60", Offset = "0xE5160")]
	private IEnumerator CoStartGame()
	{
		return null;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public CreateGameOptions()
	{
	}

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip IntroMusic;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Content;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Foreground;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x18")]
	public SpriteAnim connectIcon;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x1C")]
	public AnimationClip connectClip;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x24")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x28")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x2C")]
	public PassiveButton RegionButton;

	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShow>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShow>d__10(int <>1__state)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x786A30", Offset = "0x785E30", VA = "0x10786A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000259")]
		private object Current
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x786CD0", Offset = "0x7860D0", VA = "0x10786CD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025A")]
		private object Current
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[FieldOffset(Offset = "0x10")]
		public CreateGameOptions <>4__this;
	}

	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoHide>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoHide>d__14(int <>1__state)
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x784CF0", Offset = "0x7840F0", VA = "0x10784CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		private object Current
		{
			[Token(Token = "0x6000F80")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x784F80", Offset = "0x784380", VA = "0x10784F80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		private object Current
		{
			[Token(Token = "0x6000F82")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x10")]
		public CreateGameOptions <>4__this;
	}

	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartGame>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartGame>d__16(int <>1__state)
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x786D00", Offset = "0x786100", VA = "0x10786D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		private object Current
		{
			[Token(Token = "0x6000F86")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x786EC0", Offset = "0x7862C0", VA = "0x10786EC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		private object Current
		{
			[Token(Token = "0x6000F88")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x10")]
		public CreateGameOptions <>4__this;
	}
}
