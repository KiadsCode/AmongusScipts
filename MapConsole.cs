using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200049E RID: 1182
[Token(Token = "0x200049E")]
public class MapConsole : MonoBehaviour, IUsable
{
	// Token: 0x1700039A RID: 922
	// (get) Token: 0x06001920 RID: 6432 RVA: 0x00007DD0 File Offset: 0x00005FD0
	[Token(Token = "0x1700039A")]
	public ImageNames UseIcon
	{
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "6")]
		get
		{
			return ImageNames.LocalButton;
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x06001921 RID: 6433 RVA: 0x00007DE8 File Offset: 0x00005FE8
	[Token(Token = "0x1700039B")]
	public float UsableDistance
	{
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x273A10", Offset = "0x272E10", VA = "0x10273A10", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x06001922 RID: 6434 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x1700039C")]
	public float PercentCool
	{
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x3E2C60", Offset = "0x3E2060", VA = "0x103E2C60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x6E5270", Offset = "0x6E4670", VA = "0x106E5270", Slot = "7")]
	public void SetOutline(bool on, bool mainTarget)
	{
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x6E5180", Offset = "0x6E4580", VA = "0x106E5180", Slot = "8")]
	public float CanUse(GameData.PlayerInfo pc, out bool canUse, out bool couldUse)
	{
		return 0f;
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x6E53D0", Offset = "0x6E47D0", VA = "0x106E53D0", Slot = "9")]
	public void Use()
	{
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001926")]
	[Address(RVA = "0x6E56E0", Offset = "0x6E4AE0", VA = "0x106E56E0")]
	public MapConsole()
	{
	}

	// Token: 0x04001925 RID: 6437
	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0xC")]
	public ImageNames useIcon;

	// Token: 0x04001926 RID: 6438
	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x10")]
	public float usableDistance;

	// Token: 0x04001927 RID: 6439
	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer Image;

	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001928 RID: 6440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x799D40", Offset = "0x799140", VA = "0x10799D40")]
		internal void <Use>b__11_0(MapBehaviour m)
		{
		}

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MapConsole.<>c <>9;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x4")]
		public static Action<MapBehaviour> <>9__11_0;
	}
}
