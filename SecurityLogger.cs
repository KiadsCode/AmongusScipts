using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000452 RID: 1106
[Token(Token = "0x2000452")]
public class SecurityLogger : MonoBehaviour
{
	// Token: 0x06001795 RID: 6037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x58F740", Offset = "0x58EB40", VA = "0x1058F740")]
	private void Awake()
	{
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001796")]
	[Address(RVA = "0x58F810", Offset = "0x58EC10", VA = "0x1058F810")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001797")]
	[Address(RVA = "0x58F7C0", Offset = "0x58EBC0", VA = "0x1058F7C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE00D0", Offset = "0xDF4D0")]
	private IEnumerator BlinkSensor()
	{
		return null;
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001798")]
	[Address(RVA = "0x58FBC0", Offset = "0x58EFC0", VA = "0x1058FBC0")]
	public SecurityLogger()
	{
	}

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x0")]
	private static Collider2D[] hits;

	// Token: 0x040017A8 RID: 6056
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0xC")]
	public SecurityLogBehaviour LogParent;

	// Token: 0x040017A9 RID: 6057
	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x10")]
	public SecurityLogBehaviour.SecurityLogLocations MyLocation;

	// Token: 0x040017AA RID: 6058
	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x14")]
	public float Cooldown;

	// Token: 0x040017AB RID: 6059
	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Image;

	// Token: 0x040017AC RID: 6060
	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider2D Sensor;

	// Token: 0x040017AD RID: 6061
	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x20")]
	private float[] Timers;

	// Token: 0x040017AE RID: 6062
	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x24")]
	private ContactFilter2D filter;

	// Token: 0x02000453 RID: 1107
	[Token(Token = "0x2000453")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x0600179A RID: 6042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x371CA0", Offset = "0x3710A0", VA = "0x10371CA0")]
		internal bool <FixedUpdate>b__0(PlayerControl p)
		{
			return default(bool);
		}

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x8")]
		public int i;
	}

	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <BlinkSensor>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <BlinkSensor>d__10(int <>1__state)
		{
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x366750", Offset = "0x365B50", VA = "0x10366750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		private object Current
		{
			[Token(Token = "0x600179F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x366900", Offset = "0x365D00", VA = "0x10366900", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036D")]
		private object Current
		{
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x10")]
		public SecurityLogger <>4__this;
	}
}
