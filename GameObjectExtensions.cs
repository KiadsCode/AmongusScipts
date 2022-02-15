using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public static class GameObjectExtensions
{
	// Token: 0x06000588 RID: 1416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000588")]
	public static void SetAllGameObjectsActive<T>(this IList<T> self, bool isActive) where T : MonoBehaviour
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000589")]
	public static T Find<T>(this List<T> self, GameObject toFind) where T : MonoBehaviour
	{
		return null;
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058A")]
	[Address(RVA = "0x3AEFE0", Offset = "0x3AE3E0", VA = "0x103AEFE0")]
	public static void SetLocalX(this Transform self, float x)
	{
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058B")]
	[Address(RVA = "0x3AF040", Offset = "0x3AE440", VA = "0x103AF040")]
	public static void SetLocalY(this Transform self, float y)
	{
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058C")]
	[Address(RVA = "0x3AF0A0", Offset = "0x3AE4A0", VA = "0x103AF0A0")]
	public static void SetLocalZ(this Transform self, float z)
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058D")]
	[Address(RVA = "0x3AF0F0", Offset = "0x3AE4F0", VA = "0x103AF0F0")]
	public static void SetWorldZ(this Transform self, float z)
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058E")]
	[Address(RVA = "0x3AECE0", Offset = "0x3AE0E0", VA = "0x103AECE0")]
	public static void LookAt2d(this Transform self, Vector3 target)
	{
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x3AEE40", Offset = "0x3AE240", VA = "0x103AEE40")]
	public static void LookAt2d(this Transform self, Transform target)
	{
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000590")]
	[Address(RVA = "0x3AEB80", Offset = "0x3ADF80", VA = "0x103AEB80")]
	public static void DestroyChildren(this Transform self)
	{
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000591")]
	[Address(RVA = "0x3AEAC0", Offset = "0x3ADEC0", VA = "0x103AEAC0")]
	public static void DestroyChildren(this MonoBehaviour self)
	{
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000592")]
	[Address(RVA = "0x3AEC40", Offset = "0x3AE040", VA = "0x103AEC40")]
	public static void ForEachChild(this GameObject self, Action<GameObject> todo)
	{
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000593")]
	public static void ForEachChildBehavior<T>(this MonoBehaviour self, Action<T> todo) where T : MonoBehaviour
	{
	}
}
