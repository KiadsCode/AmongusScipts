using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200008B RID: 139
[Token(Token = "0x200008B")]
public class RecordsMinigame : Minigame
{
	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x4F3640", Offset = "0x4F2A40", VA = "0x104F3640", Slot = "4")]
	public override void Begin(PlayerTask task)
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x4F3A10", Offset = "0x4F2E10", VA = "0x104F3A10", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5840", Offset = "0xE4C40")]
	protected override IEnumerator CoAnimateOpen()
	{
		return null;
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x4F3A60", Offset = "0x4F2E60", VA = "0x104F3A60", Slot = "7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5890", Offset = "0xE4C90")]
	protected override IEnumerator CoDestroySelf()
	{
		return null;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x4F3F00", Offset = "0x4F3300", VA = "0x104F3F00")]
	public void PlaceBook()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x4F3B00", Offset = "0x4F2F00", VA = "0x104F3B00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE58E0", Offset = "0xE4CE0")]
	private IEnumerator CoSlideBook()
	{
		return null;
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x4F3BA0", Offset = "0x4F2FA0", VA = "0x104F3BA0")]
	public void FileDocument()
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x4F3E80", Offset = "0x4F3280", VA = "0x104F3E80")]
	private bool MarkConsoleFinished()
	{
		return default(bool);
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x4F3AB0", Offset = "0x4F2EB0", VA = "0x104F3AB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5930", Offset = "0xE4D30")]
	private IEnumerator CoOpenDrawer()
	{
		return null;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x4F3B50", Offset = "0x4F2F50", VA = "0x104F3B50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5980", Offset = "0xE4D80")]
	private IEnumerator CoSlideFolder()
	{
		return null;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x4F3CE0", Offset = "0x4F30E0", VA = "0x104F3CE0")]
	public void GrabFolder(SpriteRenderer folder)
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x3AC2A0", Offset = "0x3AB6A0", VA = "0x103AC2A0")]
	public RecordsMinigame()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x4F4020", Offset = "0x4F3420", VA = "0x104F4020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD9C0", Offset = "0xDCDC0")]
	[DebuggerHidden]
	private IEnumerator <>n__0()
	{
		return null;
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x4F4030", Offset = "0x4F3430", VA = "0x104F4030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD9C0", Offset = "0xDCDC0")]
	[DebuggerHidden]
	private IEnumerator <>n__1()
	{
		return null;
	}

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FoldersContent;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer[] Folders;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DrawerContent;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Drawer;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x40")]
	public SpriteRenderer DrawerFolder;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ShelfContent;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x48")]
	public SpriteRenderer[] Books;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x4C")]
	public Sprite[] BookCovers;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x50")]
	private SpriteRenderer targetBook;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x54")]
	public AudioClip recordFilePlace;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x58")]
	public AudioClip recordBookPlace;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x5C")]
	public AudioClip grabDocument;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x60")]
	public AudioClip drawerOpen;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x64")]
	public AudioClip drawerClose;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x68")]
	public Transform bookInputPrompt;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x6C")]
	public ControllerButtonBehaviourComplex slideFolderHotkey;

	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoAnimateOpen>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoAnimateOpen>d__17(int <>1__state)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x367970", Offset = "0x366D70", VA = "0x10367970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		private object Current
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x367A30", Offset = "0x366E30", VA = "0x10367A30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		private object Current
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x10")]
		public RecordsMinigame <>4__this;
	}

	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoDestroySelf>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoDestroySelf>d__18(int <>1__state)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x367D80", Offset = "0x367180", VA = "0x10367D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		private object Current
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x367F30", Offset = "0x367330", VA = "0x10367F30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		private object Current
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x10")]
		public RecordsMinigame <>4__this;
	}

	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSlideBook>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSlideBook>d__20(int <>1__state)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x369D80", Offset = "0x369180", VA = "0x10369D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		private object Current
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x369F10", Offset = "0x369310", VA = "0x10369F10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		private object Current
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x10")]
		public RecordsMinigame <>4__this;
	}

	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoOpenDrawer>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600037D RID: 893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoOpenDrawer>d__23(int <>1__state)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x368080", Offset = "0x367480", VA = "0x10368080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		private object Current
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x3681E0", Offset = "0x3675E0", VA = "0x103681E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		private object Current
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x10")]
		public RecordsMinigame <>4__this;
	}

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoSlideFolder>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000383 RID: 899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoSlideFolder>d__24(int <>1__state)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x369F40", Offset = "0x369340", VA = "0x10369F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		private object Current
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x36A080", Offset = "0x369480", VA = "0x1036A080", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		private object Current
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x10")]
		public RecordsMinigame <>4__this;
	}
}
