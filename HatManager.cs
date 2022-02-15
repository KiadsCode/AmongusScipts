using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003E5 RID: 997
[Token(Token = "0x20003E5")]
public class HatManager : DestroyableSingleton<HatManager>
{
	// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x3BA190", Offset = "0x3B9590", VA = "0x103BA190")]
	internal PetData GetPetById(string petId)
	{
		return null;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x3BA550", Offset = "0x3B9950", VA = "0x103BA550")]
	public PetData[] GetUnlockedPets()
	{
		return null;
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x3B9FD0", Offset = "0x3B93D0", VA = "0x103B9FD0")]
	public HatBehaviour GetHatById(string hatId)
	{
		return null;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x3BA350", Offset = "0x3B9750", VA = "0x103BA350")]
	public HatBehaviour[] GetUnlockedHats()
	{
		return null;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x3BA650", Offset = "0x3B9A50", VA = "0x103BA650")]
	public SkinData[] GetUnlockedSkins()
	{
		return null;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x3BA270", Offset = "0x3B9670", VA = "0x103BA270")]
	internal SkinData GetSkinById(string skinId)
	{
		return null;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x3BA930", Offset = "0x3B9D30", VA = "0x103BA930")]
	internal void SetSkin(SpriteRenderer skinRend, string skinId)
	{
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x3BA750", Offset = "0x3B9B50", VA = "0x103BA750")]
	public VisorData[] GetUnlockedVisors()
	{
		return null;
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x3BA850", Offset = "0x3B9C50", VA = "0x103BA850")]
	internal VisorData GetVisorById(string visorId)
	{
		return null;
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x3BA450", Offset = "0x3B9850", VA = "0x103BA450")]
	public NamePlateData[] GetUnlockedNamePlates()
	{
		return null;
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x3BA0B0", Offset = "0x3B94B0", VA = "0x103BA0B0")]
	internal NamePlateData GetNamePlateById(string namePlateId)
	{
		return null;
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x3BAA80", Offset = "0x3B9E80", VA = "0x103BAA80")]
	public HatManager()
	{
	}

	// Token: 0x04001556 RID: 5462
	[Token(Token = "0x4001556")]
	[FieldOffset(Offset = "0x10")]
	public Material DefaultHatShader;

	// Token: 0x04001557 RID: 5463
	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x14")]
	public List<StarBundle> AllStarBundles;

	// Token: 0x04001558 RID: 5464
	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x18")]
	public List<PetData> AllPets;

	// Token: 0x04001559 RID: 5465
	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x1C")]
	public List<HatBehaviour> AllHats;

	// Token: 0x0400155A RID: 5466
	[Token(Token = "0x400155A")]
	[FieldOffset(Offset = "0x20")]
	public List<SkinData> AllSkins;

	// Token: 0x0400155B RID: 5467
	[Token(Token = "0x400155B")]
	[FieldOffset(Offset = "0x24")]
	public List<VisorData> AllVisors;

	// Token: 0x0400155C RID: 5468
	[Token(Token = "0x400155C")]
	[FieldOffset(Offset = "0x28")]
	public List<NamePlateData> AllNamePlates;

	// Token: 0x0400155D RID: 5469
	[Token(Token = "0x400155D")]
	[FieldOffset(Offset = "0x2C")]
	public List<BundleData> AllBundles;

	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x5B4EC0", Offset = "0x5B42C0", VA = "0x105B4EC0")]
		internal bool <GetPetById>b__0(PetData p)
		{
			return default(bool);
		}

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x8")]
		public string petId;
	}

	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x5B4970", Offset = "0x5B3D70", VA = "0x105B4970")]
		internal bool <GetUnlockedPets>b__9_0(PetData h)
		{
			return default(bool);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x5B4890", Offset = "0x5B3C90", VA = "0x105B4890")]
		internal bool <GetUnlockedHats>b__11_0(HatBehaviour h)
		{
			return default(bool);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x5B49E0", Offset = "0x5B3DE0", VA = "0x105B49E0")]
		internal bool <GetUnlockedSkins>b__12_0(SkinData s)
		{
			return default(bool);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x5B4A50", Offset = "0x5B3E50", VA = "0x105B4A50")]
		internal bool <GetUnlockedVisors>b__15_0(VisorData s)
		{
			return default(bool);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5B4900", Offset = "0x5B3D00", VA = "0x105B4900")]
		internal bool <GetUnlockedNamePlates>b__17_0(NamePlateData s)
		{
			return default(bool);
		}

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HatManager.<>c <>9;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x4")]
		public static Func<PetData, bool> <>9__9_0;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HatBehaviour, bool> <>9__11_0;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0xC")]
		public static Func<SkinData, bool> <>9__12_0;

		// Token: 0x04001563 RID: 5475
		[Token(Token = "0x4001563")]
		[FieldOffset(Offset = "0x10")]
		public static Func<VisorData, bool> <>9__15_0;

		// Token: 0x04001564 RID: 5476
		[Token(Token = "0x4001564")]
		[FieldOffset(Offset = "0x14")]
		public static Func<NamePlateData, bool> <>9__17_0;
	}

	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060014C2 RID: 5314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x5B4EC0", Offset = "0x5B42C0", VA = "0x105B4EC0")]
		internal bool <GetHatById>b__0(HatBehaviour h)
		{
			return default(bool);
		}

		// Token: 0x04001565 RID: 5477
		[Token(Token = "0x4001565")]
		[FieldOffset(Offset = "0x8")]
		public string hatId;
	}

	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x5B5490", Offset = "0x5B4890", VA = "0x105B5490")]
		internal bool <GetSkinById>b__0(SkinData s)
		{
			return default(bool);
		}

		// Token: 0x04001566 RID: 5478
		[Token(Token = "0x4001566")]
		[FieldOffset(Offset = "0x8")]
		public string skinId;
	}

	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x5B4EC0", Offset = "0x5B42C0", VA = "0x105B4EC0")]
		internal bool <GetVisorById>b__0(VisorData v)
		{
			return default(bool);
		}

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x8")]
		public string visorId;
	}

	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x5B4EC0", Offset = "0x5B42C0", VA = "0x105B4EC0")]
		internal bool <GetNamePlateById>b__0(NamePlateData n)
		{
			return default(bool);
		}

		// Token: 0x04001568 RID: 5480
		[Token(Token = "0x4001568")]
		[FieldOffset(Offset = "0x8")]
		public string namePlateId;
	}
}
