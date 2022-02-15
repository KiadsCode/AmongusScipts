using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000256 RID: 598
[Token(Token = "0x2000256")]
public class TextBoxTMP : MonoBehaviour, IFocusHolder
{
	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x170001FF")]
	public float TextHeight
	{
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x4AB580", Offset = "0x4AA980", VA = "0x104AB580")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x4AB060", Offset = "0x4AA460", VA = "0x104AB060")]
	public void Start()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x4AAB80", Offset = "0x4A9F80", VA = "0x104AAB80")]
	public void OnDestroy()
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x4AA5E0", Offset = "0x4A99E0", VA = "0x104AA5E0")]
	public void Clear()
	{
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x4AB120", Offset = "0x4AA520", VA = "0x104AB120")]
	public void Update()
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x4AA620", Offset = "0x4A9A20", VA = "0x104AA620", Slot = "4")]
	public void GiveFocus()
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x4AA980", Offset = "0x4A9D80", VA = "0x104AA980", Slot = "5")]
	public void LoseFocus()
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x4AA4A0", Offset = "0x4A98A0", VA = "0x104AA4A0", Slot = "6")]
	public bool CheckCollision(Vector2 pt)
	{
		return default(bool);
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x4AAC10", Offset = "0x4AA010", VA = "0x104AAC10")]
	public void SetText(string input, string inputCompo = "")
	{
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x4AA7F0", Offset = "0x4A9BF0", VA = "0x104AA7F0")]
	public bool IsCharAllowed(char i)
	{
		return default(bool);
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x4AA390", Offset = "0x4A9790", VA = "0x104AA390")]
	public void AddText(string text)
	{
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x4AA440", Offset = "0x4A9840", VA = "0x104AA440")]
	public void Backspace()
	{
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x4AA520", Offset = "0x4A9920", VA = "0x104AA520")]
	public void ClearLastWord()
	{
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x4AB510", Offset = "0x4AA910", VA = "0x104AB510")]
	public TextBoxTMP()
	{
	}

	// Token: 0x04000D35 RID: 3381
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x0")]
	public static readonly HashSet<char> SymbolChars;

	// Token: 0x04000D36 RID: 3382
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x4")]
	public static readonly HashSet<char> EmailChars;

	// Token: 0x04000D37 RID: 3383
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0xC")]
	public bool allowAllCharacters;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x10")]
	public string text;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x14")]
	private string compoText;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x18")]
	public int characterLimit;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public TextMeshPro outputText;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer Background;

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x24")]
	public MeshRenderer Pipe;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x28")]
	private float pipeBlinkTimer;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x2C")]
	public bool ClearOnFocus;

	// Token: 0x04000D40 RID: 3392
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x2D")]
	public bool ForceUppercase;

	// Token: 0x04000D41 RID: 3393
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x30")]
	public Button.ButtonClickedEvent OnEnter;

	// Token: 0x04000D42 RID: 3394
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x34")]
	public Button.ButtonClickedEvent OnChange;

	// Token: 0x04000D43 RID: 3395
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x38")]
	public Button.ButtonClickedEvent OnFocusLost;

	// Token: 0x04000D44 RID: 3396
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x3C")]
	private TouchScreenKeyboard keyboard;

	// Token: 0x04000D45 RID: 3397
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x40")]
	public bool AllowSymbols;

	// Token: 0x04000D46 RID: 3398
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x0")]
	public bool AllowEmail;

	// Token: 0x04000D47 RID: 3399
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x0")]
	public bool IpMode;

	// Token: 0x04000D48 RID: 3400
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x0")]
	public bool AllowPaste;

	// Token: 0x04000D49 RID: 3401
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x0")]
	private Collider2D[] colliders;

	// Token: 0x04000D4A RID: 3402
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x48")]
	private bool hasFocus;

	// Token: 0x04000D4B RID: 3403
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x4C")]
	private StringBuilder tempTxt;

	// Token: 0x04000D4C RID: 3404
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x50")]
	public SpriteRenderer sendButtonGlyph;

	// Token: 0x04000D4D RID: 3405
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x54")]
	public SpriteRenderer quickChatGlyph;
}
