using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x020005A4 RID: 1444
	[Token(Token = "0x20005A4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE2DC0", Offset = "0xE21C0")]
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x4ADE40", Offset = "0x4AD240", VA = "0x104ADE40")]
		private void Start()
		{
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
		public ThemedElement()
		{
		}

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private ThemedElement.ElementInfo[] _elements;

		// Token: 0x020005A5 RID: 1445
		[Token(Token = "0x20005A5")]
		[Serializable]
		public class ElementInfo
		{
			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007C0")]
			public string themeClass
			{
				[Token(Token = "0x6002434")]
				[Address(RVA = "0x273EB0", Offset = "0x2732B0", VA = "0x10273EB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x06002435 RID: 9269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007C1")]
			public Component component
			{
				[Token(Token = "0x6002435")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002436")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public ElementInfo()
			{
			}

			// Token: 0x04002439 RID: 9273
			[Token(Token = "0x4002439")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _themeClass;

			// Token: 0x0400243A RID: 9274
			[Token(Token = "0x400243A")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Component _component;
		}
	}
}
