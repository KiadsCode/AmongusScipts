using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	public class VideoCaptureState
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x7B0CE0", Offset = "0x7B00E0", VA = "0x107B0CE0")]
		internal VideoCaptureState(bool isCapturing, VideoCaptureMode captureMode, VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
		{
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x1700083C")]
		public bool IsCapturing
		{
			[Token(Token = "0x60027C4")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x1700083D")]
		public VideoCaptureMode CaptureMode
		{
			[Token(Token = "0x60027C5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
			get
			{
				return VideoCaptureMode.File;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x1700083E")]
		public VideoQualityLevel QualityLevel
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
			get
			{
				return VideoQualityLevel.SD;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x1700083F")]
		public bool IsOverlayVisible
		{
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x27F3C0", Offset = "0x27E7C0", VA = "0x1027F3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x17000840")]
		public bool IsPaused
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x2E4130", Offset = "0x2E3530", VA = "0x102E4130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x7B0A40", Offset = "0x7AFE40", VA = "0x107B0A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040027D6 RID: 10198
		[Token(Token = "0x40027D6")]
		[FieldOffset(Offset = "0x8")]
		private bool mIsCapturing;

		// Token: 0x040027D7 RID: 10199
		[Token(Token = "0x40027D7")]
		[FieldOffset(Offset = "0xC")]
		private VideoCaptureMode mCaptureMode;

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[FieldOffset(Offset = "0x10")]
		private VideoQualityLevel mQualityLevel;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[FieldOffset(Offset = "0x14")]
		private bool mIsOverlayVisible;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[FieldOffset(Offset = "0x15")]
		private bool mIsPaused;
	}
}
