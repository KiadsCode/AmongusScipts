using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x0200036B RID: 875
[Token(Token = "0x200036B")]
public class ConsoleJoystick : MonoBehaviour, IVirtualJoystick
{
	// Token: 0x170002CE RID: 718
	// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000065E8 File Offset: 0x000047E8
	[Token(Token = "0x170002CE")]
	public Vector2 Delta
	{
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x424B50", Offset = "0x423F50", VA = "0x10424B50", Slot = "4")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
	public void ToggleVisuals(bool on)
	{
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x422D60", Offset = "0x422160", VA = "0x10422D60")]
	private void OnEnable()
	{
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x422CD0", Offset = "0x4220D0", VA = "0x10422CD0")]
	private void OnDisable()
	{
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x422FD0", Offset = "0x4223D0", VA = "0x10422FD0")]
	public static void ReapplyCurrentInputState()
	{
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x423480", Offset = "0x422880", VA = "0x10423480")]
	public static void SetMode_MenuAdditive()
	{
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x423200", Offset = "0x422600", VA = "0x10423200")]
	public static void SetMode_Gameplay()
	{
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x4235F0", Offset = "0x4229F0", VA = "0x104235F0")]
	public static void SetMode_Menu()
	{
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x423F30", Offset = "0x423330", VA = "0x10423F30")]
	public static void SetMode_Task()
	{
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x423C60", Offset = "0x423060", VA = "0x10423C60")]
	public static void SetMode_Sabotage()
	{
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x424240", Offset = "0x423640", VA = "0x10424240")]
	public static void SetMode_Vent()
	{
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x423950", Offset = "0x422D50", VA = "0x10423950")]
	public static void SetMode_QuickChat()
	{
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x423150", Offset = "0x422550", VA = "0x10423150")]
	private static void SetMapEnabled(int rewiredCategoryIndex, bool enableMap)
	{
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x424580", Offset = "0x423980", VA = "0x10424580")]
	private void Update()
	{
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x421910", Offset = "0x420D10", VA = "0x10421910")]
	private void HandleHUD()
	{
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public ConsoleJoystick()
	{
	}

	// Token: 0x04001324 RID: 4900
	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0xC")]
	private Vector2 delta;

	// Token: 0x04001325 RID: 4901
	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x0")]
	private static Player player;

	// Token: 0x04001326 RID: 4902
	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x4")]
	private static Rewired.Controller controller;

	// Token: 0x04001327 RID: 4903
	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x8")]
	private static Rewired.Controller prevController;

	// Token: 0x04001328 RID: 4904
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0xC")]
	public static ConsoleJoystick.ConsoleInputState inputState;

	// Token: 0x04001329 RID: 4905
	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x10")]
	private static ConsoleJoystick.ConsoleInputState oldInputState;

	// Token: 0x0400132A RID: 4906
	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x14")]
	private static int highlightedVentIndex;

	// Token: 0x0200036C RID: 876
	[Token(Token = "0x200036C")]
	public enum ConsoleInputState
	{
		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		Gameplay,
		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		Menu,
		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		Task,
		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		Sabotage,
		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		Vent,
		// Token: 0x04001331 RID: 4913
		[Token(Token = "0x4001331")]
		QuickChat
	}
}
