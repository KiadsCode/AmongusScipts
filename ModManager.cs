using System;
using Beebyte.Obfuscator;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029F RID: 671
[Token(Token = "0x200029F")]
[Skip]
public class ModManager : DestroyableSingleton<ModManager>
{
	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x773610", Offset = "0x772A10", VA = "0x10773610")]
	public void ShowModStamp()
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x773480", Offset = "0x772880", VA = "0x10773480")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x773640", Offset = "0x772A40", VA = "0x10773640")]
	public ModManager()
	{
	}

	// Token: 0x04000EED RID: 3821
	[Token(Token = "0x4000EED")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer ModStamp;

	// Token: 0x04000EEE RID: 3822
	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x14")]
	public Camera localCamera;
}
