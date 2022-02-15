using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000116 RID: 278
[Token(Token = "0x2000116")]
public class Cosmicube : MonoBehaviour
{
	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000FB")]
	public CosmicubeData Data
	{
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068C")]
	[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
	public void SetData(CosmicubeData d)
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068D")]
	[Address(RVA = "0x802860", Offset = "0x801C60", VA = "0x10802860")]
	public void SetMenu(CosmicubeMenu menu)
	{
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600068E")]
	[Address(RVA = "0x802820", Offset = "0x801C20", VA = "0x10802820")]
	public IEnumerable<PassiveUiElement> GetAllButtons()
	{
		return null;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068F")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public Cosmicube()
	{
	}

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	private CosmicubeData data;
}
