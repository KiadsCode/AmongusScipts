using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003DC RID: 988
[Token(Token = "0x20003DC")]
public class VirtualCursor : MonoBehaviour
{
	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x06001476 RID: 5238 RVA: 0x00006960 File Offset: 0x00004B60
	[Token(Token = "0x170002E1")]
	public static bool CursorActive
	{
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x7B1D70", Offset = "0x7B1170", VA = "0x107B1D70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x7B0D20", Offset = "0x7B0120", VA = "0x107B0D20")]
	private void Awake()
	{
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x7B0F20", Offset = "0x7B0320", VA = "0x107B0F20")]
	private void OnEnable()
	{
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x7B0E60", Offset = "0x7B0260", VA = "0x107B0E60")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x7B13B0", Offset = "0x7B07B0", VA = "0x107B13B0")]
	private void Start()
	{
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147B")]
	[Address(RVA = "0x7B1250", Offset = "0x7B0650", VA = "0x107B1250")]
	public void SetWorldPosition(Vector2 worldPos)
	{
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147C")]
	[Address(RVA = "0x7B1100", Offset = "0x7B0500", VA = "0x107B1100")]
	public void SetScreenPosition(Vector2 screenPos)
	{
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147D")]
	[Address(RVA = "0x7B14D0", Offset = "0x7B08D0", VA = "0x107B14D0")]
	private void Update()
	{
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147E")]
	[Address(RVA = "0x774C60", Offset = "0x774060", VA = "0x10774C60")]
	public VirtualCursor()
	{
	}

	// Token: 0x0400151B RID: 5403
	[Token(Token = "0x400151B")]
	[FieldOffset(Offset = "0xC")]
	public float speed;

	// Token: 0x0400151C RID: 5404
	[Token(Token = "0x400151C")]
	[FieldOffset(Offset = "0x10")]
	private float currentSpeed;

	// Token: 0x0400151D RID: 5405
	[Token(Token = "0x400151D")]
	[FieldOffset(Offset = "0x14")]
	public float acceleration;

	// Token: 0x0400151E RID: 5406
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 screenBounds;

	// Token: 0x0400151F RID: 5407
	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 position;

	// Token: 0x04001520 RID: 5408
	[Token(Token = "0x4001520")]
	private const float deadzone = 0.03f;

	// Token: 0x04001521 RID: 5409
	[Token(Token = "0x4001521")]
	private const float touchpadSensitivity = 4f;

	// Token: 0x04001522 RID: 5410
	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x2C")]
	public Camera cam;

	// Token: 0x04001523 RID: 5411
	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x0")]
	public static Vector2 currentPosition;

	// Token: 0x04001524 RID: 5412
	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x8")]
	public static bool buttonDown;

	// Token: 0x04001525 RID: 5413
	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x9")]
	public static bool joystickMoved;

	// Token: 0x04001526 RID: 5414
	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0xC")]
	public static VirtualCursor instance;

	// Token: 0x04001527 RID: 5415
	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x10")]
	public static int horizontalAxis;

	// Token: 0x04001528 RID: 5416
	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x14")]
	public static int verticalAxis;

	// Token: 0x04001529 RID: 5417
	[Token(Token = "0x4001529")]
	[FieldOffset(Offset = "0x30")]
	private int framesVisible;

	// Token: 0x0400152A RID: 5418
	[Token(Token = "0x400152A")]
	private const int minFramesToAppear = 3;

	// Token: 0x0400152B RID: 5419
	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x34")]
	private SpriteRenderer sr;

	// Token: 0x0400152C RID: 5420
	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 prevTouchPos;

	// Token: 0x0400152D RID: 5421
	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x40")]
	private bool setTouchPos;
}
