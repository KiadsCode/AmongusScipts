using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BA RID: 1210
[Token(Token = "0x20004BA")]
public class StoreArmsTaskConsole : global::Console
{
	// Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x75C120", Offset = "0x75B520", VA = "0x1075C120")]
	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x75C1E0", Offset = "0x75B5E0", VA = "0x1075C1E0", Slot = "10")]
	public override void Use()
	{
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x75BFE0", Offset = "0x75B3E0", VA = "0x1075BFE0", Slot = "11")]
	protected virtual void AfterUse(NormalPlayerTask task)
	{
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x75C4A0", Offset = "0x75B8A0", VA = "0x1075C4A0")]
	public StoreArmsTaskConsole()
	{
	}

	// Token: 0x040019CF RID: 6607
	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip useSound;

	// Token: 0x040019D0 RID: 6608
	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite[] Images;

	// Token: 0x040019D1 RID: 6609
	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x30")]
	public int usesPerStep;

	// Token: 0x040019D2 RID: 6610
	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x34")]
	private int timesUsed;
}
