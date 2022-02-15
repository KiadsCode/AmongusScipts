using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class DeconControl : MonoBehaviour, IUsable
{
	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000979 RID: 2425 RVA: 0x000045C0 File Offset: 0x000027C0
	[Token(Token = "0x17000171")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x425480", Offset = "0x424880", VA = "0x10425480", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x0600097A RID: 2426 RVA: 0x000045D8 File Offset: 0x000027D8
	[Token(Token = "0x17000172")]
	public float UsableDistance
	{
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x0600097B RID: 2427 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x17000173")]
	public float PercentCool
	{
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x5C4380", Offset = "0x5C3780", VA = "0x105C4380", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x5C40A0", Offset = "0x5C34A0", VA = "0x105C40A0", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x5C4200", Offset = "0x5C3600", VA = "0x105C4200")]
	public void Update()
	{
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x00004608 File Offset: 0x00002808
	[Token(Token = "0x600097E")]
	[Address(RVA = "0x5C3EC0", Offset = "0x5C32C0", VA = "0x105C3EC0", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x5C4250", Offset = "0x5C3650", VA = "0x105C4250", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x512B90", Offset = "0x511F90", VA = "0x10512B90")]
	public DeconControl()
	{
	}

	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0xC")]
	public DeconSystem System;

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x10")]
	public float usableDistance;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Image;

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip UseSound;

	// Token: 0x04000991 RID: 2449
	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x1C")]
	public Button.ButtonClickedEvent OnUse;

	// Token: 0x04000992 RID: 2450
	[Token(Token = "0x4000992")]
	private const float CooldownDuration = 6f;

	// Token: 0x04000993 RID: 2451
	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x20")]
	private float cooldown;
}
