using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CF RID: 975
[Token(Token = "0x20003CF")]
public class SimpleSoundPlayer : MonoBehaviour
{
	// Token: 0x06001444 RID: 5188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x49DCA0", Offset = "0x49D0A0", VA = "0x1049DCA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x49DCE0", Offset = "0x49D0E0", VA = "0x1049DCE0")]
	public void PlaySound()
	{
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x49DD10", Offset = "0x49D110", VA = "0x1049DD10")]
	public void PlaySpecificSound(int index)
	{
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SimpleSoundPlayer()
	{
	}

	// Token: 0x040014EC RID: 5356
	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip[] clips;

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x10")]
	private AudioSource soundSource;
}
