using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2300", Offset = "0xE1700")]
	public class RewiredEventSystem : EventSystem
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00009798 File Offset: 0x00007998
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063B")]
		public bool alwaysUpdate
		{
			[Token(Token = "0x6001F64")]
			[Address(RVA = "0x2E9910", Offset = "0x2E8D10", VA = "0x102E9910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F65")]
			[Address(RVA = "0x2E9940", Offset = "0x2E8D40", VA = "0x102E9940")]
			set
			{
			}
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x4F87F0", Offset = "0x4F7BF0", VA = "0x104F87F0", Slot = "18")]
		protected override void Update()
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x4F89B0", Offset = "0x4F7DB0", VA = "0x104F89B0")]
		public RewiredEventSystem()
		{
		}

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2330", Offset = "0xE1730")]
		[SerializeField]
		private bool _alwaysUpdate;
	}
}
