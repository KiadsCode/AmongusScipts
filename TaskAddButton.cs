using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000510 RID: 1296
[Token(Token = "0x2000510")]
public class TaskAddButton : MonoBehaviour
{
	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B86 RID: 7046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003FD")]
	public RoleBehaviour Role
	{
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x2D8D90", Offset = "0x2D8190", VA = "0x102D8D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x767C30", Offset = "0x767030", VA = "0x10767C30")]
		set
		{
		}
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x767760", Offset = "0x766B60", VA = "0x10767760")]
	private void Awake()
	{
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x7679B0", Offset = "0x766DB0", VA = "0x107679B0")]
	public void Start()
	{
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x767B50", Offset = "0x766F50", VA = "0x10767B50")]
	public void Update()
	{
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x7673D0", Offset = "0x7667D0", VA = "0x107673D0")]
	public void AddTask()
	{
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B8B")]
	[Address(RVA = "0x7677A0", Offset = "0x766BA0", VA = "0x107677A0")]
	private PlayerTask FindTaskByType()
	{
		return null;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B8C")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public TaskAddButton()
	{
	}

	// Token: 0x04001F4B RID: 8011
	[Token(Token = "0x4001F4B")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro Text;

	// Token: 0x04001F4C RID: 8012
	[Token(Token = "0x4001F4C")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer Overlay;

	// Token: 0x04001F4D RID: 8013
	[Token(Token = "0x4001F4D")]
	[FieldOffset(Offset = "0x14")]
	public SpriteRenderer FileImage;

	// Token: 0x04001F4E RID: 8014
	[Token(Token = "0x4001F4E")]
	[FieldOffset(Offset = "0x18")]
	public ButtonRolloverHandler RolloverHandler;

	// Token: 0x04001F4F RID: 8015
	[Token(Token = "0x4001F4F")]
	[FieldOffset(Offset = "0x1C")]
	public Sprite CheckImage;

	// Token: 0x04001F50 RID: 8016
	[Token(Token = "0x4001F50")]
	[FieldOffset(Offset = "0x20")]
	public Sprite ExImage;

	// Token: 0x04001F51 RID: 8017
	[Token(Token = "0x4001F51")]
	[FieldOffset(Offset = "0x24")]
	public PlayerTask MyTask;

	// Token: 0x04001F52 RID: 8018
	[Token(Token = "0x4001F52")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public PassiveButton Button;

	// Token: 0x04001F53 RID: 8019
	[Token(Token = "0x4001F53")]
	[FieldOffset(Offset = "0x2C")]
	private RoleBehaviour role;
}
