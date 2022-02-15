using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public interface IFocusHolder
{
	// Token: 0x06000B4A RID: 2890
	[Token(Token = "0x6000B4A")]
	void GiveFocus();

	// Token: 0x06000B4B RID: 2891
	[Token(Token = "0x6000B4B")]
	void LoseFocus();

	// Token: 0x06000B4C RID: 2892
	[Token(Token = "0x6000B4C")]
	bool CheckCollision(Vector2 pt);
}
