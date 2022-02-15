using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000298 RID: 664
[Token(Token = "0x2000298")]
public class AnnouncementPopUp : MonoBehaviour
{
	// Token: 0x06000EB3 RID: 3763 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x54B1A0", Offset = "0x54A5A0", VA = "0x1054B1A0")]
	private static bool IsSuccess(AnnouncementPopUp.AnnounceState state)
	{
		return default(bool);
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x54B240", Offset = "0x54A640", VA = "0x1054B240")]
	private void OnEnable()
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x54B1D0", Offset = "0x54A5D0", VA = "0x1054B1D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x54ACC0", Offset = "0x54A0C0", VA = "0x1054ACC0")]
	public static void ClearAnnouncementCache()
	{
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x54B4B0", Offset = "0x54A8B0", VA = "0x1054B4B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5230", Offset = "0xE4630")]
	public IEnumerator ShowIfNew([Optional] Action onDismissed)
	{
		return null;
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x54B510", Offset = "0x54A910", VA = "0x1054B510")]
	public void Show()
	{
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x54B150", Offset = "0x54A550", VA = "0x1054B150")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE5280", Offset = "0xE4680")]
	private IEnumerator Init()
	{
		return null;
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x54B590", Offset = "0x54A990", VA = "0x1054B590")]
	private void UpdateAnnounceText()
	{
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x54AD60", Offset = "0x54A160", VA = "0x1054AD60")]
	public void Close()
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x54AF70", Offset = "0x54A370", VA = "0x1054AF70")]
	private void DestroyGOs()
	{
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x54ADB0", Offset = "0x54A1B0", VA = "0x1054ADB0")]
	private string DecomposeAnnouncementText(string text)
	{
		return null;
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x54B300", Offset = "0x54A700", VA = "0x1054B300")]
	private string RecomposeAnnouncementText()
	{
		return null;
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x54B730", Offset = "0x54AB30", VA = "0x1054B730")]
	private void UpdateHyperlinkPositions()
	{
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x54B2C0", Offset = "0x54A6C0", VA = "0x1054B2C0")]
	private void OnNewSelection()
	{
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x54A960", Offset = "0x549D60", VA = "0x1054A960")]
	public void AddSelectableUiForHyperlinks()
	{
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x54B1C0", Offset = "0x54A5C0", VA = "0x1054B1C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x54BBC0", Offset = "0x54AFC0", VA = "0x1054BBC0")]
	public AnnouncementPopUp()
	{
	}

	// Token: 0x04000EC8 RID: 3784
	[Token(Token = "0x4000EC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AnnouncementPopUp.AnnounceState UpdateState;

	// Token: 0x04000EC9 RID: 3785
	[Token(Token = "0x4000EC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public TextMeshPro AnnounceTextMeshPro;

	// Token: 0x04000ECA RID: 3786
	[Token(Token = "0x4000ECA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject ConnectIcon;

	// Token: 0x04000ECB RID: 3787
	[Token(Token = "0x4000ECB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Action OnDismissed;

	// Token: 0x04000ECC RID: 3788
	[Token(Token = "0x4000ECC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0xDD8F0", Offset = "0xDCCF0")]
	public UiElement BackButton;

	// Token: 0x04000ECD RID: 3789
	[Token(Token = "0x4000ECD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private List<ITextPart> textConstituents;

	// Token: 0x04000ECE RID: 3790
	[Token(Token = "0x4000ECE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<SelectableHyperLink> selectableHyperLinks;

	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	public enum AnnounceState
	{
		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		NotStarted,
		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		Fetching,
		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		Failed,
		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		Success,
		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		Cached
	}

	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <ShowIfNew>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <ShowIfNew>d__12(int <>1__state)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x3C9B80", Offset = "0x3C8F80", VA = "0x103C9B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023B")]
		private object Current
		{
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x3C9C90", Offset = "0x3C9090", VA = "0x103C9C90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023C")]
		private object Current
		{
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnnouncementPopUp <>4__this;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Action onDismissed;
	}

	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <Init>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000ECB RID: 3787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <Init>d__14(int <>1__state)
		{
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x3C7F00", Offset = "0x3C7300", VA = "0x103C7F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023D")]
		private object Current
		{
			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x3C8830", Offset = "0x3C7C30", VA = "0x103C8830", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023E")]
		private object Current
		{
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnnouncementPopUp <>4__this;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UnityWebRequest <request>5__2;
	}
}
