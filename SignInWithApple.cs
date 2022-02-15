using System;
using AppleAuth;
using AppleAuth.Enums;
using AppleAuth.Interfaces;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
public class SignInWithApple : MonoBehaviour
{
	// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x49A3C0", Offset = "0x4997C0", VA = "0x1049A3C0")]
	public void Initialize(Action onRevoke)
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x49A260", Offset = "0x499660", VA = "0x1049A260")]
	public void GetCredentialState(string userId, Action<CredentialState> onSuccess, Action onFail)
	{
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x49A520", Offset = "0x499920", VA = "0x1049A520")]
	public void LoginWithAppleId(Action<ICredential> onSuccess, Action<IAppleError> onFail)
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x49A6D0", Offset = "0x499AD0", VA = "0x1049A6D0")]
	public void QuickLogin(Action<ICredential> onSuccess, Action<IAppleError> onFail)
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x49A880", Offset = "0x499C80", VA = "0x1049A880")]
	private void Update()
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SignInWithApple()
	{
	}

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0xC")]
	private IAppleAuthManager appleAuthManager;

	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass1_0
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass1_0()
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x3710C0", Offset = "0x3704C0", VA = "0x103710C0")]
		internal void <Initialize>b__0(string result)
		{
		}

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x8")]
		public Action onRevoke;
	}

	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3711F0", Offset = "0x3705F0", VA = "0x103711F0")]
		internal void <GetCredentialState>b__0(CredentialState state)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x3712B0", Offset = "0x3706B0", VA = "0x103712B0")]
		internal void <GetCredentialState>b__1(IAppleError error)
		{
		}

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x8")]
		public Action<CredentialState> onSuccess;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xC")]
		public Action onFail;
	}

	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x3713F0", Offset = "0x3707F0", VA = "0x103713F0")]
		internal void <LoginWithAppleId>b__0(ICredential credential)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x371440", Offset = "0x370840", VA = "0x10371440")]
		internal void <LoginWithAppleId>b__1(IAppleError error)
		{
		}

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x8")]
		public Action<ICredential> onSuccess;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xC")]
		public Action<IAppleError> onFail;
	}

	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x371500", Offset = "0x370900", VA = "0x10371500")]
		internal void <QuickLogin>b__0(ICredential credential)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x371590", Offset = "0x370990", VA = "0x10371590")]
		internal void <QuickLogin>b__1(IAppleError error)
		{
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x8")]
		public Action<ICredential> onSuccess;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xC")]
		public Action<IAppleError> onFail;
	}
}
