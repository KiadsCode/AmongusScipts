using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000485 RID: 1157
[Token(Token = "0x2000485")]
public class DoorConsole : MonoBehaviour, IUsable
{
	// Token: 0x1700037D RID: 893
	// (get) Token: 0x0600189F RID: 6303 RVA: 0x00007B18 File Offset: 0x00005D18
	[Token(Token = "0x1700037D")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x425480", Offset = "0x424880", VA = "0x10425480", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00007B30 File Offset: 0x00005D30
	[Token(Token = "0x1700037E")]
	public float UsableDistance
	{
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x469670", Offset = "0x468A70", VA = "0x10469670", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00007B48 File Offset: 0x00005D48
	[Token(Token = "0x1700037F")]
	public float PercentCool
	{
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x4690D0", Offset = "0x4684D0", VA = "0x104690D0")]
	public void Awake()
	{
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x00007B60 File Offset: 0x00005D60
	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x469130", Offset = "0x468530", VA = "0x10469130", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x469220", Offset = "0x468620", VA = "0x10469220", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x469380", Offset = "0x468780", VA = "0x10469380", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public DoorConsole()
	{
	}

	// Token: 0x040018CC RID: 6348
	[Token(Token = "0x40018CC")]
	[FieldOffset(Offset = "0xC")]
	private PlainDoor MyDoor;

	// Token: 0x040018CD RID: 6349
	[Token(Token = "0x40018CD")]
	[FieldOffset(Offset = "0x10")]
	public Minigame MinigamePrefab;

	// Token: 0x040018CE RID: 6350
	[Token(Token = "0x40018CE")]
	[FieldOffset(Offset = "0x14")]
	private SpriteRenderer Image;
}
