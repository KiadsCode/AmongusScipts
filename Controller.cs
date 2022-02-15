using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BE RID: 190
[Token(Token = "0x20000BE")]
public class Controller
{
	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000473 RID: 1139 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x170000A3")]
	public static Controller.TouchType currentTouchType
	{
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x7FDA70", Offset = "0x7FCE70", VA = "0x107FDA70")]
		get
		{
			return Controller.TouchType.Joystick;
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x7FD6C0", Offset = "0x7FCAC0", VA = "0x107FD6C0")]
	public Controller()
	{
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x7FCBE0", Offset = "0x7FBFE0", VA = "0x107FCBE0")]
	public bool CheckHover(Collider2D coll)
	{
		return default(bool);
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000476 RID: 1142 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x170000A4")]
	public Vector2 HoverPosition
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x7FD9F0", Offset = "0x7FCDF0", VA = "0x107FD9F0")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x7FC950", Offset = "0x7FBD50", VA = "0x107FC950")]
	public DragState CheckDrag(Collider2D coll)
	{
		return DragState.NoTouch;
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000478 RID: 1144 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x170000A5")]
	public bool AnyTouch
	{
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7FD880", Offset = "0x7FCC80", VA = "0x107FD880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000479 RID: 1145 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x170000A6")]
	public bool AnyTouchDown
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7FD7C0", Offset = "0x7FCBC0", VA = "0x107FD7C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600047A RID: 1146 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x170000A7")]
	public bool AnyTouchUp
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x7FD820", Offset = "0x7FCC20", VA = "0x107FD820")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600047B RID: 1147 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x170000A8")]
	public bool FirstDown
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x7FD9B0", Offset = "0x7FCDB0", VA = "0x107FD9B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600047C RID: 1148 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x170000A9")]
	public Vector2 DragPosition
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7FD8E0", Offset = "0x7FCCE0", VA = "0x107FD8E0")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x170000AA")]
	public Vector2 DragStartPosition
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7FD950", Offset = "0x7FCD50", VA = "0x107FD950")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x7FCD50", Offset = "0x7FC150", VA = "0x107FCD50")]
	public void ResetDragPosition()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x7FCCD0", Offset = "0x7FC0D0", VA = "0x107FCCD0")]
	public void ClearTouch()
	{
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000AB")]
	public Camera mainCam
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		set
		{
		}
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x7FCE70", Offset = "0x7FC270", VA = "0x107FCE70")]
	public void Update()
	{
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x7FCDA0", Offset = "0x7FC1A0", VA = "0x107FCDA0")]
	public void Reset()
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x7FCD20", Offset = "0x7FC120", VA = "0x107FCD20")]
	public Controller.TouchState GetTouch(int i)
	{
		return null;
	}

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40004F5")]
	private const int maxTouchCount = 4;

	// Token: 0x040004F6 RID: 1270
	[Token(Token = "0x40004F6")]
	private const int mainTouchIndex = 0;

	// Token: 0x040004F7 RID: 1271
	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x8")]
	public readonly Controller.TouchState[] Touches;

	// Token: 0x040004F8 RID: 1272
	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0xC")]
	private Collider2D amTouching;

	// Token: 0x040004F9 RID: 1273
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x10")]
	private int touchId;

	// Token: 0x040004FA RID: 1274
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 oldMousePos;

	// Token: 0x040004FB RID: 1275
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Camera <mainCam>k__BackingField;

	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public class TouchState
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public TouchState()
		{
		}

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 ScreenDownAt;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 ScreenPosition;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 DownAt;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x28")]
		public bool WasDown;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x0")]
		public bool IsDown;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x0")]
		public bool TouchStart;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x0")]
		public bool TouchEnd;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x0")]
		public DragState dragState;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x30")]
		public bool active;
	}

	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	public enum TouchType
	{
		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		Joystick,
		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		Mouse,
		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		Touch
	}
}
