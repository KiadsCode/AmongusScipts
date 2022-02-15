using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020003C3 RID: 963
[Token(Token = "0x20003C3")]
[Attribute(Name = "RequireComponent", RVA = "0xDE760", Offset = "0xDDB60")]
[Attribute(Name = "RequireComponent", RVA = "0xDE760", Offset = "0xDDB60")]
public class RadialMenu : MonoBehaviour
{
	// Token: 0x06001418 RID: 5144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x4EF8A0", Offset = "0x4EECA0", VA = "0x104EF8A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x4EF850", Offset = "0x4EEC50", VA = "0x104EF850")]
	private void OnDisable()
	{
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141A")]
	[Address(RVA = "0x4EEF30", Offset = "0x4EE330", VA = "0x104EEF30")]
	public void ButtonMouseOver(int which)
	{
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141B")]
	[Address(RVA = "0x4EEEA0", Offset = "0x4EE2A0", VA = "0x104EEEA0")]
	public void ButtonMouseExit()
	{
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141C")]
	[Address(RVA = "0x4EF950", Offset = "0x4EED50", VA = "0x104EF950")]
	private void Update()
	{
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600141D")]
	[Address(RVA = "0x4EF380", Offset = "0x4EE780", VA = "0x104EF380")]
	public RadialMenu.CachedButtonObject[] CreateButtonsForStrings(string[] strings)
	{
		return null;
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600141E")]
	[Address(RVA = "0x4EEFD0", Offset = "0x4EE3D0", VA = "0x104EEFD0")]
	private void CacheButtons(int numButtons)
	{
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x000068A0 File Offset: 0x00004AA0
	[Token(Token = "0x600141F")]
	[Address(RVA = "0x4EF490", Offset = "0x4EE890", VA = "0x104EF490")]
	public float GetButtonMaxStringWidth(int whichButton, float scale)
	{
		return 0f;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001420")]
	[Address(RVA = "0x4ED5F0", Offset = "0x4EC9F0", VA = "0x104ED5F0")]
	private void AlignTexts(string[] strings)
	{
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001421")]
	[Address(RVA = "0x4EDF40", Offset = "0x4ED340", VA = "0x104EDF40")]
	private void BuildMesh(int newRadialDivisions)
	{
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001422")]
	[Address(RVA = "0x4F0040", Offset = "0x4EF440", VA = "0x104F0040")]
	public RadialMenu()
	{
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001424")]
	[Address(RVA = "0x4EEEA0", Offset = "0x4EE2A0", VA = "0x104EEEA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private void <CacheButtons>b__28_1()
	{
	}

	// Token: 0x04001488 RID: 5256
	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0xC")]
	public Mesh mesh;

	// Token: 0x04001489 RID: 5257
	[Token(Token = "0x4001489")]
	[FieldOffset(Offset = "0x10")]
	public GameObject perButtonTemplateObject;

	// Token: 0x0400148A RID: 5258
	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x14")]
	private MeshFilter mf;

	// Token: 0x0400148B RID: 5259
	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x18")]
	private MeshRenderer mr;

	// Token: 0x0400148C RID: 5260
	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x1C")]
	private int radialDivisions;

	// Token: 0x0400148D RID: 5261
	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x20")]
	public float sliceDegreesPerVert;

	// Token: 0x0400148E RID: 5262
	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x24")]
	public float textPositionDistance;

	// Token: 0x0400148F RID: 5263
	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x28")]
	public bool angleText;

	// Token: 0x04001490 RID: 5264
	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x2C")]
	public int testRadialDivs;

	// Token: 0x04001491 RID: 5265
	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock mbp;

	// Token: 0x04001492 RID: 5266
	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x34")]
	private Controller cont;

	// Token: 0x04001493 RID: 5267
	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x38")]
	public Transform arrowRotateHandle;

	// Token: 0x04001494 RID: 5268
	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x3C")]
	public Transform arrowScaleHandle;

	// Token: 0x04001495 RID: 5269
	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x40")]
	public Transform inputGlyph;

	// Token: 0x04001496 RID: 5270
	[Token(Token = "0x4001496")]
	[FieldOffset(Offset = "0x44")]
	public List<RadialMenu.CachedButtonObject> cachedButtons;

	// Token: 0x04001497 RID: 5271
	[Token(Token = "0x4001497")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Vector3[] buttonCenters;

	// Token: 0x04001498 RID: 5272
	[Token(Token = "0x4001498")]
	[FieldOffset(Offset = "0x4C")]
	[NonSerialized]
	public Vector3[] buttonLeftEdges;

	// Token: 0x04001499 RID: 5273
	[Token(Token = "0x4001499")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Vector3[] buttonRightEdges;

	// Token: 0x0400149A RID: 5274
	[Token(Token = "0x400149A")]
	private const float startOffset = -1.5707964f;

	// Token: 0x0400149B RID: 5275
	[Token(Token = "0x400149B")]
	[FieldOffset(Offset = "0x0")]
	public static int instances;

	// Token: 0x0400149C RID: 5276
	[Token(Token = "0x400149C")]
	[FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public int prevSelectedButton;

	// Token: 0x0400149D RID: 5277
	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public int mouseSelectedButton;

	// Token: 0x0400149E RID: 5278
	[Token(Token = "0x400149E")]
	private const int cutoffLength = 12;

	// Token: 0x0400149F RID: 5279
	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x5C")]
	public float horizontalSqueezedWidth;

	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	public struct CachedButtonObject
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x363DD0", Offset = "0x3631D0", VA = "0x10363DD0")]
		public CachedButtonObject(GameObject go, int bIndex)
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x363B80", Offset = "0x362F80", VA = "0x10363B80")]
		public void AddIcon(Sprite iconSprite)
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x363D70", Offset = "0x363170", VA = "0x10363D70")]
		public void ResetIcon()
		{
		}

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x0")]
		public TextMeshPro tr;

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x4")]
		public Transform textHandle;

		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40014A2")]
		[FieldOffset(Offset = "0x8")]
		public RectTransform trRT;

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		[FieldOffset(Offset = "0xC")]
		public GameObject gameObject;

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x10")]
		public PassiveButton button;

		// Token: 0x040014A5 RID: 5285
		[Token(Token = "0x40014A5")]
		[FieldOffset(Offset = "0x14")]
		public ButtonRolloverHandler rolloverHandler;

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0x18")]
		public bool isNew;

		// Token: 0x040014A7 RID: 5287
		[Token(Token = "0x40014A7")]
		[FieldOffset(Offset = "0x1C")]
		public PolygonCollider2D buttonCollider;

		// Token: 0x040014A8 RID: 5288
		[Token(Token = "0x40014A8")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector2> colliderPoints;

		// Token: 0x040014A9 RID: 5289
		[Token(Token = "0x40014A9")]
		[FieldOffset(Offset = "0x24")]
		public int buttonIndex;

		// Token: 0x040014AA RID: 5290
		[Token(Token = "0x40014AA")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer iconSR;

		// Token: 0x040014AB RID: 5291
		[Token(Token = "0x40014AB")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 baseTextPos;

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 buttonDir;
	}

	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass28_0
	{
		// Token: 0x06001428 RID: 5160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass28_0()
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x3711C0", Offset = "0x3705C0", VA = "0x103711C0")]
		internal void <CacheButtons>b__0()
		{
		}

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x8")]
		public int tempButtonCount;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0xC")]
		public RadialMenu <>4__this;
	}
}
