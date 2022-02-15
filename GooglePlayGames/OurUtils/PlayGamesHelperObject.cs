using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class PlayGamesHelperObject : MonoBehaviour
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x65F770", Offset = "0x65EB70", VA = "0x1065F770")]
		public static void CreateObject()
		{
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x65F710", Offset = "0x65EB10", VA = "0x1065F710")]
		public void Awake()
		{
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x65FE00", Offset = "0x65F200", VA = "0x1065FE00")]
		public void OnDisable()
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279C")]
		[Address(RVA = "0x65FF90", Offset = "0x65F390", VA = "0x1065FF90")]
		public static void RunCoroutine(IEnumerator action)
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x6600B0", Offset = "0x65F4B0", VA = "0x106600B0")]
		public static void RunOnGameThread(Action action)
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x660260", Offset = "0x65F660", VA = "0x10660260")]
		public void Update()
		{
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x65F940", Offset = "0x65ED40", VA = "0x1065F940")]
		public void OnApplicationFocus(bool focused)
		{
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x65FBA0", Offset = "0x65EFA0", VA = "0x1065FBA0")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x65F590", Offset = "0x65E990", VA = "0x1065F590")]
		public static void AddFocusCallback(Action<bool> callback)
		{
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x65FEB0", Offset = "0x65F2B0", VA = "0x1065FEB0")]
		public static bool RemoveFocusCallback(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x65F650", Offset = "0x65EA50", VA = "0x1065F650")]
		public static void AddPauseCallback(Action<bool> callback)
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x65FF20", Offset = "0x65F320", VA = "0x1065FF20")]
		public static bool RemovePauseCallback(Action<bool> callback)
		{
			return default(bool);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x6605A0", Offset = "0x65F9A0", VA = "0x106605A0")]
		public PlayGamesHelperObject()
		{
		}

		// Token: 0x04002771 RID: 10097
		[Token(Token = "0x4002771")]
		[FieldOffset(Offset = "0x0")]
		private static PlayGamesHelperObject instance;

		// Token: 0x04002772 RID: 10098
		[Token(Token = "0x4002772")]
		[FieldOffset(Offset = "0x4")]
		private static bool sIsDummy;

		// Token: 0x04002773 RID: 10099
		[Token(Token = "0x4002773")]
		[FieldOffset(Offset = "0x8")]
		private static List<Action> sQueue;

		// Token: 0x04002774 RID: 10100
		[Token(Token = "0x4002774")]
		[FieldOffset(Offset = "0xC")]
		private List<Action> localQueue;

		// Token: 0x04002775 RID: 10101
		[Token(Token = "0x4002775")]
		[FieldOffset(Offset = "0xC")]
		private static bool sQueueEmpty;

		// Token: 0x04002776 RID: 10102
		[Token(Token = "0x4002776")]
		[FieldOffset(Offset = "0x10")]
		private static List<Action<bool>> sPauseCallbackList;

		// Token: 0x04002777 RID: 10103
		[Token(Token = "0x4002777")]
		[FieldOffset(Offset = "0x14")]
		private static List<Action<bool>> sFocusCallbackList;

		// Token: 0x02000643 RID: 1603
		[Token(Token = "0x2000643")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027A7")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060027A8 RID: 10152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x799DE0", Offset = "0x7991E0", VA = "0x10799DE0")]
			internal void <RunCoroutine>b__0()
			{
			}

			// Token: 0x04002778 RID: 10104
			[Token(Token = "0x4002778")]
			[FieldOffset(Offset = "0x8")]
			public IEnumerator action;
		}
	}
}
