using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000449 RID: 1097
[Token(Token = "0x2000449")]
public class ShapeshifterRole : ImpostorRole
{
	// Token: 0x17000342 RID: 834
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x000074D0 File Offset: 0x000056D0
	[Token(Token = "0x17000342")]
	private bool IsCoolingDown
	{
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x4949C0", Offset = "0x493DC0", VA = "0x104949C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x494660", Offset = "0x493A60", VA = "0x10494660", Slot = "8")]
	public override void UseAbility()
	{
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x494310", Offset = "0x493710", VA = "0x10494310")]
	public void RevertPlayerToNormal(bool shouldAnimate = true, bool setCooldown = true)
	{
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x4941D0", Offset = "0x4935D0", VA = "0x104941D0", Slot = "10")]
	public override void OnVotingComplete()
	{
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x4943C0", Offset = "0x4937C0", VA = "0x104943C0", Slot = "14")]
	public override void SetCooldown()
	{
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x493E70", Offset = "0x493270", VA = "0x10493E70")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x494490", Offset = "0x493890", VA = "0x10494490")]
	public void SetEvidence()
	{
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x4949B0", Offset = "0x493DB0", VA = "0x104949B0")]
	public ShapeshifterRole()
	{
	}

	// Token: 0x0400175C RID: 5980
	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x50")]
	public ShapeshifterEvidence EvidencePrefab;

	// Token: 0x0400175D RID: 5981
	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 EvidenceOffset;

	// Token: 0x0400175E RID: 5982
	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x60")]
	private float cooldownSecondsRemaining;

	// Token: 0x0400175F RID: 5983
	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x64")]
	private float durationSecondsRemaining;

	// Token: 0x04001760 RID: 5984
	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0x68")]
	public ShapeshifterMinigame ShapeshifterMenu;

	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001716")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6001717")]
		[Address(RVA = "0x370A90", Offset = "0x36FE90", VA = "0x10370A90")]
		internal bool <UseAbility>b__7_0(RoleEffectAnimation r)
		{
			return default(bool);
		}

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ShapeshifterRole.<>c <>9;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x4")]
		public static Predicate<RoleEffectAnimation> <>9__7_0;
	}
}
