using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.Xbox
{
	// Token: 0x02000672 RID: 1650
	[Token(Token = "0x2000672")]
	public class XboxSdk : MonoBehaviour
	{
		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700086A")]
		public static XboxSdk Helpers
		{
			[Token(Token = "0x600281F")]
			[Address(RVA = "0x3CE7F0", Offset = "0x3CDBF0", VA = "0x103CE7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06002820 RID: 10272 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002821 RID: 10273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event XboxSdk.OnGameSaveLoadedHandler OnGameSaveLoaded
		{
			[Token(Token = "0x6002820")]
			[Address(RVA = "0x3CE770", Offset = "0x3CDB70", VA = "0x103CE770")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x6002821")]
			[Address(RVA = "0x3CE970", Offset = "0x3CDD70", VA = "0x103CE970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002823 RID: 10275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public event XboxSdk.OnErrorHandler OnError
		{
			[Token(Token = "0x6002822")]
			[Address(RVA = "0x3CE6F0", Offset = "0x3CDAF0", VA = "0x103CE6F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x6002823")]
			[Address(RVA = "0x3CE8F0", Offset = "0x3CDCF0", VA = "0x103CE8F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x3CE490", Offset = "0x3CD890", VA = "0x103CE490")]
		private void Start()
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x3CE600", Offset = "0x3CDA00", VA = "0x103CE600")]
		private void _Initialize()
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void SignIn()
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void Save(byte[] data)
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void LoadSaveData()
		{
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void UnlockAchievement(string achievementId)
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		private void Update()
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x3CE4A0", Offset = "0x3CD8A0", VA = "0x103CE4A0")]
		protected static bool Succeeded(int hresult, string operationFriendlyName)
		{
			return default(bool);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x3CE680", Offset = "0x3CDA80", VA = "0x103CE680")]
		private static void _LogError(string message)
		{
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x3CE6D0", Offset = "0x3CDAD0", VA = "0x103CE6D0")]
		public XboxSdk()
		{
		}

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0xC")]
		public Text dlcOutputTextBox;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "HeaderAttribute", RVA = "0xDEEA0", Offset = "0xDE2A0")]
		public string scid;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x14")]
		public Text gamertagLabel;

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x18")]
		public bool signInOnStart;

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		[FieldOffset(Offset = "0x0")]
		private static XboxSdk _xboxHelpers;

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x4")]
		private static bool _initialized;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		private const string _GAME_SAVE_CONTAINER_NAME = "x_game_save_default_container";

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		private const string _GAME_SAVE_BLOB_NAME = "x_game_save_default_blob";

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x0600282F RID: 10287
		[Token(Token = "0x2000673")]
		public delegate void OnGameSaveLoadedHandler(object sender, GameSaveLoadedArgs e);

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x06002833 RID: 10291
		[Token(Token = "0x2000674")]
		public delegate void OnErrorHandler(object sender, ErrorEventArgs e);
	}
}
