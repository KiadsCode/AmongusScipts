using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[Token(Token = "0x20000C8")]
public static class Effects
{
	// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x4744A0", Offset = "0x4738A0", VA = "0x104744A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE64B0", Offset = "0xE58B0")]
	public static IEnumerator Action(Action todo)
	{
		return null;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x474FD0", Offset = "0x4743D0", VA = "0x10474FD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6500", Offset = "0xE5900")]
	public static IEnumerator Wait(float duration)
	{
		return null;
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x474D00", Offset = "0x474100", VA = "0x10474D00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6550", Offset = "0xE5950")]
	public static IEnumerator Sequence(params IEnumerator[] items)
	{
		return null;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x4744F0", Offset = "0x4738F0", VA = "0x104744F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE65A0", Offset = "0xE59A0")]
	public static IEnumerator All(params IEnumerator[] items)
	{
		return null;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x474A70", Offset = "0x473E70", VA = "0x10474A70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE65F0", Offset = "0xE59F0")]
	internal static IEnumerator Lerp(float duration, Action<float> action)
	{
		return null;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x474AD0", Offset = "0x473ED0", VA = "0x10474AD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6640", Offset = "0xE5A40")]
	internal static IEnumerator Overlerp(float duration, Action<float> action, float overextend = 0.05f)
	{
		return null;
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x474C90", Offset = "0x474090", VA = "0x10474C90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6690", Offset = "0xE5A90")]
	internal static IEnumerator ScaleIn(Transform self, float source, float target, float duration)
	{
		return null;
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x474920", Offset = "0x473D20", VA = "0x10474920")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE66E0", Offset = "0xE5AE0")]
	internal static IEnumerator CycleColors(SpriteRenderer self, Color source, Color target, float rate, float duration)
	{
		return null;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x474BB0", Offset = "0x473FB0", VA = "0x10474BB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6730", Offset = "0xE5B30")]
	internal static IEnumerator PulseColor(SpriteRenderer self, Color source, Color target, float duration = 0.5f)
	{
		return null;
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x474B40", Offset = "0x473F40", VA = "0x10474B40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6780", Offset = "0xE5B80")]
	internal static IEnumerator PulseColor(TextMeshPro self, Color source, Color target, float duration = 0.5f)
	{
		return null;
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x4748B0", Offset = "0x473CB0", VA = "0x104748B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE67D0", Offset = "0xE5BD0")]
	public static IEnumerator ColorFade(TextMeshPro self, Color source, Color target, float duration)
	{
		return null;
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x474840", Offset = "0x473C40", VA = "0x10474840")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6820", Offset = "0xE5C20")]
	public static IEnumerator ColorFade(SpriteRenderer self, Color source, Color target, float duration)
	{
		return null;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x474C20", Offset = "0x474020", VA = "0x10474C20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6870", Offset = "0xE5C70")]
	public static IEnumerator Rotate2D(Transform target, float source, float dest, float duration = 0.75f)
	{
		return null;
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x474EE0", Offset = "0x4742E0", VA = "0x10474EE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6930", Offset = "0xE5D30")]
	public static IEnumerator Slide3D(Transform target, Vector3 source, Vector3 dest, float duration = 0.75f)
	{
		return null;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x474E50", Offset = "0x474250", VA = "0x10474E50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6980", Offset = "0xE5D80")]
	public static IEnumerator Slide2D(Transform target, Vector2 source, Vector2 dest, float duration = 0.75f)
	{
		return null;
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x474DC0", Offset = "0x4741C0", VA = "0x10474DC0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE69D0", Offset = "0xE5DD0")]
	public static IEnumerator Slide2DWorld(Transform target, Vector2 source, Vector2 dest, float duration = 0.75f)
	{
		return null;
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x4747D0", Offset = "0x473BD0", VA = "0x104747D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6A20", Offset = "0xE5E20")]
	public static IEnumerator Bounce(Transform target, float duration = 0.3f, float height = 0.15f)
	{
		return null;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x474D50", Offset = "0x474150", VA = "0x10474D50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6AE0", Offset = "0xE5EE0")]
	public static IEnumerator Shake(Transform target, float duration, float halfWidth, bool taper)
	{
		return null;
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x474F60", Offset = "0x474360", VA = "0x10474F60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6B80", Offset = "0xE5F80")]
	public static IEnumerator SwayX(Transform target, float duration = 0.75f, float halfWidth = 0.25f)
	{
		return null;
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x474760", Offset = "0x473B60", VA = "0x10474760")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6C20", Offset = "0xE6020")]
	public static IEnumerator Bloop(float delay, Transform target, float finalSize = 1f, float duration = 0.5f)
	{
		return null;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x474540", Offset = "0x473940", VA = "0x10474540")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6C70", Offset = "0xE6070")]
	public static IEnumerator ArcSlide(float duration, Transform target, Vector2 sourcePos, Vector2 targetPos, float anchorDistance)
	{
		return null;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x4745D0", Offset = "0x4739D0", VA = "0x104745D0")]
	public static Vector3 Bezier(float t, Vector3 src, Vector3 dest, Vector3 anchor)
	{
		return default(Vector3);
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x4746B0", Offset = "0x473AB0", VA = "0x104746B0")]
	public static Vector2 Bezier(float t, Vector2 src, Vector2 dest, Vector2 anchor)
	{
		return default(Vector2);
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x4749A0", Offset = "0x473DA0", VA = "0x104749A0")]
	private static float ElasticOut(float time, float duration)
	{
		return 0f;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x474A10", Offset = "0x473E10", VA = "0x10474A10")]
	public static float ExpOut(float t)
	{
		return 0f;
	}

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[FieldOffset(Offset = "0x32763245")]
	private static HashSet<Transform> activeShakes;

	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Action>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Action>d__1(int <>1__state)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x781760", Offset = "0x780B60", VA = "0x10781760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		private object Current
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x781790", Offset = "0x780B90", VA = "0x10781790", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		private object Current
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x10")]
		public Action todo;
	}

	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Wait>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Wait>d__2(int <>1__state)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x3728D0", Offset = "0x371CD0", VA = "0x103728D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		private object Current
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x78E140", Offset = "0x78D540", VA = "0x1078E140", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		private object Current
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x14")]
		private float <t>5__2;
	}

	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Sequence>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Sequence>d__3(int <>1__state)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x78B650", Offset = "0x78AA50", VA = "0x1078B650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		private object Current
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x78B6B0", Offset = "0x78AAB0", VA = "0x1078B6B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BB")]
		private object Current
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x10")]
		public IEnumerator[] items;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x14")]
		private int <i>5__2;
	}

	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <All>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <All>d__4(int <>1__state)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7817C0", Offset = "0x780BC0", VA = "0x107817C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		private object Current
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x781B00", Offset = "0x780F00", VA = "0x10781B00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		private object Current
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x10")]
		public IEnumerator[] items;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x14")]
		private Stack<IEnumerator>[] <enums>5__2;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x18")]
		private int <cap>5__3;
	}

	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Lerp>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Lerp>d__5(int <>1__state)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x788BC0", Offset = "0x787FC0", VA = "0x10788BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		private object Current
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x788C90", Offset = "0x788090", VA = "0x10788C90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		private object Current
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x10")]
		public Action<float> action;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x18")]
		private float <t>5__2;
	}

	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Overlerp>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Overlerp>d__6(int <>1__state)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x789070", Offset = "0x788470", VA = "0x10789070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		private object Current
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x789260", Offset = "0x788660", VA = "0x10789260", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C1")]
		private object Current
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x14")]
		public Action<float> action;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x18")]
		public float overextend;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x1C")]
		private float <d1>5__2;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x20")]
		private float <d2>5__3;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x24")]
		private float <t>5__4;
	}

	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ScaleIn>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ScaleIn>d__7(int <>1__state)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x78B420", Offset = "0x78A820", VA = "0x1078B420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		private object Current
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x78B5A0", Offset = "0x78A9A0", VA = "0x1078B5A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		private object Current
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x10")]
		public Transform self;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x14")]
		public float source;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x18")]
		public float target;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x1C")]
		public float duration;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__2;
	}

	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CycleColors>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CycleColors>d__8(int <>1__state)
		{
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x787910", Offset = "0x786D10", VA = "0x10787910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		private object Current
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x787AA0", Offset = "0x786EA0", VA = "0x10787AA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		private object Current
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer self;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x14")]
		public float rate;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x18")]
		public Color source;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x28")]
		public Color target;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x38")]
		public float duration;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x3C")]
		private float <t>5__2;
	}

	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PulseColor>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060004FA RID: 1274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PulseColor>d__9(int <>1__state)
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x789620", Offset = "0x788A20", VA = "0x10789620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		private object Current
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x789770", Offset = "0x788B70", VA = "0x10789770", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		private object Current
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer self;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x14")]
		public Color target;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x24")]
		public Color source;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x34")]
		public float duration;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x38")]
		private float <t>5__2;
	}

	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PulseColor>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PulseColor>d__10(int <>1__state)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x7894A0", Offset = "0x7888A0", VA = "0x107894A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		private object Current
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x7895F0", Offset = "0x7889F0", VA = "0x107895F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		private object Current
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x10")]
		public TextMeshPro self;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x14")]
		public Color target;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x24")]
		public Color source;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x34")]
		public float duration;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x38")]
		private float <t>5__2;
	}

	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ColorFade>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ColorFade>d__11(int <>1__state)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x7875F0", Offset = "0x7869F0", VA = "0x107875F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		private object Current
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x787760", Offset = "0x786B60", VA = "0x10787760", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CB")]
		private object Current
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x10")]
		public TextMeshPro self;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x14")]
		public Color source;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x24")]
		public Color target;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x34")]
		public float duration;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x38")]
		private float <t>5__2;
	}

	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ColorFade>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ColorFade>d__12(int <>1__state)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x787790", Offset = "0x786B90", VA = "0x10787790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		private object Current
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x7878E0", Offset = "0x786CE0", VA = "0x107878E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		private object Current
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x10")]
		public SpriteRenderer self;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x14")]
		public Color source;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x24")]
		public Color target;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x34")]
		public float duration;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x38")]
		private float <t>5__2;
	}

	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Rotate2D>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Rotate2D>d__13(int <>1__state)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x789E20", Offset = "0x789220", VA = "0x10789E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		private object Current
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x789F50", Offset = "0x789350", VA = "0x10789F50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		private object Current
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x18")]
		public float source;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x1C")]
		public float dest;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 <temp>5__2;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x2C")]
		private float <time>5__3;
	}

	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Slide3D>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Slide3D>d__14(int <>1__state)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x78C980", Offset = "0x78BD80", VA = "0x1078C980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D0")]
		private object Current
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x78CAF0", Offset = "0x78BEF0", VA = "0x1078CAF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		private object Current
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 source;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 dest;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x2C")]
		public Transform target;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x30")]
		private float <time>5__2;
	}

	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Slide2D>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Slide2D>d__15(int <>1__state)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x78C620", Offset = "0x78BA20", VA = "0x1078C620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		private object Current
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x78C7A0", Offset = "0x78BBA0", VA = "0x1078C7A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		private object Current
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 source;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 dest;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <temp>5__2;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x34")]
		private float <time>5__3;
	}

	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Slide2DWorld>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Slide2DWorld>d__16(int <>1__state)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x78C7D0", Offset = "0x78BBD0", VA = "0x1078C7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D4")]
		private object Current
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x78C950", Offset = "0x78BD50", VA = "0x1078C950", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		private object Current
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 source;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 dest;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <temp>5__2;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x34")]
		private float <time>5__3;
	}

	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Bounce>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Bounce>d__17(int <>1__state)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x783860", Offset = "0x782C60", VA = "0x10783860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D6")]
		private object Current
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x783A80", Offset = "0x782E80", VA = "0x10783A80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		private object Current
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x18")]
		public float height;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 <origin>5__2;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <temp>5__3;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x34")]
		private float <timer>5__4;
	}

	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Shake>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Shake>d__18(int <>1__state)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x78B6E0", Offset = "0x78AAE0", VA = "0x1078B6E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		private object Current
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x78B890", Offset = "0x78AC90", VA = "0x1078B890", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		private object Current
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x18")]
		public float halfWidth;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x1C")]
		public bool taper;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x20")]
		private float <timer>5__2;
	}

	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <SwayX>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <SwayX>d__19(int <>1__state)
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x78CE90", Offset = "0x78C290", VA = "0x1078CE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		private object Current
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x78D130", Offset = "0x78C530", VA = "0x1078D130", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		private object Current
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x10")]
		public Transform target;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x18")]
		public float halfWidth;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 <origin>5__2;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x28")]
		private float <timer>5__3;
	}

	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Bloop>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Bloop>d__20(int <>1__state)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x783650", Offset = "0x782A50", VA = "0x10783650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		private object Current
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x783830", Offset = "0x782C30", VA = "0x10783830", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DD")]
		private object Current
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x10")]
		public float delay;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x18")]
		public float finalSize;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x1C")]
		public Transform target;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x20")]
		private float <t>5__2;
	}

	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ArcSlide>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ArcSlide>d__21(int <>1__state)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x782BE0", Offset = "0x781FE0", VA = "0x10782BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DE")]
		private object Current
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x782EC0", Offset = "0x7822C0", VA = "0x10782EC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DF")]
		private object Current
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 targetPos;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 sourcePos;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x20")]
		public float anchorDistance;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x24")]
		public Transform target;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x28")]
		public float duration;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 <anchor>5__2;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x34")]
		private float <z>5__3;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x38")]
		private float <timer>5__4;
	}
}
