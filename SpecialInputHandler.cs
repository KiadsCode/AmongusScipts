using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003D0 RID: 976
[Token(Token = "0x20003D0")]
public class SpecialInputHandler : MonoBehaviour
{
	// Token: 0x170002DD RID: 733
	// (get) Token: 0x06001448 RID: 5192 RVA: 0x000068B8 File Offset: 0x00004AB8
	// (set) Token: 0x06001449 RID: 5193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DD")]
	public bool disableVirtualCursor
	{
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x4A4EB0", Offset = "0x4A42B0", VA = "0x104A4EB0")]
		set
		{
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x0600144A RID: 5194 RVA: 0x000068D0 File Offset: 0x00004AD0
	// (set) Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002DE")]
	public bool suppressInGamePlayerList
	{
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x4A4F50", Offset = "0x4A4350", VA = "0x104A4F50")]
		set
		{
		}
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144C")]
	[Address(RVA = "0x4A4E00", Offset = "0x4A4200", VA = "0x104A4E00")]
	private void OnEnable()
	{
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144D")]
	[Address(RVA = "0x4A4D50", Offset = "0x4A4150", VA = "0x104A4D50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600144E")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SpecialInputHandler()
	{
	}

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x0")]
	public static int count;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x4")]
	public static int disableVirtualCursorCount;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x8")]
	public static int suppressInGamePlayerListCount;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private bool _disableVirtualCursor;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0xD")]
	[SerializeField]
	private bool _suppressInGamePlayerList;
}
