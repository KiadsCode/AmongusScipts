using System;
using Il2CppDummyDll;

// Token: 0x02000266 RID: 614
[Token(Token = "0x2000266")]
public enum DisconnectReasons
{
	// Token: 0x04000D92 RID: 3474
	[Token(Token = "0x4000D92")]
	ExitGame,
	// Token: 0x04000D93 RID: 3475
	[Token(Token = "0x4000D93")]
	GameFull,
	// Token: 0x04000D94 RID: 3476
	[Token(Token = "0x4000D94")]
	GameStarted,
	// Token: 0x04000D95 RID: 3477
	[Token(Token = "0x4000D95")]
	GameNotFound,
	// Token: 0x04000D96 RID: 3478
	[Token(Token = "0x4000D96")]
	IncorrectVersion = 5,
	// Token: 0x04000D97 RID: 3479
	[Token(Token = "0x4000D97")]
	Banned,
	// Token: 0x04000D98 RID: 3480
	[Token(Token = "0x4000D98")]
	Kicked,
	// Token: 0x04000D99 RID: 3481
	[Token(Token = "0x4000D99")]
	Custom,
	// Token: 0x04000D9A RID: 3482
	[Token(Token = "0x4000D9A")]
	InvalidName,
	// Token: 0x04000D9B RID: 3483
	[Token(Token = "0x4000D9B")]
	Hacking,
	// Token: 0x04000D9C RID: 3484
	[Token(Token = "0x4000D9C")]
	NotAuthorized,
	// Token: 0x04000D9D RID: 3485
	[Token(Token = "0x4000D9D")]
	Destroy = 16,
	// Token: 0x04000D9E RID: 3486
	[Token(Token = "0x4000D9E")]
	Error,
	// Token: 0x04000D9F RID: 3487
	[Token(Token = "0x4000D9F")]
	IncorrectGame,
	// Token: 0x04000DA0 RID: 3488
	[Token(Token = "0x4000DA0")]
	ServerRequest,
	// Token: 0x04000DA1 RID: 3489
	[Token(Token = "0x4000DA1")]
	ServerFull,
	// Token: 0x04000DA2 RID: 3490
	[Token(Token = "0x4000DA2")]
	InternalPlayerMissing = 100,
	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	InternalNonceFailure,
	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	InternalConnectionToken,
	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	PlatformLock,
	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	LobbyInactivity,
	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	MatchmakerInactivity,
	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	InvalidGameOptions,
	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	NoServersAvailable,
	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	QuickmatchDisabled,
	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	TooManyGames,
	// Token: 0x04000DAC RID: 3500
	[Token(Token = "0x4000DAC")]
	QuickchatLock,
	// Token: 0x04000DAD RID: 3501
	[Token(Token = "0x4000DAD")]
	MatchmakerFull,
	// Token: 0x04000DAE RID: 3502
	[Token(Token = "0x4000DAE")]
	Sanctions,
	// Token: 0x04000DAF RID: 3503
	[Token(Token = "0x4000DAF")]
	ServerError,
	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	SelfPlatformLock,
	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	IntentionalLeaving = 208,
	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	FocusLostBackground = 207,
	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	FocusLost = 209,
	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000DB4")]
	NewConnection,
	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	PlatformParentalControlsBlock,
	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	PlatformUserBlock,
	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	PlatformFailedToGetUserBlock
}
