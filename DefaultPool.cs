using System;
using Il2CppDummyDll;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class DefaultPool : IObjectPool
{
	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x170000B0")]
	public override int InUse
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x170000B1")]
	public override int NotInUse
	{
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "7")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x170000B2")]
	public static bool InstanceExists
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x5C5770", Offset = "0x5C4B70", VA = "0x105C5770")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B3")]
	public static DefaultPool Instance
	{
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x5C57F0", Offset = "0x5C4BF0", VA = "0x105C57F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x5C5570", Offset = "0x5C4970", VA = "0x105C5570")]
	public void OnDestroy()
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004A7")]
	public override T Get<T>()
	{
		return null;
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x5C5670", Offset = "0x5C4A70", VA = "0x105C5670", Slot = "5")]
	public override void Reclaim(PoolableBehavior obj)
	{
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public DefaultPool()
	{
	}

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x0")]
	private static DefaultPool _instance;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[FieldOffset(Offset = "0x4")]
	private static object _lock;
}
