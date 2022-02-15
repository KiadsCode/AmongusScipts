using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C2 RID: 1218
[Token(Token = "0x20004C2")]
public class Vent : MonoBehaviour, IUsable
{
	// Token: 0x170003BE RID: 958
	// (get) Token: 0x060019DB RID: 6619 RVA: 0x00008268 File Offset: 0x00006468
	[Token(Token = "0x170003BE")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x6C1DE0", Offset = "0x6C11E0", VA = "0x106C1DE0", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x060019DC RID: 6620 RVA: 0x00008280 File Offset: 0x00006480
	[Token(Token = "0x170003BF")]
	public float UsableDistance
	{
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x7ACCE0", Offset = "0x7AC0E0", VA = "0x107ACCE0", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x060019DD RID: 6621 RVA: 0x00008298 File Offset: 0x00006498
	[Token(Token = "0x170003C0")]
	public float PercentCool
	{
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x060019DE RID: 6622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C1")]
	private Vent[] NearbyVents
	{
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x7ACBE0", Offset = "0x7ABFE0", VA = "0x107ACBE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x7AC880", Offset = "0x7ABC80", VA = "0x107AC880")]
	private void Start()
	{
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x7ABF40", Offset = "0x7AB340", VA = "0x107ABF40")]
	public void SetButtons(bool enabled)
	{
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x000082B0 File Offset: 0x000064B0
	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x7AB330", Offset = "0x7AA730", VA = "0x107AB330", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x7AC6A0", Offset = "0x7ABAA0", VA = "0x107AC6A0", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x7AB800", Offset = "0x7AAC00", VA = "0x107AB800")]
	public void ClickRight()
	{
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x7AB750", Offset = "0x7AAB50", VA = "0x107AB750")]
	public void ClickLeft()
	{
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x7AB6A0", Offset = "0x7AAAA0", VA = "0x107AB6A0")]
	public void ClickCenter()
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x7ACA80", Offset = "0x7ABE80", VA = "0x107ACA80", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E7")]
	[Address(RVA = "0x7AC910", Offset = "0x7ABD10", VA = "0x107AC910")]
	public void UpdateArrows(VentilationSystem ventSystem)
	{
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x7AB8B0", Offset = "0x7AACB0", VA = "0x107AB8B0")]
	internal void EnterVent(PlayerControl pc)
	{
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x7ABAD0", Offset = "0x7AAED0", VA = "0x107ABAD0")]
	internal void ExitVent(PlayerControl pc)
	{
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x7ABCC0", Offset = "0x7AB0C0", VA = "0x107ABCC0")]
	private void MoveToVent(Vent otherVent)
	{
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x7AC8D0", Offset = "0x7ABCD0", VA = "0x107AC8D0")]
	private void ToggleNeighborVentBeingCleaned(bool ventBeingCleaned, ButtonBehavior b, GameObject c)
	{
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019EC")]
	[Address(RVA = "0x7ACBB0", Offset = "0x7ABFB0", VA = "0x107ACBB0")]
	public Vent()
	{
	}

	// Token: 0x04001A17 RID: 6679
	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x0")]
	public static Vent currentVent;

	// Token: 0x04001A18 RID: 6680
	[Token(Token = "0x4001A18")]
	[FieldOffset(Offset = "0xC")]
	public int Id;

	// Token: 0x04001A19 RID: 6681
	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x10")]
	public Vent Left;

	// Token: 0x04001A1A RID: 6682
	[Token(Token = "0x4001A1A")]
	[FieldOffset(Offset = "0x14")]
	public Vent Right;

	// Token: 0x04001A1B RID: 6683
	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x18")]
	public Vent Center;

	// Token: 0x04001A1C RID: 6684
	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x1C")]
	public ButtonBehavior[] Buttons;

	// Token: 0x04001A1D RID: 6685
	[Token(Token = "0x4001A1D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] CleaningIndicators;

	// Token: 0x04001A1E RID: 6686
	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0x24")]
	public AnimationClip EnterVentAnim;

	// Token: 0x04001A1F RID: 6687
	[Token(Token = "0x4001A1F")]
	[FieldOffset(Offset = "0x28")]
	public AnimationClip ExitVentAnim;

	// Token: 0x04001A20 RID: 6688
	[Token(Token = "0x4001A20")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Offset;

	// Token: 0x04001A21 RID: 6689
	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0x38")]
	public float spreadAmount;

	// Token: 0x04001A22 RID: 6690
	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0x3C")]
	public float spreadShift;

	// Token: 0x04001A23 RID: 6691
	[Token(Token = "0x4001A23")]
	[FieldOffset(Offset = "0x40")]
	private SpriteRenderer myRend;
}
