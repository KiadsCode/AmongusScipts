using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000482 RID: 1154
[Token(Token = "0x2000482")]
public class Console : MonoBehaviour, IUsable
{
	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06001893 RID: 6291 RVA: 0x00007AA0 File Offset: 0x00005CA0
	[Token(Token = "0x1700037A")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x425480", Offset = "0x424880", VA = "0x10425480", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06001894 RID: 6292 RVA: 0x00007AB8 File Offset: 0x00005CB8
	[Token(Token = "0x1700037B")]
	public float UsableDistance
	{
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06001895 RID: 6293 RVA: 0x00007AD0 File Offset: 0x00005CD0
	[Token(Token = "0x1700037C")]
	public float PercentCool
	{
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x425080", Offset = "0x424480", VA = "0x10425080", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x00007AE8 File Offset: 0x00005CE8
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x424B80", Offset = "0x423F80", VA = "0x10424B80", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00007B00 File Offset: 0x00005D00
	[Token(Token = "0x6001898")]
	[Address(RVA = "0x424F00", Offset = "0x424300", VA = "0x10424F00")]
	private bool InRoom(Vector2 truePos)
	{
		return default(bool);
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x424E40", Offset = "0x424240", VA = "0x10424E40")]
	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x4251E0", Offset = "0x4245E0", VA = "0x104251E0", Slot = "10")]
	public virtual void Use()
	{
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x425460", Offset = "0x424860", VA = "0x10425460")]
	public Console()
	{
	}

	// Token: 0x040018BB RID: 6331
	[Token(Token = "0x40018BB")]
	[FieldOffset(Offset = "0xC")]
	public float usableDistance;

	// Token: 0x040018BC RID: 6332
	[Token(Token = "0x40018BC")]
	[FieldOffset(Offset = "0x10")]
	public int ConsoleId;

	// Token: 0x040018BD RID: 6333
	[Token(Token = "0x40018BD")]
	[FieldOffset(Offset = "0x14")]
	public bool onlyFromBelow;

	// Token: 0x040018BE RID: 6334
	[Token(Token = "0x40018BE")]
	[FieldOffset(Offset = "0x15")]
	public bool onlySameRoom;

	// Token: 0x040018BF RID: 6335
	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x16")]
	public bool checkWalls;

	// Token: 0x040018C0 RID: 6336
	[Token(Token = "0x40018C0")]
	[FieldOffset(Offset = "0x17")]
	public bool GhostsIgnored;

	// Token: 0x040018C1 RID: 6337
	[Token(Token = "0x40018C1")]
	[FieldOffset(Offset = "0x18")]
	public bool AllowImpostor;

	// Token: 0x040018C2 RID: 6338
	[Token(Token = "0x40018C2")]
	[FieldOffset(Offset = "0x19")]
	public SystemTypes Room;

	// Token: 0x040018C3 RID: 6339
	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x1C")]
	public TaskTypes[] TaskTypes;

	// Token: 0x040018C4 RID: 6340
	[Token(Token = "0x40018C4")]
	[FieldOffset(Offset = "0x20")]
	public TaskSet[] ValidTasks;

	// Token: 0x040018C5 RID: 6341
	[Token(Token = "0x40018C5")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer Image;
}
