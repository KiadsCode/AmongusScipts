using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x02000200 RID: 512
[Token(Token = "0x2000200")]
public class KeyboardJoystick : MonoBehaviour, IVirtualJoystick
{
	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x170001B3")]
	public Vector2 Delta
	{
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x424B50", Offset = "0x423F50", VA = "0x10424B50", Slot = "4")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
	public void ToggleVisuals(bool on)
	{
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x6D58D0", Offset = "0x6D4CD0", VA = "0x106D58D0")]
	private void UpdateTouchMovement()
	{
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x6D5C00", Offset = "0x6D5000", VA = "0x106D5C00")]
	private void Update()
	{
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x6D5470", Offset = "0x6D4870", VA = "0x106D5470")]
	private static void HandleHud()
	{
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x6D6090", Offset = "0x6D5490", VA = "0x106D6090")]
	public KeyboardJoystick()
	{
	}

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0xC")]
	private Vector2 del;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x0")]
	private static Player player;

	// Token: 0x04000B89 RID: 2953
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x14")]
	private global::Controller myController;

	// Token: 0x04000B8A RID: 2954
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x18")]
	private Collider2D[] hitBuffer;

	// Token: 0x04000B8B RID: 2955
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x1C")]
	private int touchId;

	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5B4AC0", Offset = "0x5B3EC0", VA = "0x105B4AC0")]
		internal void <HandleHud>b__10_0(MapBehaviour m)
		{
		}

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly KeyboardJoystick.<>c <>9;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x4")]
		public static Action<MapBehaviour> <>9__10_0;
	}
}
