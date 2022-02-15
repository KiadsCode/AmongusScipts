using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public static class Extensions
{
	// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x47DC60", Offset = "0x47D060", VA = "0x1047DC60")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE7890", Offset = "0xE6C90")]
	public static IEnumerator WaitForCompletion(this Task self)
	{
		return null;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x47D570", Offset = "0x47C970", VA = "0x1047D570")]
	public static string RemoveAll(this string self, params char[] chars)
	{
		return null;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x47DBF0", Offset = "0x47CFF0", VA = "0x1047DBF0")]
	public static void TrimEnd(this StringBuilder self)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054B")]
	public static void DestroyAll<T>(this IList<T> self) where T : MonoBehaviour
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054C")]
	public static void AddUnique<T>(this IList<T> self, T item)
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x47D8B0", Offset = "0x47CCB0", VA = "0x1047D8B0")]
	public static string ToTextColor(this Color c)
	{
		return null;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x47D7B0", Offset = "0x47CBB0", VA = "0x1047D7B0")]
	public static Color SetAlpha(this Color c, float alpha)
	{
		return default(Color);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x47D800", Offset = "0x47CC00", VA = "0x1047D800")]
	public static int ToInteger(this Color c, bool alpha)
	{
		return 0;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x47D060", Offset = "0x47C460", VA = "0x1047D060")]
	public static bool HasAnyBit(this int self, int bit)
	{
		return default(bool);
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x47D040", Offset = "0x47C440", VA = "0x1047D040")]
	public static bool HasAnyBit(this byte self, byte bit)
	{
		return default(bool);
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x47D050", Offset = "0x47C450", VA = "0x1047D050")]
	public static bool HasAnyBit(this ushort self, byte bit)
	{
		return default(bool);
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x47D070", Offset = "0x47C470", VA = "0x1047D070")]
	public static bool HasBit(this byte self, byte bit)
	{
		return default(bool);
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x47CFC0", Offset = "0x47C3C0", VA = "0x1047CFC0")]
	public static int BitCount(this byte self)
	{
		return 0;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x6000555")]
	public static int IndexOf<T>(this T[] self, T item) where T : class
	{
		return 0;
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x6000556")]
	public static int IndexOfMin<T>(this T[] self, Func<T, float> comparer)
	{
		return 0;
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x47D3A0", Offset = "0x47C7A0", VA = "0x1047D3A0")]
	public static KeyValuePair<byte, int> MaxPair(this Dictionary<byte, int> self, out bool tie)
	{
		return default(KeyValuePair<byte, int>);
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000558")]
	public static TV GetValueOrSetDefault<TK, TV>(this Dictionary<TK, TV> self, TK key, Func<TV> defaultValueFunc)
	{
		return null;
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	public static void SetAll<T>(this IList<T> self, T value)
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055A")]
	public static void AddAll<T>(this List<T> self, IList<T> other)
	{
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055B")]
	public static void RemoveDupes<T>(this IList<T> self) where T : class
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055C")]
	public static void Shuffle<T>(this IList<T> self, int startAt = 0)
	{
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055D")]
	public static void Shuffle<T>(this System.Random r, IList<T> self)
	{
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600055E")]
	public static T[] RandomSet<T>(this IList<T> self, int length)
	{
		return null;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	public static void RandomFill<T>(this IList<T> self, T[] target)
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x6000560")]
	public static int RandomIdx<T>(this IList<T> self)
	{
		return 0;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x6000561")]
	public static int RandomIdx<T>(this IEnumerable<T> self)
	{
		return 0;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000562")]
	public static T Random<T>(this IEnumerable<T> self)
	{
		return null;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000563")]
	public static T Random<T>(this IList<T> self)
	{
		return null;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x47D010", Offset = "0x47C410", VA = "0x1047D010")]
	public static Vector2 Div(this Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x47D500", Offset = "0x47C900", VA = "0x1047D500")]
	public static Vector2 Mul(this Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x47D530", Offset = "0x47C930", VA = "0x1047D530")]
	public static Vector3 Mul(this Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x6000567")]
	[Address(RVA = "0x47D090", Offset = "0x47C490", VA = "0x1047D090")]
	public static Vector3 Inv(this Vector3 a)
	{
		return default(Vector3);
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x6000568")]
	[Address(RVA = "0x47D1D0", Offset = "0x47C5D0", VA = "0x1047D1D0")]
	public static Rect Lerp(this Rect source, Rect target, float t)
	{
		return default(Rect);
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000569")]
	public static void ForEach<T>(this IList<T> self, Action<T> todo)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056A")]
	public static T Max<T>(this IList<T> self, Func<T, float> comparer)
	{
		return null;
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600056B")]
	public static T Max<T>(this IList<T> self, Func<T, decimal> comparer)
	{
		return null;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x47DDA0", Offset = "0x47D1A0", VA = "0x1047DDA0")]
	public static int Wrap(this int self, int max)
	{
		return 0;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x600056D")]
	public static int LastIndexOf<T>(this T[] self, Predicate<T> pred)
	{
		return 0;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x600056E")]
	public static int IndexOf<T>(this T[] self, Predicate<T> pred)
	{
		return 0;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x47D2E0", Offset = "0x47C6E0", VA = "0x1047D2E0")]
	public static Vector2 MapToRectangle(this Vector2 del, Vector2 widthAndHeight)
	{
		return default(Vector2);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x47CE40", Offset = "0x47C240", VA = "0x1047CE40")]
	public static float AngleSignedRad(this Vector2 vector1, Vector2 vector2)
	{
		return 0f;
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x47CEC0", Offset = "0x47C2C0", VA = "0x1047CEC0")]
	public static float AngleSigned(this Vector2 vector1, Vector2 vector2)
	{
		return 0f;
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00003360 File Offset: 0x00001560
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x47CF80", Offset = "0x47C380", VA = "0x1047CF80")]
	public static float AngleSigned(this Vector2 vector1)
	{
		return 0f;
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x47DCB0", Offset = "0x47D0B0", VA = "0x1047DCB0")]
	public static float WheelAngle(this Vector2 vector1, Vector2 vector2)
	{
		return 0f;
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x6000574")]
	[Address(RVA = "0x47D730", Offset = "0x47CB30", VA = "0x1047D730")]
	public static Vector2 Rotate(this Vector2 self, float degrees)
	{
		return default(Vector2);
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x6000575")]
	[Address(RVA = "0x47D6B0", Offset = "0x47CAB0", VA = "0x1047D6B0")]
	public static Vector3 RotateZ(this Vector3 self, float degrees)
	{
		return default(Vector3);
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x6000576")]
	[Address(RVA = "0x47D630", Offset = "0x47CA30", VA = "0x1047D630")]
	public static Vector3 RotateY(this Vector3 self, float degrees)
	{
		return default(Vector3);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x6000577")]
	public static bool TryToEnum<TEnum>(this string strEnumValue, out TEnum enumValue)
	{
		return default(bool);
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000578")]
	public static TEnum ToEnum<TEnum>(this string strEnumValue)
	{
		return null;
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000579")]
	public static TEnum ToEnum<TEnum>(this string strEnumValue, TEnum defaultValue)
	{
		return null;
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x47D0D0", Offset = "0x47C4D0", VA = "0x1047D0D0")]
	public static bool IsNullOrWhiteSpace(this string s)
	{
		return default(bool);
	}

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x329B3295")]
	private static string[] ByteHex;

	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <WaitForCompletion>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <WaitForCompletion>d__0(int <>1__state)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x78E040", Offset = "0x78D440", VA = "0x1078E040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E0")]
		private object Current
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x78E090", Offset = "0x78D490", VA = "0x1078E090", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E1")]
		private object Current
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x10")]
		public Task self;
	}

	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x78D530", Offset = "0x78C930", VA = "0x1078D530")]
		internal bool <IsNullOrWhiteSpace>b__51_0(char c)
		{
			return default(bool);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x78D6B0", Offset = "0x78CAB0", VA = "0x1078D6B0")]
		internal string <.cctor>b__52_0(int x)
		{
			return null;
		}

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Extensions.<>c <>9;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x4")]
		public static Func<char, bool> <>9__51_0;
	}
}
