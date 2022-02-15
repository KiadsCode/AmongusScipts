using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000243 RID: 579
[Token(Token = "0x2000243")]
public abstract class UiElement : MonoBehaviour
{
	// Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x4B6E00", Offset = "0x4B6200", VA = "0x104B6E00", Slot = "4")]
	public virtual void ReceiveMouseOut()
	{
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x4B6E30", Offset = "0x4B6230", VA = "0x104B6E30", Slot = "5")]
	public virtual void ReceiveMouseOver()
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x4B6E60", Offset = "0x4B6260", VA = "0x104B6E60")]
	protected UiElement()
	{
	}

	// Token: 0x04000CD1 RID: 3281
	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0xC")]
	public UnityEvent OnMouseOver;

	// Token: 0x04000CD2 RID: 3282
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x10")]
	public UnityEvent OnMouseOut;

	// Token: 0x04000CD3 RID: 3283
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x14")]
	public ControllerNavigation ControllerNav;
}
