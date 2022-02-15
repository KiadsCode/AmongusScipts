using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200034F RID: 847
[Token(Token = "0x200034F")]
public class WaterWheelGame : Minigame
{
	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06001279 RID: 4729 RVA: 0x00006480 File Offset: 0x00004680
	// (set) Token: 0x0600127A RID: 4730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C3")]
	private float Water
	{
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x7B71D0", Offset = "0x7B65D0", VA = "0x107B71D0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x7B71F0", Offset = "0x7B65F0", VA = "0x107B71F0")]
		set
		{
		}
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x7B64F0", Offset = "0x7B58F0", VA = "0x107B64F0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x7B66D0", Offset = "0x7B5AD0", VA = "0x107B66D0")]
	public void Update()
	{
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x7B66B0", Offset = "0x7B5AB0", VA = "0x107B66B0")]
	public void Grab()
	{
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x7B6630", Offset = "0x7B5A30", VA = "0x107B6630", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x7B7180", Offset = "0x7B6580", VA = "0x107B7180")]
	public WaterWheelGame()
	{
	}

	// Token: 0x040012AE RID: 4782
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer Wheel;

	// Token: 0x040012AF RID: 4783
	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0x34")]
	public VerticalSpriteGauge WaterLevel;

	// Token: 0x040012B0 RID: 4784
	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer Watertop;

	// Token: 0x040012B1 RID: 4785
	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0x3C")]
	public int WheelScale;

	// Token: 0x040012B2 RID: 4786
	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip FillStart;

	// Token: 0x040012B3 RID: 4787
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x44")]
	public AudioClip FillLoop;

	// Token: 0x040012B4 RID: 4788
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip WheelTurn;

	// Token: 0x040012B5 RID: 4789
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x4C")]
	private TouchpadBehavior touchpad;

	// Token: 0x040012B6 RID: 4790
	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0x50")]
	private float Rate;

	// Token: 0x040012B7 RID: 4791
	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0x54")]
	private AudioSource fillSound;

	// Token: 0x040012B8 RID: 4792
	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 prevStickInput;

	// Token: 0x040012B9 RID: 4793
	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0x60")]
	private bool hadPrev;

	// Token: 0x040012BA RID: 4794
	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0x61")]
	private bool grabbed;
}
