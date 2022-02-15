using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class AccountSignInList : MonoBehaviour
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x53DA00", Offset = "0x53CE00", VA = "0x1053DA00")]
	public void Start()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	public void LogInWith(AccountButton selected)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x515CE0", Offset = "0x5150E0", VA = "0x10515CE0")]
	public AccountSignInList()
	{
	}

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xC")]
	public AccountButton ButtonPrefab;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x10")]
	public Scroller ButtonParent;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x14")]
	public float ButtonStart;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x18")]
	public float ButtonHeight;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x1C")]
	private AccountButton[] AllButtons;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x20")]
	public AccountsMenu parent;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x24")]
	public ControllerNavMenu controllerNavParent;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	public bool createAccount;

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3CACD0", Offset = "0x3CA0D0", VA = "0x103CACD0")]
		internal void <Start>b__0()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x8")]
		public AccountButton button;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC")]
		public AccountSignInList <>4__this;
	}
}
