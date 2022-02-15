using System;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
public class NotificationPopper : MonoBehaviour
{
	// Token: 0x06000C8F RID: 3215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x77AC20", Offset = "0x77A020", VA = "0x1077AC20")]
	public void Update()
	{
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x77AB50", Offset = "0x779F50", VA = "0x1077AB50")]
	public void AddItem(string item)
	{
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x77AF90", Offset = "0x77A390", VA = "0x1077AF90")]
	public NotificationPopper()
	{
	}

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro TextArea;

	// Token: 0x04000C84 RID: 3204
	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0x10")]
	public float zPos;

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x14")]
	private float alphaTimer;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x18")]
	public float ShowDuration;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x1C")]
	public float FadeDuration;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x20")]
	public Color textColor;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x30")]
	private StringBuilder builder;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x34")]
	public AudioClip NotificationSound;
}
