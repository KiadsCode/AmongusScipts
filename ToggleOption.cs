using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000502 RID: 1282
[Token(Token = "0x2000502")]
public class ToggleOption : OptionBehaviour
{
	// Token: 0x06001B51 RID: 6993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x4AEAB0", Offset = "0x4ADEB0", VA = "0x104AEAB0")]
	public void OnEnable()
	{
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x4AEA30", Offset = "0x4ADE30", VA = "0x104AEA30")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x4AED20", Offset = "0x4AE120", VA = "0x104AED20")]
	public void Toggle()
	{
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x00008B08 File Offset: 0x00006D08
	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x4AEA80", Offset = "0x4ADE80", VA = "0x104AEA80", Slot = "6")]
	public override bool GetBool()
	{
		return default(bool);
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public ToggleOption()
	{
	}

	// Token: 0x04001B7B RID: 7035
	[Token(Token = "0x4001B7B")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro TitleText;

	// Token: 0x04001B7C RID: 7036
	[Token(Token = "0x4001B7C")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer CheckMark;

	// Token: 0x04001B7D RID: 7037
	[Token(Token = "0x4001B7D")]
	[FieldOffset(Offset = "0x1C")]
	private bool oldValue;
}
