using System;
using System.Collections.Generic;
using Hazel;
using Hazel.Udp;
using Il2CppDummyDll;
using UnityEngine;

namespace InnerNet
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	public class InnerNetServer : DestroyableSingleton<InnerNetServer>
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x3F87C0", Offset = "0x3F7BC0", VA = "0x103F87C0", Slot = "5")]
		public override void OnDestroy()
		{
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x3F9060", Offset = "0x3F8460", VA = "0x103F9060")]
		public void StartAsServer()
		{
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x3F8E80", Offset = "0x3F8280", VA = "0x103F8E80")]
		public void StartAsLocalServer()
		{
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x3F7040", Offset = "0x3F6440", VA = "0x103F7040")]
		private void DebugString(string obj)
		{
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x3F92C0", Offset = "0x3F86C0", VA = "0x103F92C0")]
		public void StopServer()
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x3F8000", Offset = "0x3F7400", VA = "0x103F8000")]
		public static bool IsCompatibleVersion(int version)
		{
			return default(bool);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x3F8800", Offset = "0x3F7C00", VA = "0x103F8800")]
		private void OnServerConnect(NewConnectionEventArgs evt)
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x3F8BF0", Offset = "0x3F7FF0", VA = "0x103F8BF0")]
		private static void SendIncorrectVersion(Connection connection)
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x3F6ED0", Offset = "0x3F62D0", VA = "0x103F6ED0")]
		private void Connection_DataRecievedRaw(byte[] data, int length)
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x3F8630", Offset = "0x3F7A30", VA = "0x103F8630")]
		private void OnDataReceived(InnerNetServer.Player client, DataReceivedEventArgs evt)
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x3F7270", Offset = "0x3F6670", VA = "0x103F7270")]
		private void HandleMessage(InnerNetServer.Player client, MessageReader reader, SendOption sendOption)
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x3F8380", Offset = "0x3F7780", VA = "0x103F8380")]
		private void KickPlayer(int targetId, bool ban)
		{
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x3F8070", Offset = "0x3F7470", VA = "0x103F8070")]
		protected void JoinGame(InnerNetServer.Player client)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x3F7B40", Offset = "0x3F6F40", VA = "0x103F7B40")]
		private void HandleRejoin(InnerNetServer.Player client)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x3F7720", Offset = "0x3F6B20", VA = "0x103F7720")]
		private void HandleNewGameJoin(InnerNetServer.Player client)
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x3F70A0", Offset = "0x3F64A0", VA = "0x103F70A0")]
		private void EndGame(MessageReader message, InnerNetServer.Player source)
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x3F9230", Offset = "0x3F8630", VA = "0x103F9230")]
		private void StartGame(MessageReader message, InnerNetServer.Player source)
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x3F6CB0", Offset = "0x3F60B0", VA = "0x103F6CB0")]
		private void ClientDisconnect(InnerNetServer.Player client)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x3F8C90", Offset = "0x3F8090", VA = "0x103F8C90")]
		protected void SendTo(MessageWriter msg, int targetId)
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x3F6AD0", Offset = "0x3F5ED0", VA = "0x103F6AD0")]
		protected void Broadcast(MessageWriter msg, InnerNetServer.Player source)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x3F6A30", Offset = "0x3F5E30", VA = "0x103F6A30")]
		private void BroadcastJoinMessage(InnerNetServer.Player client, MessageWriter msg)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x3F93B0", Offset = "0x3F87B0", VA = "0x103F93B0")]
		private void WriteJoinedMessage(InnerNetServer.Player client, MessageWriter msg, bool clear)
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x3F9510", Offset = "0x3F8910", VA = "0x103F9510")]
		public InnerNetServer()
		{
		}

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		public const int LocalGameId = 32;

		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		private const int InvalidHost = -1;

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		[FieldOffset(Offset = "0x10")]
		private int HostId;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		[FieldOffset(Offset = "0x14")]
		public PlatformSpecificData PlatformData;

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<string> ipBans;

		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x1C")]
		public int Port;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameStates GameState;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x24")]
		private UdpConnectionListener listener;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x28")]
		private List<InnerNetServer.Player> Clients;

		// Token: 0x02000632 RID: 1586
		[Token(Token = "0x2000632")]
		protected class Player
		{
			// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x5A7D60", Offset = "0x5A7160", VA = "0x105A7D60")]
			public Player(Connection connection, string playerName, PlatformSpecificData platformData)
			{
			}

			// Token: 0x04002736 RID: 10038
			[Token(Token = "0x4002736")]
			[FieldOffset(Offset = "0x0")]
			private static int IdCount;

			// Token: 0x04002737 RID: 10039
			[Token(Token = "0x4002737")]
			[FieldOffset(Offset = "0x8")]
			public int Id;

			// Token: 0x04002738 RID: 10040
			[Token(Token = "0x4002738")]
			[FieldOffset(Offset = "0xC")]
			public Connection Connection;

			// Token: 0x04002739 RID: 10041
			[Token(Token = "0x4002739")]
			[FieldOffset(Offset = "0x10")]
			public string PlayerName;

			// Token: 0x0400273A RID: 10042
			[Token(Token = "0x400273A")]
			[FieldOffset(Offset = "0x14")]
			public PlatformSpecificData PlatformData;

			// Token: 0x0400273B RID: 10043
			[Token(Token = "0x400273B")]
			[FieldOffset(Offset = "0x18")]
			public LimboStates LimboState;
		}

		// Token: 0x02000633 RID: 1587
		[Token(Token = "0x2000633")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002777 RID: 10103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002777")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06002778 RID: 10104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002778")]
			[Address(RVA = "0x5B4BE0", Offset = "0x5B3FE0", VA = "0x105B4BE0")]
			internal void <StartAsServer>b__11_0(string s)
			{
			}

			// Token: 0x06002779 RID: 10105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002779")]
			[Address(RVA = "0x5B4B90", Offset = "0x5B3F90", VA = "0x105B4B90")]
			internal void <StartAsLocalServer>b__12_0(string s)
			{
			}

			// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600277A")]
			[Address(RVA = "0x5B47E0", Offset = "0x5B3BE0", VA = "0x105B47E0")]
			internal string <Connection_DataRecievedRaw>b__18_0(byte b)
			{
				return null;
			}

			// Token: 0x0400273C RID: 10044
			[Token(Token = "0x400273C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly InnerNetServer.<>c <>9;

			// Token: 0x0400273D RID: 10045
			[Token(Token = "0x400273D")]
			[FieldOffset(Offset = "0x4")]
			public static Action<string> <>9__11_0;

			// Token: 0x0400273E RID: 10046
			[Token(Token = "0x400273E")]
			[FieldOffset(Offset = "0x8")]
			public static Action<string> <>9__12_0;

			// Token: 0x0400273F RID: 10047
			[Token(Token = "0x400273F")]
			[FieldOffset(Offset = "0xC")]
			public static Func<byte, string> <>9__18_0;
		}

		// Token: 0x02000634 RID: 1588
		[Token(Token = "0x2000634")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600277B")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x0600277C RID: 10108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600277C")]
			[Address(RVA = "0x5B54C0", Offset = "0x5B48C0", VA = "0x105B54C0")]
			internal void <OnServerConnect>b__0(DataReceivedEventArgs e)
			{
			}

			// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600277D")]
			[Address(RVA = "0x5B5500", Offset = "0x5B4900", VA = "0x105B5500")]
			internal void <OnServerConnect>b__1(object o, DisconnectedEventArgs e)
			{
			}

			// Token: 0x04002740 RID: 10048
			[Token(Token = "0x4002740")]
			[FieldOffset(Offset = "0x8")]
			public InnerNetServer <>4__this;

			// Token: 0x04002741 RID: 10049
			[Token(Token = "0x4002741")]
			[FieldOffset(Offset = "0xC")]
			public InnerNetServer.Player client;
		}
	}
}
