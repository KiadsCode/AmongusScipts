using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x020002D1 RID: 721
[Token(Token = "0x20002D1")]
public class JoinGameButton : MonoBehaviour, IConnectButton
{
	// Token: 0x06000FE9 RID: 4073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x6D3300", Offset = "0x6D2700", VA = "0x106D3300")]
	public void OnClick()
	{
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x6D32B0", Offset = "0x6D26B0", VA = "0x106D32B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6460", Offset = "0xE5860")]
	private IEnumerator JoinLocalGame()
	{
		return null;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x6D3780", Offset = "0x6D2B80", VA = "0x106D3780")]
	public void SetGameName(string[] gameNameParts)
	{
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x6D3840", Offset = "0x6D2C40", VA = "0x106D3840", Slot = "4")]
	public void StartIcon()
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x6D3870", Offset = "0x6D2C70", VA = "0x106D3870", Slot = "5")]
	public void StopIcon()
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public JoinGameButton()
	{
	}

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip IntroMusic;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x10")]
	public TextBoxTMP GameIdText;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro gameNameText;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x18")]
	public float timeRecieved;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer FillScreen;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x20")]
	public SpriteAnim connectIcon;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x24")]
	public AnimationClip connectClip;

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000FB3")]
	[FieldOffset(Offset = "0x28")]
	public GameModes GameMode;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000FB4")]
	[FieldOffset(Offset = "0x2C")]
	public string netAddress;

	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <JoinLocalGame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000FEF RID: 4079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <JoinLocalGame>d__10(int <>1__state)
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x5B27B0", Offset = "0x5B1BB0", VA = "0x105B27B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		private object Current
		{
			[Token(Token = "0x6000FF2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x5B2C40", Offset = "0x5B2040", VA = "0x105B2C40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		private object Current
		{
			[Token(Token = "0x6000FF4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x10")]
		public JoinGameButton <>4__this;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x14")]
		private float <time>5__2;
	}
}
