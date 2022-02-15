using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000474 RID: 1140
[Token(Token = "0x2000474")]
public class ShadowCollab : MonoBehaviour
{
	// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x4933C0", Offset = "0x4927C0", VA = "0x104933C0")]
	public void OnEnable()
	{
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x493420", Offset = "0x492820", VA = "0x10493420")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0300", Offset = "0xDF700")]
	private IEnumerator Run()
	{
		return null;
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ShadowCollab()
	{
	}

	// Token: 0x04001875 RID: 6261
	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0xC")]
	public Camera ShadowCamera;

	// Token: 0x04001876 RID: 6262
	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0x10")]
	public MeshRenderer ShadowQuad;

	// Token: 0x04001877 RID: 6263
	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x14")]
	private float oldAspect;

	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Run>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Run>d__4(int <>1__state)
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x36F130", Offset = "0x36E530", VA = "0x1036F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000378")]
		private object Current
		{
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x36F360", Offset = "0x36E760", VA = "0x1036F360", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		private object Current
		{
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400187A RID: 6266
		[Token(Token = "0x400187A")]
		[FieldOffset(Offset = "0x10")]
		public ShadowCollab <>4__this;

		// Token: 0x0400187B RID: 6267
		[Token(Token = "0x400187B")]
		[FieldOffset(Offset = "0x14")]
		private Camera <cam>5__2;
	}
}
