using System;
using Beebyte.Obfuscator;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using UnityEngine;

// Token: 0x020002DD RID: 733
[Token(Token = "0x20002DD")]
[SkipRename]
public class LobbyBehaviour : InnerNetObject
{
	// Token: 0x0600102B RID: 4139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x6E2930", Offset = "0x6E1D30", VA = "0x106E2930")]
	public void Start()
	{
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x6E26C0", Offset = "0x6E1AC0", VA = "0x106E26C0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x6E28B0", Offset = "0x6E1CB0", VA = "0x106E28B0", Slot = "7")]
	public override void OnDestroy()
	{
	}

	// Token: 0x0600102E RID: 4142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x6E2AB0", Offset = "0x6E1EB0", VA = "0x106E2AB0")]
	public LobbyBehaviour()
	{
	}

	// Token: 0x04000FF4 RID: 4084
	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x0")]
	public static LobbyBehaviour Instance;

	// Token: 0x04000FF5 RID: 4085
	[Token(Token = "0x4000FF5")]
	[FieldOffset(Offset = "0x24")]
	public AudioClip SpawnSound;

	// Token: 0x04000FF6 RID: 4086
	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x28")]
	public AnimationClip SpawnInClip;

	// Token: 0x04000FF7 RID: 4087
	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2[] SpawnPositions;

	// Token: 0x04000FF8 RID: 4088
	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip DropShipSound;

	// Token: 0x04000FF9 RID: 4089
	[Token(Token = "0x4000FF9")]
	[FieldOffset(Offset = "0x34")]
	public SkeldShipRoom[] AllRooms;

	// Token: 0x04000FFA RID: 4090
	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x38")]
	private float timer;
}
