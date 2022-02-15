using System;
using Il2CppDummyDll;

// Token: 0x02000437 RID: 1079
[Token(Token = "0x2000437")]
public class ImpostorRole : RoleBehaviour
{
	// Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x3ED4F0", Offset = "0x3EC8F0", VA = "0x103ED4F0", Slot = "6")]
	public override void Deinitialize(PlayerControl targetPlayer)
	{
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x3ED6E0", Offset = "0x3ECAE0", VA = "0x103ED6E0", Slot = "11")]
	public override void Initialize(PlayerControl player)
	{
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x3ED7C0", Offset = "0x3ECBC0", VA = "0x103ED7C0", Slot = "7")]
	public override void SpawnTaskHeader(PlayerControl playerControl)
	{
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x00007290 File Offset: 0x00005490
	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x3ED440", Offset = "0x3EC840", VA = "0x103ED440", Slot = "4")]
	public override bool CanUse(IUsable usable)
	{
		return default(bool);
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x000072A8 File Offset: 0x000054A8
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x3ED690", Offset = "0x3ECA90", VA = "0x103ED690", Slot = "5")]
	public override bool DidWin(GameOverReason gameOverReason)
	{
		return default(bool);
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x3B8460", Offset = "0x3B7860", VA = "0x103B8460")]
	public ImpostorRole()
	{
	}

	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060016C4 RID: 5828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x5B4800", Offset = "0x5B3C00", VA = "0x105B4800")]
		internal bool <Deinitialize>b__0_0(PlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ImpostorRole.<>c <>9;

		// Token: 0x04001715 RID: 5909
		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x4")]
		public static Func<PlayerTask, bool> <>9__0_0;
	}
}
