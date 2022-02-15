using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public class InfoTextBox : MonoBehaviour
{
	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3EF3D0", Offset = "0x3EE7D0", VA = "0x103EF3D0")]
	public void Awake()
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3EF4A0", Offset = "0x3EE8A0", VA = "0x103EF4A0")]
	public void Close()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3EF4F0", Offset = "0x3EE8F0", VA = "0x103EF4F0")]
	public void SetConfirmWindow()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3EF5C0", Offset = "0x3EE9C0", VA = "0x103EF5C0")]
	public void SetTwoButtons()
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3EF530", Offset = "0x3EE930", VA = "0x103EF530")]
	public void SetOneButton()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3EF6C0", Offset = "0x3EEAC0", VA = "0x103EF6C0")]
	public void Update()
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public InfoTextBox()
	{
	}

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer background;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x10")]
	public bool isConfirmWindow;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro titleTexxt;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro bodyText;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro button1Text;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro button2Text;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x24")]
	public PassiveButton button1;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x28")]
	public PassiveButton button2;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x2C")]
	public Transform button1Trans;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x30")]
	public Transform button2Trans;
}
