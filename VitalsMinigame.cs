using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x0200034C RID: 844
[Token(Token = "0x200034C")]
public class VitalsMinigame : Minigame
{
	// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126D")]
	[Address(RVA = "0x7B3720", Offset = "0x7B2B20", VA = "0x107B3720", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126E")]
	[Address(RVA = "0x7B3AB0", Offset = "0x7B2EB0", VA = "0x107B3AB0")]
	private void Update()
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x7B3D60", Offset = "0x7B3160", VA = "0x107B3D60")]
	public VitalsMinigame()
	{
	}

	// Token: 0x0400129B RID: 4763
	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro BatteryText;

	// Token: 0x0400129C RID: 4764
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x34")]
	public VitalsPanel PanelPrefab;

	// Token: 0x0400129D RID: 4765
	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshPro SabText;

	// Token: 0x0400129E RID: 4766
	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x3C")]
	public float XStart;

	// Token: 0x0400129F RID: 4767
	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0x40")]
	public float YStart;

	// Token: 0x040012A0 RID: 4768
	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0x44")]
	public float XOffset;

	// Token: 0x040012A1 RID: 4769
	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0x48")]
	public float YOffset;

	// Token: 0x040012A2 RID: 4770
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x4C")]
	private VitalsPanel[] vitals;

	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06001270 RID: 4720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x13029B0", Offset = "0x1301DB0", VA = "0x113029B0")]
		internal bool <Begin>b__0(DeadBody b)
		{
			return default(bool);
		}

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x8")]
		public GameData.PlayerInfo player;
	}
}
