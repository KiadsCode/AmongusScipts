using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020003D8 RID: 984
[Token(Token = "0x20003D8")]
public class VibrationManager : DestroyableSingleton<VibrationManager>
{
	// Token: 0x06001461 RID: 5217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001461")]
	[Address(RVA = "0x7AF6A0", Offset = "0x7AEAA0", VA = "0x107AF6A0")]
	private void Start()
	{
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001462")]
	[Address(RVA = "0x7AF510", Offset = "0x7AE910", VA = "0x107AF510")]
	private void OnEnable()
	{
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001463")]
	[Address(RVA = "0x7AF480", Offset = "0x7AE880", VA = "0x107AF480")]
	private void OnDisable()
	{
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001464")]
	[Address(RVA = "0x7AF5A0", Offset = "0x7AE9A0", VA = "0x107AF5A0")]
	private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
	{
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x7AF3B0", Offset = "0x7AE7B0", VA = "0x107AF3B0")]
	public static void ClearAllVibration()
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x7AF6C0", Offset = "0x7AEAC0", VA = "0x107AF6C0")]
	private void Update()
	{
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x7AF180", Offset = "0x7AE580", VA = "0x107AF180")]
	public static void CancelVibration(AudioClip clipToCancel)
	{
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x107B00C0")]
	public static void Vibrate(float left, float right)
	{
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x7B02F0", Offset = "0x7AF6F0", VA = "0x107B02F0")]
	public static void Vibrate(float left, float right, float duration, VibrationManager.VibrationFalloff falloffType = VibrationManager.VibrationFalloff.None, [Optional] AudioClip sourceClip, bool loopClip = false)
	{
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146A")]
	[Address(RVA = "0x7B0130", Offset = "0x7AF530", VA = "0x107B0130")]
	public static void Vibrate(float intensity, Vector2 worldPosition, float radius)
	{
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146B")]
	[Address(RVA = "0x7AFFE0", Offset = "0x7AF3E0", VA = "0x107AFFE0")]
	public static void Vibrate(float intensity, Vector2 worldPosition, float radius, float duration, VibrationManager.VibrationFalloff falloffType = VibrationManager.VibrationFalloff.None, [Optional] AudioClip sourceClip, bool loopClip = false)
	{
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146C")]
	[Address(RVA = "0x7B0410", Offset = "0x7AF810", VA = "0x107B0410")]
	public VibrationManager()
	{
	}

	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x40014FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<VibrationManager.LocalVibration> currentLocalVibration;

	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x40014FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<VibrationManager.WorldVibration> currentWorldVibration;

	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 singleFrameVibration;

	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool hasFrameVibration;

	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool zeroNextFrame;

	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int numVibrationsActive;

	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 currentVibration;

	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Camera cam;

	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private VibrationManager.WorldVibration tempSingleFrameWorldVibration;

	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x4001507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VibrationManager.WorldVibration tempAmbientSoundVibration;

	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x4001508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float[] samples;

	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	public enum VibrationFalloff
	{
		// Token: 0x0400150A RID: 5386
		[Token(Token = "0x400150A")]
		None,
		// Token: 0x0400150B RID: 5387
		[Token(Token = "0x400150B")]
		Linear,
		// Token: 0x0400150C RID: 5388
		[Token(Token = "0x400150C")]
		InverseLinear
	}

	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	private class LocalVibration
	{
		// Token: 0x0600146E RID: 5230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x12FC100", Offset = "0x12FB500", VA = "0x112FC100")]
		public void Init()
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x170002DF")]
		public bool Alive
		{
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x781590", Offset = "0x780990", VA = "0x10781590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x12FC1B0", Offset = "0x12FB5B0", VA = "0x112FC1B0")]
		public Vector2 UpdateIntensity(float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public LocalVibration()
		{
		}

		// Token: 0x0400150D RID: 5389
		[Token(Token = "0x400150D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 intensity;

		// Token: 0x0400150E RID: 5390
		[Token(Token = "0x400150E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float t;

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float duration;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VibrationManager.VibrationFalloff falloff;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AudioClip clip;

		// Token: 0x04001512 RID: 5394
		[Token(Token = "0x4001512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool loopClip;
	}

	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	private class WorldVibration
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x1302C10", Offset = "0x1302010", VA = "0x11302C10")]
		public void Init()
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x170002E0")]
		public bool Alive
		{
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x1303100", Offset = "0x1302500", VA = "0x11303100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x1302CC0", Offset = "0x13020C0", VA = "0x11302CC0")]
		public Vector2 UpdateIntensity(Vector2 cameraPos, float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public WorldVibration()
		{
		}

		// Token: 0x04001513 RID: 5395
		[Token(Token = "0x4001513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float intensity;

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 location;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float radius;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float t;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float duration;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VibrationManager.VibrationFalloff falloff;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AudioClip clip;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool loopClip;
	}
}
