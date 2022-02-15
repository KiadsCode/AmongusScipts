using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000391 RID: 913
[Token(Token = "0x2000391")]
public class MouseCursorForConsole : MonoBehaviour
{
	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600137E RID: 4990 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x170002D7")]
	public static bool CursorActive
	{
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x774C90", Offset = "0x774090", VA = "0x10774C90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600137F")]
	[Address(RVA = "0x7745C0", Offset = "0x7739C0", VA = "0x107745C0")]
	private void Awake()
	{
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x7747C0", Offset = "0x773BC0", VA = "0x107747C0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x774700", Offset = "0x773B00", VA = "0x10774700")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x774AD0", Offset = "0x773ED0", VA = "0x10774AD0")]
	private void Start()
	{
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x774980", Offset = "0x773D80", VA = "0x10774980")]
	public void SetScreenPosition(Vector2 screenPos)
	{
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x774BF0", Offset = "0x773FF0", VA = "0x10774BF0")]
	private void Update()
	{
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x774C60", Offset = "0x774060", VA = "0x10774C60")]
	public MouseCursorForConsole()
	{
	}

	// Token: 0x040013BE RID: 5054
	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0xC")]
	public float speed;

	// Token: 0x040013BF RID: 5055
	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x10")]
	private float currentSpeed;

	// Token: 0x040013C0 RID: 5056
	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x14")]
	public float acceleration;

	// Token: 0x040013C1 RID: 5057
	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 screenBounds;

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 position;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x2C")]
	public Camera cam;

	// Token: 0x040013C4 RID: 5060
	[Token(Token = "0x40013C4")]
	[FieldOffset(Offset = "0x0")]
	public static Vector2 currentPosition;

	// Token: 0x040013C5 RID: 5061
	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x8")]
	public static bool buttonDown;

	// Token: 0x040013C6 RID: 5062
	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x9")]
	public static bool joystickMoved;

	// Token: 0x040013C7 RID: 5063
	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0xC")]
	public static MouseCursorForConsole instance;

	// Token: 0x040013C8 RID: 5064
	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x10")]
	public static int horizontalAxis;

	// Token: 0x040013C9 RID: 5065
	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x14")]
	public static int verticalAxis;

	// Token: 0x040013CA RID: 5066
	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x30")]
	private int framesVisible;

	// Token: 0x040013CB RID: 5067
	[Token(Token = "0x40013CB")]
	private const int minFramesToAppear = 3;

	// Token: 0x040013CC RID: 5068
	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x34")]
	private SpriteRenderer sr;
}
