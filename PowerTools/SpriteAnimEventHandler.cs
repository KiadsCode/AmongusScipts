using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PowerTools
{
	// Token: 0x020005E7 RID: 1511
	[Token(Token = "0x20005E7")]
	[DisallowMultipleComponent]
	public class SpriteAnimEventHandler : MonoBehaviour
	{
		// Token: 0x06002623 RID: 9763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002623")]
		[Address(RVA = "0x4A67B0", Offset = "0x4A5BB0", VA = "0x104A67B0")]
		private void _Anim(string function)
		{
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002624")]
		[Address(RVA = "0x4A6590", Offset = "0x4A5990", VA = "0x104A6590")]
		private void _AnimInt(string messageString)
		{
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x4A6500", Offset = "0x4A5900", VA = "0x104A6500")]
		private void _AnimFloat(string messageString)
		{
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x4A6750", Offset = "0x4A5B50", VA = "0x104A6750")]
		private void _AnimString(string messageString)
		{
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x4A66B0", Offset = "0x4A5AB0", VA = "0x104A66B0")]
		private void _AnimObjectFunc(string funcName)
		{
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002628")]
		[Address(RVA = "0x4A6610", Offset = "0x4A5A10", VA = "0x104A6610")]
		private void _AnimObjectData(UnityEngine.Object data)
		{
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002629")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public SpriteAnimEventHandler()
		{
		}

		// Token: 0x040025A3 RID: 9635
		[Token(Token = "0x40025A3")]
		[FieldOffset(Offset = "0xC")]
		private string m_eventWithObjectMessage;

		// Token: 0x040025A4 RID: 9636
		[Token(Token = "0x40025A4")]
		[FieldOffset(Offset = "0x10")]
		private object m_eventWithObjectData;

		// Token: 0x020005E8 RID: 1512
		[Token(Token = "0x20005E8")]
		public static class EventParser
		{
			// Token: 0x0600262A RID: 9770 RVA: 0x0000B4C0 File Offset: 0x000096C0
			[Token(Token = "0x600262A")]
			[Address(RVA = "0x3642D0", Offset = "0x3636D0", VA = "0x103642D0")]
			public static int ParseInt(ref string messageString)
			{
				return 0;
			}

			// Token: 0x0600262B RID: 9771 RVA: 0x0000B4D8 File Offset: 0x000096D8
			[Token(Token = "0x600262B")]
			[Address(RVA = "0x364220", Offset = "0x363620", VA = "0x10364220")]
			public static float ParseFloat(ref string messageString)
			{
				return 0f;
			}

			// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600262C")]
			[Address(RVA = "0x364380", Offset = "0x363780", VA = "0x10364380")]
			public static string ParseString(ref string messageString)
			{
				return null;
			}

			// Token: 0x040025A5 RID: 9637
			[Token(Token = "0x40025A5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly char MESSAGE_DELIMITER;

			// Token: 0x040025A6 RID: 9638
			[Token(Token = "0x40025A6")]
			[FieldOffset(Offset = "0x4")]
			public static readonly string MESSAGE_NOPARAM;

			// Token: 0x040025A7 RID: 9639
			[Token(Token = "0x40025A7")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string MESSAGE_INT;

			// Token: 0x040025A8 RID: 9640
			[Token(Token = "0x40025A8")]
			[FieldOffset(Offset = "0xC")]
			public static readonly string MESSAGE_FLOAT;

			// Token: 0x040025A9 RID: 9641
			[Token(Token = "0x40025A9")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string MESSAGE_STRING;

			// Token: 0x040025AA RID: 9642
			[Token(Token = "0x40025AA")]
			[FieldOffset(Offset = "0x14")]
			public static readonly string MESSAGE_OBJECT_FUNCNAME;

			// Token: 0x040025AB RID: 9643
			[Token(Token = "0x40025AB")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string MESSAGE_OBJECT_DATA;
		}
	}
}
