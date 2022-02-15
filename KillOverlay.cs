using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
public class KillOverlay : MonoBehaviour
{
	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x170001B6")]
	public bool IsOpen
	{
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x6D7060", Offset = "0x6D6460", VA = "0x106D7060")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x6D6FB0", Offset = "0x6D63B0", VA = "0x106D6FB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1940", Offset = "0xE0D40")]
	public IEnumerator WaitForFinish()
	{
		return null;
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x6D6D10", Offset = "0x6D6110", VA = "0x106D6D10")]
	public void ShowKillAnimation(GameData.PlayerInfo killer, GameData.PlayerInfo victim)
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x6D6ED0", Offset = "0x6D62D0", VA = "0x106D6ED0")]
	public void ShowMeeting(MeetingCalledAnimation prefab, GameData.PlayerInfo playerInfo)
	{
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x6D6CC0", Offset = "0x6D60C0", VA = "0x106D6CC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1990", Offset = "0xE0D90")]
	private IEnumerator ShowAll()
	{
		return null;
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x6D6C60", Offset = "0x6D6060", VA = "0x106D6C60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE19E0", Offset = "0xE0DE0")]
	private IEnumerator CoShowOne(OverlayAnimation anim)
	{
		return null;
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x6D7000", Offset = "0x6D6400", VA = "0x106D7000")]
	public KillOverlay()
	{
	}

	// Token: 0x04000B9A RID: 2970
	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer background;

	// Token: 0x04000B9B RID: 2971
	[Token(Token = "0x4000B9B")]
	[FieldOffset(Offset = "0x10")]
	public GameObject flameParent;

	// Token: 0x04000B9C RID: 2972
	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x14")]
	public OverlayKillAnimation[] KillAnims;

	// Token: 0x04000B9D RID: 2973
	[Token(Token = "0x4000B9D")]
	[FieldOffset(Offset = "0x18")]
	private Queue<Func<IEnumerator>> queue;

	// Token: 0x04000B9E RID: 2974
	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x1C")]
	private Coroutine showAll;

	// Token: 0x04000B9F RID: 2975
	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine showOne;

	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForFinish>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForFinish>d__8(int <>1__state)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x5B6010", Offset = "0x5B5410", VA = "0x105B6010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B7")]
		private object Current
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x5B6080", Offset = "0x5B5480", VA = "0x105B6080", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		private object Current
		{
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x10")]
		public KillOverlay <>4__this;
	}

	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x5B59C0", Offset = "0x5B4DC0", VA = "0x105B59C0")]
		internal IEnumerator <ShowKillAnimation>b__0()
		{
			return null;
		}

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x8")]
		public IEnumerable<OverlayKillAnimation> killAnims;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0xC")]
		public KillOverlay <>4__this;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x10")]
		public GameData.PlayerInfo killer;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x14")]
		public GameData.PlayerInfo victim;
	}

	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x5B4EF0", Offset = "0x5B42F0", VA = "0x105B4EF0")]
		internal IEnumerator <ShowMeeting>b__0()
		{
			return null;
		}

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x8")]
		public MeetingCalledAnimation prefab;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0xC")]
		public KillOverlay <>4__this;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x10")]
		public GameData.PlayerInfo playerInfo;
	}

	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowAll>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowAll>d__11(int <>1__state)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x5B4030", Offset = "0x5B3430", VA = "0x105B4030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		private object Current
		{
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x5B4100", Offset = "0x5B3500", VA = "0x105B4100", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BA")]
		private object Current
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x10")]
		public KillOverlay <>4__this;
	}

	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoShowOne>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoShowOne>d__12(int <>1__state)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x5AD460", Offset = "0x5AC860", VA = "0x105AD460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		private object Current
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x5AD530", Offset = "0x5AC930", VA = "0x105AD530", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		private object Current
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x10")]
		public OverlayAnimation anim;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x14")]
		public KillOverlay <>4__this;
	}
}
