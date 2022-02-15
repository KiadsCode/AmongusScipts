using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PowerTools
{
	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x20005E6")]
	[DisallowMultipleComponent]
	[Attribute(Name = "RequireComponent", RVA = "0xE7A30", Offset = "0xE6E30")]
	public class SpriteAnim : SpriteAnimEventHandler
	{
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x17000806")]
		public bool Playing
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x4A8850", Offset = "0x4A7C50", VA = "0x104A8850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x0000B3D0 File Offset: 0x000095D0
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000807")]
		public bool Paused
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x4A7B80", Offset = "0x4A6F80", VA = "0x104A7B80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x4A8960", Offset = "0x4A7D60", VA = "0x104A8960")]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x0000B3E8 File Offset: 0x000095E8
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000808")]
		public float Speed
		{
			[Token(Token = "0x6002609")]
			[Address(RVA = "0x328170", Offset = "0x327570", VA = "0x10328170")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600260A")]
			[Address(RVA = "0x4A84F0", Offset = "0x4A78F0", VA = "0x104A84F0")]
			set
			{
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000809")]
		public float Time
		{
			[Token(Token = "0x600260B")]
			[Address(RVA = "0x4A8870", Offset = "0x4A7C70", VA = "0x104A8870")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600260C")]
			[Address(RVA = "0x4A8550", Offset = "0x4A7950", VA = "0x104A8550")]
			set
			{
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080A")]
		public float NormalizedTime
		{
			[Token(Token = "0x600260D")]
			[Address(RVA = "0x4A8790", Offset = "0x4A7B90", VA = "0x104A8790")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600260E")]
			[Address(RVA = "0x4A8940", Offset = "0x4A7D40", VA = "0x104A8940")]
			set
			{
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080B")]
		public AnimationClip Clip
		{
			[Token(Token = "0x600260F")]
			[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080C")]
		public string ClipName
		{
			[Token(Token = "0x6002610")]
			[Address(RVA = "0x4A8700", Offset = "0x4A7B00", VA = "0x104A8700")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x4A7E10", Offset = "0x4A7210", VA = "0x104A7E10")]
		public void Play([Optional] AnimationClip anim, float speed = 1f)
		{
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x4A8600", Offset = "0x4A7A00", VA = "0x104A8600")]
		public void Stop()
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x4A7DE0", Offset = "0x4A71E0", VA = "0x104A7DE0")]
		public void Pause()
		{
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x4A83C0", Offset = "0x4A77C0", VA = "0x104A83C0")]
		public void Resume()
		{
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x2D5F80", Offset = "0x2D5380", VA = "0x102D5F80")]
		public AnimationClip GetCurrentAnimation()
		{
			return null;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x4A7CF0", Offset = "0x4A70F0", VA = "0x104A7CF0")]
		public bool IsPlaying([Optional] AnimationClip clip)
		{
			return default(bool);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x4A7C10", Offset = "0x4A7010", VA = "0x104A7C10")]
		public bool IsPlaying(string animName)
		{
			return default(bool);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x4A7B80", Offset = "0x4A6F80", VA = "0x104A7B80")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002619")]
		[Address(RVA = "0x4A84F0", Offset = "0x4A78F0", VA = "0x104A84F0")]
		public void SetSpeed(float speed)
		{
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600261A")]
		[Address(RVA = "0x328170", Offset = "0x327570", VA = "0x10328170")]
		public float GetSpeed()
		{
			return 0f;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x600261B")]
		[Address(RVA = "0x4A7AC0", Offset = "0x4A6EC0", VA = "0x104A7AC0")]
		public float GetTime()
		{
			return 0f;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261C")]
		[Address(RVA = "0x4A8550", Offset = "0x4A7950", VA = "0x104A8550")]
		public void SetTime(float time)
		{
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x4A7A10", Offset = "0x4A6E10", VA = "0x104A7A10")]
		public float GetNormalisedTime()
		{
			return 0f;
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261E")]
		[Address(RVA = "0x4A83F0", Offset = "0x4A77F0", VA = "0x104A83F0")]
		public void SetNormalizedTime(float ratio)
		{
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261F")]
		[Address(RVA = "0x4A7860", Offset = "0x4A6C60", VA = "0x104A7860")]
		private void Awake()
		{
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002620")]
		[Address(RVA = "0x4A8250", Offset = "0x4A7650", VA = "0x104A8250")]
		private void Reset()
		{
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002621")]
		[Address(RVA = "0x4A8690", Offset = "0x4A7A90", VA = "0x104A8690")]
		public SpriteAnim()
		{
		}

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string STATE_NAME;

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly string CONTROLLER_PATH;

		// Token: 0x0400259B RID: 9627
		[Token(Token = "0x400259B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AnimationClip m_defaultAnim;

		// Token: 0x0400259C RID: 9628
		[Token(Token = "0x400259C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeAnimatorController m_sharedAnimatorController;

		// Token: 0x0400259D RID: 9629
		[Token(Token = "0x400259D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator m_animator;

		// Token: 0x0400259E RID: 9630
		[Token(Token = "0x400259E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AnimatorOverrideController m_controller;

		// Token: 0x0400259F RID: 9631
		[Token(Token = "0x400259F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpriteAnimNodes m_nodes;

		// Token: 0x040025A0 RID: 9632
		[Token(Token = "0x40025A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> m_clipPairList;

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationClip m_currAnim;

		// Token: 0x040025A2 RID: 9634
		[Token(Token = "0x40025A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_speed;
	}
}
