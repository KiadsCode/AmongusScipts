using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
internal class ChatBubble : PoolableBehavior
{
	// Token: 0x06000AAC RID: 2732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x830CF0", Offset = "0x8300F0", VA = "0x10830CF0")]
	public void SetLeft()
	{
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x831140", Offset = "0x830540", VA = "0x10831140")]
	public void SetNotification()
	{
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x830BD0", Offset = "0x82FFD0", VA = "0x10830BD0")]
	public void SetCosmetics(GameData.PlayerInfo playerInfo)
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x8314A0", Offset = "0x8308A0", VA = "0x108314A0")]
	public void SetRight()
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x831010", Offset = "0x830410", VA = "0x10831010")]
	public void SetName(string playerName, bool isDead, bool voted, Color color)
	{
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x830B60", Offset = "0x82FF60", VA = "0x10830B60", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x8309F0", Offset = "0x82FDF0", VA = "0x108309F0")]
	public void AlignChildren()
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x8317C0", Offset = "0x830BC0", VA = "0x108317C0")]
	internal void SetText(string chatText)
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public ChatBubble()
	{
	}

	// Token: 0x04000AB8 RID: 2744
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 PlayerMessageScale;

	// Token: 0x04000AB9 RID: 2745
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 PlayerNotificationScale;

	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Vector3 VotedAndDeadMarkerPosition;

	// Token: 0x04000ABB RID: 2747
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x24")]
	private static readonly Vector3 VotedAndDeadMarkerPositionRight;

	// Token: 0x04000ABC RID: 2748
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x14")]
	public PoolablePlayer Player;

	// Token: 0x04000ABD RID: 2749
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Xmark;

	// Token: 0x04000ABE RID: 2750
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer votedMark;

	// Token: 0x04000ABF RID: 2751
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro NameText;

	// Token: 0x04000AC0 RID: 2752
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x24")]
	public TextMeshPro TextArea;

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer Background;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer MaskArea;

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x30")]
	public PlatformIdentifier PlatformIcon;
}
