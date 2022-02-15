using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200018F RID: 399
[Token(Token = "0x200018F")]
public class GameStartManager : DestroyableSingleton<GameStartManager>, IDisconnectHandler
{
	// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000924")]
	[Address(RVA = "0x3B3440", Offset = "0x3B2840", VA = "0x103B3440")]
	public void Start()
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000925")]
	[Address(RVA = "0x3B2FB0", Offset = "0x3B23B0", VA = "0x103B2FB0")]
	public void MakePublic()
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000926")]
	[Address(RVA = "0x3B33E0", Offset = "0x3B27E0", VA = "0x103B33E0")]
	public void ShareGameInvite()
	{
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x3B3870", Offset = "0x3B2C70", VA = "0x103B3870")]
	public void Update()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x3B3100", Offset = "0x3B2500", VA = "0x103B3100")]
	public void ResetStartState()
	{
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x3B32A0", Offset = "0x3B26A0", VA = "0x103B32A0")]
	public void SetStartCounter(sbyte sec)
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x3B2BE0", Offset = "0x3B1FE0", VA = "0x103B2BE0")]
	public void BeginGame()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x3B3050", Offset = "0x3B2450", VA = "0x103B3050")]
	public void ReallyBegin(bool neverShow)
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x3B2E10", Offset = "0x3B2210", VA = "0x103B2E10")]
	public void FinallyBegin()
	{
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x3B2EE0", Offset = "0x3B22E0", VA = "0x103B2EE0", Slot = "6")]
	public void HandleDisconnect(PlayerControl pc, DisconnectReasons reason)
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x3B2EE0", Offset = "0x3B22E0", VA = "0x103B2EE0", Slot = "7")]
	public void HandleDisconnect()
	{
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void ShowInviteMenu()
	{
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x3B4280", Offset = "0x3B3680", VA = "0x103B4280")]
	public GameStartManager()
	{
	}

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	private const float CountdownDuration = 5.0001f;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x10")]
	public int MinPlayers;

	// Token: 0x04000915 RID: 2325
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro PlayerCounter;

	// Token: 0x04000916 RID: 2326
	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x18")]
	private int LastPlayerCount;

	// Token: 0x04000917 RID: 2327
	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GameSizePopup;

	// Token: 0x04000918 RID: 2328
	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro GameRoomName;

	// Token: 0x04000919 RID: 2329
	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x24")]
	public LobbyBehaviour LobbyPrefab;

	// Token: 0x0400091A RID: 2330
	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro GameStartText;

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x2C")]
	public TextMeshPro startLabelText;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer StartButton;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x34")]
	public ActionMapGlyphDisplay StartButtonGlyph;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer MakePublicButton;

	// Token: 0x0400091F RID: 2335
	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x3C")]
	public ControllerHeldButtonBehaviour MakePublicButtonBehaviour;

	// Token: 0x04000920 RID: 2336
	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x40")]
	public Sprite PublicGameImage;

	// Token: 0x04000921 RID: 2337
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x44")]
	public Sprite PrivateGameImage;

	// Token: 0x04000922 RID: 2338
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshPro privatePublicText;

	// Token: 0x04000923 RID: 2339
	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x4C")]
	public SpriteRenderer ShareOnDiscordButton;

	// Token: 0x04000924 RID: 2340
	[Token(Token = "0x4000924")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InviteFriendsButton;

	// Token: 0x04000925 RID: 2341
	[Token(Token = "0x4000925")]
	[FieldOffset(Offset = "0x54")]
	private GameStartManager.StartingStates startState;

	// Token: 0x04000926 RID: 2342
	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x58")]
	private float countDownTimer;

	// Token: 0x04000927 RID: 2343
	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x5C")]
	private ImageTranslator publicButtonTranslator;

	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	private enum StartingStates
	{
		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		NotStarting,
		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		Countdown,
		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		Starting
	}
}
