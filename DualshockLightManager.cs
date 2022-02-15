using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000384 RID: 900
[Token(Token = "0x2000384")]
public class DualshockLightManager : DestroyableSingleton<DualshockLightManager>
{
	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x00006708 File Offset: 0x00004908
	// (set) Token: 0x06001352 RID: 4946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002D3")]
	public Color BaseColor
	{
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x44AFB0", Offset = "0x44A3B0", VA = "0x1044AFB0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x46E120", Offset = "0x46D520", VA = "0x1046E120")]
		set
		{
		}
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001353")]
	[Address(RVA = "0x46D740", Offset = "0x46CB40", VA = "0x1046D740")]
	public DualshockLightManager.LightOverlayHandle AllocateLight()
	{
		return null;
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x6001354")]
	[Address(RVA = "0x46D8D0", Offset = "0x46CCD0", VA = "0x1046D8D0")]
	private float GetExternalBrightnessFromElectrical()
	{
		return 0f;
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001355")]
	[Address(RVA = "0x46DA20", Offset = "0x46CE20", VA = "0x1046DA20")]
	private void Update()
	{
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001356")]
	[Address(RVA = "0x46D7B0", Offset = "0x46CBB0", VA = "0x1046D7B0")]
	public static void Flash(Color c, float intensity, AudioClip clip)
	{
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x46E030", Offset = "0x46D430", VA = "0x1046E030")]
	public DualshockLightManager()
	{
	}

	// Token: 0x04001398 RID: 5016
	[Token(Token = "0x4001398")]
	private const float lightIntensity = 0.5f;

	// Token: 0x04001399 RID: 5017
	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x10")]
	private Color baseColor;

	// Token: 0x0400139A RID: 5018
	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x20")]
	private Color oldColor;

	// Token: 0x0400139B RID: 5019
	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x30")]
	private List<DualshockLightManager.LightOverlayHandle> overlays;

	// Token: 0x0400139C RID: 5020
	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x34")]
	private List<DualshockLightManager.LightOverlayFlash> lightOverlayFlashes;

	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public class LightOverlayHandle
	{
		// Token: 0x06001358 RID: 4952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x7815B0", Offset = "0x7809B0", VA = "0x107815B0")]
		public void Dispose()
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x781610", Offset = "0x780A10", VA = "0x10781610")]
		public LightOverlayHandle()
		{
		}

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x8")]
		public Color color;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[FieldOffset(Offset = "0x18")]
		public float intensity;
	}

	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public class LightOverlayFlash
	{
		// Token: 0x0600135A RID: 4954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x7812D0", Offset = "0x7806D0", VA = "0x107812D0")]
		public void Init()
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x170002D4")]
		public bool Alive
		{
			[Token(Token = "0x600135B")]
			[Address(RVA = "0x781590", Offset = "0x780990", VA = "0x10781590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x781260", Offset = "0x780660", VA = "0x10781260")]
		public void Dispose()
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x781380", Offset = "0x780780", VA = "0x10781380")]
		public void Update(float deltaTime)
		{
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public LightOverlayFlash()
		{
		}

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[FieldOffset(Offset = "0x8")]
		public DualshockLightManager.LightOverlayHandle handle;

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[FieldOffset(Offset = "0xC")]
		public AudioClip clip;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x10")]
		public float t;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x0")]
		private static float[] samples;
	}
}
