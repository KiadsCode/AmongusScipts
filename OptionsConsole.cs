using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
public class OptionsConsole : MonoBehaviour, IUsable
{
	// Token: 0x17000273 RID: 627
	// (get) Token: 0x0600103F RID: 4159 RVA: 0x00005CB8 File Offset: 0x00003EB8
	[Token(Token = "0x17000273")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06001040 RID: 4160 RVA: 0x00005CD0 File Offset: 0x00003ED0
	[Token(Token = "0x17000274")]
	public float UsableDistance
	{
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x469670", Offset = "0x468A70", VA = "0x10469670", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06001041 RID: 4161 RVA: 0x00005CE8 File Offset: 0x00003EE8
	[Token(Token = "0x17000275")]
	public float PercentCool
	{
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00005D00 File Offset: 0x00003F00
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x77D5E0", Offset = "0x77C9E0", VA = "0x1077D5E0", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x77D710", Offset = "0x77CB10", VA = "0x1077D710", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x77D870", Offset = "0x77CC70", VA = "0x1077D870", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public OptionsConsole()
	{
	}

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4001001")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 CustomPosition;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4001002")]
	[FieldOffset(Offset = "0x18")]
	public bool HostOnly;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4001003")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MenuPrefab;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4001004")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer Outline;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4001005")]
	[FieldOffset(Offset = "0x24")]
	public ImageNames CustomUseIcon;
}
