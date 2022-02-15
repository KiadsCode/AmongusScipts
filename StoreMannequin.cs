using System;
using Il2CppDummyDll;
using PowerTools;
using UnityEngine;

// Token: 0x020004E4 RID: 1252
[Token(Token = "0x20004E4")]
public class StoreMannequin : MonoBehaviour
{
	// Token: 0x06001ABF RID: 6847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x75D4F0", Offset = "0x75C8F0", VA = "0x1075D4F0")]
	public void Update()
	{
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x75D570", Offset = "0x75C970", VA = "0x1075D570")]
	public void WearThing(IBuyable product)
	{
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public StoreMannequin()
	{
	}

	// Token: 0x04001AE1 RID: 6881
	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0xC")]
	public HatParent HatSlot;

	// Token: 0x04001AE2 RID: 6882
	[Token(Token = "0x4001AE2")]
	[FieldOffset(Offset = "0x10")]
	public SpriteRenderer SkinSlot;

	// Token: 0x04001AE3 RID: 6883
	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x14")]
	public SpriteAnim PetSlot;

	// Token: 0x04001AE4 RID: 6884
	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x18")]
	public VisorLayer VisorLayer;

	// Token: 0x04001AE5 RID: 6885
	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0x1C")]
	private PetBehaviour currentPet;
}
