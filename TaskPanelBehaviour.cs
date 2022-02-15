using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
[Token(Token = "0x20004E5")]
public class TaskPanelBehaviour : DestroyableSingleton<TaskPanelBehaviour>
{
	// Token: 0x06001AC2 RID: 6850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x769650", Offset = "0x768A50", VA = "0x10769650")]
	private void Update()
	{
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x769630", Offset = "0x768A30", VA = "0x10769630")]
	public void ToggleOpen()
	{
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x769C60", Offset = "0x769060", VA = "0x10769C60")]
	public TaskPanelBehaviour()
	{
	}

	// Token: 0x04001AE6 RID: 6886
	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 OpenPosition;

	// Token: 0x04001AE7 RID: 6887
	[Token(Token = "0x4001AE7")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 ClosedPosition;

	// Token: 0x04001AE8 RID: 6888
	[Token(Token = "0x4001AE8")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer background;

	// Token: 0x04001AE9 RID: 6889
	[Token(Token = "0x4001AE9")]
	[FieldOffset(Offset = "0x2C")]
	public SpriteRenderer tab;

	// Token: 0x04001AEA RID: 6890
	[Token(Token = "0x4001AEA")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro TaskText;

	// Token: 0x04001AEB RID: 6891
	[Token(Token = "0x4001AEB")]
	[FieldOffset(Offset = "0x34")]
	public bool open;

	// Token: 0x04001AEC RID: 6892
	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	// Token: 0x04001AED RID: 6893
	[Token(Token = "0x4001AED")]
	[FieldOffset(Offset = "0x3C")]
	public float Duration;
}
