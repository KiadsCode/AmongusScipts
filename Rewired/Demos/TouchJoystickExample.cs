using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	[Attribute(Name = "RequireComponent", RVA = "0xE6F40", Offset = "0xE6340")]
	[Attribute(Name = "AddComponentMenu", RVA = "0xE6F40", Offset = "0xE6340")]
	public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0000B298 File Offset: 0x00009498
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F4")]
		public Vector2 position
		{
			[Token(Token = "0x6002547")]
			[Address(RVA = "0x4AFC30", Offset = "0x4AF030", VA = "0x104AFC30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002548")]
			[Address(RVA = "0x4AFC60", Offset = "0x4AF060", VA = "0x104AFC60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			private set
			{
			}
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002549")]
		[Address(RVA = "0x4AF7F0", Offset = "0x4AEBF0", VA = "0x104AF7F0")]
		private void Start()
		{
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254A")]
		[Address(RVA = "0x4AFB90", Offset = "0x4AEF90", VA = "0x104AFB90")]
		private void Update()
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x4AF750", Offset = "0x4AEB50", VA = "0x104AF750")]
		private void Restart()
		{
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x4AF820", Offset = "0x4AEC20", VA = "0x104AF820")]
		private void StoreOrigValues()
		{
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x4AFB30", Offset = "0x4AEF30", VA = "0x104AFB30")]
		private void UpdateValue(Vector3 value)
		{
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x4AFAA0", Offset = "0x4AEEA0", VA = "0x104AFAA0", Slot = "4")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x4AFAF0", Offset = "0x4AEEF0", VA = "0x104AFAF0", Slot = "5")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x4AF910", Offset = "0x4AED10", VA = "0x104AF910", Slot = "6")]
		private void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x4AF6A0", Offset = "0x4AEAA0", VA = "0x104AF6A0")]
		private static bool IsMousePointerId(int id)
		{
			return default(bool);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AF000", VA = "0x104AFC00")]
		public TouchJoystickExample()
		{
		}

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0xC")]
		public bool allowMouseControl;

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40024D8")]
		[FieldOffset(Offset = "0x10")]
		public int radius;

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 origAnchoredPosition;

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 origWorldPosition;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 origScreenResolution;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x30")]
		private ScreenOrientation origScreenOrientation;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x34")]
		[NonSerialized]
		private bool hasFinger;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private int lastFingerId;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private Vector2 <position>k__BackingField;
	}
}
