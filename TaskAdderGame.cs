using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000511 RID: 1297
[Token(Token = "0x2000511")]
public class TaskAdderGame : Minigame
{
	// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x7682A0", Offset = "0x7676A0", VA = "0x107682A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x768240", Offset = "0x767640", VA = "0x10768240")]
	private void OnDisable()
	{
	}

	// Token: 0x06001B8F RID: 7055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x767EE0", Offset = "0x7672E0", VA = "0x10767EE0", Slot = "4")]
	public override void Begin(PlayerTask t)
	{
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x768320", Offset = "0x767720", VA = "0x10768320")]
	private void PopulateRoot(TaskFolder rootFolder, Dictionary<SystemTypes, TaskFolder> folders, NormalPlayerTask[] taskList)
	{
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x768140", Offset = "0x767540", VA = "0x10768140")]
	public void GoToRoot()
	{
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x768190", Offset = "0x767590", VA = "0x10768190")]
	public void GoUpOne()
	{
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x7685C0", Offset = "0x7679C0", VA = "0x107685C0")]
	public void ShowFolder(TaskFolder taskFolder)
	{
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x767D20", Offset = "0x767120", VA = "0x10767D20")]
	private void AddFileAsChild(TaskFolder taskFolder, TaskAddButton item, ref float xCursor, ref float yCursor, ref float maxHeight)
	{
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x769430", Offset = "0x768830", VA = "0x10769430")]
	public TaskAdderGame()
	{
	}

	// Token: 0x04001F54 RID: 8020
	[Token(Token = "0x4001F54")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro PathText;

	// Token: 0x04001F55 RID: 8021
	[Token(Token = "0x4001F55")]
	[FieldOffset(Offset = "0x34")]
	public TaskFolder RootFolderPrefab;

	// Token: 0x04001F56 RID: 8022
	[Token(Token = "0x4001F56")]
	[FieldOffset(Offset = "0x38")]
	public TaskAddButton TaskPrefab;

	// Token: 0x04001F57 RID: 8023
	[Token(Token = "0x4001F57")]
	[FieldOffset(Offset = "0x3C")]
	public Transform TaskParent;

	// Token: 0x04001F58 RID: 8024
	[Token(Token = "0x4001F58")]
	[FieldOffset(Offset = "0x40")]
	public List<TaskFolder> Hierarchy;

	// Token: 0x04001F59 RID: 8025
	[Token(Token = "0x4001F59")]
	[FieldOffset(Offset = "0x44")]
	public List<Transform> ActiveItems;

	// Token: 0x04001F5A RID: 8026
	[Token(Token = "0x4001F5A")]
	[FieldOffset(Offset = "0x48")]
	public TaskAddButton RoleButton;

	// Token: 0x04001F5B RID: 8027
	[Token(Token = "0x4001F5B")]
	[FieldOffset(Offset = "0x4C")]
	public float folderWidth;

	// Token: 0x04001F5C RID: 8028
	[Token(Token = "0x4001F5C")]
	[FieldOffset(Offset = "0x50")]
	public float fileWidth;

	// Token: 0x04001F5D RID: 8029
	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x54")]
	public float lineWidth;

	// Token: 0x04001F5E RID: 8030
	[Token(Token = "0x4001F5E")]
	[FieldOffset(Offset = "0x58")]
	private TaskFolder Root;

	// Token: 0x04001F5F RID: 8031
	[Token(Token = "0x4001F5F")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04001F60 RID: 8032
	[Token(Token = "0x4001F60")]
	[FieldOffset(Offset = "0x60")]
	public UiElement FolderBackButton;

	// Token: 0x04001F61 RID: 8033
	[Token(Token = "0x4001F61")]
	[FieldOffset(Offset = "0x64")]
	public List<UiElement> ControllerSelectable;

	// Token: 0x04001F62 RID: 8034
	[Token(Token = "0x4001F62")]
	[FieldOffset(Offset = "0x68")]
	private string restorePreviousSelectionByFolderName;

	// Token: 0x04001F63 RID: 8035
	[Token(Token = "0x4001F63")]
	[FieldOffset(Offset = "0x6C")]
	public UiElement restorePreviousSelectionFound;

	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001B97 RID: 7063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x3700E0", Offset = "0x36F4E0", VA = "0x103700E0")]
		internal string <Begin>b__18_0(TaskFolder f)
		{
			return null;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x370980", Offset = "0x36FD80", VA = "0x10370980")]
		internal TaskTypes <ShowFolder>b__22_0(PlayerTask t)
		{
			return TaskTypes.SubmitScan;
		}

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TaskAdderGame.<>c <>9;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x4")]
		public static Func<TaskFolder, string> <>9__18_0;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlayerTask, TaskTypes> <>9__22_0;
	}
}
