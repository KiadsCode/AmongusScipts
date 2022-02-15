using System;
using System.Text;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020004DA RID: 1242
[Token(Token = "0x20004DA")]
public class StatsPopup : MonoBehaviour
{
	// Token: 0x06001A89 RID: 6793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x759710", Offset = "0x758B10", VA = "0x10759710")]
	private void OnDisable()
	{
	}

	// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x759780", Offset = "0x758B80", VA = "0x10759780")]
	private void OnEnable()
	{
	}

	// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x759670", Offset = "0x758A70", VA = "0x10759670")]
	private static void AppendStat(StringBuilder str, StringBuilder strNums, StringNames statName, object stat)
	{
	}

	// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A8C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public StatsPopup()
	{
	}

	// Token: 0x04001A9D RID: 6813
	[Token(Token = "0x4001A9D")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro StatsText;

	// Token: 0x04001A9E RID: 6814
	[Token(Token = "0x4001A9E")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro NumbersText;

	// Token: 0x04001A9F RID: 6815
	[Token(Token = "0x4001A9F")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;
}
