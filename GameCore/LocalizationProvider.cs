using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameCore
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	public abstract class LocalizationProvider : MonoBehaviour
	{
		// Token: 0x06002650 RID: 9808
		[Token(Token = "0x6002650")]
		public abstract string GetLocalizedText(LocalizationKeys key);

		// Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		protected LocalizationProvider()
		{
		}
	}
}
