using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x0200036E RID: 878
[Token(Token = "0x200036E")]
public class ControllerButtonBehaviourComplex : MonoBehaviour
{
	// Token: 0x060012F5 RID: 4853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x7F5460", Offset = "0x7F4860", VA = "0x107F5460")]
	private void Start()
	{
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00006600 File Offset: 0x00004800
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x7F5370", Offset = "0x7F4770", VA = "0x107F5370")]
	private bool ConditionMet()
	{
		return default(bool);
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x7F54D0", Offset = "0x7F48D0", VA = "0x107F54D0")]
	private void Update()
	{
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ControllerButtonBehaviourComplex()
	{
	}

	// Token: 0x04001336 RID: 4918
	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0xC")]
	public ControllerButtonBehaviourComplex.ActionTriggerType actionTriggerType;

	// Token: 0x04001337 RID: 4919
	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x10")]
	public ControllerButtonBehaviourComplex.ActionTrigger[] actionTriggers;

	// Token: 0x04001338 RID: 4920
	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x14")]
	public GameObject requiredMenuObject;

	// Token: 0x04001339 RID: 4921
	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x18")]
	private Player player;

	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	public enum ActionTriggerType
	{
		// Token: 0x0400133B RID: 4923
		[Token(Token = "0x400133B")]
		Any,
		// Token: 0x0400133C RID: 4924
		[Token(Token = "0x400133C")]
		All
	}

	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	[Serializable]
	public struct ActionTrigger
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x77FAA0", Offset = "0x77EEA0", VA = "0x1077FAA0")]
		public bool ConditionMet(Player player)
		{
			return default(bool);
		}

		// Token: 0x0400133D RID: 4925
		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x0")]
		public RewiredConstsEnum.Action action;

		// Token: 0x0400133E RID: 4926
		[Token(Token = "0x400133E")]
		[FieldOffset(Offset = "0x4")]
		public ControllerButtonBehaviourComplex.ActionTrigger.ActionType actionType;

		// Token: 0x0400133F RID: 4927
		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x8")]
		public float axisComparisonValue;

		// Token: 0x02000371 RID: 881
		[Token(Token = "0x2000371")]
		public enum ActionType
		{
			// Token: 0x04001341 RID: 4929
			[Token(Token = "0x4001341")]
			Axis_GEqual,
			// Token: 0x04001342 RID: 4930
			[Token(Token = "0x4001342")]
			Axis_LEqual,
			// Token: 0x04001343 RID: 4931
			[Token(Token = "0x4001343")]
			Button_Down
		}
	}
}
