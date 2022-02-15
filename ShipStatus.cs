using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using PowerTools;
using UnityEngine;

// Token: 0x020004B1 RID: 1201
[Token(Token = "0x20004B1")]
public class ShipStatus : InnerNetObject
{
	// Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001974")]
	[Address(RVA = "0x498860", Offset = "0x497C60", VA = "0x10498860")]
	public void RpcCloseDoorsOfType(SystemTypes type)
	{
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001975")]
	[Address(RVA = "0x498A30", Offset = "0x497E30", VA = "0x10498A30")]
	public void RpcRepairSystem(SystemTypes systemType, int amount)
	{
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001976")]
	[Address(RVA = "0x498B60", Offset = "0x497F60", VA = "0x10498B60")]
	public void RpcUpdateSystem(SystemTypes systemType, MessageWriter msgWriter)
	{
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00008010 File Offset: 0x00006210
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x498CE0", Offset = "0x4980E0", VA = "0x10498CE0", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001978")]
	[Address(RVA = "0x497250", Offset = "0x496650", VA = "0x10497250", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001979")]
	[Address(RVA = "0x497930", Offset = "0x496D30", VA = "0x10497930", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x0600197A RID: 6522 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600197B RID: 6523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B1")]
	public IStepWatcher[] AllStepWatchers
	{
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x4992A0", Offset = "0x4986A0", VA = "0x104992A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x4992F0", Offset = "0x4986F0", VA = "0x104992F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B2")]
	public PlainShipRoom[] AllRooms
	{
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x499290", Offset = "0x498690", VA = "0x10499290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x4992D0", Offset = "0x4986D0", VA = "0x104992D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x0600197E RID: 6526 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600197F RID: 6527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B3")]
	public Dictionary<SystemTypes, PlainShipRoom> FastRooms
	{
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x4992C0", Offset = "0x4986C0", VA = "0x104992C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x499350", Offset = "0x498750", VA = "0x10499350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06001980 RID: 6528 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B4")]
	public Vent[] AllVents
	{
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x437DF0", Offset = "0x4371F0", VA = "0x10437DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x499310", Offset = "0x498710", VA = "0x10499310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06001982 RID: 6530 RVA: 0x00008028 File Offset: 0x00006228
	// (set) Token: 0x06001983 RID: 6531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B5")]
	public bool BeginCalled
	{
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x4992B0", Offset = "0x4986B0", VA = "0x104992B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x499330", Offset = "0x498730", VA = "0x10499330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06001984 RID: 6532 RVA: 0x00008040 File Offset: 0x00006240
	[Token(Token = "0x170003B6")]
	public override bool IsDirty
	{
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x2EDC10", Offset = "0x2ED010", VA = "0x102EDC10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001985")]
	[Address(RVA = "0x497C60", Offset = "0x497060", VA = "0x10497C60", Slot = "11")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x4984B0", Offset = "0x4978B0", VA = "0x104984B0", Slot = "12")]
	public virtual void RepairGameOverSystems()
	{
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x495CC0", Offset = "0x4950C0", VA = "0x10495CC0")]
	private void Awake()
	{
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x499000", Offset = "0x498400", VA = "0x10499000", Slot = "13")]
	protected virtual void Start()
	{
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x497B90", Offset = "0x496F90", VA = "0x10497B90", Slot = "7")]
	public override void OnDestroy()
	{
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x498E40", Offset = "0x498240", VA = "0x10498E40", Slot = "14")]
	public virtual void SpawnPlayer(PlayerControl player, int numPlayers, bool initialSpawn)
	{
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x498F60", Offset = "0x498360", VA = "0x10498F60")]
	public void StartShields()
	{
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198C")]
	[Address(RVA = "0x497400", Offset = "0x496800", VA = "0x10497400")]
	public void FireWeapon()
	{
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198D")]
	[Address(RVA = "0x4977F0", Offset = "0x496BF0", VA = "0x104977F0")]
	public NormalPlayerTask GetTaskById(byte idx)
	{
		return null;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198E")]
	[Address(RVA = "0x4983B0", Offset = "0x4977B0", VA = "0x104983B0")]
	public void OpenHatch()
	{
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x497150", Offset = "0x496550", VA = "0x10497150")]
	public void CloseDoorsOfType(SystemTypes room)
	{
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x498570", Offset = "0x497970", VA = "0x10498570")]
	public void RepairSystem(SystemTypes systemType, PlayerControl player, byte amount)
	{
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x499170", Offset = "0x498570", VA = "0x10499170")]
	public void UpdateSystem(SystemTypes systemType, PlayerControl player, MessageReader msgReader)
	{
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001992")]
	[Address(RVA = "0x495BC0", Offset = "0x494FC0", VA = "0x10495BC0")]
	private void AssignTaskIndexes()
	{
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "15")]
	public virtual void OnMeetingCalled()
	{
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x498470", Offset = "0x497870", VA = "0x10498470", Slot = "16")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE09B0", Offset = "0xDFDB0")]
	public virtual IEnumerator PrespawnStep()
	{
		return null;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x496000", Offset = "0x495400", VA = "0x10496000")]
	public void Begin()
	{
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001996")]
	[Address(RVA = "0x4958F0", Offset = "0x494CF0", VA = "0x104958F0")]
	private void AddTasksFromList(ref int start, int count, List<byte> tasks, HashSet<TaskTypes> usedTaskTypes, List<NormalPlayerTask> unusedTasks)
	{
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x4974E0", Offset = "0x4968E0", VA = "0x104974E0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x6001998")]
	[Address(RVA = "0x496530", Offset = "0x495930", VA = "0x10496530", Slot = "17")]
	public virtual float CalculateLightRadius(GameData.PlayerInfo player)
	{
		return 0f;
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x4966E0", Offset = "0x495AE0", VA = "0x104966E0")]
	private void CheckEndCriteria()
	{
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x497300", Offset = "0x496700", VA = "0x10497300")]
	private void EndGameForSabotage()
	{
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x497A10", Offset = "0x496E10", VA = "0x10497A10")]
	public bool IsGameOverDueToDeath()
	{
		return default(bool);
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x498910", Offset = "0x497D10", VA = "0x10498910")]
	private static void RpcEndGame(GameOverReason endReason, bool showAd)
	{
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x498640", Offset = "0x497A40", VA = "0x10498640")]
	private static void ReviveEveryone()
	{
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x00008088 File Offset: 0x00006288
	[Token(Token = "0x600199E")]
	[Address(RVA = "0x496ED0", Offset = "0x4962D0", VA = "0x10496ED0")]
	public bool CheckTaskCompletion()
	{
		return default(bool);
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199F")]
	[Address(RVA = "0x499240", Offset = "0x498640", VA = "0x10499240")]
	public ShipStatus()
	{
	}

	// Token: 0x04001987 RID: 6535
	[Token(Token = "0x4001987")]
	[FieldOffset(Offset = "0x0")]
	public static ShipStatus Instance;

	// Token: 0x04001988 RID: 6536
	[Token(Token = "0x4001988")]
	[FieldOffset(Offset = "0x24")]
	public Color CameraColor;

	// Token: 0x04001989 RID: 6537
	[Token(Token = "0x4001989")]
	[FieldOffset(Offset = "0x34")]
	public float MaxLightRadius;

	// Token: 0x0400198A RID: 6538
	[Token(Token = "0x400198A")]
	[FieldOffset(Offset = "0x38")]
	public float MinLightRadius;

	// Token: 0x0400198B RID: 6539
	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x3C")]
	public float MapScale;

	// Token: 0x0400198C RID: 6540
	[Token(Token = "0x400198C")]
	[FieldOffset(Offset = "0x40")]
	public MapBehaviour MapPrefab;

	// Token: 0x0400198D RID: 6541
	[Token(Token = "0x400198D")]
	[FieldOffset(Offset = "0x44")]
	public ExileController ExileCutscenePrefab;

	// Token: 0x0400198E RID: 6542
	[Token(Token = "0x400198E")]
	[FieldOffset(Offset = "0x48")]
	public MeetingCalledAnimation EmergencyOverlay;

	// Token: 0x0400198F RID: 6543
	[Token(Token = "0x400198F")]
	[FieldOffset(Offset = "0x4C")]
	public MeetingCalledAnimation ReportOverlay;

	// Token: 0x04001990 RID: 6544
	[Token(Token = "0x4001990")]
	[FieldOffset(Offset = "0x50")]
	public Sprite MeetingBackground;

	// Token: 0x04001991 RID: 6545
	[Token(Token = "0x4001991")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 InitialSpawnCenter;

	// Token: 0x04001992 RID: 6546
	[Token(Token = "0x4001992")]
	[FieldOffset(Offset = "0x5C")]
	public Vector2 MeetingSpawnCenter;

	// Token: 0x04001993 RID: 6547
	[Token(Token = "0x4001993")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 MeetingSpawnCenter2;

	// Token: 0x04001994 RID: 6548
	[Token(Token = "0x4001994")]
	[FieldOffset(Offset = "0x6C")]
	public float SpawnRadius;

	// Token: 0x04001995 RID: 6549
	[Token(Token = "0x4001995")]
	[FieldOffset(Offset = "0x70")]
	public NormalPlayerTask[] CommonTasks;

	// Token: 0x04001996 RID: 6550
	[Token(Token = "0x4001996")]
	[FieldOffset(Offset = "0x74")]
	public NormalPlayerTask[] LongTasks;

	// Token: 0x04001997 RID: 6551
	[Token(Token = "0x4001997")]
	[FieldOffset(Offset = "0x78")]
	public NormalPlayerTask[] NormalTasks;

	// Token: 0x04001998 RID: 6552
	[Token(Token = "0x4001998")]
	[FieldOffset(Offset = "0x7C")]
	public PlayerTask[] SpecialTasks;

	// Token: 0x04001999 RID: 6553
	[Token(Token = "0x4001999")]
	[FieldOffset(Offset = "0x80")]
	public Transform[] DummyLocations;

	// Token: 0x0400199A RID: 6554
	[Token(Token = "0x400199A")]
	[FieldOffset(Offset = "0x84")]
	public SurvCamera[] AllCameras;

	// Token: 0x0400199B RID: 6555
	[Token(Token = "0x400199B")]
	[FieldOffset(Offset = "0x88")]
	public PlainDoor[] AllDoors;

	// Token: 0x0400199C RID: 6556
	[Token(Token = "0x400199C")]
	[FieldOffset(Offset = "0x8C")]
	public global::Console[] AllConsoles;

	// Token: 0x0400199D RID: 6557
	[Token(Token = "0x400199D")]
	[FieldOffset(Offset = "0x90")]
	public Dictionary<SystemTypes, ISystemType> Systems;

	// Token: 0x0400199E RID: 6558
	[Token(Token = "0x400199E")]
	[FieldOffset(Offset = "0x94")]
	public StringNames[] SystemNames;

	// Token: 0x0400199F RID: 6559
	[Token(Token = "0x400199F")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private IStepWatcher[] <AllStepWatchers>k__BackingField;

	// Token: 0x040019A0 RID: 6560
	[Token(Token = "0x40019A0")]
	[FieldOffset(Offset = "0x9C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private PlainShipRoom[] <AllRooms>k__BackingField;

	// Token: 0x040019A1 RID: 6561
	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Dictionary<SystemTypes, PlainShipRoom> <FastRooms>k__BackingField;

	// Token: 0x040019A2 RID: 6562
	[Token(Token = "0x40019A2")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Vent[] <AllVents>k__BackingField;

	// Token: 0x040019A3 RID: 6563
	[Token(Token = "0x40019A3")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip SabotageSound;

	// Token: 0x040019A4 RID: 6564
	[Token(Token = "0x40019A4")]
	[FieldOffset(Offset = "0xAC")]
	public AnimationClip[] WeaponFires;

	// Token: 0x040019A5 RID: 6565
	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0xB0")]
	public SpriteAnim WeaponsImage;

	// Token: 0x040019A6 RID: 6566
	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0xB4")]
	public AudioClip[] VentMoveSounds;

	// Token: 0x040019A7 RID: 6567
	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0xB8")]
	public AudioClip VentEnterSound;

	// Token: 0x040019A8 RID: 6568
	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0xBC")]
	public AnimationClip HatchActive;

	// Token: 0x040019A9 RID: 6569
	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0xC0")]
	public SpriteAnim Hatch;

	// Token: 0x040019AA RID: 6570
	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0xC4")]
	public ParticleSystem HatchParticles;

	// Token: 0x040019AB RID: 6571
	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0xC8")]
	public AnimationClip ShieldsActive;

	// Token: 0x040019AC RID: 6572
	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0xCC")]
	public SpriteAnim[] ShieldsImages;

	// Token: 0x040019AD RID: 6573
	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0xD0")]
	public SpriteRenderer ShieldBorder;

	// Token: 0x040019AE RID: 6574
	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0xD4")]
	public Sprite ShieldBorderOn;

	// Token: 0x040019AF RID: 6575
	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0xD8")]
	public MedScannerBehaviour MedScanner;

	// Token: 0x040019B0 RID: 6576
	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0xDC")]
	private int WeaponFireIdx;

	// Token: 0x040019B1 RID: 6577
	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0xE0")]
	public float Timer;

	// Token: 0x040019B2 RID: 6578
	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0xE4")]
	public float EmergencyCooldown;

	// Token: 0x040019B3 RID: 6579
	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0xE8")]
	public ShipStatus.MapType Type;

	// Token: 0x040019B4 RID: 6580
	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <BeginCalled>k__BackingField;

	// Token: 0x040019B5 RID: 6581
	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0xF0")]
	private int numScans;

	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	public enum MapType
	{
		// Token: 0x040019B7 RID: 6583
		[Token(Token = "0x40019B7")]
		Ship,
		// Token: 0x040019B8 RID: 6584
		[Token(Token = "0x40019B8")]
		Hq,
		// Token: 0x040019B9 RID: 6585
		[Token(Token = "0x40019B9")]
		Pb
	}

	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	public class SystemTypeComparer : IEqualityComparer<SystemTypes>
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x365C00", Offset = "0x365000", VA = "0x10365C00", Slot = "4")]
		public bool Equals(SystemTypes x, SystemTypes y)
		{
			return default(bool);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x365C10", Offset = "0x365010", VA = "0x10365C10", Slot = "5")]
		public int GetHashCode(SystemTypes obj)
		{
			return 0;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public SystemTypeComparer()
		{
		}

		// Token: 0x040019BA RID: 6586
		[Token(Token = "0x40019BA")]
		[FieldOffset(Offset = "0x348F3485")]
		public static readonly ShipStatus.SystemTypeComparer Instance;
	}

	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060019A5 RID: 6565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x370720", Offset = "0x36FB20", VA = "0x10370720")]
		internal bool <OnEnable>b__70_0(ISystemType i)
		{
			return default(bool);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x370000", Offset = "0x36F400", VA = "0x10370000")]
		internal int <Awake>b__72_0(IStepWatcher s)
		{
			return 0;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x370040", Offset = "0x36F440", VA = "0x10370040")]
		internal bool <Awake>b__72_1(PlainShipRoom p)
		{
			return default(bool);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x370060", Offset = "0x36F460", VA = "0x10370060")]
		internal SystemTypes <Awake>b__72_2(PlainShipRoom d)
		{
			return SystemTypes.Hallway;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x370120", Offset = "0x36F520", VA = "0x10370120")]
		internal bool <CheckEndCriteria>b__91_0(PlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x3708D0", Offset = "0x36FCD0", VA = "0x103708D0")]
		internal void <ReviveEveryone>b__95_0(DeadBody b)
		{
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x370120", Offset = "0x36F520", VA = "0x10370120")]
		internal bool <CheckTaskCompletion>b__96_0(PlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ShipStatus.<>c <>9;

		// Token: 0x040019BC RID: 6588
		[Token(Token = "0x40019BC")]
		[FieldOffset(Offset = "0x4")]
		public static Func<ISystemType, bool> <>9__70_0;

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x8")]
		public static Func<IStepWatcher, int> <>9__72_0;

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0xC")]
		public static Func<PlainShipRoom, bool> <>9__72_1;

		// Token: 0x040019BF RID: 6591
		[Token(Token = "0x40019BF")]
		[FieldOffset(Offset = "0x10")]
		public static Func<PlainShipRoom, SystemTypes> <>9__72_2;

		// Token: 0x040019C0 RID: 6592
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x14")]
		public static Func<PlayerTask, bool> <>9__91_0;

		// Token: 0x040019C1 RID: 6593
		[Token(Token = "0x40019C1")]
		[FieldOffset(Offset = "0x18")]
		public static Action<DeadBody> <>9__95_0;

		// Token: 0x040019C2 RID: 6594
		[Token(Token = "0x40019C2")]
		[FieldOffset(Offset = "0x1C")]
		public static Func<PlayerTask, bool> <>9__96_0;
	}

	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass78_0
	{
		// Token: 0x060019AD RID: 6573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass78_0()
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x371740", Offset = "0x370B40", VA = "0x10371740")]
		internal bool <GetTaskById>b__0(NormalPlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x371740", Offset = "0x370B40", VA = "0x10371740")]
		internal bool <GetTaskById>b__1(NormalPlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x371740", Offset = "0x370B40", VA = "0x10371740")]
		internal bool <GetTaskById>b__2(NormalPlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x040019C3 RID: 6595
		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x8")]
		public byte idx;
	}

	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <PrespawnStep>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <PrespawnStep>d__85(int <>1__state)
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x36D6D0", Offset = "0x36CAD0", VA = "0x1036D6D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B7")]
		private object Current
		{
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x36D6F0", Offset = "0x36CAF0", VA = "0x1036D6F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B8")]
		private object Current
		{
			[Token(Token = "0x60019B6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040019C4 RID: 6596
		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040019C5 RID: 6597
		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;
	}

	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass88_0
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass88_0()
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x3717D0", Offset = "0x370BD0", VA = "0x103717D0")]
		internal bool <AddTasksFromList>b__0(NormalPlayerTask t)
		{
			return default(bool);
		}

		// Token: 0x040019C6 RID: 6598
		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x8")]
		public HashSet<TaskTypes> usedTaskTypes;

		// Token: 0x040019C7 RID: 6599
		[Token(Token = "0x40019C7")]
		[FieldOffset(Offset = "0xC")]
		public Func<NormalPlayerTask, bool> <>9__0;
	}
}
