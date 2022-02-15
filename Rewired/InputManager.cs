using System;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE1820", Offset = "0xE0C20")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0xE1820", Offset = "0xE0C20")]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x3FA800", Offset = "0x3F9C00", VA = "0x103FA800", Slot = "4")]
		protected override void OnInitialized()
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x3FA7F0", Offset = "0x3F9BF0", VA = "0x103FA7F0", Slot = "5")]
		protected override void OnDeinitialized()
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x3FA730", Offset = "0x3F9B30", VA = "0x103FA730", Slot = "6")]
		protected override void DetectPlatform()
		{
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		protected override void CheckRecompile()
		{
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x3FA7B0", Offset = "0x3F9BB0", VA = "0x103FA7B0", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			return null;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x3FA6A0", Offset = "0x3F9AA0", VA = "0x103FA6A0")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return default(bool);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x3FA800", Offset = "0x3F9C00", VA = "0x103FA800")]
		private void SubscribeEvents()
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x3FA8C0", Offset = "0x3F9CC0", VA = "0x103FA8C0")]
		private void UnsubscribeEvents()
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x3FA8A0", Offset = "0x3F9CA0", VA = "0x103FA8A0")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x3FA950", Offset = "0x3F9D50", VA = "0x103FA950")]
		public InputManager()
		{
		}

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x38")]
		private bool ignoreRecompile;
	}
}
