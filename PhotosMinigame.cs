using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
public class PhotosMinigame : Minigame
{
	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060003B1 RID: 945 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x17000090")]
	private bool AllowDraggingPhotos
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x65C790", Offset = "0x65BB90", VA = "0x1065C790")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x65B510", Offset = "0x65A910", VA = "0x1065B510")]
	private List<Sprite> GetUniqueListOfPhotos(int count)
	{
		return null;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x65B0C0", Offset = "0x65A4C0", VA = "0x1065B0C0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x65C440", Offset = "0x65B840", VA = "0x1065C440")]
	private void WriteInitialData()
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x65BDD0", Offset = "0x65B1D0", VA = "0x1065BDD0")]
	private void ReadInitialData()
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x65C060", Offset = "0x65B460", VA = "0x1065C060")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5E70", Offset = "0xE5270")]
	public IEnumerator Start()
	{
		return null;
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x65C110", Offset = "0x65B510", VA = "0x1065C110")]
	private void Update()
	{
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x65B620", Offset = "0x65AA20", VA = "0x1065B620")]
	private void HandleJoystick()
	{
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x65BB00", Offset = "0x65AF00", VA = "0x1065BB00")]
	private void HandleMouse()
	{
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x65B3E0", Offset = "0x65A7E0", VA = "0x1065B3E0")]
	private void FixZ(GamePhotoBehaviour current)
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x65C730", Offset = "0x65BB30", VA = "0x1065C730")]
	public PhotosMinigame()
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x65C0B0", Offset = "0x65B4B0", VA = "0x1065C0B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Update>b__15_0(GamePhotoBehaviour p)
	{
		return default(bool);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x65C0E0", Offset = "0x65B4E0", VA = "0x1065C0E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private bool <Update>b__15_1(GamePhotoBehaviour p)
	{
		return default(bool);
	}

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0x30")]
	public GamePhotoBehaviour[] photos;

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40003A7")]
	[FieldOffset(Offset = "0x34")]
	public Sprite[] PhotoContents;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[FieldOffset(Offset = "0x38")]
	public Collider2D PoolHitbox;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[FieldOffset(Offset = "0x3C")]
	public Transform selectorObject;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40003AA")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer selectorHand;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40003AB")]
	[FieldOffset(Offset = "0x44")]
	private Controller controller;

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40003AC")]
	[FieldOffset(Offset = "0x48")]
	private bool prevHadButton;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40003AD")]
	[FieldOffset(Offset = "0x4C")]
	private int currentlyGrabbedObject;

	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x79A090", Offset = "0x799490", VA = "0x1079A090")]
		internal bool <WriteInitialData>b__0(Sprite s)
		{
			return default(bool);
		}

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x8")]
		public GamePhotoBehaviour p;
	}

	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Start>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Start>d__14(int <>1__state)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x798DB0", Offset = "0x7981B0", VA = "0x10798DB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		private object Current
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x798FE0", Offset = "0x7983E0", VA = "0x10798FE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		private object Current
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x10")]
		public PhotosMinigame <>4__this;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x14")]
		private float <z>5__2;
	}
}
