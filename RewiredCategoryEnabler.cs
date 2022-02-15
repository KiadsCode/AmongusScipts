using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x020003C8 RID: 968
[Token(Token = "0x20003C8")]
public class RewiredCategoryEnabler : MonoBehaviour
{
	// Token: 0x0600142E RID: 5166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142E")]
	[Address(RVA = "0x4F8740", Offset = "0x4F7B40", VA = "0x104F8740")]
	private void OnEnable()
	{
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600142F")]
	[Address(RVA = "0x4F86B0", Offset = "0x4F7AB0", VA = "0x104F86B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001430")]
	[Address(RVA = "0x4F87D0", Offset = "0x4F7BD0", VA = "0x104F87D0")]
	private void ReInput_ControllerConnectedEvent(ControllerStatusChangedEventArgs obj)
	{
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001431")]
	[Address(RVA = "0x4F82A0", Offset = "0x4F76A0", VA = "0x104F82A0")]
	public void ApplyDefaultMapState()
	{
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001432")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public RewiredCategoryEnabler()
	{
	}

	// Token: 0x040014B0 RID: 5296
	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0xC")]
	public bool applyDefaultMapState;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x10")]
	public RewiredCategoryEnabler.RewiredCategoryState[] defaultStates;

	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	[Serializable]
	public class RewiredCategoryState
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001433")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public RewiredCategoryState()
		{
		}

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0xC")]
		public bool enabled;
	}
}
