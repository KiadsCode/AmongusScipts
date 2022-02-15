using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000456 RID: 1110
[Token(Token = "0x2000456")]
public class SurveillanceMinigame : Minigame
{
	// Token: 0x060017AC RID: 6060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x7647C0", Offset = "0x763BC0", VA = "0x107647C0", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x764E30", Offset = "0x764230", VA = "0x10764E30")]
	public void Update()
	{
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x764D20", Offset = "0x764120", VA = "0x10764D20", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0120", Offset = "0xDF520")]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x764CD0", Offset = "0x7640D0", VA = "0x10764CD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE0170", Offset = "0xDF570")]
	private IEnumerator CoAnimateClose()
	{
		return null;
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x764D70", Offset = "0x764170", VA = "0x10764D70", Slot = "7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE01C0", Offset = "0xDF5C0")]
	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x764C80", Offset = "0x764080", VA = "0x10764C80", Slot = "5")]
	public override void Close()
	{
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x764DC0", Offset = "0x7641C0", VA = "0x10764DC0")]
	public void OnDestroy()
	{
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public SurveillanceMinigame()
	{
	}

	// Token: 0x040017B8 RID: 6072
	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x30")]
	public Camera CameraPrefab;

	// Token: 0x040017B9 RID: 6073
	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Viewables;

	// Token: 0x040017BA RID: 6074
	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer[] ViewPorts;

	// Token: 0x040017BB RID: 6075
	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x3C")]
	public TextMeshPro[] SabText;

	// Token: 0x040017BC RID: 6076
	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x40")]
	private PlainShipRoom[] FilteredRooms;

	// Token: 0x040017BD RID: 6077
	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x44")]
	private RenderTexture[] textures;

	// Token: 0x040017BE RID: 6078
	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x48")]
	public MeshRenderer FillQuad;

	// Token: 0x040017BF RID: 6079
	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x4C")]
	public Material DefaultMaterial;

	// Token: 0x040017C0 RID: 6080
	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0x50")]
	public Material StaticMaterial;

	// Token: 0x040017C1 RID: 6081
	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x54")]
	private bool isStatic;

	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x370080", Offset = "0x36F480", VA = "0x10370080")]
		internal bool <Begin>b__10_0(PlainShipRoom i)
		{
			return default(bool);
		}

		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SurveillanceMinigame.<>c <>9;

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x4")]
		public static Func<PlainShipRoom, bool> <>9__10_0;
	}

	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060017B7 RID: 6071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__12(int <>1__state)
		{
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x367520", Offset = "0x366920", VA = "0x10367520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000370")]
		private object Current
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x367940", Offset = "0x366D40", VA = "0x10367940", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000371")]
		private object Current
		{
			[Token(Token = "0x60017BC")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0x10")]
		public SurveillanceMinigame <>4__this;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateClose>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateClose>d__13(int <>1__state)
		{
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x366EE0", Offset = "0x3662E0", VA = "0x10366EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		private object Current
		{
			[Token(Token = "0x60017C0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x367150", Offset = "0x366550", VA = "0x10367150", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		private object Current
		{
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x10")]
		public SurveillanceMinigame <>4__this;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x14")]
		private float <timer>5__2;
	}

	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDestroySelf>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060017C3 RID: 6083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDestroySelf>d__14(int <>1__state)
		{
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x367C80", Offset = "0x367080", VA = "0x10367C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		private object Current
		{
			[Token(Token = "0x60017C6")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x367D50", Offset = "0x367150", VA = "0x10367D50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000375")]
		private object Current
		{
			[Token(Token = "0x60017C8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x10")]
		public SurveillanceMinigame <>4__this;
	}
}
