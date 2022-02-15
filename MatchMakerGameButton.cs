using System;
using Il2CppDummyDll;
using InnerNet;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x020002F0 RID: 752
[Token(Token = "0x20002F0")]
public class MatchMakerGameButton : PoolableBehavior, IConnectButton
{
	// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x76B570", Offset = "0x76A970", VA = "0x1076B570")]
	public void OnClick()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x76BA70", Offset = "0x76AE70", VA = "0x1076BA70", Slot = "5")]
	public void StartIcon()
	{
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x76BAA0", Offset = "0x76AEA0", VA = "0x1076BAA0", Slot = "6")]
	public void StopIcon()
	{
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x76B7F0", Offset = "0x76ABF0", VA = "0x1076B7F0")]
	public void SetGame(GameListing gameListing)
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public MatchMakerGameButton()
	{
	}

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro NameText;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro SmallNameText;

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro PlayerCountText;

	// Token: 0x0400103D RID: 4157
	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro ImpostorCountText;

	// Token: 0x0400103E RID: 4158
	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer MapIcon;

	// Token: 0x0400103F RID: 4159
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0x28")]
	public PlatformIdentifier PlatformIdentifier;

	// Token: 0x04001040 RID: 4160
	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite[] MapIcons;

	// Token: 0x04001041 RID: 4161
	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0x30")]
	public SpriteAnim connectIcon;

	// Token: 0x04001042 RID: 4162
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x34")]
	public AnimationClip connectClip;

	// Token: 0x04001043 RID: 4163
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x38")]
	public GameListing myListing;
}
