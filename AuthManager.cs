using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Hazel.Dtls;
using Il2CppDummyDll;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class AuthManager : DestroyableSingleton<AuthManager>
{
	// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x54E190", Offset = "0x54D590", VA = "0x1054E190")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE6250", Offset = "0xE5650")]
	public IEnumerator CoConnect(string targetIp, ushort targetPort)
	{
		return null;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x54E3A0", Offset = "0x54D7A0", VA = "0x1054E3A0")]
	public static DtlsUnityConnection CreateDtlsConnection(string targetIp, ushort targetPort)
	{
		return null;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x54E1F0", Offset = "0x54D5F0", VA = "0x1054E1F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE62A0", Offset = "0xE56A0")]
	public IEnumerator CoWaitForNonce(float timeout = 5f)
	{
		return null;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x54E4E0", Offset = "0x54D8E0", VA = "0x1054E4E0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x54E500", Offset = "0x54D900", VA = "0x1054E500", Slot = "5")]
	public override void OnDestroy()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x54E370", Offset = "0x54D770", VA = "0x1054E370")]
	private void Connection_Disconnected(object sender, DisconnectedEventArgs e)
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x54E250", Offset = "0x54D650", VA = "0x1054E250")]
	private void Connection_DataReceived(Hazel.DataReceivedEventArgs obj)
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x54E0A0", Offset = "0x54D4A0", VA = "0x1054E0A0")]
	private byte[] BuildData()
	{
		return null;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x54E550", Offset = "0x54D950", VA = "0x1054E550")]
	public AuthManager()
	{
	}

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x4000488")]
	private const string ServerCertification = "\r\n-----BEGIN CERTIFICATE-----\r\nMIIDbTCCAlWgAwIBAgIUf8xD1G/d5NK1MTjQAYGqd1AmBvcwDQYJKoZIhvcNAQEL\r\nBQAwRTELMAkGA1UEBhMCQVUxEzARBgNVBAgMClNvbWUtU3RhdGUxITAfBgNVBAoM\r\nGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAgFw0yMTAyMDIxNzE4MDFaGA8yMjk0\r\nMTExODE3MTgwMVowRTELMAkGA1UEBhMCQVUxEzARBgNVBAgMClNvbWUtU3RhdGUx\r\nITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDCCASIwDQYJKoZIhvcN\r\nAQEBBQADggEPADCCAQoCggEBAL7GFDbZdXwPYXeHWRi2GfAXkaLCgxuSADfa1pI2\r\nvJkvgMTK1miSt3jNSg/o6VsjSOSL461nYmGCF6Ho3fMhnefOhKaaWu0VxF0GR1bd\r\ne836YWzhWINQRwmoVD/Wx1NUjLRlTa8g/W3eE5NZFkWI70VOPRJpR9SqjNHwtPbm\r\nKi41PVgJIc3m/7cKOEMrMYNYoc6E9ehwLdJLQ5olJXnMoGjHo2d59hC8KW2V1dY9\r\nsacNPUjbFZRWeQ0eJ7kbn8m3a5EuF34VEC7DFcP4NCWWI7HO5/KYE+mUNn0qxgua\r\nr32qFnoaKZr9dXWRWJSm2XecBgqQmeF/90gdbohNNHGC/iMCAwEAAaNTMFEwHQYD\r\nVR0OBBYEFAJAdUS5AZE3U3SPQoG06Ahq3wBbMB8GA1UdIwQYMBaAFAJAdUS5AZE3\r\nU3SPQoG06Ahq3wBbMA8GA1UdEwEB/wQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEB\r\nALUoaAEuJf4kQ1bYVA2ax2QipkUM8PL9zoNiDjUw6ZlwMFi++XCQm8XDap45aaeZ\r\nMnXGBqIBWElezoH6BNSbdGwci/ZhxXHG/qdHm7zfCTNaLBe2+sZkGic1x6bZPFtK\r\nZUjGy7LmxsXOxqGMgPhAV4JbN1+LTmOkOutfHiXKe4Z1zu09mOo9sWfGCkbIyERX\r\nQQILBYSIkg3hU4R4xMOjvxcDrOZja6fSNyi2sgidTfe5OCKC2ovU7OmsQqzb7mFv\r\ne+7kpIUp6AZNc49n6GWtGeOoL7JUAqMOIO+R++YQN7/dgaGDPuu0PpmgI2gPLNW1\r\nZwHJ755zQQRX528xg9vfykY=\r\n-----END CERTIFICATE-----\r\n";

	// Token: 0x04000489 RID: 1161
	[Token(Token = "0x4000489")]
	private const byte AuthTagNonceMessage = 1;

	// Token: 0x0400048A RID: 1162
	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x10")]
	public DtlsUnityConnection connection;

	// Token: 0x0400048B RID: 1163
	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x14")]
	public uint? LastNonceReceived;

	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoConnect>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoConnect>d__4(int <>1__state)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x3C3B80", Offset = "0x3C2F80", VA = "0x103C3B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		private object Current
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x3C3D80", Offset = "0x3C3180", VA = "0x103C3D80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		private object Current
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x10")]
		public AuthManager <>4__this;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x14")]
		public string targetIp;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x18")]
		public ushort targetPort;
	}

	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoWaitForNonce>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoWaitForNonce>d__6(int <>1__state)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3C7090", Offset = "0x3C6490", VA = "0x103C7090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		private object Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3C7140", Offset = "0x3C6540", VA = "0x103C7140", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		private object Current
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x10")]
		public AuthManager <>4__this;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x14")]
		public float timeout;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x18")]
		private float <timer>5__2;
	}
}
