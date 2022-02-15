using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class Ladder : MonoBehaviour, IUsable
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060002EC RID: 748 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x1700006F")]
	public float UsableDistance
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x6D75A0", Offset = "0x6D69A0", VA = "0x106D75A0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060002ED RID: 749 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x17000070")]
	public float PercentCool
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060002EE RID: 750 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x17000071")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x425480", Offset = "0x424880", VA = "0x10425480", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x6D70B0", Offset = "0x6D64B0", VA = "0x106D70B0", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x6D7260", Offset = "0x6D6660", VA = "0x106D7260", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x6D7380", Offset = "0x6D6780", VA = "0x106D7380", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public Ladder()
	{
	}

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0xC")]
	public byte Id;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer SpotArea;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x14")]
	public bool IsTop;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x18")]
	public Ladder Destination;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x1C")]
	public AudioClip UseSound;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer Image;
}
