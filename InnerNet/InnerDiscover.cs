using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel.Udp;
using Il2CppDummyDll;

namespace InnerNet
{
	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	public class InnerDiscover : DestroyableSingleton<InnerDiscover>
	{
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06002679 RID: 9849 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600267A RID: 9850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public event Action<BroadcastPacket> OnPacketGet
		{
			[Token(Token = "0x6002679")]
			[Address(RVA = "0x3EFCF0", Offset = "0x3EF0F0", VA = "0x103EFCF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x600267A")]
			[Address(RVA = "0x3EFD70", Offset = "0x3EF170", VA = "0x103EFD70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x3EFB30", Offset = "0x3EEF30", VA = "0x103EFB30")]
		public void StartAsServer(string data)
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x3EF880", Offset = "0x3EEC80", VA = "0x103EF880")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE120", Offset = "0xDD520")]
		private IEnumerator RunServer()
		{
			return null;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267D")]
		[Address(RVA = "0x3EFC70", Offset = "0x3EF070", VA = "0x103EFC70")]
		public void StopServer()
		{
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x3EF8D0", Offset = "0x3EECD0", VA = "0x103EF8D0")]
		public void StartAsClient()
		{
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267F")]
		[Address(RVA = "0x3EF830", Offset = "0x3EEC30", VA = "0x103EF830")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE1C0", Offset = "0xDD5C0")]
		private IEnumerator RunClient()
		{
			return null;
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002680")]
		[Address(RVA = "0x3EFC40", Offset = "0x3EF040", VA = "0x103EFC40")]
		public void StopClient()
		{
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x3EF7C0", Offset = "0x3EEBC0", VA = "0x103EF7C0", Slot = "5")]
		public override void OnDestroy()
		{
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x3EFCA0", Offset = "0x3EF0A0", VA = "0x103EFCA0")]
		public InnerDiscover()
		{
		}

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x10")]
		private UdpBroadcastListener listener;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x14")]
		private UdpBroadcaster sender;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x18")]
		public int Port;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x1C")]
		public float Interval;

		// Token: 0x0200060C RID: 1548
		[Token(Token = "0x200060C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <RunServer>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002683 RID: 9859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002683")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <RunServer>d__8(int <>1__state)
			{
			}

			// Token: 0x06002684 RID: 9860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002684")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002685 RID: 9861 RVA: 0x0000B670 File Offset: 0x00009870
			[Token(Token = "0x6002685")]
			[Address(RVA = "0x5B3A00", Offset = "0x5B2E00", VA = "0x105B3A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000817")]
			private object Current
			{
				[Token(Token = "0x6002686")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x5B3AA0", Offset = "0x5B2EA0", VA = "0x105B3AA0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000818")]
			private object Current
			{
				[Token(Token = "0x6002688")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400267B RID: 9851
			[Token(Token = "0x400267B")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x0400267C RID: 9852
			[Token(Token = "0x400267C")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x0400267D RID: 9853
			[Token(Token = "0x400267D")]
			[FieldOffset(Offset = "0x10")]
			public InnerDiscover <>4__this;

			// Token: 0x0400267E RID: 9854
			[Token(Token = "0x400267E")]
			[FieldOffset(Offset = "0x14")]
			private float <timer>5__2;
		}

		// Token: 0x0200060D RID: 1549
		[Token(Token = "0x200060D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <RunClient>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002689")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <RunClient>d__11(int <>1__state)
			{
			}

			// Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600268A")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600268B RID: 9867 RVA: 0x0000B688 File Offset: 0x00009888
			[Token(Token = "0x600268B")]
			[Address(RVA = "0x5B3900", Offset = "0x5B2D00", VA = "0x105B3900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000819")]
			private object Current
			{
				[Token(Token = "0x600268C")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600268D")]
			[Address(RVA = "0x5B39D0", Offset = "0x5B2DD0", VA = "0x105B39D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700081A")]
			private object Current
			{
				[Token(Token = "0x600268E")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400267F RID: 9855
			[Token(Token = "0x400267F")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x04002680 RID: 9856
			[Token(Token = "0x4002680")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x04002681 RID: 9857
			[Token(Token = "0x4002681")]
			[FieldOffset(Offset = "0x10")]
			public InnerDiscover <>4__this;
		}
	}
}
