using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	public class VideoCapabilities
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x7B0A00", Offset = "0x7AFE00", VA = "0x107B0A00")]
		internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
		{
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x17000839")]
		public bool IsCameraSupported
		{
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x1700083A")]
		public bool IsMicSupported
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x3ECDB0", Offset = "0x3EC1B0", VA = "0x103ECDB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x1700083B")]
		public bool IsWriteStorageSupported
		{
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x39B9C0", Offset = "0x39ADC0", VA = "0x1039B9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x7B0510", Offset = "0x7AF910", VA = "0x107B0510")]
		public bool SupportsCaptureMode(VideoCaptureMode captureMode)
		{
			return default(bool);
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x7B05A0", Offset = "0x7AF9A0", VA = "0x107B05A0")]
		public bool SupportsQualityLevel(VideoQualityLevel qualityLevel)
		{
			return default(bool);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x7B0630", Offset = "0x7AFA30", VA = "0x107B0630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040027CE RID: 10190
		[Token(Token = "0x40027CE")]
		[FieldOffset(Offset = "0x8")]
		private bool mIsCameraSupported;

		// Token: 0x040027CF RID: 10191
		[Token(Token = "0x40027CF")]
		[FieldOffset(Offset = "0x9")]
		private bool mIsMicSupported;

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0xA")]
		private bool mIsWriteStorageSupported;

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[FieldOffset(Offset = "0xC")]
		private bool[] mCaptureModesSupported;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x10")]
		private bool[] mQualityLevelsSupported;

		// Token: 0x02000657 RID: 1623
		[Token(Token = "0x2000657")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027C0")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027C1")]
			[Address(RVA = "0x13020A0", Offset = "0x13014A0", VA = "0x113020A0")]
			internal string <ToString>b__14_0(bool p)
			{
				return null;
			}

			// Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027C2")]
			[Address(RVA = "0x13020A0", Offset = "0x13014A0", VA = "0x113020A0")]
			internal string <ToString>b__14_1(bool p)
			{
				return null;
			}

			// Token: 0x040027D3 RID: 10195
			[Token(Token = "0x40027D3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VideoCapabilities.<>c <>9;

			// Token: 0x040027D4 RID: 10196
			[Token(Token = "0x40027D4")]
			[FieldOffset(Offset = "0x4")]
			public static Func<bool, string> <>9__14_0;

			// Token: 0x040027D5 RID: 10197
			[Token(Token = "0x40027D5")]
			[FieldOffset(Offset = "0x8")]
			public static Func<bool, string> <>9__14_1;
		}
	}
}
