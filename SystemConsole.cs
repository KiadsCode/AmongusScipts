using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004BC RID: 1212
[Token(Token = "0x20004BC")]
public class SystemConsole : MonoBehaviour, IUsable
{
	// Token: 0x170003BA RID: 954
	// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000081F0 File Offset: 0x000063F0
	[Token(Token = "0x170003BA")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00008208 File Offset: 0x00006408
	[Token(Token = "0x170003BB")]
	public float UsableDistance
	{
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x060019C9 RID: 6601 RVA: 0x00008220 File Offset: 0x00006420
	[Token(Token = "0x170003BC")]
	public float PercentCool
	{
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x766B50", Offset = "0x765F50", VA = "0x10766B50")]
	public void Start()
	{
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x7669F0", Offset = "0x765DF0", VA = "0x107669F0", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x00008238 File Offset: 0x00006438
	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x766850", Offset = "0x765C50", VA = "0x10766850", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x766BD0", Offset = "0x765FD0", VA = "0x10766BD0", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x766D80", Offset = "0x766180", VA = "0x10766D80")]
	public SystemConsole()
	{
	}

	// Token: 0x040019DC RID: 6620
	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0xC")]
	public ImageNames useIcon;

	// Token: 0x040019DD RID: 6621
	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x10")]
	public float usableDistance;

	// Token: 0x040019DE RID: 6622
	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x14")]
	public bool FreeplayOnly;

	// Token: 0x040019DF RID: 6623
	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x15")]
	public bool onlyFromBelow;

	// Token: 0x040019E0 RID: 6624
	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Image;

	// Token: 0x040019E1 RID: 6625
	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x1C")]
	public Minigame MinigamePrefab;
}
