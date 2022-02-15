using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using Il2CppDummyDll;
using ImaginationOverflow.UniversalDeepLinking;
using UnityEngine;

namespace Twitch
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class TwitchManager : DestroyableSingleton<TwitchManager>
	{
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040F")]
		public string Token
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x287920", Offset = "0x286D20", VA = "0x10287920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			set
			{
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x4B4400", Offset = "0x4B3800", VA = "0x104B4400")]
		private void Start()
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x4B3DD0", Offset = "0x4B31D0", VA = "0x104B3DD0")]
		private void Instance_LinkActivated(LinkActivation s)
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x4B42C0", Offset = "0x4B36C0", VA = "0x104B42C0", Slot = "5")]
		public override void OnDestroy()
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x4B4240", Offset = "0x4B3640", VA = "0x104B4240")]
		public void LaunchImplicitAuth(Transform target)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x4B43B0", Offset = "0x4B37B0", VA = "0x104B43B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE1690", Offset = "0xE0A90")]
		private IEnumerator ShakeGlitch(Transform target)
		{
			return null;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x4B41C0", Offset = "0x4B35C0", VA = "0x104B41C0")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE16E0", Offset = "0xE0AE0")]
		private void LaunchImplicitAuthAsync()
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x4B3D10", Offset = "0x4B3110", VA = "0x104B3D10")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE1730", Offset = "0xE0B30")]
		private Task FetchNewToken()
		{
			return null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x4B3C30", Offset = "0x4B3030", VA = "0x104B3C30")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xE1780", Offset = "0xE0B80")]
		public Task<HttpStatusCode> FetchEntitlements(string token)
		{
			return null;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x4B45C0", Offset = "0x4B39C0", VA = "0x104B45C0")]
		public TwitchManager()
		{
		}

		// Token: 0x04001FD0 RID: 8144
		[Token(Token = "0x4001FD0")]
		private const string RedirectUri = "AmongUs://callback";

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		private const string ClientId = "yioca4gf70qx0v05qodt6tnwlkerr3";

		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] Scopes;

		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		[FieldOffset(Offset = "0x10")]
		private string verify;

		// Token: 0x04001FD4 RID: 8148
		[Token(Token = "0x4001FD4")]
		[FieldOffset(Offset = "0x14")]
		public GenericPopup TwitchPopup;

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[FieldOffset(Offset = "0x18")]
		private TwitchManager.UpdateState running;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		[FieldOffset(Offset = "0x1C")]
		private List<string> newItems;

		// Token: 0x04001FD7 RID: 8151
		[Token(Token = "0x4001FD7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private string <Token>k__BackingField;

		// Token: 0x02000530 RID: 1328
		[Token(Token = "0x2000530")]
		private enum UpdateState
		{
			// Token: 0x04001FD9 RID: 8153
			[Token(Token = "0x4001FD9")]
			NotStarted,
			// Token: 0x04001FDA RID: 8154
			[Token(Token = "0x4001FDA")]
			Started,
			// Token: 0x04001FDB RID: 8155
			[Token(Token = "0x4001FDB")]
			Success,
			// Token: 0x04001FDC RID: 8156
			[Token(Token = "0x4001FDC")]
			Failure
		}

		// Token: 0x02000531 RID: 1329
		[Token(Token = "0x2000531")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001C24 RID: 7204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06001C25 RID: 7205 RVA: 0x00008CE8 File Offset: 0x00006EE8
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x3701A0", Offset = "0x36F5A0", VA = "0x103701A0")]
			internal bool <Instance_LinkActivated>b__13_0(string a)
			{
				return default(bool);
			}

			// Token: 0x06001C26 RID: 7206 RVA: 0x00008D00 File Offset: 0x00006F00
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x3701E0", Offset = "0x36F5E0", VA = "0x103701E0")]
			internal bool <Instance_LinkActivated>b__13_1(string a)
			{
				return default(bool);
			}

			// Token: 0x04001FDD RID: 8157
			[Token(Token = "0x4001FDD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TwitchManager.<>c <>9;

			// Token: 0x04001FDE RID: 8158
			[Token(Token = "0x4001FDE")]
			[FieldOffset(Offset = "0x4")]
			public static Func<string, bool> <>9__13_0;

			// Token: 0x04001FDF RID: 8159
			[Token(Token = "0x4001FDF")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__13_1;
		}

		// Token: 0x02000532 RID: 1330
		[Token(Token = "0x2000532")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <ShakeGlitch>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06001C27 RID: 7207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <ShakeGlitch>d__16(int <>1__state)
			{
			}

			// Token: 0x06001C28 RID: 7208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06001C29 RID: 7209 RVA: 0x00008D18 File Offset: 0x00006F18
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x1301850", Offset = "0x1300C50", VA = "0x11301850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000410")]
			private object Current
			{
				[Token(Token = "0x6001C2A")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x1301A20", Offset = "0x1300E20", VA = "0x11301A20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000411")]
			private object Current
			{
				[Token(Token = "0x6001C2C")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04001FE0 RID: 8160
			[Token(Token = "0x4001FE0")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04001FE1 RID: 8161
			[Token(Token = "0x4001FE1")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04001FE2 RID: 8162
			[Token(Token = "0x4001FE2")]
			[FieldOffset(Offset = "0x10")]
			public TwitchManager <>4__this;
		}
	}
}
