using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000390 RID: 912
[Token(Token = "0x2000390")]
[Attribute(Name = "RequireComponent", RVA = "0xDE030", Offset = "0xDD430")]
public class ManualScrollHelper : MonoBehaviour
{
	// Token: 0x0600137B RID: 4987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x6E45C0", Offset = "0x6E39C0", VA = "0x106E45C0")]
	private void Start()
	{
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137C")]
	[Address(RVA = "0x6E4650", Offset = "0x6E3A50", VA = "0x106E4650")]
	private void Update()
	{
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137D")]
	[Address(RVA = "0x6E47A0", Offset = "0x6E3BA0", VA = "0x106E47A0")]
	public ManualScrollHelper()
	{
	}

	// Token: 0x040013B8 RID: 5048
	[Token(Token = "0x40013B8")]
	[FieldOffset(Offset = "0xC")]
	public bool doVertical;

	// Token: 0x040013B9 RID: 5049
	[Token(Token = "0x40013B9")]
	[FieldOffset(Offset = "0x10")]
	public RewiredConstsEnum.Action verticalAxis;

	// Token: 0x040013BA RID: 5050
	[Token(Token = "0x40013BA")]
	[FieldOffset(Offset = "0x14")]
	public bool doHorizontal;

	// Token: 0x040013BB RID: 5051
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x18")]
	public RewiredConstsEnum.Action horizontalAxis;

	// Token: 0x040013BC RID: 5052
	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x1C")]
	public float scrollSpeed;

	// Token: 0x040013BD RID: 5053
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x20")]
	private Scroller scroller;
}
