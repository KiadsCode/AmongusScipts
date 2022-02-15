using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using Hazel;
using Il2CppDummyDll;
using InnerNet;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
[SkipRename]
public class GameData : InnerNetObject, IDisconnectHandler
{
	// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x3AD1B0", Offset = "0x3AC5B0", VA = "0x103AD1B0")]
	public void RpcSetTasks(byte playerId, byte[] taskTypeIds)
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x3AD260", Offset = "0x3AC660", VA = "0x103AD260", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x3AC860", Offset = "0x3ABC60", VA = "0x103AC860", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x3ACEB0", Offset = "0x3AC2B0", VA = "0x103ACEB0", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x1700015B")]
	public override bool Chunked
	{
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x060008EA RID: 2282 RVA: 0x000043E0 File Offset: 0x000025E0
	[Token(Token = "0x1700015C")]
	public int PlayerCount
	{
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x3AE1E0", Offset = "0x3AD5E0", VA = "0x103AE1E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x3AC560", Offset = "0x3AB960", VA = "0x103AC560")]
	public void Awake()
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x3AD4C0", Offset = "0x3AC8C0", VA = "0x103AD4C0")]
	internal void SetDirty()
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x3ACA20", Offset = "0x3ABE20", VA = "0x103ACA20")]
	public GameData.PlayerInfo GetHost()
	{
		return null;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x3AC950", Offset = "0x3ABD50", VA = "0x103AC950")]
	public sbyte GetAvailableId()
	{
		return 0;
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x3ACAC0", Offset = "0x3ABEC0", VA = "0x103ACAC0")]
	public GameData.PlayerInfo GetPlayerById(byte id)
	{
		return null;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x3ADF50", Offset = "0x3AD350", VA = "0x103ADF50")]
	public void UpdateName(byte playerId, string name, bool dontCensor = false)
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x3ADEB0", Offset = "0x3AD2B0", VA = "0x103ADEB0")]
	public void UpdateLevel(byte playerId, uint level)
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x3ADDA0", Offset = "0x3AD1A0", VA = "0x103ADDA0")]
	public void UpdateColor(byte playerId, int color)
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x3ADE50", Offset = "0x3AD250", VA = "0x103ADE50")]
	public void UpdateHat(byte playerId, string hat)
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x3AE010", Offset = "0x3AD410", VA = "0x103AE010")]
	public void UpdatePet(byte playerId, string petId)
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x3AE070", Offset = "0x3AD470", VA = "0x103AE070")]
	public void UpdateSkin(byte playerId, string skin)
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x3AE0D0", Offset = "0x3AD4D0", VA = "0x103AE0D0")]
	public void UpdateVisor(byte playerId, string visor)
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x3ADEF0", Offset = "0x3AD2F0", VA = "0x103ADEF0")]
	public void UpdateNamePlate(byte playerId, string namePlate)
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x3AC460", Offset = "0x3AB860", VA = "0x103AC460")]
	public GameData.PlayerInfo AddPlayer(PlayerControl pc)
	{
		return null;
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00004410 File Offset: 0x00002610
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x3AD0E0", Offset = "0x3AC4E0", VA = "0x103AD0E0")]
	public bool RemovePlayer(byte playerId)
	{
		return default(bool);
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x3ACEF0", Offset = "0x3AC2F0", VA = "0x103ACEF0")]
	public void RecomputeTaskCounts()
	{
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x3ADD30", Offset = "0x3AD130", VA = "0x103ADD30")]
	public void TutOnlyRemoveTask(byte playerId, uint taskId)
	{
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00004428 File Offset: 0x00002628
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x3ADBB0", Offset = "0x3ACFB0", VA = "0x103ADBB0")]
	public uint TutOnlyAddTask(byte playerId)
	{
		return 0U;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x3AD4E0", Offset = "0x3AC8E0", VA = "0x103AD4E0")]
	private void SetTasks(byte playerId, byte[] taskTypeIds)
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x3AC780", Offset = "0x3ABB80", VA = "0x103AC780")]
	public void CompleteTask(PlayerControl pc, uint taskId)
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x3ACB70", Offset = "0x3ABF70", VA = "0x103ACB70", Slot = "11")]
	public void HandleDisconnect(PlayerControl player, DisconnectReasons reason)
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x3AD770", Offset = "0x3ACB70", VA = "0x103AD770")]
	private void ShowNotification(string playerName, DisconnectReasons reason)
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000901")]
	[Address(RVA = "0x3ACD90", Offset = "0x3AC190", VA = "0x103ACD90", Slot = "12")]
	public void HandleDisconnect()
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000902")]
	[Address(RVA = "0x3AE180", Offset = "0x3AD580", VA = "0x103AE180")]
	public GameData()
	{
	}

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x0")]
	public static GameData Instance;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x24")]
	public List<GameData.PlayerInfo> AllPlayers;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x28")]
	public int TotalTasks;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x2C")]
	public int CompletedTasks;

	// Token: 0x040008F4 RID: 2292
	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x30")]
	public RoleBehaviour DefaultRole;

	// Token: 0x040008F5 RID: 2293
	[Token(Token = "0x40008F5")]
	public const byte InvalidPlayerId = 255;

	// Token: 0x040008F6 RID: 2294
	[Token(Token = "0x40008F6")]
	public const byte DisconnectedPlayerId = 254;

	// Token: 0x040008F7 RID: 2295
	[Token(Token = "0x40008F7")]
	[FieldOffset(Offset = "0x4")]
	public static Random randy;

	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public class TaskInfo
	{
		// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public TaskInfo()
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x5A84B0", Offset = "0x5A78B0", VA = "0x105A84B0")]
		public TaskInfo(byte typeId, uint id)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x5A8470", Offset = "0x5A7870", VA = "0x105A8470")]
		public void Serialize(MessageWriter writer)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x5A8430", Offset = "0x5A7830", VA = "0x105A8430")]
		public void Deserialize(MessageReader reader)
		{
		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[FieldOffset(Offset = "0x8")]
		public uint Id;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0xC")]
		public byte TypeId;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0xD")]
		public bool Complete;
	}

	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public class PlayerInfo
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x1700015D")]
		public bool IsIncomplete
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x5A7840", Offset = "0x5A6C40", VA = "0x105A7840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015E")]
		public PlayerControl Object
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x5A7990", Offset = "0x5A6D90", VA = "0x105A7990")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public GameData.PlayerOutfit DefaultOutfit
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x5A77F0", Offset = "0x5A6BF0", VA = "0x105A77F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000160")]
		public string PlayerName
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x5A7A80", Offset = "0x5A6E80", VA = "0x105A7A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x5A7AA0", Offset = "0x5A6EA0", VA = "0x105A7AA0")]
			set
			{
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5A7670", Offset = "0x5A6A70", VA = "0x105A7670")]
		public PlayerInfo(byte playerId)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5A7720", Offset = "0x5A6B20", VA = "0x105A7720")]
		public PlayerInfo(PlayerControl pc)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5A7310", Offset = "0x5A6710", VA = "0x105A7310")]
		public void Serialize(MessageWriter writer)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5A6E60", Offset = "0x5A6260", VA = "0x105A6E60")]
		public void Deserialize(MessageReader reader)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x5A7280", Offset = "0x5A6680", VA = "0x105A7280")]
		public string GetPlayerName(PlayerOutfitType outfitType)
		{
			return null;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5A71D0", Offset = "0x5A65D0", VA = "0x105A71D0")]
		public GameData.TaskInfo FindTaskById(uint taskId)
		{
			return null;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5A7600", Offset = "0x5A6A00", VA = "0x105A7600")]
		public void SetOutfit(PlayerOutfitType outfitType, GameData.PlayerOutfit outfit)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x5A7650", Offset = "0x5A6A50", VA = "0x105A7650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private bool <get_Object>b__11_0(PlayerControl p)
		{
			return default(bool);
		}

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x8")]
		public readonly byte PlayerId;

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<PlayerOutfitType, GameData.PlayerOutfit> Outfits;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x10")]
		public uint PlayerLevel;

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0x14")]
		public bool Disconnected;

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0x18")]
		public RoleBehaviour Role;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0x1C")]
		public List<GameData.TaskInfo> Tasks;

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x20")]
		public bool IsDead;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x24")]
		private PlayerControl _object;

		// Token: 0x0200018B RID: 395
		[Token(Token = "0x200018B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000916 RID: 2326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c()
			{
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x00004470 File Offset: 0x00002670
			[Token(Token = "0x6000917")]
			[Address(RVA = "0x1302180", Offset = "0x1301580", VA = "0x11302180")]
			internal bool <get_IsIncomplete>b__7_0(GameData.PlayerOutfit outfit)
			{
				return default(bool);
			}

			// Token: 0x04000903 RID: 2307
			[Token(Token = "0x4000903")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameData.PlayerInfo.<>c <>9;

			// Token: 0x04000904 RID: 2308
			[Token(Token = "0x4000904")]
			[FieldOffset(Offset = "0x4")]
			public static Func<GameData.PlayerOutfit, bool> <>9__7_0;
		}
	}

	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class PlayerOutfit
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000161")]
		public string PlayerName
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x292AA0", Offset = "0x291EA0", VA = "0x10292AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x292AB0", Offset = "0x291EB0", VA = "0x10292AB0")]
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x17000162")]
		public bool IsIncomplete
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x5A7C70", Offset = "0x5A7070", VA = "0x105A7C70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x5A7B60", Offset = "0x5A6F60", VA = "0x105A7B60")]
		public void Serialize(MessageWriter writer)
		{
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x5A7AF0", Offset = "0x5A6EF0", VA = "0x105A7AF0")]
		public void Deserialize(MessageReader reader)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x5A7BD0", Offset = "0x5A6FD0", VA = "0x105A7BD0")]
		public PlayerOutfit()
		{
		}

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x8")]
		public bool dontCensorName;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0xC")]
		public int ColorId;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x10")]
		public string HatId;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x14")]
		public string PetId;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x18")]
		public string SkinId;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x1C")]
		public string VisorId;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x20")]
		public string NamePlateId;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x24")]
		private string _playerName;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x28")]
		private string preCensorName;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x2C")]
		private string postCensorName;
	}

	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x5B4B60", Offset = "0x5B3F60", VA = "0x105B4B60")]
		internal int <Serialize>b__1_0(GameData.PlayerInfo p)
		{
			return 0;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x59F0B0", Offset = "0x59E4B0", VA = "0x1059F0B0")]
		internal uint <TutOnlyAddTask>b__36_0(GameData.TaskInfo d)
		{
			return 0U;
		}

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GameData.<>c <>9;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x4")]
		public static Func<GameData.PlayerInfo, int> <>9__1_0;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameData.TaskInfo, uint> <>9__36_0;
	}

	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x5B5570", Offset = "0x5B4970", VA = "0x105B5570")]
		internal bool <GetAvailableId>b__0(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x8")]
		public sbyte i;
	}
}
