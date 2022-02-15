using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000480 RID: 1152
[Token(Token = "0x2000480")]
public class AutoTaskConsole : global::Console
{
	// Token: 0x0600188C RID: 6284 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600188C")]
	[Address(RVA = "0x54F750", Offset = "0x54EB50", VA = "0x1054F750")]
	private PlayerTask FindTask(PlayerControl pc)
	{
		return null;
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188D")]
	[Address(RVA = "0x54F810", Offset = "0x54EC10", VA = "0x1054F810", Slot = "10")]
	public override void Use()
	{
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188E")]
	[Address(RVA = "0x54F610", Offset = "0x54EA10", VA = "0x1054F610", Slot = "11")]
	protected virtual void AfterUse(NormalPlayerTask task)
	{
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600188F")]
	[Address(RVA = "0x54FA50", Offset = "0x54EE50", VA = "0x1054FA50")]
	public AutoTaskConsole()
	{
	}

	// Token: 0x040018B6 RID: 6326
	[Token(Token = "0x40018B6")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip useSound;
}
