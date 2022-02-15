using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PowerTools
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public class SpriteAnimNodes : MonoBehaviour
	{
		// Token: 0x06002630 RID: 9776 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x4A7260", Offset = "0x4A6660", VA = "0x104A7260")]
		public Vector3 GetPosition(int nodeId, bool ignoredPivot = false)
		{
			return default(Vector3);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x4A6CB0", Offset = "0x4A60B0", VA = "0x104A6CB0")]
		public Vector3 GetLocalPosition(int nodeId, bool ignoredPivot = false)
		{
			return default(Vector3);
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x4A6AB0", Offset = "0x4A5EB0", VA = "0x104A6AB0")]
		public float GetAngle(int nodeId)
		{
			return 0f;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x4A70C0", Offset = "0x4A64C0", VA = "0x104A70C0")]
		public Vector2 GetPositionRaw(int nodeId)
		{
			return default(Vector2);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x4A6A10", Offset = "0x4A5E10", VA = "0x104A6A10")]
		public float GetAngleRaw(int nodeId)
		{
			return 0f;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x4A7510", Offset = "0x4A6910", VA = "0x104A7510")]
		public void Reset()
		{
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x4A76F0", Offset = "0x4A6AF0", VA = "0x104A76F0")]
		public SpriteAnimNodes()
		{
		}

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int NUM_NODES;

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node0;

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node1;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		[SerializeField]
		private Vector2 m_node2;

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node3;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node4;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node5;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node6;

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[HideInInspector]
		private Vector2 m_node7;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		[SerializeField]
		private Vector2 m_node8;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x54")]
		[HideInInspector]
		[SerializeField]
		private Vector2 m_node9;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[HideInInspector]
		private float m_ang0;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private float m_ang1;

		// Token: 0x040025BD RID: 9661
		[Token(Token = "0x40025BD")]
		[FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[SerializeField]
		private float m_ang2;

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[SerializeField]
		private float m_ang3;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		[SerializeField]
		private float m_ang4;

		// Token: 0x040025C0 RID: 9664
		[Token(Token = "0x40025C0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[HideInInspector]
		private float m_ang5;

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[HideInInspector]
		private float m_ang6;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private float m_ang7;

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		[SerializeField]
		private float m_ang8;

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		[SerializeField]
		private float m_ang9;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x84")]
		private SpriteRenderer m_spriteRenderer;
	}
}
