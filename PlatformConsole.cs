using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A8 RID: 1192
[Token(Token = "0x20004A8")]
public class PlatformConsole : MonoBehaviour, IUsable
{
	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06001952 RID: 6482 RVA: 0x00007F08 File Offset: 0x00006108
	[Token(Token = "0x170003A9")]
	public float UsableDistance
	{
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x273770", Offset = "0x272B70", VA = "0x10273770", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x06001953 RID: 6483 RVA: 0x00007F20 File Offset: 0x00006120
	[Token(Token = "0x170003AA")]
	public float PercentCool
	{
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06001954 RID: 6484 RVA: 0x00007F38 File Offset: 0x00006138
	[Token(Token = "0x170003AB")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x425480", Offset = "0x424880", VA = "0x10425480", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00007F50 File Offset: 0x00006150
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x65E400", Offset = "0x65D800", VA = "0x1065E400", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x65E6B0", Offset = "0x65DAB0", VA = "0x1065E6B0", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x65E810", Offset = "0x65DC10", VA = "0x1065E810", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x65E8B0", Offset = "0x65DCB0", VA = "0x1065E8B0")]
	public PlatformConsole()
	{
	}

	// Token: 0x04001953 RID: 6483
	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0xC")]
	public float usableDistance;

	// Token: 0x04001954 RID: 6484
	[Token(Token = "0x4001954")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Image;

	// Token: 0x04001955 RID: 6485
	[Token(Token = "0x4001955")]
	[FieldOffset(Offset = "0x14")]
	public MovingPlatformBehaviour Platform;
}
