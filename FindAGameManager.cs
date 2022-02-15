using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using InnerNet;
using TMPro;

// Token: 0x020002BE RID: 702
[Token(Token = "0x20002BE")]
public class FindAGameManager : DestroyableSingleton<FindAGameManager>, IGameListHandler
{
	// Token: 0x06000F91 RID: 3985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x3A68B0", Offset = "0x3A5CB0", VA = "0x103A68B0")]
	public void ResetTimer()
	{
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x3A68F0", Offset = "0x3A5CF0", VA = "0x103A68F0")]
	public void Start()
	{
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x3A6B50", Offset = "0x3A5F50", VA = "0x103A6B50")]
	public void Update()
	{
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x3A6730", Offset = "0x3A5B30", VA = "0x103A6730")]
	public void RefreshList()
	{
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x3A6670", Offset = "0x3A5A70", VA = "0x103A6670", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x3A5F90", Offset = "0x3A5390", VA = "0x103A5F90", Slot = "6")]
	public void HandleList(InnerNetClient.TotalGameData totalGames, List<GameListing> availableGames)
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x3A5F50", Offset = "0x3A5350", VA = "0x103A5F50")]
	public void ExitGame()
	{
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x3A6C50", Offset = "0x3A6050", VA = "0x103A6C50")]
	public FindAGameManager()
	{
	}

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000F65")]
	private const float RefreshTime = 5f;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x10")]
	private float timer;

	// Token: 0x04000F67 RID: 3943
	[Token(Token = "0x4000F67")]
	[FieldOffset(Offset = "0x14")]
	public ObjectPoolBehavior buttonPool;

	// Token: 0x04000F68 RID: 3944
	[Token(Token = "0x4000F68")]
	[FieldOffset(Offset = "0x18")]
	public SpinAnimator RefreshSpinner;

	// Token: 0x04000F69 RID: 3945
	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x1C")]
	public Scroller TargetArea;

	// Token: 0x04000F6A RID: 3946
	[Token(Token = "0x4000F6A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro TotalText;

	// Token: 0x04000F6B RID: 3947
	[Token(Token = "0x4000F6B")]
	[FieldOffset(Offset = "0x24")]
	public float ButtonStart;

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x28")]
	public float ButtonHeight;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000F6D")]
	public const bool showPrivate = false;

	// Token: 0x04000F6E RID: 3950
	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000F6F RID: 3951
	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x30")]
	public UiElement DefaultButtonSelected;

	// Token: 0x04000F70 RID: 3952
	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x34")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	private class GameSorter : IComparer<GameListing>
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x780D20", Offset = "0x780120", VA = "0x10780D20", Slot = "4")]
		public int Compare(GameListing x, GameListing y)
		{
			return 0;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public GameSorter()
		{
		}

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x332A3323")]
		public static readonly FindAGameManager.GameSorter Instance;
	}
}
