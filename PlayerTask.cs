using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F2 RID: 1266
[Token(Token = "0x20004F2")]
public abstract class PlayerTask : MonoBehaviour
{
	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00008910 File Offset: 0x00006B10
	// (set) Token: 0x06001B0F RID: 6927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F5")]
	public int Index
	{
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x273ED0", Offset = "0x2732D0", VA = "0x10273ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		internal set
		{
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06001B10 RID: 6928 RVA: 0x00008928 File Offset: 0x00006B28
	// (set) Token: 0x06001B11 RID: 6929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F6")]
	public uint Id
	{
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x273EC0", Offset = "0x2732C0", VA = "0x10273EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x273100", Offset = "0x272500", VA = "0x10273100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		internal set
		{
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F7")]
	public PlayerControl Owner
	{
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		internal set
		{
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06001B14 RID: 6932
	[Token(Token = "0x170003F8")]
	public abstract int TaskStep { [Token(Token = "0x6001B14")] get; }

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001B15 RID: 6933
	[Token(Token = "0x170003F9")]
	public abstract bool IsComplete { [Token(Token = "0x6001B15")] get; }

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003FA")]
	public List<Vector2> Locations
	{
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x5098F0", Offset = "0x508CF0", VA = "0x105098F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B17 RID: 6935
	[Token(Token = "0x6001B17")]
	public abstract void Initialize();

	// Token: 0x06001B18 RID: 6936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
	public virtual void OnRemove()
	{
	}

	// Token: 0x06001B19 RID: 6937
	[Token(Token = "0x6001B19")]
	public abstract bool ValidConsole(global::Console console);

	// Token: 0x06001B1A RID: 6938
	[Token(Token = "0x6001B1A")]
	public abstract void Complete();

	// Token: 0x06001B1B RID: 6939
	[Token(Token = "0x6001B1B")]
	public abstract void AppendTaskText(StringBuilder sb);

	// Token: 0x06001B1C RID: 6940 RVA: 0x00008940 File Offset: 0x00006B40
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x5097A0", Offset = "0x508BA0", VA = "0x105097A0")]
	internal static bool TaskIsEmergency(PlayerTask arg)
	{
		return default(bool);
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x509390", Offset = "0x508790", VA = "0x10509390")]
	protected List<global::Console> FindConsoles()
	{
		return null;
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x00008958 File Offset: 0x00006B58
	[Token(Token = "0x6001B1E")]
	public static bool PlayerHasTaskOfType<T>(PlayerControl localPlayer)
	{
		return default(bool);
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x509640", Offset = "0x508A40", VA = "0x10509640")]
	protected List<Vector2> FindValidConsolesPositions()
	{
		return null;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x509590", Offset = "0x508990", VA = "0x10509590")]
	protected global::Console FindSpecialConsole(Func<global::Console, bool> func)
	{
		return null;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x509480", Offset = "0x508880", VA = "0x10509480")]
	protected global::Console FindObjectPos()
	{
		return null;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x509210", Offset = "0x508610", VA = "0x10509210")]
	protected List<Vector2> FindConsolesPos()
	{
		return null;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x287A00", Offset = "0x286E00", VA = "0x10287A00", Slot = "11")]
	public virtual Minigame GetMinigamePrefab()
	{
		return null;
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x00008970 File Offset: 0x00006B70
	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x509130", Offset = "0x508530", VA = "0x10509130")]
	protected static bool AllTasksCompleted(PlayerControl player)
	{
		return default(bool);
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B25")]
	[Address(RVA = "0x5098D0", Offset = "0x508CD0", VA = "0x105098D0")]
	protected PlayerTask()
	{
	}

	// Token: 0x04001B10 RID: 6928
	[Token(Token = "0x4001B10")]
	[FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private int <Index>k__BackingField;

	// Token: 0x04001B11 RID: 6929
	[Token(Token = "0x4001B11")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private uint <Id>k__BackingField;

	// Token: 0x04001B12 RID: 6930
	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	private PlayerControl <Owner>k__BackingField;

	// Token: 0x04001B13 RID: 6931
	[Token(Token = "0x4001B13")]
	[FieldOffset(Offset = "0x18")]
	public SystemTypes StartAt;

	// Token: 0x04001B14 RID: 6932
	[Token(Token = "0x4001B14")]
	[FieldOffset(Offset = "0x1C")]
	public TaskTypes TaskType;

	// Token: 0x04001B15 RID: 6933
	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0x20")]
	public Minigame MinigamePrefab;

	// Token: 0x04001B16 RID: 6934
	[Token(Token = "0x4001B16")]
	[FieldOffset(Offset = "0x24")]
	public bool HasLocation;

	// Token: 0x04001B17 RID: 6935
	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0x25")]
	public bool LocationDirty;
}
