using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

// Token: 0x02000360 RID: 864
[Token(Token = "0x2000360")]
public static class PEW
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public static class Hardware
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00006588 File Offset: 0x00004788
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CC")]
		public static PEW.Hardware.HardwareType hardwareType
		{
			[Token(Token = "0x60012CE")]
			[Address(RVA = "0x78EAC0", Offset = "0x78DEC0", VA = "0x1078EAC0")]
			get
			{
				return PEW.Hardware.HardwareType.PC;
			}
			[Token(Token = "0x60012CF")]
			[Address(RVA = "0x78EB70", Offset = "0x78DF70", VA = "0x1078EB70")]
			private set
			{
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000065A0 File Offset: 0x000047A0
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CD")]
		public static int hardwareTier
		{
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x78EA70", Offset = "0x78DE70", VA = "0x1078EA70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x78EB10", Offset = "0x78DF10", VA = "0x1078EB10")]
			private set
			{
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x5EB0C0", Offset = "0x5EA4C0", VA = "0x105EB0C0")]
		private static PEW.Hardware.HardwareType GetHardwareType()
		{
			return PEW.Hardware.HardwareType.PC;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x39DDA0", Offset = "0x39D1A0", VA = "0x1039DDA0")]
		private static int GetHardwareTier()
		{
			return 0;
		}

		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		[FieldOffset(Offset = "0x0")]
		private static PEW.Hardware.HardwareType type;

		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		[FieldOffset(Offset = "0x4")]
		private static int tier;

		// Token: 0x02000362 RID: 866
		[Token(Token = "0x2000362")]
		public enum HardwareType
		{
			// Token: 0x04001311 RID: 4881
			[Token(Token = "0x4001311")]
			PC,
			// Token: 0x04001312 RID: 4882
			[Token(Token = "0x4001312")]
			Switch,
			// Token: 0x04001313 RID: 4883
			[Token(Token = "0x4001313")]
			XboxOne,
			// Token: 0x04001314 RID: 4884
			[Token(Token = "0x4001314")]
			XboxScarlett,
			// Token: 0x04001315 RID: 4885
			[Token(Token = "0x4001315")]
			PS4,
			// Token: 0x04001316 RID: 4886
			[Token(Token = "0x4001316")]
			PS5,
			// Token: 0x04001317 RID: 4887
			[Token(Token = "0x4001317")]
			Stadia,
			// Token: 0x04001318 RID: 4888
			[Token(Token = "0x4001318")]
			Unknown
		}
	}

	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xDD7F0", Offset = "0xDCBF0")]
	public class ConditionalValue<T>
	{
		// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D5")]
		[MethodImpl(256)]
		public T Select()
		{
			return null;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D6")]
		[MethodImpl(256)]
		public static implicit operator T(PEW.ConditionalValue<T> input)
		{
			return null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D7")]
		[MethodImpl(256)]
		public static implicit operator PEW.ConditionalValue<T>(T input)
		{
			return null;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D8")]
		public ConditionalValue()
		{
		}

		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x4001319")]
		[FieldOffset(Offset = "0x0")]
		public T PC;

		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x400131A")]
		[FieldOffset(Offset = "0x0")]
		public T Switch;

		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x0")]
		public T XboxOne;

		// Token: 0x0400131C RID: 4892
		[Token(Token = "0x400131C")]
		[FieldOffset(Offset = "0x0")]
		public T XboxOneX;

		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x400131D")]
		[FieldOffset(Offset = "0x0")]
		public T PS4;

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x0")]
		public T PS4Pro;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		[FieldOffset(Offset = "0x0")]
		public T PS5;

		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		[FieldOffset(Offset = "0x0")]
		public T Stadia;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		[FieldOffset(Offset = "0x0")]
		public T Misc;
	}
}
