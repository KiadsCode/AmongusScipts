using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200009E RID: 158
[Token(Token = "0x200009E")]
public class SafeMinigame : Minigame
{
	// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x57FF50", Offset = "0x57F350", VA = "0x1057FF50")]
	public void OnEnable()
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x57F6E0", Offset = "0x57EAE0", VA = "0x1057F6E0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x57FF70", Offset = "0x57F370", VA = "0x1057FF70")]
	private void UpdateComboInstructions()
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x580220", Offset = "0x57F620", VA = "0x10580220")]
	private void Update()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x57FA00", Offset = "0x57EE00", VA = "0x1057FA00")]
	private void CheckTumblr(float delta, float tumRotZ, int unlatched, int expected)
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x57FED0", Offset = "0x57F2D0", VA = "0x1057FED0", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x57F610", Offset = "0x57EA10", VA = "0x1057F610")]
	private bool AngleNear(float actual, float dir, float expected, float Threshold)
	{
		return default(bool);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x581650", Offset = "0x580A50", VA = "0x10581650")]
	public SafeMinigame()
	{
	}

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x40003E6")]
	private const float LowTumblerThreshold = 5f;

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x40003E7")]
	private const float HighTumblerThreshold = 7f;

	// Token: 0x040003E8 RID: 1000
	[Token(Token = "0x40003E8")]
	private const float ReverseDirThreshold = 0.15f;

	// Token: 0x040003E9 RID: 1001
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshPro ComboText;

	// Token: 0x040003EA RID: 1002
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x34")]
	public Collider2D Tumbler;

	// Token: 0x040003EB RID: 1003
	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x38")]
	public SpriteRenderer TumblerBehind;

	// Token: 0x040003EC RID: 1004
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x3C")]
	public Collider2D Spinner;

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer[] Arrows;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x44")]
	private int[] combo;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x48")]
	private bool[] latched;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x4C")]
	private bool[] vibration;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x50")]
	private Controller controller;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x54")]
	private float lastTumDir;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 lastMouseVec;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x60")]
	private float spinTime;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x64")]
	private float spinDel;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x68")]
	private float spinVel;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x6C")]
	private float reversalBuffer;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip DialTurnSound;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x74")]
	public AudioClip DialGoodSound;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x78")]
	public AudioClip SpinnerStartSound;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x7C")]
	public AudioClip SpinnerFreeSound;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip SpinnerStopSound;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x84")]
	private AudioSource loopSound;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x88")]
	private bool prevHadLeftInput;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x40003FF")]
	[FieldOffset(Offset = "0x89")]
	private bool prevHadRightInput;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x4000400")]
	[FieldOffset(Offset = "0x8C")]
	private Vector2 prevLeftInput;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x4000401")]
	[FieldOffset(Offset = "0x94")]
	private Vector2 prevRightInput;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x4000402")]
	[FieldOffset(Offset = "0x9C")]
	private float leftStickStartAngle;

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000403")]
	[FieldOffset(Offset = "0xA0")]
	public float TopSpinRate;

	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x370A00", Offset = "0x36FE00", VA = "0x10370A00")]
		internal bool <UpdateComboInstructions>b__26_0(bool b)
		{
			return default(bool);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x370A10", Offset = "0x36FE10", VA = "0x10370A10")]
		internal int <UpdateComboInstructions>b__26_1(int c)
		{
			return 0;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x370A00", Offset = "0x36FE00", VA = "0x10370A00")]
		internal bool <Update>b__32_0(bool b)
		{
			return default(bool);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x370A80", Offset = "0x36FE80", VA = "0x10370A80")]
		internal bool <Update>b__32_1(bool b)
		{
			return default(bool);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x370A00", Offset = "0x36FE00", VA = "0x10370A00")]
		internal bool <Update>b__32_2(bool b)
		{
			return default(bool);
		}

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SafeMinigame.<>c <>9;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x4")]
		public static Predicate<bool> <>9__26_0;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x8")]
		public static Func<int, int> <>9__26_1;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0xC")]
		public static Func<bool, bool> <>9__32_0;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<bool> <>9__32_1;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x14")]
		public static Func<bool, bool> <>9__32_2;
	}
}
