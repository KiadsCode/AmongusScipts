using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020B RID: 523
[Token(Token = "0x200020B")]
public class InfectedOverlay : MonoBehaviour
{
	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00004B90 File Offset: 0x00002D90
	[Token(Token = "0x170001BD")]
	public bool CanUseDoors
	{
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x3EF2F0", Offset = "0x3EE6F0", VA = "0x103EF2F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00004BA8 File Offset: 0x00002DA8
	[Token(Token = "0x170001BE")]
	public bool CanUseSpecial
	{
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x3EF350", Offset = "0x3EE750", VA = "0x103EF350")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x3EEB80", Offset = "0x3EDF80", VA = "0x103EEB80")]
	public void Start()
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x3EE490", Offset = "0x3ED890", VA = "0x103EE490")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x3EE710", Offset = "0x3EDB10", VA = "0x103EE710")]
	private void OnEnable()
	{
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA3")]
	[Address(RVA = "0x3EE650", Offset = "0x3EDA50", VA = "0x103EE650")]
	private void OnDisable()
	{
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA4")]
	[Address(RVA = "0x3EE590", Offset = "0x3ED990", VA = "0x103EE590")]
	public void OnControlTypeChanged()
	{
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA5")]
	[Address(RVA = "0x3EE3B0", Offset = "0x3ED7B0", VA = "0x103EE3B0")]
	private void DeselectCurrent()
	{
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x3EEA70", Offset = "0x3EDE70", VA = "0x103EEA70")]
	private void Select(ButtonBehavior newSelected)
	{
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x3EE890", Offset = "0x3EDC90", VA = "0x103EE890")]
	private void SelectClosestButton(Vector2 anchorSpot)
	{
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x3EED20", Offset = "0x3EE120", VA = "0x103EED20")]
	private void Update()
	{
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public InfectedOverlay()
	{
	}

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0xC")]
	public MapRoom[] rooms;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x10")]
	private IActivatable doors;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0x14")]
	private SabotageSystemType SabSystem;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x18")]
	public ButtonBehavior[] allButtons;

	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0x1C")]
	public ButtonBehavior selectedButton;

	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000BB6")]
	private const float selectCooldown = 0.5f;

	// Token: 0x04000BB7 RID: 2999
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x20")]
	private float currentCooldown;
}
