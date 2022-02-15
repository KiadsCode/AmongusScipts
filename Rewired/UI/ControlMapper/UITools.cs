using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005B1 RID: 1457
	[Token(Token = "0x20005B1")]
	public static class UITools
	{
		// Token: 0x06002462 RID: 9314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002462")]
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			return null;
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002463")]
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
		{
			return null;
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002464")]
		private static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			return null;
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x4B64C0", Offset = "0x4B58C0", VA = "0x104B64C0")]
		public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
		{
			return default(Vector3);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x4B6680", Offset = "0x4B5A80", VA = "0x104B6680")]
		public static Rect GetWorldSpaceRect(RectTransform rt)
		{
			return default(Rect);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x4B6A80", Offset = "0x4B5E80", VA = "0x104B6A80")]
		public static Rect TransformRectTo(Transform from, Transform to, Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x4B6880", Offset = "0x4B5C80", VA = "0x104B6880")]
		public static Rect InvertY(Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x4B6920", Offset = "0x4B5D20", VA = "0x104B6920")]
		public static void SetInteractable(Selectable selectable, bool state, bool playTransition)
		{
		}
	}
}
