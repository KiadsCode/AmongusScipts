using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x02000232 RID: 562
[Token(Token = "0x2000232")]
public class ButtonAnimRolloverHandler : MonoBehaviour
{
	// Token: 0x06000C92 RID: 3218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x82BAB0", Offset = "0x82AEB0", VA = "0x1082BAB0")]
	public void Start()
	{
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x82B9E0", Offset = "0x82ADE0", VA = "0x1082B9E0")]
	public void DoMouseOver()
	{
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x82B9A0", Offset = "0x82ADA0", VA = "0x1082B9A0")]
	public void DoMouseOut()
	{
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ButtonAnimRolloverHandler()
	{
	}

	// Token: 0x04000C8B RID: 3211
	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0xC")]
	public Sprite StaticOutImage;

	// Token: 0x04000C8C RID: 3212
	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip RolloverAnim;

	// Token: 0x04000C8D RID: 3213
	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x14")]
	public AudioClip HoverSound;

	// Token: 0x04000C8E RID: 3214
	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x18")]
	private SpriteRenderer target;

	// Token: 0x04000C8F RID: 3215
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x1C")]
	private SpriteAnim animTarget;
}
