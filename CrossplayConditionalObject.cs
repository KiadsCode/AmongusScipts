using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200037E RID: 894
[Token(Token = "0x200037E")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xDD960", Offset = "0xDCD60")]
public class CrossplayConditionalObject : MonoBehaviour
{
	// Token: 0x06001345 RID: 4933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x5B9F10", Offset = "0x5B9310", VA = "0x105B9F10")]
	private void Awake()
	{
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x5BA060", Offset = "0x5B9460", VA = "0x105BA060")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001347")]
	[Address(RVA = "0x5BA100", Offset = "0x5B9500", VA = "0x105BA100")]
	private void UpdateEnabledState()
	{
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001348")]
	[Address(RVA = "0x3E8790", Offset = "0x3E7B90", VA = "0x103E8790")]
	public CrossplayConditionalObject()
	{
	}

	// Token: 0x04001387 RID: 4999
	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0xC")]
	public bool onlyOnPlayStation;

	// Token: 0x04001388 RID: 5000
	[Token(Token = "0x4001388")]
	[FieldOffset(Offset = "0x10")]
	public CrossplayConditionalObject.CrossplayConditionalType crossplayConditionalType;

	// Token: 0x04001389 RID: 5001
	[Token(Token = "0x4001389")]
	[FieldOffset(Offset = "0x0")]
	public static Action OnCrossplayChanged;

	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public enum CrossplayConditionalType
	{
		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		ShowIfCrossplayEnabled,
		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		HideIfCrossplayEnabled
	}
}
