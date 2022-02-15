using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FF RID: 511
[Token(Token = "0x20001FF")]
public interface IVirtualJoystick
{
	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000B69 RID: 2921
	[Token(Token = "0x170001B2")]
	Vector2 Delta { [Token(Token = "0x6000B69")] get; }

	// Token: 0x06000B6A RID: 2922
	[Token(Token = "0x6000B6A")]
	void ToggleVisuals(bool on);
}
