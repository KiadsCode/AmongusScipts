using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Beebyte.Obfuscator;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using PowerTools;
using TMPro;
using UnityEngine;

// Token: 0x020003FA RID: 1018
[Token(Token = "0x20003FA")]
[SkipRename]
public class PlayerControl : InnerNetObject
{
	// Token: 0x06001500 RID: 5376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x667570", Offset = "0x666970", VA = "0x10667570")]
	public void RpcSetScanner(bool value)
	{
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x667AF0", Offset = "0x666EF0", VA = "0x10667AF0")]
	public void RpcUsePlatform()
	{
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001502")]
	[Address(RVA = "0x6669E0", Offset = "0x665DE0", VA = "0x106669E0")]
	public void RpcPlayAnimation(byte animType)
	{
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001503")]
	[Address(RVA = "0x667710", Offset = "0x666B10", VA = "0x10667710")]
	public void RpcSetStartCounter(int secondsLeft)
	{
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x666890", Offset = "0x665C90", VA = "0x10666890")]
	public void RpcCompleteTask(uint idx)
	{
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001505")]
	[Address(RVA = "0x6679C0", Offset = "0x666DC0", VA = "0x106679C0")]
	public void RpcSyncSettings(GameOptionsData gameOptions)
	{
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x6674D0", Offset = "0x6668D0", VA = "0x106674D0")]
	public void RpcSetRole(RoleTypes roleType)
	{
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001507")]
	[Address(RVA = "0x661C90", Offset = "0x661090", VA = "0x10661C90")]
	public void CmdCheckName(string name)
	{
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001508")]
	[Address(RVA = "0x667250", Offset = "0x666650", VA = "0x10667250")]
	public void RpcSetLevel(uint level)
	{
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001509")]
	[Address(RVA = "0x667790", Offset = "0x666B90", VA = "0x10667790")]
	public void RpcSetVisor(string visorId)
	{
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150A")]
	[Address(RVA = "0x6672F0", Offset = "0x6666F0", VA = "0x106672F0")]
	public void RpcSetNamePlate(string namePlateId)
	{
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150B")]
	[Address(RVA = "0x667670", Offset = "0x666A70", VA = "0x10667670")]
	public void RpcSetSkin(string skinId)
	{
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150C")]
	[Address(RVA = "0x667150", Offset = "0x666550", VA = "0x10667150")]
	public void RpcSetHat(string hatId)
	{
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x667430", Offset = "0x666830", VA = "0x10667430")]
	public void RpcSetPet(string petId)
	{
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150E")]
	[Address(RVA = "0x667390", Offset = "0x666790", VA = "0x10667390")]
	public void RpcSetName(string name)
	{
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600150F")]
	[Address(RVA = "0x661B30", Offset = "0x660F30", VA = "0x10661B30")]
	public void CmdCheckColor(byte bodyColor)
	{
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001510")]
	[Address(RVA = "0x6670B0", Offset = "0x6664B0", VA = "0x106670B0")]
	public void RpcSetColor(byte bodyColor)
	{
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x6001511")]
	[Address(RVA = "0x666D50", Offset = "0x666150", VA = "0x10666D50")]
	public bool RpcSendChat(string chatText)
	{
		return default(bool);
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x6001512")]
	[Address(RVA = "0x666F20", Offset = "0x666320", VA = "0x10666F20")]
	public bool RpcSendQuickChat(string chatText, QuickChatNetData chatData)
	{
		return default(bool);
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001513")]
	[Address(RVA = "0x666C40", Offset = "0x666040", VA = "0x10666C40")]
	public void RpcSendChatNote(byte srcPlayerId, ChatNoteTypes noteType)
	{
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001514")]
	[Address(RVA = "0x661DF0", Offset = "0x6611F0", VA = "0x10661DF0")]
	public void CmdReportDeadBody(GameData.PlayerInfo target)
	{
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001515")]
	[Address(RVA = "0x6678F0", Offset = "0x666CF0", VA = "0x106678F0")]
	public void RpcStartMeeting(GameData.PlayerInfo info)
	{
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001516")]
	[Address(RVA = "0x661BE0", Offset = "0x660FE0", VA = "0x10661BE0")]
	public void CmdCheckMurder(PlayerControl target)
	{
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x661D40", Offset = "0x661140", VA = "0x10661D40")]
	public void CmdCheckProtect(PlayerControl target)
	{
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x666930", Offset = "0x665D30", VA = "0x10666930")]
	public void RpcMurderPlayer(PlayerControl target)
	{
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x666AC0", Offset = "0x665EC0", VA = "0x10666AC0")]
	public void RpcProtectPlayer(PlayerControl target, int colorId)
	{
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151A")]
	[Address(RVA = "0x667830", Offset = "0x666C30", VA = "0x10667830")]
	public void RpcShapeshift(PlayerControl target, bool shouldAnimate)
	{
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x600151B")]
	[Address(RVA = "0x667CA0", Offset = "0x6670A0", VA = "0x10667CA0", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151C")]
	[Address(RVA = "0x662210", Offset = "0x661610", VA = "0x10662210", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151D")]
	[Address(RVA = "0x663B20", Offset = "0x662F20", VA = "0x10663B20", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x0600151E RID: 5406 RVA: 0x00006C00 File Offset: 0x00004E00
	[Token(Token = "0x170002F6")]
	public bool CanMove
	{
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x66AE30", Offset = "0x66A230", VA = "0x1066AE30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F7")]
	public GameData.PlayerOutfit CurrentOutfit
	{
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x66B1C0", Offset = "0x66A5C0", VA = "0x1066B1C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x06001520 RID: 5408 RVA: 0x00006C18 File Offset: 0x00004E18
	// (set) Token: 0x06001521 RID: 5409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002F8")]
	public PlayerOutfitType CurrentOutfitType
	{
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x328160", Offset = "0x327560", VA = "0x10328160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return PlayerOutfitType.Default;
		}
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x327E80", Offset = "0x327280", VA = "0x10327E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x06001522 RID: 5410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F9")]
	public GameData.PlayerInfo Data
	{
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x66B220", Offset = "0x66A620", VA = "0x1066B220")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001523")]
	[Address(RVA = "0x6682A0", Offset = "0x6676A0", VA = "0x106682A0")]
	public void SetKillTimer(float time)
	{
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002FA")]
	public SpriteRenderer MyRend
	{
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x3C16B0", Offset = "0x3C0AB0", VA = "0x103C16B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002FB")]
	public SpriteAnim MyAnim
	{
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x3C16D0", Offset = "0x3C0AD0", VA = "0x103C16D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06001526 RID: 5414 RVA: 0x00006C30 File Offset: 0x00004E30
	// (set) Token: 0x06001527 RID: 5415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002FC")]
	public bool Visible
	{
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x66B300", Offset = "0x66A700", VA = "0x1066B300")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x66B330", Offset = "0x66A730", VA = "0x1066B330")]
		set
		{
		}
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001528")]
	[Address(RVA = "0x660DA0", Offset = "0x6601A0", VA = "0x10660DA0")]
	private void Awake()
	{
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x66A690", Offset = "0x669A90", VA = "0x1066A690")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEE00", Offset = "0xDE200")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600152A")]
	[Address(RVA = "0x661AE0", Offset = "0x660EE0", VA = "0x10661AE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEE50", Offset = "0xDE250")]
	private IEnumerator ClientInitialize()
	{
		return null;
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152B")]
	[Address(RVA = "0x665010", Offset = "0x664410", VA = "0x10665010", Slot = "7")]
	public override void OnDestroy()
	{
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x662BD0", Offset = "0x661FD0", VA = "0x10662BD0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x66ABA0", Offset = "0x669FA0", VA = "0x1066ABA0")]
	public void UseClosest()
	{
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152E")]
	[Address(RVA = "0x665F80", Offset = "0x665380", VA = "0x10665F80")]
	public void ReportClosest()
	{
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152F")]
	[Address(RVA = "0x6651B0", Offset = "0x6645B0", VA = "0x106651B0")]
	public void PlayStepSound()
	{
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001530")]
	[Address(RVA = "0x669B60", Offset = "0x668F60", VA = "0x10669B60")]
	private void SetScanner(bool on, byte cnt)
	{
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x6001531")]
	[Address(RVA = "0x663A90", Offset = "0x662E90", VA = "0x10663A90")]
	public Vector2 GetTruePosition()
	{
		return default(Vector2);
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001532")]
	[Address(RVA = "0x662800", Offset = "0x661C00", VA = "0x10662800")]
	private PlayerControl FindClosestTarget(bool protecting)
	{
		return null;
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001533")]
	[Address(RVA = "0x669E90", Offset = "0x669290", VA = "0x10669E90")]
	public void SetTasks(List<GameData.TaskInfo> tasks)
	{
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001534")]
	[Address(RVA = "0x661EA0", Offset = "0x6612A0", VA = "0x10661EA0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEED0", Offset = "0xDE2D0")]
	private IEnumerator CoSetTasks(List<GameData.TaskInfo> tasks)
	{
		return null;
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001535")]
	[Address(RVA = "0x660A60", Offset = "0x65FE60", VA = "0x10660A60")]
	public void AddSystemTask(SystemTypes system)
	{
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001536")]
	[Address(RVA = "0x665E60", Offset = "0x665260", VA = "0x10665E60")]
	public void RemoveTask(PlayerTask task)
	{
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001537")]
	[Address(RVA = "0x6619D0", Offset = "0x660DD0", VA = "0x106619D0")]
	private void ClearTasks()
	{
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001538")]
	[Address(RVA = "0x665C50", Offset = "0x665050", VA = "0x10665C50")]
	public void RemoveInfected()
	{
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001539")]
	[Address(RVA = "0x662260", Offset = "0x661660", VA = "0x10662260")]
	public void Die(DeathReason reason)
	{
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x666490", Offset = "0x665890", VA = "0x10666490")]
	public void Revive(bool resetRoleIfGhost = true)
	{
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153B")]
	[Address(RVA = "0x665120", Offset = "0x664520", VA = "0x10665120")]
	public void PlayAnimation(byte animType)
	{
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x661F60", Offset = "0x661360", VA = "0x10661F60")]
	public void CompleteTask(uint idx)
	{
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00006C60 File Offset: 0x00004E60
	[Token(Token = "0x600153D")]
	[Address(RVA = "0x660CB0", Offset = "0x6600B0", VA = "0x10660CB0")]
	public bool AllTasksCompleted()
	{
		return default(bool);
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x600153E")]
	[Address(RVA = "0x664E30", Offset = "0x664230", VA = "0x10664E30")]
	public bool MustCleanVent(int ventId)
	{
		return default(bool);
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600153F")]
	[Address(RVA = "0x6693A0", Offset = "0x6687A0", VA = "0x106693A0")]
	private void SetRole(RoleTypes role)
	{
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x662560", Offset = "0x661960", VA = "0x10662560")]
	public void Exiled()
	{
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x6613E0", Offset = "0x6607E0", VA = "0x106613E0")]
	public void CheckName(string name)
	{
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x668580", Offset = "0x667980", VA = "0x10668580")]
	public void SetName(string name, bool dontCensor = false)
	{
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x660EA0", Offset = "0x6602A0", VA = "0x10660EA0")]
	public void CheckColor(byte bodyColor)
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001544")]
	[Address(RVA = "0x6680D0", Offset = "0x6674D0", VA = "0x106680D0")]
	public void SetHatAndVisorAlpha(float a)
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x667F10", Offset = "0x667310", VA = "0x10667F10")]
	public void SetColor(int bodyColor)
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001546")]
	[Address(RVA = "0x6684B0", Offset = "0x6678B0", VA = "0x106684B0")]
	public void SetNamePlate(string namePlateId)
	{
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x669F70", Offset = "0x669370", VA = "0x10669F70")]
	public void SetVisor(string visorId)
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x6683E0", Offset = "0x6677E0", VA = "0x106683E0")]
	public void SetLevel(uint level)
	{
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x669DB0", Offset = "0x6691B0", VA = "0x10669DB0")]
	public void SetSkin(string skinId)
	{
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x668140", Offset = "0x667540", VA = "0x10668140")]
	public void SetHat(string hatId, int colorId)
	{
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x668AE0", Offset = "0x667EE0", VA = "0x10668AE0")]
	public void SetPet(string petId)
	{
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154C")]
	[Address(RVA = "0x668A00", Offset = "0x667E00", VA = "0x10668A00")]
	public void SetPet(string petId, int colorId)
	{
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154D")]
	[Address(RVA = "0x668950", Offset = "0x667D50", VA = "0x10668950")]
	public static void SetPetImage(string petId, int colorId, SpriteRenderer target)
	{
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x668770", Offset = "0x667B70", VA = "0x10668770")]
	public static void SetPetImage(PetData pet, int colorId, SpriteRenderer target)
	{
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154F")]
	[Address(RVA = "0x669CD0", Offset = "0x6690D0", VA = "0x10669CD0")]
	public static void SetSkinImage(string skinId, SpriteRenderer target)
	{
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001550")]
	[Address(RVA = "0x669D80", Offset = "0x669180", VA = "0x10669D80")]
	public static void SetSkinImage(SkinData skin, SpriteRenderer target)
	{
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001551")]
	[Address(RVA = "0x669EF0", Offset = "0x6692F0", VA = "0x10669EF0")]
	public static void SetVisorImage(string visorId, VisorLayer target)
	{
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x6661A0", Offset = "0x6655A0", VA = "0x106661A0")]
	private void ReportDeadBody(GameData.PlayerInfo target)
	{
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x661F00", Offset = "0x661300", VA = "0x10661F00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEF20", Offset = "0xDE320")]
	public IEnumerator CoStartMeeting(GameData.PlayerInfo target)
	{
		return null;
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x6610E0", Offset = "0x6604E0", VA = "0x106610E0")]
	public void CheckMurder(PlayerControl target)
	{
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x6644C0", Offset = "0x6638C0", VA = "0x106644C0")]
	public void MurderPlayer(PlayerControl target)
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x661690", Offset = "0x660A90", VA = "0x10661690")]
	public void CheckProtect(PlayerControl target)
	{
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x665570", Offset = "0x664970", VA = "0x10665570")]
	public void ProtectPlayer(PlayerControl target, int colorId)
	{
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x6690C0", Offset = "0x6684C0", VA = "0x106690C0")]
	public void SetPlayerMaterialColors(Renderer rend)
	{
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x669180", Offset = "0x668580", VA = "0x10669180")]
	public static void SetPlayerMaterialColors(int colorId, Renderer rend)
	{
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x668F60", Offset = "0x668360", VA = "0x10668F60")]
	public static void SetPlayerMaterialColors(Color color, Renderer rend)
	{
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x668BE0", Offset = "0x667FE0", VA = "0x10668BE0")]
	public static void SetPlayerMaterialColorsGrayscale(int colorId, Renderer rend)
	{
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x664410", Offset = "0x663810", VA = "0x10664410")]
	public static void HideCursorTemporarily()
	{
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x667CF0", Offset = "0x6670F0", VA = "0x10667CF0")]
	public void SetAppearanceFromSaveData()
	{
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x66A6E0", Offset = "0x669AE0", VA = "0x1066A6E0")]
	public void ToggleHighlight(bool active, RoleTeamTypes targeterTeam)
	{
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155F")]
	[Address(RVA = "0x66A0F0", Offset = "0x6694F0", VA = "0x1066A0F0")]
	public void Shapeshift(PlayerControl targetPlayer, bool animate)
	{
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001560")]
	[Address(RVA = "0x667C30", Offset = "0x667030", VA = "0x10667C30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDEF70", Offset = "0xDE370")]
	public IEnumerator ScalePlayer(float targetScale, float duration)
	{
		return null;
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001561")]
	[Address(RVA = "0x666B80", Offset = "0x665F80", VA = "0x10666B80")]
	public void RpcRevertShapeshift(bool shouldAnimate)
	{
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x665870", Offset = "0x664C70", VA = "0x10665870")]
	private void RawSetName(string name)
	{
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x6656D0", Offset = "0x664AD0", VA = "0x106656D0")]
	private void RawSetColor(int bodyColor)
	{
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x665B90", Offset = "0x664F90", VA = "0x10665B90")]
	private void RawSetVisor(string visorId)
	{
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x665B60", Offset = "0x664F60", VA = "0x10665B60")]
	private void RawSetSkin(string skinId)
	{
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x6657D0", Offset = "0x664BD0", VA = "0x106657D0")]
	private void RawSetHat(string hatId, int colorId)
	{
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x6659A0", Offset = "0x664DA0", VA = "0x106659A0")]
	private void RawSetPet(string petId, int colorId)
	{
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001568")]
	[Address(RVA = "0x66A5A0", Offset = "0x6699A0", VA = "0x1066A5A0")]
	private void ShowFailedMurder()
	{
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001569")]
	[Address(RVA = "0x665CD0", Offset = "0x6650D0", VA = "0x10665CD0")]
	private void RemoveProtection()
	{
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156A")]
	[Address(RVA = "0x66A830", Offset = "0x669C30", VA = "0x1066A830")]
	private void TurnOnProtection(bool visible, int colorId)
	{
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600156B")]
	[Address(RVA = "0x66ACC0", Offset = "0x66A0C0", VA = "0x1066ACC0")]
	public PlayerControl()
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00006C90 File Offset: 0x00004E90
	[Token(Token = "0x600156D")]
	[Address(RVA = "0x66AB30", Offset = "0x669F30", VA = "0x1066AB30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	internal static Color <SetPlayerMaterialColorsGrayscale>g__ToGrayscale|142_0(Color c)
	{
		return default(Color);
	}

	// Token: 0x040015AF RID: 5551
	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x24")]
	private int LastStartCounter;

	// Token: 0x040015B0 RID: 5552
	[Token(Token = "0x40015B0")]
	[FieldOffset(Offset = "0x28")]
	public byte PlayerId;

	// Token: 0x040015B1 RID: 5553
	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0x2C")]
	public float MaxReportDistance;

	// Token: 0x040015B2 RID: 5554
	[Token(Token = "0x40015B2")]
	[FieldOffset(Offset = "0x30")]
	public bool moveable;

	// Token: 0x040015B3 RID: 5555
	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private PlayerOutfitType <CurrentOutfitType>k__BackingField;

	// Token: 0x040015B4 RID: 5556
	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x38")]
	public bool inVent;

	// Token: 0x040015B5 RID: 5557
	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x39")]
	public bool protectedByGuardianThisRound;

	// Token: 0x040015B6 RID: 5558
	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x3A")]
	public bool shapeshifting;

	// Token: 0x040015B7 RID: 5559
	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x0")]
	public static PlayerControl LocalPlayer;

	// Token: 0x040015B8 RID: 5560
	[Token(Token = "0x40015B8")]
	[FieldOffset(Offset = "0x3C")]
	private GameData.PlayerInfo _cachedData;

	// Token: 0x040015B9 RID: 5561
	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0x40")]
	private bool protectedByGuardian;

	// Token: 0x040015BA RID: 5562
	[Token(Token = "0x40015BA")]
	[FieldOffset(Offset = "0x44")]
	public AudioSource FootSteps;

	// Token: 0x040015BB RID: 5563
	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip KillSfx;

	// Token: 0x040015BC RID: 5564
	[Token(Token = "0x40015BC")]
	[FieldOffset(Offset = "0x4C")]
	public KillAnimation[] KillAnimations;

	// Token: 0x040015BD RID: 5565
	[Token(Token = "0x40015BD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float killTimer;

	// Token: 0x040015BE RID: 5566
	[Token(Token = "0x40015BE")]
	[FieldOffset(Offset = "0x54")]
	public int RemainingEmergencies;

	// Token: 0x040015BF RID: 5567
	[Token(Token = "0x40015BF")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshPro nameText;

	// Token: 0x040015C0 RID: 5568
	[Token(Token = "0x40015C0")]
	[FieldOffset(Offset = "0x5C")]
	public LightSource LightPrefab;

	// Token: 0x040015C1 RID: 5569
	[Token(Token = "0x40015C1")]
	[FieldOffset(Offset = "0x60")]
	private LightSource myLight;

	// Token: 0x040015C2 RID: 5570
	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public Collider2D Collider;

	// Token: 0x040015C3 RID: 5571
	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public PlayerPhysics MyPhysics;

	// Token: 0x040015C4 RID: 5572
	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public CustomNetworkTransform NetTransform;

	// Token: 0x040015C5 RID: 5573
	[Token(Token = "0x40015C5")]
	[FieldOffset(Offset = "0x70")]
	public PetBehaviour CurrentPet;

	// Token: 0x040015C6 RID: 5574
	[Token(Token = "0x40015C6")]
	[FieldOffset(Offset = "0x74")]
	public HatParent HatRenderer;

	// Token: 0x040015C7 RID: 5575
	[Token(Token = "0x40015C7")]
	[FieldOffset(Offset = "0x78")]
	public VisorLayer VisorSlot;

	// Token: 0x040015C8 RID: 5576
	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private SpriteRenderer myRend;

	// Token: 0x040015C9 RID: 5577
	[Token(Token = "0x40015C9")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private SpriteAnim myAnim;

	// Token: 0x040015CA RID: 5578
	[Token(Token = "0x40015CA")]
	[FieldOffset(Offset = "0x84")]
	private Collider2D[] hitBuffer;

	// Token: 0x040015CB RID: 5579
	[Token(Token = "0x40015CB")]
	[FieldOffset(Offset = "0x4")]
	public static GameOptionsData GameOptions;

	// Token: 0x040015CC RID: 5580
	[Token(Token = "0x40015CC")]
	[FieldOffset(Offset = "0x88")]
	public List<PlayerTask> myTasks;

	// Token: 0x040015CD RID: 5581
	[Token(Token = "0x40015CD")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 defaultPlayerScale;

	// Token: 0x040015CE RID: 5582
	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0x98")]
	public SpriteAnim[] ScannerAnims;

	// Token: 0x040015CF RID: 5583
	[Token(Token = "0x40015CF")]
	[FieldOffset(Offset = "0x9C")]
	public SpriteRenderer[] ScannersImages;

	// Token: 0x040015D0 RID: 5584
	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0xA0")]
	public List<RoleEffectAnimation> currentRoleAnimations;

	// Token: 0x040015D1 RID: 5585
	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0xA4")]
	private IUsable closest;

	// Token: 0x040015D2 RID: 5586
	[Token(Token = "0x40015D2")]
	[FieldOffset(Offset = "0xA8")]
	private bool isNew;

	// Token: 0x040015D3 RID: 5587
	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0xA9")]
	public bool isDummy;

	// Token: 0x040015D4 RID: 5588
	[Token(Token = "0x40015D4")]
	[FieldOffset(Offset = "0xAA")]
	public bool notRealPlayer;

	// Token: 0x040015D5 RID: 5589
	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x8")]
	public static List<PlayerControl> AllPlayerControls;

	// Token: 0x040015D6 RID: 5590
	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<Collider2D, IUsable[]> cache;

	// Token: 0x040015D7 RID: 5591
	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0xB0")]
	private List<IUsable> itemsInRange;

	// Token: 0x040015D8 RID: 5592
	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0xB4")]
	private List<IUsable> newItemsInRange;

	// Token: 0x040015D9 RID: 5593
	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0xB8")]
	private byte scannerCount;

	// Token: 0x040015DA RID: 5594
	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0xB9")]
	private bool roleAssigned;

	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	public class ColliderComparer : IEqualityComparer<Collider2D>
	{
		// Token: 0x0600156E RID: 5486 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x600156E")]
		[Address(RVA = "0x78E450", Offset = "0x78D850", VA = "0x1078E450", Slot = "4")]
		public bool Equals(Collider2D x, Collider2D y)
		{
			return default(bool);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x600156F")]
		[Address(RVA = "0x78E4A0", Offset = "0x78D8A0", VA = "0x1078E4A0", Slot = "5")]
		public int GetHashCode(Collider2D obj)
		{
			return 0;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001570")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ColliderComparer()
		{
		}

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x3395338B")]
		public static readonly PlayerControl.ColliderComparer Instance;
	}

	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public class UsableComparer : IEqualityComparer<IUsable>
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6001572")]
		[Address(RVA = "0x2F6850", Offset = "0x2F5C50", VA = "0x102F6850", Slot = "4")]
		public bool Equals(IUsable x, IUsable y)
		{
			return default(bool);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6001573")]
		[Address(RVA = "0x79CB20", Offset = "0x79BF20", VA = "0x1079CB20", Slot = "5")]
		public int GetHashCode(IUsable obj)
		{
			return 0;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public UsableComparer()
		{
		}

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x33D1339F")]
		public static readonly PlayerControl.UsableComparer Instance;
	}

	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Start>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001576 RID: 5494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Start>d__86(int <>1__state)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x799010", Offset = "0x798410", VA = "0x10799010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FD")]
		private object Current
		{
			[Token(Token = "0x6001579")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x7993C0", Offset = "0x7987C0", VA = "0x107993C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FE")]
		private object Current
		{
			[Token(Token = "0x600157B")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl <>4__this;
	}

	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ClientInitialize>d__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ClientInitialize>d__87(int <>1__state)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x791040", Offset = "0x790440", VA = "0x10791040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FF")]
		private object Current
		{
			[Token(Token = "0x600157F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x791230", Offset = "0x790630", VA = "0x10791230", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000300")]
		private object Current
		{
			[Token(Token = "0x6001581")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl <>4__this;
	}

	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass93_0
	{
		// Token: 0x06001582 RID: 5506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass93_0()
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x3CA2C0", Offset = "0x3C96C0", VA = "0x103CA2C0")]
		internal bool <FixedUpdate>b__0(IUsable j)
		{
			return default(bool);
		}

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x8")]
		public IUsable item;
	}

	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSetTasks>d__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSetTasks>d__102(int <>1__state)
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x7943A0", Offset = "0x7937A0", VA = "0x107943A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000301")]
		private object Current
		{
			[Token(Token = "0x6001587")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x794700", Offset = "0x793B00", VA = "0x10794700", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000302")]
		private object Current
		{
			[Token(Token = "0x6001589")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl <>4__this;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x14")]
		public List<GameData.TaskInfo> tasks;
	}

	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass110_0
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass110_0()
		{
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x799E50", Offset = "0x799250", VA = "0x10799E50")]
		internal bool <CompleteTask>b__0(PlayerTask p)
		{
			return default(bool);
		}

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x8")]
		public uint idx;
	}

	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600158D RID: 5517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x7997A0", Offset = "0x798BA0", VA = "0x107997A0")]
		internal bool <MustCleanVent>b__112_0(PlayerTask p)
		{
			return default(bool);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x799950", Offset = "0x798D50", VA = "0x10799950")]
		internal bool <SetRole>b__114_0(PlayerControl pc)
		{
			return default(bool);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x799970", Offset = "0x798D70", VA = "0x10799970")]
		internal void <SetRole>b__114_1(PlayerControl pc)
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x370940", Offset = "0x36FD40", VA = "0x10370940")]
		internal bool <SetRole>b__114_2(GameData.PlayerInfo pcd)
		{
			return default(bool);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x799A50", Offset = "0x798E50", VA = "0x10799A50")]
		internal bool <SetRole>b__114_3(GameData.PlayerInfo pcd)
		{
			return default(bool);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x799B30", Offset = "0x798F30", VA = "0x10799B30")]
		internal PlayerControl <SetRole>b__114_4(GameData.PlayerInfo pcd)
		{
			return null;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x799B50", Offset = "0x798F50", VA = "0x10799B50")]
		internal int <SetRole>b__114_5(PlayerControl pc)
		{
			return 0;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x7996E0", Offset = "0x798AE0", VA = "0x107996E0")]
		internal GameData.PlayerInfo <CoStartMeeting>b__134_0(DeadBody b)
		{
			return null;
		}

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayerControl.<>c <>9;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x4")]
		public static Predicate<PlayerTask> <>9__112_0;

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<PlayerControl, bool> <>9__114_0;

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		[FieldOffset(Offset = "0xC")]
		public static Action<PlayerControl> <>9__114_1;

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x10")]
		public static Func<GameData.PlayerInfo, bool> <>9__114_2;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x14")]
		public static Func<GameData.PlayerInfo, bool> <>9__114_3;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x18")]
		public static Func<GameData.PlayerInfo, PlayerControl> <>9__114_4;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x1C")]
		public static Func<PlayerControl, int> <>9__114_5;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x20")]
		public static Func<DeadBody, GameData.PlayerInfo> <>9__134_0;
	}

	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass116_0
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass116_0()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x799E70", Offset = "0x799270", VA = "0x10799E70")]
		internal bool <CheckName>b__0(GameData.PlayerInfo i)
		{
			return default(bool);
		}

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x8")]
		public PlayerControl <>4__this;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0xC")]
		public string name;
	}

	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass118_0
	{
		// Token: 0x06001598 RID: 5528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass118_0()
		{
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x799EC0", Offset = "0x7992C0", VA = "0x10799EC0")]
		internal bool <CheckColor>b__0(GameData.PlayerInfo p)
		{
			return default(bool);
		}

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x8")]
		public PlayerControl <>4__this;

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		[FieldOffset(Offset = "0xC")]
		public byte bodyColor;
	}

	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoStartMeeting>d__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600159A RID: 5530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoStartMeeting>d__134(int <>1__state)
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x795AC0", Offset = "0x794EC0", VA = "0x10795AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000303")]
		private object Current
		{
			[Token(Token = "0x600159D")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x796570", Offset = "0x795970", VA = "0x10796570", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		private object Current
		{
			[Token(Token = "0x600159F")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x10")]
		public GameData.PlayerInfo target;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x14")]
		public PlayerControl <>4__this;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x18")]
		private bool <isEmergency>5__2;
	}

	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass146_0
	{
		// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass146_0()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x79A240", Offset = "0x799640", VA = "0x1079A240")]
		internal void <Shapeshift>b__0()
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x79A530", Offset = "0x799930", VA = "0x1079A530")]
		internal void <Shapeshift>b__1()
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x79A6D0", Offset = "0x799AD0", VA = "0x1079A6D0")]
		internal void <Shapeshift>b__2()
		{
		}

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x8")]
		public PlayerControl <>4__this;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0xC")]
		public GameData.PlayerOutfit newOutfit;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x10")]
		public GameData.PlayerInfo targetPlayerInfo;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x14")]
		public Action changeOutfit;
	}

	// Token: 0x02000407 RID: 1031
	[Token(Token = "0x2000407")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ScalePlayer>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ScalePlayer>d__147(int <>1__state)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x798700", Offset = "0x797B00", VA = "0x10798700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		private object Current
		{
			[Token(Token = "0x60015A7")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x798A80", Offset = "0x797E80", VA = "0x10798A80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		private object Current
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x10")]
		public PlayerControl <>4__this;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x14")]
		public float targetScale;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x18")]
		public float duration;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x1C")]
		private float <elapsedTime>5__2;
	}
}
