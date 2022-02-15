using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class PlayerIdentifierButton : PoolableBehavior
{
	// Token: 0x06000B5E RID: 2910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x501210", Offset = "0x500610", VA = "0x10501210")]
	public void SetTargetPlayerId(byte targetId)
	{
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x5010C0", Offset = "0x5004C0", VA = "0x105010C0")]
	public void SetMaskLayer(int maskLayer)
	{
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x500F20", Offset = "0x500320", VA = "0x10500F20")]
	public void DisplayProfileInfo()
	{
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x501040", Offset = "0x500440", VA = "0x10501040", Slot = "4")]
	public override void Reset()
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public PlayerIdentifierButton()
	{
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x501550", Offset = "0x500950", VA = "0x10501550")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <DisplayProfileInfo>b__7_0(PlayerControl pc)
	{
		return default(bool);
	}

	// Token: 0x04000B78 RID: 2936
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x14")]
	public byte TargetPlayerId;

	// Token: 0x04000B79 RID: 2937
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro NameText;

	// Token: 0x04000B7A RID: 2938
	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x1C")]
	public PlatformIdentifier PlatformIdentifier;

	// Token: 0x04000B7B RID: 2939
	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x20")]
	public PoolablePlayer PlayerPreview;

	// Token: 0x04000B7C RID: 2940
	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x24")]
	public SpriteRenderer MaskArea;

	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06000B64 RID: 2916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x5A7650", Offset = "0x5A6A50", VA = "0x105A7650")]
		internal bool <SetTargetPlayerId>b__0(PlayerControl pc)
		{
			return default(bool);
		}

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x8")]
		public byte targetId;
	}
}
