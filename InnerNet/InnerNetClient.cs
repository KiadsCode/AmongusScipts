using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Hazel;
using Hazel.Udp;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace InnerNet
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	public abstract class InnerNetClient : MonoBehaviour
	{
		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x3F0E60", Offset = "0x3F0260", VA = "0x103F0E60")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x3F4AC0", Offset = "0x3F3EC0", VA = "0x103F4AC0")]
		private bool SendAllStreamedObjects()
		{
			return default(bool);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002691")]
		public T FindObjectByNetId<T>(uint netId) where T : InnerNetObject
		{
			return null;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x3F5860", Offset = "0x3F4C60", VA = "0x103F5860")]
		public MessageWriter StartRpcImmediately(uint targetNetId, byte callId, SendOption option, int targetClientId = -1)
		{
			return null;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x3F0E20", Offset = "0x3F0220", VA = "0x103F0E20")]
		public void FinishRpcImmediately(MessageWriter msg)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x3F55D0", Offset = "0x3F49D0", VA = "0x103F55D0")]
		public void SendXuidToAll()
		{
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x3F53C0", Offset = "0x3F47C0", VA = "0x103F53C0")]
		public void SendRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
		{
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x3F5930", Offset = "0x3F4D30", VA = "0x103F5930")]
		public MessageWriter StartRpc(uint targetNetId, byte callId, SendOption option = SendOption.Reliable)
		{
			return null;
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x3F5420", Offset = "0x3F4820", VA = "0x103F5420")]
		private void SendSceneChange(string sceneName)
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x3F0290", Offset = "0x3EF690", VA = "0x103F0290")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE3C0", Offset = "0xDD7C0")]
		private IEnumerator CoSendSceneChange(string sceneName)
		{
			return null;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x3F5700", Offset = "0x3F4B00", VA = "0x103F5700")]
		public void Spawn(InnerNetObject netObjParent, int ownerId = -2, SpawnFlags flags = SpawnFlags.None)
		{
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x3F62D0", Offset = "0x3F56D0", VA = "0x103F62D0")]
		private void WriteSpawnMessage(InnerNetObject netObjParent, int ownerId, SpawnFlags flags, MessageWriter msg)
		{
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x3F0610", Offset = "0x3EFA10", VA = "0x103F0610")]
		public void Despawn(InnerNetObject objToDespawn)
		{
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x3EFDF0", Offset = "0x3EF1F0", VA = "0x103EFDF0")]
		private bool AddNetObject(InnerNetObject obj)
		{
			return default(bool);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x3F4300", Offset = "0x3F3700", VA = "0x103F4300")]
		public void RemoveNetObject(InnerNetObject obj)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x3F45E0", Offset = "0x3F39E0", VA = "0x103F45E0")]
		public void RemoveUnownedObjects()
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x3F1BA0", Offset = "0x3F0FA0", VA = "0x103F1BA0")]
		private void HandleGameData(MessageReader parentReader)
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x3F1B40", Offset = "0x3F0F40", VA = "0x103F1B40")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE460", Offset = "0xDD860")]
		private IEnumerator HandleGameDataInner(MessageReader reader, int msgNum)
		{
			return null;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x3F0230", Offset = "0x3EF630", VA = "0x103F0230")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE4B0", Offset = "0xDD8B0")]
		private IEnumerator CoHandleSpawn(MessageReader reader)
		{
			return null;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x3F56E0", Offset = "0x3F4AE0", VA = "0x103F56E0")]
		public void SetEndpoint(string addr, ushort port, bool dtls)
		{
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x1700081B")]
		public bool AmConnected
		{
			[Token(Token = "0x60026A3")]
			[Address(RVA = "0x3F66A0", Offset = "0x3F5AA0", VA = "0x103F66A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x1700081C")]
		public int Ping
		{
			[Token(Token = "0x60026A4")]
			[Address(RVA = "0x3F6760", Offset = "0x3F5B60", VA = "0x103F6760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x1700081D")]
		public int BytesSent
		{
			[Token(Token = "0x60026A5")]
			[Address(RVA = "0x3F6700", Offset = "0x3F5B00", VA = "0x103F6700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x1700081E")]
		public int BytesGot
		{
			[Token(Token = "0x60026A6")]
			[Address(RVA = "0x3F66D0", Offset = "0x3F5AD0", VA = "0x103F66D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x1700081F")]
		public int Resends
		{
			[Token(Token = "0x60026A7")]
			[Address(RVA = "0x3F67A0", Offset = "0x3F5BA0", VA = "0x103F67A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x17000820")]
		public bool AmHost
		{
			[Token(Token = "0x60026A8")]
			[Address(RVA = "0x3F66B0", Offset = "0x3F5AB0", VA = "0x103F66B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x17000821")]
		public bool AmClient
		{
			[Token(Token = "0x60026A9")]
			[Address(RVA = "0x3F6690", Offset = "0x3F5A90", VA = "0x103F6690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0000B778 File Offset: 0x00009978
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000822")]
		public bool IsGamePublic
		{
			[Token(Token = "0x60026AA")]
			[Address(RVA = "0x3F6740", Offset = "0x3F5B40", VA = "0x103F6740")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026AB")]
			[Address(RVA = "0x3F67D0", Offset = "0x3F5BD0", VA = "0x103F67D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x17000823")]
		public bool IsGameStarted
		{
			[Token(Token = "0x60026AC")]
			[Address(RVA = "0x3F6750", Offset = "0x3F5B50", VA = "0x103F6750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x17000824")]
		public bool IsGameOver
		{
			[Token(Token = "0x60026AD")]
			[Address(RVA = "0x3F6730", Offset = "0x3F5B30", VA = "0x103F6730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x3F5990", Offset = "0x3F4D90", VA = "0x103F5990", Slot = "4")]
		public virtual void Start()
		{
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x3F5250", Offset = "0x3F4650", VA = "0x103F5250")]
		private void SendOrDisconnect(MessageWriter msg)
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x3F1430", Offset = "0x3F0830", VA = "0x103F1430")]
		public ClientData GetHost()
		{
			return null;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x3F0EE0", Offset = "0x3F02E0", VA = "0x103F0EE0")]
		public ClientData GetClientFromCharacter(InnerNetObject character)
		{
			return null;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x3F10A0", Offset = "0x3F04A0", VA = "0x103F10A0")]
		public int GetClientIdFromCharacter(InnerNetObject character)
		{
			return 0;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x3F3EF0", Offset = "0x3F32F0", VA = "0x103F3EF0", Slot = "5")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x3F0180", Offset = "0x3EF580", VA = "0x103F0180")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE500", Offset = "0xDD900")]
		public IEnumerator CoConnect()
		{
			return null;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x3F0350", Offset = "0x3EF750", VA = "0x103F0350")]
		private void Connection_DataReceivedRaw(byte[] data)
		{
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x3F04A0", Offset = "0x3EF8A0", VA = "0x103F04A0")]
		private void Connection_DataSentRaw(byte[] data, int length)
		{
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x3F02F0", Offset = "0x3EF6F0", VA = "0x103F02F0")]
		public void Connect(MatchMakerModes mode)
		{
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x3F01D0", Offset = "0x3EF5D0", VA = "0x103F01D0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE550", Offset = "0xDD950")]
		private IEnumerator CoConnect(MatchMakerModes mode)
		{
			return null;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x3F6150", Offset = "0x3F5550", VA = "0x103F6150")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE600", Offset = "0xDDA00")]
		public IEnumerator WaitForConnectionOrFail()
		{
			return null;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x3F6260", Offset = "0x3F5660", VA = "0x103F6260")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDE6B0", Offset = "0xDDAB0")]
		private IEnumerator WaitWithTimeout(Func<bool> success, string errorMessage, int durationSeconds = 15)
		{
			return null;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x3F5CA0", Offset = "0x3F50A0", VA = "0x103F5CA0")]
		public void Update()
		{
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x3F3F10", Offset = "0x3F3310", VA = "0x103F3F10")]
		private void OnDisconnect(object sender, DisconnectedEventArgs e)
		{
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x3F1AC0", Offset = "0x3F0EC0", VA = "0x103F1AC0")]
		public void HandleDisconnect(DisconnectReasons reason, [Optional] string stringReason)
		{
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x3F0B60", Offset = "0x3EFF60", VA = "0x103F0B60")]
		protected void EnqueueDisconnect(DisconnectReasons reason, [Optional] string stringReason)
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x3F0710", Offset = "0x3EFB10", VA = "0x103F0710")]
		protected void DisconnectInternal(DisconnectReasons reason, [Optional] string stringReason)
		{
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x3F3870", Offset = "0x3F2C70", VA = "0x103F3870")]
		public void HostGame(GameOptionsData settings)
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x3F4900", Offset = "0x3F3D00", VA = "0x103F4900")]
		public void ReportPlayer(int clientId, ReportReasons reason)
		{
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x3F3970", Offset = "0x3F2D70", VA = "0x103F3970")]
		public void JoinGame()
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x3F0080", Offset = "0x3EF480", VA = "0x103F0080")]
		public bool CanBan()
		{
			return default(bool);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x3F00A0", Offset = "0x3EF4A0", VA = "0x103F00A0")]
		public bool CanKick()
		{
			return default(bool);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x3F3CF0", Offset = "0x3F30F0", VA = "0x103F3CF0")]
		public void KickPlayer(int clientId, bool ban)
		{
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C6")]
		[Address(RVA = "0x3F57E0", Offset = "0x3F4BE0", VA = "0x103F57E0")]
		public MessageWriter StartEndGame()
		{
			return null;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x3F0DE0", Offset = "0x3F01E0", VA = "0x103F0DE0")]
		public void FinishEndGame(MessageWriter msg)
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x3F51A0", Offset = "0x3F45A0", VA = "0x103F51A0")]
		protected void SendLateRejection(int targetId, DisconnectReasons reason)
		{
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x3F4E60", Offset = "0x3F4260", VA = "0x103F4E60")]
		protected void SendClientReady()
		{
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x3F5540", Offset = "0x3F4940", VA = "0x103F5540")]
		protected void SendStartGame()
		{
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CB")]
		[Address(RVA = "0x3F49C0", Offset = "0x3F3DC0", VA = "0x103F49C0")]
		public void RequestGameList(bool includePrivate, GameOptionsData settings)
		{
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CC")]
		[Address(RVA = "0x3F00C0", Offset = "0x3EF4C0", VA = "0x103F00C0")]
		public void ChangeGamePublic(bool isPublic)
		{
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		public void SetGameSession(string session)
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x3F5630", Offset = "0x3F4A30", VA = "0x103F5630")]
		public void SetActivePodType(string podType)
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x3F4270", Offset = "0x3F3670", VA = "0x103F4270")]
		public void QueryPlatformIds()
		{
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x3F4250", Offset = "0x3F3650", VA = "0x103F4250")]
		private void OnQueryPlatformData(List<PlatformSpecificData> playerData)
		{
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0x3F41A0", Offset = "0x3F35A0", VA = "0x103F41A0")]
		private void OnMessageReceived(Hazel.DataReceivedEventArgs e)
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x3F1CB0", Offset = "0x3F10B0", VA = "0x103F1CB0")]
		private void HandleMessage(MessageReader reader, SendOption sendOption)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x3EFEA0", Offset = "0x3EF2A0", VA = "0x103EFEA0")]
		public static string AddressToString(uint address)
		{
			return null;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x3F1590", Offset = "0x3F0990", VA = "0x103F1590")]
		private ClientData GetOrCreateClient(ClientData client)
		{
			return null;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x3F10D0", Offset = "0x3F04D0", VA = "0x103F10D0")]
		public ClientData GetClient(int clientId)
		{
			return null;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0x3F19B0", Offset = "0x3F0DB0", VA = "0x103F19B0")]
		public void GetRecentClients(List<ClientData> buffer)
		{
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x3F1850", Offset = "0x3F0C50", VA = "0x103F1850")]
		public ClientData GetRecentClient(int clientId)
		{
			return null;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x3F43A0", Offset = "0x3F37A0", VA = "0x103F43A0")]
		private void RemovePlayer(int playerIdThatLeft, DisconnectReasons reason)
		{
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x3F3DA0", Offset = "0x3F31A0", VA = "0x103F3DA0", Slot = "6")]
		protected virtual void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x3F61A0", Offset = "0x3F55A0", VA = "0x103F61A0")]
		private void WaitToDisconnect(object state)
		{
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DB")]
		[Address(RVA = "0x3F4F60", Offset = "0x3F4360", VA = "0x103F4F60")]
		protected void SendInitialData(int clientId)
		{
		}

		// Token: 0x060026DC RID: 9948
		[Token(Token = "0x60026DC")]
		protected abstract void OnGameCreated(string gameIdString);

		// Token: 0x060026DD RID: 9949
		[Token(Token = "0x60026DD")]
		protected abstract void OnGameJoined(string gameIdString, ClientData client);

		// Token: 0x060026DE RID: 9950
		[Token(Token = "0x60026DE")]
		protected abstract void OnWaitForHost(string gameIdString);

		// Token: 0x060026DF RID: 9951
		[Token(Token = "0x60026DF")]
		protected abstract IEnumerator CoStartGame();

		// Token: 0x060026E0 RID: 9952
		[Token(Token = "0x60026E0")]
		protected abstract void OnGameEnd(EndGameResult endGameResult);

		// Token: 0x060026E1 RID: 9953
		[Token(Token = "0x60026E1")]
		protected abstract void OnBecomeHost();

		// Token: 0x060026E2 RID: 9954
		[Token(Token = "0x60026E2")]
		protected abstract void OnPlayerJoined(ClientData client);

		// Token: 0x060026E3 RID: 9955
		[Token(Token = "0x60026E3")]
		protected abstract IEnumerator CoOnPlayerChangedScene(ClientData client, string targetScene);

		// Token: 0x060026E4 RID: 9956
		[Token(Token = "0x60026E4")]
		protected abstract void OnPlayerLeft(ClientData client, DisconnectReasons reason);

		// Token: 0x060026E5 RID: 9957
		[Token(Token = "0x60026E5")]
		protected abstract void OnReportedPlayer(ReportOutcome outcome, int clientId, string playerName, ReportReasons reason);

		// Token: 0x060026E6 RID: 9958
		[Token(Token = "0x60026E6")]
		protected abstract void OnDisconnected();

		// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
		private void OnSetPSNSessionId(string sessionId)
		{
		}

		// Token: 0x060026E8 RID: 9960
		[Token(Token = "0x60026E8")]
		protected abstract void OnGetGameList(InnerNetClient.TotalGameData totalGames, List<GameListing> availableGames);

		// Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x3F1230", Offset = "0x3F0630", VA = "0x103F1230")]
		private byte[] GetConnectionData(bool useDtlsLayout)
		{
			return null;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x3F0CB0", Offset = "0x3F00B0", VA = "0x103F0CB0")]
		protected ClientData FindClientById(int id)
		{
			return null;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x3F64D0", Offset = "0x3F58D0", VA = "0x103F64D0")]
		protected InnerNetClient()
		{
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0x3F5B80", Offset = "0x3F4F80", VA = "0x103F5B80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <Start>b__88_0(Scene oldScene, Scene scene)
		{
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x3F5A30", Offset = "0x3F4E30", VA = "0x103F5A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <CoConnect>b__98_0()
		{
			return default(bool);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x3F5A40", Offset = "0x3F4E40", VA = "0x103F5A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <CoConnect>b__98_1()
		{
			return default(bool);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x3F5A30", Offset = "0x3F4E30", VA = "0x103F5A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <CoConnect>b__98_2()
		{
			return default(bool);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x3F5A80", Offset = "0x3F4E80", VA = "0x103F5A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <HandleMessage>b__125_1()
		{
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x3F5AF0", Offset = "0x3F4EF0", VA = "0x103F5AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <HandleMessage>b__125_2()
		{
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x3F5B10", Offset = "0x3F4F10", VA = "0x103F5B10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <HandleMessage>b__125_5()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x3F5AF0", Offset = "0x3F4EF0", VA = "0x103F5AF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <HandleMessage>b__125_8()
		{
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x3F5A50", Offset = "0x3F4E50", VA = "0x103F5A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private void <HandleMessage>b__125_12()
		{
		}

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		public const int CurrentClient = -3;

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		public const int HostInherit = -2;

		// Token: 0x04002687 RID: 9863
		[Token(Token = "0x4002687")]
		internal const byte DataFlag = 1;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		internal const byte RpcFlag = 2;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		internal const byte SpawnFlag = 4;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		internal const byte DespawnFlag = 5;

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		internal const byte SceneChangeFlag = 6;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		internal const byte ReadyFlag = 7;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		internal const byte ChangeSettingsFlag = 8;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		internal const byte XboxDeclareXuid = 207;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float MinSendInterval;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint NetIdCnt;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float timer;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetReference[] SpawnableObjects;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public InnerNetObject[] NonAddressableSpawnableObjects;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool InOnlineScene;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private HashSet<uint> DestroyedObjects;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<InnerNetObject> allObjects;

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, InnerNetObject> allObjectsFast;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MessageWriter[] Streams;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int msgNum;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DisconnectReasons[] disconnectReasons;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		public const int MaxRecentClients = 20;

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		private const int DefaultSecondsSuspendedBeforeDisconnect = 30;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int SecondsSuspendedBeforeDisconnect;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		public const int NoClientId = -1;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string networkAddress;

		// Token: 0x040026A0 RID: 9888
		[Token(Token = "0x40026A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int networkPort;

		// Token: 0x040026A1 RID: 9889
		[Token(Token = "0x40026A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool useDtls;

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private UnityUdpClientConnection connection;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MatchMakerModes mode;

		// Token: 0x040026A4 RID: 9892
		[Token(Token = "0x40026A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public GameModes GameMode;

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int GameId;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int HostId;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int ClientId;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected List<ClientData> allClients;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CircleBuffer<ClientData> recentClients;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DisconnectReasons LastDisconnectReason;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string LastCustomDisconnect;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public byte LastServerChatMode;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<Action> PreSpawnDispatcher;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private readonly List<Action> Dispatcher;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <IsGamePublic>k__BackingField;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public InnerNetClient.GameStates GameState;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isConnecting;

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool platformSpecificsChecked;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private List<Action> TempQueue;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool appPaused;

		// Token: 0x02000610 RID: 1552
		[Token(Token = "0x2000610")]
		public enum GameStates
		{
			// Token: 0x040026B6 RID: 9910
			[Token(Token = "0x40026B6")]
			NotJoined,
			// Token: 0x040026B7 RID: 9911
			[Token(Token = "0x40026B7")]
			Joined,
			// Token: 0x040026B8 RID: 9912
			[Token(Token = "0x40026B8")]
			Started,
			// Token: 0x040026B9 RID: 9913
			[Token(Token = "0x40026B9")]
			Ended
		}

		// Token: 0x02000611 RID: 1553
		[Token(Token = "0x2000611")]
		public class TotalGameData
		{
			// Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public TotalGameData()
			{
			}

			// Token: 0x040026BA RID: 9914
			[Token(Token = "0x40026BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int[] PerMapTotals;
		}

		// Token: 0x02000612 RID: 1554
		[Token(Token = "0x2000612")]
		private class RecentPlayerComparer : IComparer<ClientData>
		{
			// Token: 0x060026F7 RID: 9975 RVA: 0x0000B850 File Offset: 0x00009A50
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x5A7DE0", Offset = "0x5A71E0", VA = "0x105A7DE0", Slot = "4")]
			public int Compare(ClientData x, ClientData y)
			{
				return 0;
			}

			// Token: 0x060026F8 RID: 9976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public RecentPlayerComparer()
			{
			}

			// Token: 0x040026BB RID: 9915
			[Token(Token = "0x40026BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3DA13D9B")]
			public static readonly InnerNetClient.RecentPlayerComparer Instance;
		}

		// Token: 0x02000613 RID: 1555
		[Token(Token = "0x2000613")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <CoSendSceneChange>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060026FA RID: 9978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <CoSendSceneChange>d__29(int <>1__state)
			{
			}

			// Token: 0x060026FB RID: 9979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060026FC RID: 9980 RVA: 0x0000B868 File Offset: 0x00009A68
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x5ACB90", Offset = "0x5ABF90", VA = "0x105ACB90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x060026FD RID: 9981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000825")]
			private object Current
			{
				[Token(Token = "0x60026FD")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x5ACFB0", Offset = "0x5AC3B0", VA = "0x105ACFB0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x060026FF RID: 9983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000826")]
			private object Current
			{
				[Token(Token = "0x60026FF")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026BC RID: 9916
			[Token(Token = "0x40026BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026BD RID: 9917
			[Token(Token = "0x40026BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026BE RID: 9918
			[Token(Token = "0x40026BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;

			// Token: 0x040026BF RID: 9919
			[Token(Token = "0x40026BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public string sceneName;
		}

		// Token: 0x02000614 RID: 1556
		[Token(Token = "0x2000614")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <HandleGameDataInner>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002700 RID: 9984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <HandleGameDataInner>d__38(int <>1__state)
			{
			}

			// Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x5B2720", Offset = "0x5B1B20", VA = "0x105B2720", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002702 RID: 9986 RVA: 0x0000B880 File Offset: 0x00009A80
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x5B18D0", Offset = "0x5B0CD0", VA = "0x105B18D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x5B2780", Offset = "0x5B1B80", VA = "0x105B2780")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x5B2780", Offset = "0x5B1B80", VA = "0x105B2780")]
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000827")]
			private object Current
			{
				[Token(Token = "0x6002705")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002706")]
			[Address(RVA = "0x5B26F0", Offset = "0x5B1AF0", VA = "0x105B26F0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000828")]
			private object Current
			{
				[Token(Token = "0x6002707")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026C0 RID: 9920
			[Token(Token = "0x40026C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026C1 RID: 9921
			[Token(Token = "0x40026C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026C2 RID: 9922
			[Token(Token = "0x40026C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MessageReader reader;

			// Token: 0x040026C3 RID: 9923
			[Token(Token = "0x40026C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public InnerNetClient <>4__this;

			// Token: 0x040026C4 RID: 9924
			[Token(Token = "0x40026C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int msgNum;

			// Token: 0x040026C5 RID: 9925
			[Token(Token = "0x40026C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int <cnt>5__2;
		}

		// Token: 0x02000615 RID: 1557
		[Token(Token = "0x2000615")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002708")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x06002709 RID: 9993 RVA: 0x0000B898 File Offset: 0x00009A98
			[Token(Token = "0x6002709")]
			[Address(RVA = "0x5B57A0", Offset = "0x5B4BA0", VA = "0x105B57A0")]
			internal bool <CoHandleSpawn>b__0(InnerNetObject f)
			{
				return default(bool);
			}

			// Token: 0x040026C6 RID: 9926
			[Token(Token = "0x40026C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint spawnId;
		}

		// Token: 0x02000616 RID: 1558
		[Token(Token = "0x2000616")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <CoHandleSpawn>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600270A RID: 9994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600270A")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <CoHandleSpawn>d__39(int <>1__state)
			{
			}

			// Token: 0x0600270B RID: 9995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600270B")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600270C RID: 9996 RVA: 0x0000B8B0 File Offset: 0x00009AB0
			[Token(Token = "0x600270C")]
			[Address(RVA = "0x5AAA40", Offset = "0x5A9E40", VA = "0x105AAA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000829")]
			private object Current
			{
				[Token(Token = "0x600270D")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600270E")]
			[Address(RVA = "0x5AB4E0", Offset = "0x5AA8E0", VA = "0x105AB4E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082A")]
			private object Current
			{
				[Token(Token = "0x600270F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026C7 RID: 9927
			[Token(Token = "0x40026C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026C8 RID: 9928
			[Token(Token = "0x40026C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026C9 RID: 9929
			[Token(Token = "0x40026C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MessageReader reader;

			// Token: 0x040026CA RID: 9930
			[Token(Token = "0x40026CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public InnerNetClient <>4__this;

			// Token: 0x040026CB RID: 9931
			[Token(Token = "0x40026CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private InnerNetClient.<>c__DisplayClass39_0 <>8__1;

			// Token: 0x040026CC RID: 9932
			[Token(Token = "0x40026CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int <ownerId>5__2;

			// Token: 0x040026CD RID: 9933
			[Token(Token = "0x40026CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private ClientData <ownerClient>5__3;

			// Token: 0x040026CE RID: 9934
			[Token(Token = "0x40026CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int <frames>5__4;

			// Token: 0x040026CF RID: 9935
			[Token(Token = "0x40026CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperationHandle<GameObject> <spawnPrefab>5__5;
		}

		// Token: 0x02000617 RID: 1559
		[Token(Token = "0x2000617")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <CoConnect>d__94 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002710")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <CoConnect>d__94(int <>1__state)
			{
			}

			// Token: 0x06002711 RID: 10001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002711")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002712 RID: 10002 RVA: 0x0000B8C8 File Offset: 0x00009AC8
			[Token(Token = "0x6002712")]
			[Address(RVA = "0x5A9810", Offset = "0x5A8C10", VA = "0x105A9810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082B")]
			private object Current
			{
				[Token(Token = "0x6002713")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002714")]
			[Address(RVA = "0x5A9DE0", Offset = "0x5A91E0", VA = "0x105A9DE0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06002715 RID: 10005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082C")]
			private object Current
			{
				[Token(Token = "0x6002715")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026D0 RID: 9936
			[Token(Token = "0x40026D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026D1 RID: 9937
			[Token(Token = "0x40026D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026D2 RID: 9938
			[Token(Token = "0x40026D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;

			// Token: 0x040026D3 RID: 9939
			[Token(Token = "0x40026D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private string <ipAddr>5__2;
		}

		// Token: 0x02000618 RID: 1560
		[Token(Token = "0x2000618")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002717")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002718")]
			[Address(RVA = "0x5B47E0", Offset = "0x5B3BE0", VA = "0x105B47E0")]
			internal string <Connection_DataReceivedRaw>b__95_0(byte b)
			{
				return null;
			}

			// Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002719")]
			[Address(RVA = "0x5B47E0", Offset = "0x5B3BE0", VA = "0x105B47E0")]
			internal string <Connection_DataSentRaw>b__96_0(byte b)
			{
				return null;
			}

			// Token: 0x040026D4 RID: 9940
			[Token(Token = "0x40026D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly InnerNetClient.<>c <>9;

			// Token: 0x040026D5 RID: 9941
			[Token(Token = "0x40026D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<byte, string> <>9__95_0;

			// Token: 0x040026D6 RID: 9942
			[Token(Token = "0x40026D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<byte, string> <>9__96_0;
		}

		// Token: 0x02000619 RID: 1561
		[Token(Token = "0x2000619")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <CoConnect>d__98 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600271A")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <CoConnect>d__98(int <>1__state)
			{
			}

			// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600271B")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600271C RID: 10012 RVA: 0x0000B8E0 File Offset: 0x00009AE0
			[Token(Token = "0x600271C")]
			[Address(RVA = "0x5A9E10", Offset = "0x5A9210", VA = "0x105A9E10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x0600271D RID: 10013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082D")]
			private object Current
			{
				[Token(Token = "0x600271D")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600271E")]
			[Address(RVA = "0x5AA180", Offset = "0x5A9580", VA = "0x105AA180", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x0600271F RID: 10015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082E")]
			private object Current
			{
				[Token(Token = "0x600271F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026D7 RID: 9943
			[Token(Token = "0x40026D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026D8 RID: 9944
			[Token(Token = "0x40026D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026D9 RID: 9945
			[Token(Token = "0x40026D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;

			// Token: 0x040026DA RID: 9946
			[Token(Token = "0x40026DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MatchMakerModes mode;
		}

		// Token: 0x0200061A RID: 1562
		[Token(Token = "0x200061A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <WaitForConnectionOrFail>d__99 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002720")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <WaitForConnectionOrFail>d__99(int <>1__state)
			{
			}

			// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002721")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002722 RID: 10018 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			[Token(Token = "0x6002722")]
			[Address(RVA = "0x5B5F40", Offset = "0x5B5340", VA = "0x105B5F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06002723 RID: 10019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700082F")]
			private object Current
			{
				[Token(Token = "0x6002723")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002724")]
			[Address(RVA = "0x5B5FE0", Offset = "0x5B53E0", VA = "0x105B5FE0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06002725 RID: 10021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000830")]
			private object Current
			{
				[Token(Token = "0x6002725")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026DB RID: 9947
			[Token(Token = "0x40026DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026DC RID: 9948
			[Token(Token = "0x40026DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026DD RID: 9949
			[Token(Token = "0x40026DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x0200061B RID: 1563
		[Token(Token = "0x200061B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <WaitWithTimeout>d__100 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002726")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <WaitWithTimeout>d__100(int <>1__state)
			{
			}

			// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002727")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06002728 RID: 10024 RVA: 0x0000B910 File Offset: 0x00009B10
			[Token(Token = "0x6002728")]
			[Address(RVA = "0x5B6130", Offset = "0x5B5530", VA = "0x105B6130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06002729 RID: 10025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000831")]
			private object Current
			{
				[Token(Token = "0x6002729")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600272A")]
			[Address(RVA = "0x5B6240", Offset = "0x5B5640", VA = "0x105B6240", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x0600272B RID: 10027 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000832")]
			private object Current
			{
				[Token(Token = "0x600272B")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040026DE RID: 9950
			[Token(Token = "0x40026DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040026DF RID: 9951
			[Token(Token = "0x40026DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040026E0 RID: 9952
			[Token(Token = "0x40026E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<bool> success;

			// Token: 0x040026E1 RID: 9953
			[Token(Token = "0x40026E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public InnerNetClient <>4__this;

			// Token: 0x040026E2 RID: 9954
			[Token(Token = "0x40026E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int durationSeconds;

			// Token: 0x040026E3 RID: 9955
			[Token(Token = "0x40026E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public string errorMessage;

			// Token: 0x040026E4 RID: 9956
			[Token(Token = "0x40026E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool <failed>5__2;

			// Token: 0x040026E5 RID: 9957
			[Token(Token = "0x40026E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <timer>5__3;
		}

		// Token: 0x0200061C RID: 1564
		[Token(Token = "0x200061C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600272C")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x0600272D RID: 10029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600272D")]
			[Address(RVA = "0x5B4E90", Offset = "0x5B4290", VA = "0x105B4E90")]
			internal void <EnqueueDisconnect>b__0()
			{
			}

			// Token: 0x040026E6 RID: 9958
			[Token(Token = "0x40026E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InnerNetClient <>4__this;

			// Token: 0x040026E7 RID: 9959
			[Token(Token = "0x40026E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public DisconnectReasons reason;

			// Token: 0x040026E8 RID: 9960
			[Token(Token = "0x40026E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stringReason;
		}

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x0600272E RID: 10030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600272E")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x0600272F RID: 10031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600272F")]
			[Address(RVA = "0x5B50B0", Offset = "0x5B44B0", VA = "0x105B50B0")]
			internal void <HandleMessage>b__0()
			{
			}

			// Token: 0x040026E9 RID: 9961
			[Token(Token = "0x40026E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ReportOutcome outcome;

			// Token: 0x040026EA RID: 9962
			[Token(Token = "0x40026EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int clientId;

			// Token: 0x040026EB RID: 9963
			[Token(Token = "0x40026EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playerName;

			// Token: 0x040026EC RID: 9964
			[Token(Token = "0x40026EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ReportReasons reason;

			// Token: 0x040026ED RID: 9965
			[Token(Token = "0x40026ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x0200061E RID: 1566
		[Token(Token = "0x200061E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_1
		{
			// Token: 0x06002730 RID: 10032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002730")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_1()
			{
			}

			// Token: 0x06002731 RID: 10033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002731")]
			[Address(RVA = "0x5B50F0", Offset = "0x5B44F0", VA = "0x105B50F0")]
			internal void <HandleMessage>b__3()
			{
			}

			// Token: 0x040026EE RID: 9966
			[Token(Token = "0x40026EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public EndGameResult endGameResult;

			// Token: 0x040026EF RID: 9967
			[Token(Token = "0x40026EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x0200061F RID: 1567
		[Token(Token = "0x200061F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_2
		{
			// Token: 0x06002732 RID: 10034 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002732")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_2()
			{
			}

			// Token: 0x06002733 RID: 10035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002733")]
			[Address(RVA = "0x5B5120", Offset = "0x5B4520", VA = "0x105B5120")]
			internal void <HandleMessage>b__4()
			{
			}

			// Token: 0x040026F0 RID: 9968
			[Token(Token = "0x40026F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public List<PlatformSpecificData> received;

			// Token: 0x040026F1 RID: 9969
			[Token(Token = "0x40026F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000620 RID: 1568
		[Token(Token = "0x2000620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_3
		{
			// Token: 0x06002734 RID: 10036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002734")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_3()
			{
			}

			// Token: 0x06002735 RID: 10037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002735")]
			[Address(RVA = "0x5B5150", Offset = "0x5B4550", VA = "0x105B5150")]
			internal void <HandleMessage>b__6()
			{
			}

			// Token: 0x040026F2 RID: 9970
			[Token(Token = "0x40026F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ClientData myClient;

			// Token: 0x040026F3 RID: 9971
			[Token(Token = "0x40026F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000621 RID: 1569
		[Token(Token = "0x2000621")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_4
		{
			// Token: 0x06002736 RID: 10038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002736")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_4()
			{
			}

			// Token: 0x06002737 RID: 10039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002737")]
			[Address(RVA = "0x5B51D0", Offset = "0x5B45D0", VA = "0x105B51D0")]
			internal void <HandleMessage>b__7()
			{
			}

			// Token: 0x040026F4 RID: 9972
			[Token(Token = "0x40026F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ClientData client;

			// Token: 0x040026F5 RID: 9973
			[Token(Token = "0x40026F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000622 RID: 1570
		[Token(Token = "0x2000622")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_5
		{
			// Token: 0x06002738 RID: 10040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002738")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_5()
			{
			}

			// Token: 0x06002739 RID: 10041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002739")]
			[Address(RVA = "0x5B5200", Offset = "0x5B4600", VA = "0x105B5200")]
			internal void <HandleMessage>b__9()
			{
			}

			// Token: 0x040026F6 RID: 9974
			[Token(Token = "0x40026F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MessageReader subReader;

			// Token: 0x040026F7 RID: 9975
			[Token(Token = "0x40026F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000623 RID: 1571
		[Token(Token = "0x2000623")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_6
		{
			// Token: 0x0600273A RID: 10042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273A")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_6()
			{
			}

			// Token: 0x0600273B RID: 10043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273B")]
			[Address(RVA = "0x5B5200", Offset = "0x5B4600", VA = "0x105B5200")]
			internal void <HandleMessage>b__10()
			{
			}

			// Token: 0x040026F8 RID: 9976
			[Token(Token = "0x40026F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MessageReader subReader;

			// Token: 0x040026F9 RID: 9977
			[Token(Token = "0x40026F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000624 RID: 1572
		[Token(Token = "0x2000624")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_7
		{
			// Token: 0x0600273C RID: 10044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273C")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_7()
			{
			}

			// Token: 0x0600273D RID: 10045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273D")]
			[Address(RVA = "0x5B5230", Offset = "0x5B4630", VA = "0x105B5230")]
			internal void <HandleMessage>b__11()
			{
			}

			// Token: 0x040026FA RID: 9978
			[Token(Token = "0x40026FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InnerNetClient.TotalGameData totals;

			// Token: 0x040026FB RID: 9979
			[Token(Token = "0x40026FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public List<GameListing> output;

			// Token: 0x040026FC RID: 9980
			[Token(Token = "0x40026FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000625 RID: 1573
		[Token(Token = "0x2000625")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass125_8
		{
			// Token: 0x0600273E RID: 10046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273E")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass125_8()
			{
			}

			// Token: 0x0600273F RID: 10047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600273F")]
			[Address(RVA = "0x5B5260", Offset = "0x5B4660", VA = "0x105B5260")]
			internal void <HandleMessage>b__13()
			{
			}

			// Token: 0x040026FD RID: 9981
			[Token(Token = "0x40026FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint address;

			// Token: 0x040026FE RID: 9982
			[Token(Token = "0x40026FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ushort port;

			// Token: 0x040026FF RID: 9983
			[Token(Token = "0x40026FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InnerNetClient <>4__this;
		}

		// Token: 0x02000626 RID: 1574
		[Token(Token = "0x2000626")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass127_0
		{
			// Token: 0x06002740 RID: 10048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002740")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass127_0()
			{
			}

			// Token: 0x06002741 RID: 10049 RVA: 0x0000B928 File Offset: 0x00009B28
			[Token(Token = "0x6002741")]
			[Address(RVA = "0x5B5410", Offset = "0x5B4810", VA = "0x105B5410")]
			internal bool <GetOrCreateClient>b__0(ClientData c)
			{
				return default(bool);
			}

			// Token: 0x06002742 RID: 10050 RVA: 0x0000B940 File Offset: 0x00009B40
			[Token(Token = "0x6002742")]
			[Address(RVA = "0x5B5410", Offset = "0x5B4810", VA = "0x105B5410")]
			internal bool <GetOrCreateClient>b__1(ClientData c)
			{
				return default(bool);
			}

			// Token: 0x04002700 RID: 9984
			[Token(Token = "0x4002700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ClientData client;
		}

		// Token: 0x02000627 RID: 1575
		[Token(Token = "0x2000627")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x06002743 RID: 10051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x06002744 RID: 10052 RVA: 0x0000B958 File Offset: 0x00009B58
			[Token(Token = "0x6002744")]
			[Address(RVA = "0x5B5440", Offset = "0x5B4840", VA = "0x105B5440")]
			internal bool <GetClient>b__0(ClientData c)
			{
				return default(bool);
			}

			// Token: 0x04002701 RID: 9985
			[Token(Token = "0x4002701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int clientId;
		}

		// Token: 0x02000628 RID: 1576
		[Token(Token = "0x2000628")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass130_0
		{
			// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002745")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass130_0()
			{
			}

			// Token: 0x06002746 RID: 10054 RVA: 0x0000B970 File Offset: 0x00009B70
			[Token(Token = "0x6002746")]
			[Address(RVA = "0x5B5440", Offset = "0x5B4840", VA = "0x105B5440")]
			internal bool <GetRecentClient>b__0(ClientData c)
			{
				return default(bool);
			}

			// Token: 0x04002702 RID: 9986
			[Token(Token = "0x4002702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int clientId;
		}

		// Token: 0x02000629 RID: 1577
		[Token(Token = "0x2000629")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002747")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002748")]
			[Address(RVA = "0x5B5460", Offset = "0x5B4860", VA = "0x105B5460")]
			internal void <RemovePlayer>b__0()
			{
			}

			// Token: 0x04002703 RID: 9987
			[Token(Token = "0x4002703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InnerNetClient <>4__this;

			// Token: 0x04002704 RID: 9988
			[Token(Token = "0x4002704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ClientData client;

			// Token: 0x04002705 RID: 9989
			[Token(Token = "0x4002705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DisconnectReasons reason;
		}
	}
}
