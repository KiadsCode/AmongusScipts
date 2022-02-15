using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class HideObjectIfMinor : MonoBehaviour
{
	// Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x3E84A0", Offset = "0x3E78A0", VA = "0x103E84A0")]
	private void Awake()
	{
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x3E85B0", Offset = "0x3E79B0", VA = "0x103E85B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x3E8660", Offset = "0x3E7A60", VA = "0x103E8660")]
	private void Start()
	{
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x3E8660", Offset = "0x3E7A60", VA = "0x103E8660")]
	private void OnEnable()
	{
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x3E8550", Offset = "0x3E7950", VA = "0x103E8550")]
	private bool IsGuestAndHide()
	{
		return default(bool);
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x3E8670", Offset = "0x3E7A70", VA = "0x103E8670")]
	public void UpdateVisual()
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
	public HideObjectIfMinor()
	{
	}

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0xC")]
	public bool hideIfGuest;
}
