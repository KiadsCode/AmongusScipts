using System;
using Hazel;
using Il2CppDummyDll;
using UnityEngine;

namespace InnerNet
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	public abstract class InnerNetObject : MonoBehaviour, IComparable<InnerNetObject>
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x17000834")]
		public virtual bool IsDirty
		{
			[Token(Token = "0x600274B")]
			[Address(RVA = "0x3F6A20", Offset = "0x3F5E20", VA = "0x103F6A20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x17000835")]
		public virtual bool Chunked
		{
			[Token(Token = "0x600274C")]
			[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x17000836")]
		public bool AmOwner
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0x3F69D0", Offset = "0x3F5DD0", VA = "0x103F69D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274E")]
		[Address(RVA = "0x3F6820", Offset = "0x3F5C20", VA = "0x103F6820")]
		public void Despawn()
		{
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274F")]
		[Address(RVA = "0x3F68D0", Offset = "0x3F5CD0", VA = "0x103F68D0", Slot = "7")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x06002750 RID: 10064
		[Token(Token = "0x6002750")]
		public abstract void HandleRpc(byte callId, MessageReader reader);

		// Token: 0x06002751 RID: 10065
		[Token(Token = "0x6002751")]
		public abstract bool Serialize(MessageWriter writer, bool initialState);

		// Token: 0x06002752 RID: 10066
		[Token(Token = "0x6002752")]
		public abstract void Deserialize(MessageReader reader, bool initialState);

		// Token: 0x06002753 RID: 10067 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x6002753")]
		[Address(RVA = "0x3F67F0", Offset = "0x3F5BF0", VA = "0x103F67F0", Slot = "4")]
		public int CompareTo(InnerNetObject other)
		{
			return 0;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x6002754")]
		[Address(RVA = "0x3F68B0", Offset = "0x3F5CB0", VA = "0x103F68B0")]
		protected bool IsDirtyBitSet(int idx)
		{
			return default(bool);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x3F67E0", Offset = "0x3F5BE0", VA = "0x103F67E0")]
		protected void ClearDirtyBits()
		{
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x3F69A0", Offset = "0x3F5DA0", VA = "0x103F69A0")]
		protected void UnsetDirtyBit(uint val)
		{
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x3F6990", Offset = "0x3F5D90", VA = "0x103F6990")]
		protected void SetDirtyBit(uint val)
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x3F69B0", Offset = "0x3F5DB0", VA = "0x103F69B0")]
		protected InnerNetObject()
		{
		}

		// Token: 0x04002715 RID: 10005
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0xC")]
		public uint SpawnId;

		// Token: 0x04002716 RID: 10006
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x10")]
		public uint NetId;

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x14")]
		protected uint DirtyBits;

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x18")]
		public SpawnFlags SpawnFlags;

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x19")]
		public SendOption sendMode;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x1C")]
		public int OwnerId;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x20")]
		protected bool DespawnOnDestroy;
	}
}
