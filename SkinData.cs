using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000417 RID: 1047
[Token(Token = "0x2000417")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x952B0", Offset = "0x946B0")]
public class SkinData : CosmeticData
{
	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000316")]
	public new string ProdId
	{
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x49EF40", Offset = "0x49E340", VA = "0x1049EF40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001606")]
	[Address(RVA = "0x49EF10", Offset = "0x49E310", VA = "0x1049EF10", Slot = "9")]
	public override void PreviewOnPlayer(PoolablePlayer p)
	{
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001607")]
	[Address(RVA = "0x49EEB0", Offset = "0x49E2B0", VA = "0x1049EEB0", Slot = "10")]
	public override string GetItemCategory()
	{
		return null;
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001608")]
	[Address(RVA = "0x3B9FA0", Offset = "0x3B93A0", VA = "0x103B9FA0")]
	public SkinData()
	{
	}

	// Token: 0x04001650 RID: 5712
	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite IdleFrame;

	// Token: 0x04001651 RID: 5713
	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x30")]
	public AnimationClip IdleAnim;

	// Token: 0x04001652 RID: 5714
	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x34")]
	public AnimationClip RunAnim;

	// Token: 0x04001653 RID: 5715
	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0x38")]
	public AnimationClip EnterVentAnim;

	// Token: 0x04001654 RID: 5716
	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x3C")]
	public AnimationClip ExitVentAnim;

	// Token: 0x04001655 RID: 5717
	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x40")]
	public AnimationClip ClimbAnim;

	// Token: 0x04001656 RID: 5718
	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0x44")]
	public AnimationClip ClimbDownAnim;

	// Token: 0x04001657 RID: 5719
	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x48")]
	public AnimationClip KillTongueImpostor;

	// Token: 0x04001658 RID: 5720
	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationClip KillTongueVictim;

	// Token: 0x04001659 RID: 5721
	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x50")]
	public AnimationClip KillShootImpostor;

	// Token: 0x0400165A RID: 5722
	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0x54")]
	public AnimationClip KillShootVictim;

	// Token: 0x0400165B RID: 5723
	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x58")]
	public AnimationClip KillNeckImpostor;

	// Token: 0x0400165C RID: 5724
	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x5C")]
	public AnimationClip KillNeckVictim;

	// Token: 0x0400165D RID: 5725
	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0x60")]
	public AnimationClip KillStabImpostor;

	// Token: 0x0400165E RID: 5726
	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x64")]
	public AnimationClip KillStabVictim;

	// Token: 0x0400165F RID: 5727
	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x68")]
	public AnimationClip KillRHMVictim;

	// Token: 0x04001660 RID: 5728
	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0x6C")]
	public Sprite EjectFrame;

	// Token: 0x04001661 RID: 5729
	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x70")]
	public AnimationClip SpawnAnim;

	// Token: 0x04001662 RID: 5730
	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x74")]
	public AnimationClip IdleLeftAnim;

	// Token: 0x04001663 RID: 5731
	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x78")]
	public AnimationClip RunLeftAnim;

	// Token: 0x04001664 RID: 5732
	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x7C")]
	public AnimationClip EnterLeftVentAnim;

	// Token: 0x04001665 RID: 5733
	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x80")]
	public AnimationClip ExitLeftVentAnim;

	// Token: 0x04001666 RID: 5734
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x84")]
	public AnimationClip SpawnLeftAnim;

	// Token: 0x04001667 RID: 5735
	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x88")]
	public OverlayKillAnimation[] KillAnims;

	// Token: 0x04001668 RID: 5736
	[Token(Token = "0x4001668")]
	[FieldOffset(Offset = "0x8C")]
	public bool NotInStore;

	// Token: 0x04001669 RID: 5737
	[Token(Token = "0x4001669")]
	[FieldOffset(Offset = "0x8D")]
	public bool Free;

	// Token: 0x0400166A RID: 5738
	[Token(Token = "0x400166A")]
	[FieldOffset(Offset = "0x90")]
	public HatBehaviour RelatedHat;

	// Token: 0x0400166B RID: 5739
	[Token(Token = "0x400166B")]
	[FieldOffset(Offset = "0x94")]
	public VisorData RelatedVisor;

	// Token: 0x0400166C RID: 5740
	[Token(Token = "0x400166C")]
	[FieldOffset(Offset = "0x98")]
	public string StoreName;

	// Token: 0x0400166D RID: 5741
	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0x9C")]
	public int Order;
}
