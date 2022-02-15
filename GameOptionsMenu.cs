using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000463 RID: 1123
[Token(Token = "0x2000463")]
public class GameOptionsMenu : MonoBehaviour
{
	// Token: 0x060017F9 RID: 6137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x3B1640", Offset = "0x3B0A40", VA = "0x103B1640")]
	private void Start()
	{
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x3B17F0", Offset = "0x3B0BF0", VA = "0x103B17F0")]
	private void Update()
	{
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x3B15C0", Offset = "0x3B09C0", VA = "0x103B15C0")]
	private void RefreshChildren()
	{
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x3B1880", Offset = "0x3B0C80", VA = "0x103B1880")]
	private void ValueChanged(OptionBehaviour option)
	{
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x2E74A0", Offset = "0x2E68A0", VA = "0x102E74A0")]
	public GameOptionsMenu()
	{
	}

	// Token: 0x04001810 RID: 6160
	[Token(Token = "0x4001810")]
	[FieldOffset(Offset = "0xC")]
	private GameOptionsData cachedData;

	// Token: 0x04001811 RID: 6161
	[Token(Token = "0x4001811")]
	[FieldOffset(Offset = "0x10")]
	public GameObject ResetButton;

	// Token: 0x04001812 RID: 6162
	[Token(Token = "0x4001812")]
	[FieldOffset(Offset = "0x14")]
	private OptionBehaviour[] Children;
}
