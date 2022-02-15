using System;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00009738 File Offset: 0x00007938
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000635")]
		public int playerId
		{
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x504850", Offset = "0x503C50", VA = "0x10504850")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x5048E0", Offset = "0x503CE0", VA = "0x105048E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00009750 File Offset: 0x00007950
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000636")]
		public int inputSourceIndex
		{
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0x504830", Offset = "0x503C30", VA = "0x10504830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0x5048A0", Offset = "0x503CA0", VA = "0x105048A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		public IMouseInputSource mouseSource
		{
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0x504840", Offset = "0x503C40", VA = "0x10504840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5B")]
			[Address(RVA = "0x5048C0", Offset = "0x503CC0", VA = "0x105048C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000638")]
		public ITouchInputSource touchSource
		{
			[Token(Token = "0x6001F5C")]
			[Address(RVA = "0x504870", Offset = "0x503C70", VA = "0x10504870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0x504920", Offset = "0x503D20", VA = "0x10504920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00009768 File Offset: 0x00007968
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000639")]
		public PointerEventType sourceType
		{
			[Token(Token = "0x6001F5E")]
			[Address(RVA = "0x504860", Offset = "0x503C60", VA = "0x10504860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return PointerEventType.Mouse;
			}
			[Token(Token = "0x6001F5F")]
			[Address(RVA = "0x504900", Offset = "0x503D00", VA = "0x10504900")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00009780 File Offset: 0x00007980
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063A")]
		public int buttonIndex
		{
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x504820", Offset = "0x503C20", VA = "0x10504820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x504880", Offset = "0x503C80", VA = "0x10504880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x5047E0", Offset = "0x503BE0", VA = "0x105047E0")]
		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x5045C0", Offset = "0x5039C0", VA = "0x105045C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0xFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private int <playerId>k__BackingField;

		// Token: 0x040021D1 RID: 8657
		[Token(Token = "0x40021D1")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private int <inputSourceIndex>k__BackingField;

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private IMouseInputSource <mouseSource>k__BackingField;

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private ITouchInputSource <touchSource>k__BackingField;

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x10C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private PointerEventType <sourceType>k__BackingField;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private int <buttonIndex>k__BackingField;
	}
}
