using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
[Token(Token = "0x20004A6")]
public class OpenDoorConsole : MonoBehaviour, IUsable
{
	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06001949 RID: 6473 RVA: 0x00007EA8 File Offset: 0x000060A8
	[Token(Token = "0x170003A6")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x0600194A RID: 6474 RVA: 0x00007EC0 File Offset: 0x000060C0
	[Token(Token = "0x170003A7")]
	public float UsableDistance
	{
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x328490", Offset = "0x327890", VA = "0x10328490", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x0600194B RID: 6475 RVA: 0x00007ED8 File Offset: 0x000060D8
	[Token(Token = "0x170003A8")]
	public float PercentCool
	{
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x77CD80", Offset = "0x77C180", VA = "0x1077CD80")]
	public void Awake()
	{
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x00007EF0 File Offset: 0x000060F0
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x77CDE0", Offset = "0x77C1E0", VA = "0x1077CDE0", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x77CED0", Offset = "0x77C2D0", VA = "0x1077CED0", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x77D030", Offset = "0x77C430", VA = "0x1077D030", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x77D1B0", Offset = "0x77C5B0", VA = "0x1077D1B0")]
	public OpenDoorConsole()
	{
	}

	// Token: 0x0400194C RID: 6476
	[Token(Token = "0x400194C")]
	[FieldOffset(Offset = "0xC")]
	private ImageNames useIcon;

	// Token: 0x0400194D RID: 6477
	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x10")]
	private PlainDoor MyDoor;

	// Token: 0x0400194E RID: 6478
	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x14")]
	private SpriteRenderer Image;

	// Token: 0x0400194F RID: 6479
	[Token(Token = "0x400194F")]
	[FieldOffset(Offset = "0x18")]
	public float usableDisance;
}
