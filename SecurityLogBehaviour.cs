using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AE RID: 1198
[Token(Token = "0x20004AE")]
public class SecurityLogBehaviour : MonoBehaviour
{
	// Token: 0x06001971 RID: 6513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x58ED30", Offset = "0x58E130", VA = "0x1058ED30")]
	public void LogPlayer(PlayerControl player, SecurityLogBehaviour.SecurityLogLocations location)
	{
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x58EDE0", Offset = "0x58E1E0", VA = "0x1058EDE0")]
	public SecurityLogBehaviour()
	{
	}

	// Token: 0x0400197C RID: 6524
	[Token(Token = "0x400197C")]
	public const byte ConsoleMask = 240;

	// Token: 0x0400197D RID: 6525
	[Token(Token = "0x400197D")]
	public const byte PlayerMask = 15;

	// Token: 0x0400197E RID: 6526
	[Token(Token = "0x400197E")]
	[FieldOffset(Offset = "0xC")]
	public Color[] BarColors;

	// Token: 0x0400197F RID: 6527
	[Token(Token = "0x400197F")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<SecurityLogBehaviour.SecurityLogEntry> LogEntries;

	// Token: 0x04001980 RID: 6528
	[Token(Token = "0x4001980")]
	[FieldOffset(Offset = "0x14")]
	public bool HasNew;

	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public enum SecurityLogLocations
	{
		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		North,
		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		Southeast,
		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		Southwest
	}

	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	public struct SecurityLogEntry
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x365390", Offset = "0x364790", VA = "0x10365390")]
		public SecurityLogEntry(byte playerId, SecurityLogBehaviour.SecurityLogLocations location)
		{
		}

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x0")]
		public byte PlayerId;

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x4")]
		public SecurityLogBehaviour.SecurityLogLocations Location;
	}
}
