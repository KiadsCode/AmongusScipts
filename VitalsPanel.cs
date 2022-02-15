using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034E RID: 846
[Token(Token = "0x200034E")]
public class VitalsPanel : MonoBehaviour
{
	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06001272 RID: 4722 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001273 RID: 4723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C2")]
	public GameData.PlayerInfo PlayerInfo
	{
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x7B3FB0", Offset = "0x7B33B0", VA = "0x107B3FB0")]
	public void SetPlayer(int index, GameData.PlayerInfo playerInfo)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x7B3F60", Offset = "0x7B3360", VA = "0x107B3F60")]
	public void SetDisconnected()
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x7B3E00", Offset = "0x7B3200", VA = "0x107B3E00")]
	public void SetDead()
	{
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x7B3DA0", Offset = "0x7B31A0", VA = "0x107B3DA0")]
	public void SetAlive()
	{
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public VitalsPanel()
	{
	}

	// Token: 0x040012A4 RID: 4772
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private GameData.PlayerInfo <PlayerInfo>k__BackingField;

	// Token: 0x040012A5 RID: 4773
	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0x10")]
	public PoolablePlayer PlayerIcon;

	// Token: 0x040012A6 RID: 4774
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer MaskingArea;

	// Token: 0x040012A7 RID: 4775
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Background;

	// Token: 0x040012A8 RID: 4776
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x1C")]
	public VertLineBehaviour Cardio;

	// Token: 0x040012A9 RID: 4777
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x20")]
	public Sprite VitalBgDead;

	// Token: 0x040012AA RID: 4778
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x24")]
	public Sprite VitalBgDiscon;

	// Token: 0x040012AB RID: 4779
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x28")]
	public IntRange BeatRange;

	// Token: 0x040012AC RID: 4780
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsDead;

	// Token: 0x040012AD RID: 4781
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x2D")]
	public bool IsDiscon;
}
