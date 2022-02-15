using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000513 RID: 1299
[Token(Token = "0x2000513")]
public class TaskFolder : MonoBehaviour
{
	// Token: 0x06001B9A RID: 7066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x7694E0", Offset = "0x7688E0", VA = "0x107694E0")]
	private void Awake()
	{
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x769570", Offset = "0x768970", VA = "0x10769570")]
	public void Start()
	{
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B9C")]
	[Address(RVA = "0x769520", Offset = "0x768920", VA = "0x10769520")]
	public void OnClick()
	{
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B9D")]
	[Address(RVA = "0x769540", Offset = "0x768940", VA = "0x10769540")]
	internal List<TaskFolder> OrderBy()
	{
		return null;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x7695A0", Offset = "0x7689A0", VA = "0x107695A0")]
	public TaskFolder()
	{
	}

	// Token: 0x04001F67 RID: 8039
	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0xC")]
	public string FolderName;

	// Token: 0x04001F68 RID: 8040
	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro Text;

	// Token: 0x04001F69 RID: 8041
	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0x14")]
	public TaskAdderGame Parent;

	// Token: 0x04001F6A RID: 8042
	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x18")]
	public List<TaskFolder> SubFolders;

	// Token: 0x04001F6B RID: 8043
	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0x1C")]
	public List<PlayerTask> Children;

	// Token: 0x04001F6C RID: 8044
	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public PassiveButton Button;
}
