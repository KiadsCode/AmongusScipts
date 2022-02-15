using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020000FE RID: 254
[Token(Token = "0x20000FE")]
public class SceneChanger : MonoBehaviour
{
	// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x58AB40", Offset = "0x589F40", VA = "0x1058AB40")]
	public void Click()
	{
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x58AA60", Offset = "0x589E60", VA = "0x1058AA60")]
	private void ChangeScene()
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000635")]
	[Address(RVA = "0x58AA10", Offset = "0x589E10", VA = "0x1058AA10")]
	public static void ChangeScene(string target)
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000636")]
	[Address(RVA = "0x58ACC0", Offset = "0x58A0C0", VA = "0x1058ACC0")]
	public void ExitGame()
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000637")]
	[Address(RVA = "0x58A9F0", Offset = "0x589DF0", VA = "0x1058A9F0")]
	public void BeginLoadingScene()
	{
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x58A8C0", Offset = "0x589CC0", VA = "0x1058A8C0")]
	public void BeginLoadingSceneAdditive()
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x58A8E0", Offset = "0x589CE0", VA = "0x1058A8E0")]
	private void BeginLoadingSceneInternal(LoadSceneMode mode)
	{
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x58A590", Offset = "0x589990", VA = "0x1058A590")]
	public void AllowFinishLoadingScene()
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00003A08 File Offset: 0x00001C08
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x58A800", Offset = "0x589C00", VA = "0x1058A800")]
	private bool AllowSceneChange()
	{
		return default(bool);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public SceneChanger()
	{
	}

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0xC")]
	public string TargetScene;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x10")]
	public bool disallowBasedOnSwitchParentalControls;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x11")]
	public bool disallowBasedOnAssetPackDownloads;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ConnectIcon;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x18")]
	public Button.ButtonClickedEvent BeforeSceneChange;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x1C")]
	private AsyncOperation loadOp;

	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public static class SceneManagerCallbacks
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		private static void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x364F60", Offset = "0x364360", VA = "0x10364F60")]
		private static void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public static void Init()
		{
		}
	}
}
