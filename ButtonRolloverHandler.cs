using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000235 RID: 565
[Token(Token = "0x2000235")]
public class ButtonRolloverHandler : MonoBehaviour
{
	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x82C0E0", Offset = "0x82B4E0", VA = "0x1082C0E0")]
	public void Awake()
	{
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x82C660", Offset = "0x82BA60", VA = "0x1082C660")]
	public void DoMouseOver()
	{
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x82C510", Offset = "0x82B910", VA = "0x1082C510")]
	public void DoMouseOut()
	{
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x82C830", Offset = "0x82BC30", VA = "0x1082C830")]
	public void SetDisabledColors()
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x82C8B0", Offset = "0x82BCB0", VA = "0x1082C8B0")]
	public void SetEnabledColors()
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x82C3B0", Offset = "0x82B7B0", VA = "0x1082C3B0")]
	public void ChangeOutColor(Color color)
	{
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x82C930", Offset = "0x82BD30", VA = "0x1082C930")]
	public ButtonRolloverHandler()
	{
	}

	// Token: 0x04000C97 RID: 3223
	[Token(Token = "0x4000C97")]
	[FieldOffset(Offset = "0xC")]
	public SpriteRenderer Target;

	// Token: 0x04000C98 RID: 3224
	[Token(Token = "0x4000C98")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro TargetText;

	// Token: 0x04000C99 RID: 3225
	[Token(Token = "0x4000C99")]
	[FieldOffset(Offset = "0x14")]
	public MeshRenderer TargetMesh;

	// Token: 0x04000C9A RID: 3226
	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x18")]
	public Color OverColor;

	// Token: 0x04000C9B RID: 3227
	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0x28")]
	public Color OutColor;

	// Token: 0x04000C9C RID: 3228
	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x38")]
	public bool UseObjectsOutColor;

	// Token: 0x04000C9D RID: 3229
	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x3C")]
	public AudioClip HoverSound;
}
