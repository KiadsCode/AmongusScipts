using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
public class VirtualJoystick : MonoBehaviour, IVirtualJoystick
{
	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00004B18 File Offset: 0x00002D18
	// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001B5")]
	public Vector2 Delta
	{
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x7B25D0", Offset = "0x7B19D0", VA = "0x107B25D0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x34DD20", Offset = "0x34D120", VA = "0x1034DD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private set
		{
		}
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x7B21F0", Offset = "0x7B15F0", VA = "0x107B21F0", Slot = "5")]
	public void ToggleVisuals(bool on)
	{
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x7B1E70", Offset = "0x7B1270", VA = "0x107B1E70", Slot = "6")]
	protected virtual void FixedUpdate()
	{
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x7B22D0", Offset = "0x7B16D0", VA = "0x107B22D0", Slot = "7")]
	public virtual void UpdateJoystick(FingerBehaviour finger, Vector2 velocity, bool syncFinger)
	{
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x7B2570", Offset = "0x7B1970", VA = "0x107B2570")]
	public VirtualJoystick()
	{
	}

	// Token: 0x04000B92 RID: 2962
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0xC")]
	public float InnerRadius;

	// Token: 0x04000B93 RID: 2963
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x10")]
	public float OuterRadius;

	// Token: 0x04000B94 RID: 2964
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x14")]
	public CircleCollider2D Outer;

	// Token: 0x04000B95 RID: 2965
	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer Inner;

	// Token: 0x04000B96 RID: 2966
	[Token(Token = "0x4000B96")]
	[FieldOffset(Offset = "0x1C")]
	public SpriteRenderer[] AllSprites;

	// Token: 0x04000B97 RID: 2967
	[Token(Token = "0x4000B97")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private Vector2 <Delta>k__BackingField;

	// Token: 0x04000B98 RID: 2968
	[Token(Token = "0x4000B98")]
	[FieldOffset(Offset = "0x28")]
	private Controller myController;

	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x1302290", Offset = "0x1301690", VA = "0x11302290")]
		internal void <ToggleVisuals>b__0(SpriteRenderer s)
		{
		}

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x8")]
		public bool on;
	}
}
