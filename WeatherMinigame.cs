using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Token(Token = "0x20000B4")]
public class WeatherMinigame : Minigame
{
	// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000443")]
	[Address(RVA = "0x7BA100", Offset = "0x7B9500", VA = "0x107BA100", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000444")]
	[Address(RVA = "0x7BA250", Offset = "0x7B9650", VA = "0x107BA250")]
	private void OnDisable()
	{
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000445")]
	[Address(RVA = "0x7BA2C0", Offset = "0x7B96C0", VA = "0x107BA2C0")]
	public void StartStopFill()
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000446")]
	[Address(RVA = "0x7BA200", Offset = "0x7B9600", VA = "0x107BA200")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE62F0", Offset = "0xE56F0")]
	private IEnumerator CoDoAnimation()
	{
		return null;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000447")]
	[Address(RVA = "0x7BA190", Offset = "0x7B9590", VA = "0x107BA190", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000448")]
	[Address(RVA = "0x7B6400", Offset = "0x7B5800", VA = "0x107B6400")]
	public WeatherMinigame()
	{
	}

	// Token: 0x040004A2 RID: 1186
	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x30")]
	public float Duration;

	// Token: 0x040004A3 RID: 1187
	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x34")]
	public HorizontalGauge destGauge1;

	// Token: 0x040004A4 RID: 1188
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x38")]
	public HorizontalGauge destGauge2;

	// Token: 0x040004A5 RID: 1189
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x3C")]
	public HorizontalGauge destGauge3;

	// Token: 0x040004A6 RID: 1190
	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x40")]
	public PassiveButton StartButton;

	// Token: 0x040004A7 RID: 1191
	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x44")]
	public TextMeshPro EtaText;

	// Token: 0x040004A8 RID: 1192
	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip StartSound;

	// Token: 0x040004A9 RID: 1193
	[Token(Token = "0x40004A9")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x040004AA RID: 1194
	[Token(Token = "0x40004AA")]
	[FieldOffset(Offset = "0x50")]
	public UiElement DefaultButtonSelected;

	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDoAnimation>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDoAnimation>d__12(int <>1__state)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x12FE3C0", Offset = "0x12FD7C0", VA = "0x112FE3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		private object Current
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x12FE8B0", Offset = "0x12FDCB0", VA = "0x112FE8B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		private object Current
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x10")]
		public WeatherMinigame <>4__this;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}
}
