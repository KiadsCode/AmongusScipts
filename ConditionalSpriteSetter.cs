using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000369 RID: 873
[Token(Token = "0x2000369")]
[Attribute(Name = "RequireComponent", RVA = "0xDD860", Offset = "0xDCC60")]
public class ConditionalSpriteSetter : MonoBehaviour
{
	// Token: 0x060012DE RID: 4830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x420BA0", Offset = "0x41FFA0", VA = "0x10420BA0")]
	private void Start()
	{
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
	public ConditionalSpriteSetter()
	{
	}

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0xC")]
	public bool ignoreIfNoSpriteForPlatform;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x10")]
	public ConditionalSprite sprite;
}
