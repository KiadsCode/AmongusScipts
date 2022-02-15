using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Video
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public interface IVideoClient
	{
		// Token: 0x060027B1 RID: 10161
		[Token(Token = "0x60027B1")]
		void GetCaptureCapabilities(Action<ResponseStatus, VideoCapabilities> callback);

		// Token: 0x060027B2 RID: 10162
		[Token(Token = "0x60027B2")]
		void ShowCaptureOverlay();

		// Token: 0x060027B3 RID: 10163
		[Token(Token = "0x60027B3")]
		void GetCaptureState(Action<ResponseStatus, VideoCaptureState> callback);

		// Token: 0x060027B4 RID: 10164
		[Token(Token = "0x60027B4")]
		void IsCaptureAvailable(VideoCaptureMode captureMode, Action<ResponseStatus, bool> callback);

		// Token: 0x060027B5 RID: 10165
		[Token(Token = "0x60027B5")]
		bool IsCaptureSupported();

		// Token: 0x060027B6 RID: 10166
		[Token(Token = "0x60027B6")]
		void RegisterCaptureOverlayStateChangedListener(CaptureOverlayStateListener listener);

		// Token: 0x060027B7 RID: 10167
		[Token(Token = "0x60027B7")]
		void UnregisterCaptureOverlayStateChangedListener();
	}
}
