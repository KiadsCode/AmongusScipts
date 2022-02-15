using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class IntroCutscene : MonoBehaviour
{
	// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x3FB770", Offset = "0x3FAB70", VA = "0x103FB770")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xDECC0", Offset = "0xDE0C0")]
	public IEnumerator CoBegin(List<PlayerControl> yourTeam, bool isImpostor)
	{
		return null;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x3FABF0", Offset = "0x3F9FF0", VA = "0x103FABF0")]
	private void BeginCrewmate(List<PlayerControl> yourTeam)
	{
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x3FB800", Offset = "0x3FAC00", VA = "0x103FB800")]
	private void SetUpRoleText()
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x3FB350", Offset = "0x3FA750", VA = "0x103FB350")]
	private void BeginImpostor(List<PlayerControl> yourTeam)
	{
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x3FB7D0", Offset = "0x3FABD0", VA = "0x103FB7D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public IntroCutscene()
	{
	}

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x0")]
	public static IntroCutscene Instance;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0xC")]
	public TextMeshPro TeamTitle;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x10")]
	public TextMeshPro ImpostorText;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x14")]
	public TextMeshPro YouAreText;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro RoleText;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x1C")]
	public TextMeshPro RoleBlurbText;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x20")]
	public PoolablePlayer PlayerPrefab;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x24")]
	public PoolablePlayer OurCrewmate;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer BackgroundBar;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x2C")]
	public MeshRenderer Foreground;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x30")]
	public FloatRange ForegroundRadius;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x34")]
	public SpriteRenderer FrontMost;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip IntroStinger;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x400074C")]
	private const float BaseY = -1f;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x400074D")]
	private const float ScaleAll = 1f;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x400074E")]
	private const float OffsetWidth = 0.9f;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x400074F")]
	private const float OffsetHeight = 0.15f;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x3C")]
	private DualshockLightManager.LightOverlayHandle overlayHandle;

	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <CoBegin>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
		[DebuggerHidden]
		public <CoBegin>d__18(int <>1__state)
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x5A8D70", Offset = "0x5A8170", VA = "0x105A8D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		private object Current
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x5A95B0", Offset = "0x5A89B0", VA = "0x105A95B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		private object Current
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x10")]
		public IntroCutscene <>4__this;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x14")]
		public bool isImpostor;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerControl> yourTeam;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x1C")]
		private Color <c>5__2;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x2C")]
		private Color <fade>5__3;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x3C")]
		private Color <impColor>5__4;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 <titlePos>5__5;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x58")]
		private float <timer>5__6;
	}
}
