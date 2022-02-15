using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EF RID: 751
[Token(Token = "0x20002EF")]
public class MatchMaker : DestroyableSingleton<MatchMaker>
{
	// Token: 0x0600108C RID: 4236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x76BCF0", Offset = "0x76B0F0", VA = "0x1076BCF0")]
	public void Start()
	{
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x76BB10", Offset = "0x76AF10", VA = "0x1076BB10")]
	public bool Connecting(MonoBehaviour button)
	{
		return default(bool);
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x76BC30", Offset = "0x76B030", VA = "0x1076BC30")]
	public void NotConnecting()
	{
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x76BE00", Offset = "0x76B200", VA = "0x1076BE00")]
	public MatchMaker()
	{
	}

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x10")]
	public TextBoxTMP GameIdText;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x14")]
	private MonoBehaviour Connecter;
}
