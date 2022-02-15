using System;
using Hazel;
using Il2CppDummyDll;
using InnerNet;
using UnityEngine;

// Token: 0x02000265 RID: 613
[Token(Token = "0x2000265")]
[DisallowMultipleComponent]
public class CustomNetworkTransform : InnerNetObject
{
	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x5BF860", Offset = "0x5BEC60", VA = "0x105BF860")]
	private void Awake()
	{
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x5C0320", Offset = "0x5BF720", VA = "0x105C0320")]
	public void OnEnable()
	{
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x5C0090", Offset = "0x5BF490", VA = "0x105C0090")]
	public void Halt()
	{
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x5C0480", Offset = "0x5BF880", VA = "0x105C0480")]
	public void RpcSnapTo(Vector2 position)
	{
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x5C0820", Offset = "0x5BFC20", VA = "0x105C0820")]
	public void SnapTo(Vector2 position)
	{
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x5C0850", Offset = "0x5BFC50", VA = "0x105C0850")]
	private void SnapTo(Vector2 position, ushort minSid)
	{
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x5BFC50", Offset = "0x5BF050", VA = "0x105BFC50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x5C0170", Offset = "0x5BF570", VA = "0x105C0170")]
	private bool HasMoved()
	{
		return default(bool);
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x5C0110", Offset = "0x5BF510", VA = "0x105C0110", Slot = "8")]
	public override void HandleRpc(byte callId, MessageReader reader)
	{
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x5C05B0", Offset = "0x5BF9B0", VA = "0x105C05B0", Slot = "9")]
	public override bool Serialize(MessageWriter writer, bool initialState)
	{
		return default(bool);
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x5BF920", Offset = "0x5BED20", VA = "0x105BF920", Slot = "10")]
	public override void Deserialize(MessageReader reader, bool initialState)
	{
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x5C0970", Offset = "0x5BFD70", VA = "0x105C0970")]
	private void WriteVector2(Vector2 vec, MessageWriter writer)
	{
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00005418 File Offset: 0x00003618
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x5C03D0", Offset = "0x5BF7D0", VA = "0x105C03D0")]
	private Vector2 ReadVector2(MessageReader reader)
	{
		return default(Vector2);
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x5C0A10", Offset = "0x5BFE10", VA = "0x105C0A10")]
	public CustomNetworkTransform()
	{
	}

	// Token: 0x04000D83 RID: 3459
	[Token(Token = "0x4000D83")]
	private const float LocalMovementThreshold = 0.0001f;

	// Token: 0x04000D84 RID: 3460
	[Token(Token = "0x4000D84")]
	private const float LocalVelocityThreshold = 0.0001f;

	// Token: 0x04000D85 RID: 3461
	[Token(Token = "0x4000D85")]
	private const float MoveAheadRatio = 0.1f;

	// Token: 0x04000D86 RID: 3462
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x24")]
	private readonly FloatRange XRange;

	// Token: 0x04000D87 RID: 3463
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x28")]
	private readonly FloatRange YRange;

	// Token: 0x04000D88 RID: 3464
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float sendInterval;

	// Token: 0x04000D89 RID: 3465
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float snapThreshold;

	// Token: 0x04000D8A RID: 3466
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float interpolateMovement;

	// Token: 0x04000D8B RID: 3467
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D body;

	// Token: 0x04000D8C RID: 3468
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 targetSyncPosition;

	// Token: 0x04000D8D RID: 3469
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 targetSyncVelocity;

	// Token: 0x04000D8E RID: 3470
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x4C")]
	private ushort lastSequenceId;

	// Token: 0x04000D8F RID: 3471
	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 prevPosSent;

	// Token: 0x04000D90 RID: 3472
	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 prevVelSent;
}
