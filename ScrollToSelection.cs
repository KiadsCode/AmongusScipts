using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CD RID: 973
[Token(Token = "0x20003CD")]
[Attribute(Name = "RequireComponent", RVA = "0xDE8B0", Offset = "0xDDCB0")]
public class ScrollToSelection : MonoBehaviour
{
	// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143C")]
	[Address(RVA = "0x58BE80", Offset = "0x58B280", VA = "0x1058BE80")]
	private void Awake()
	{
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143D")]
	[Address(RVA = "0x58C430", Offset = "0x58B830", VA = "0x1058C430")]
	private void OnEnable()
	{
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143E")]
	[Address(RVA = "0x58C9C0", Offset = "0x58BDC0", VA = "0x1058C9C0")]
	private void Start()
	{
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143F")]
	[Address(RVA = "0x58BEC0", Offset = "0x58B2C0", VA = "0x1058BEC0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001440")]
	[Address(RVA = "0x58C5A0", Offset = "0x58B9A0", VA = "0x1058C5A0")]
	private void ScrollToRect(Transform targetRectTransform)
	{
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ScrollToSelection()
	{
	}

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x40014E4")]
	[FieldOffset(Offset = "0xC")]
	private Scroller scrollRect;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x40014E5")]
	[FieldOffset(Offset = "0x10")]
	private UIScrollbarHelper[] childElements;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x40014E6")]
	[FieldOffset(Offset = "0x14")]
	public Vector2 wantedValue;

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x40014E7")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject lastSelectedObject;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x20")]
	public bool cursorEnabled;

	// Token: 0x040014E9 RID: 5353
	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x21")]
	public bool killScroll;

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x22")]
	public bool onePage;
}
