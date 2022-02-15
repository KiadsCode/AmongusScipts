using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Data
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x000093D8 File Offset: 0x000075D8
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000625")]
		public bool IsEnabled
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x2D4E40", Offset = "0x2D4240", VA = "0x102D4E40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x2D4E60", Offset = "0x2D4260", VA = "0x102D4E60")]
			set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x000093F0 File Offset: 0x000075F0
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public bool LoadDataOnStart
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x2D4E30", Offset = "0x2D4230", VA = "0x102D4E30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x2D4E50", Offset = "0x2D4250", VA = "0x102D4E50")]
			set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00009408 File Offset: 0x00007608
		// (set) Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public bool LoadJoystickAssignments
		{
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x324FB0", Offset = "0x3243B0", VA = "0x10324FB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EEB")]
			[Address(RVA = "0x324FC0", Offset = "0x3243C0", VA = "0x10324FC0")]
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00009420 File Offset: 0x00007620
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000628")]
		public bool LoadKeyboardAssignments
		{
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0x4BF0D0", Offset = "0x4BE4D0", VA = "0x104BF0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EED")]
			[Address(RVA = "0x4BF430", Offset = "0x4BE830", VA = "0x104BF430")]
			set
			{
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00009438 File Offset: 0x00007638
		// (set) Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000629")]
		public bool LoadMouseAssignments
		{
			[Token(Token = "0x6001EEE")]
			[Address(RVA = "0x274CF0", Offset = "0x2740F0", VA = "0x10274CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x274D00", Offset = "0x274100", VA = "0x10274D00")]
			set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		public string PlayerPrefsKeyPrefix
		{
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x273EA0", Offset = "0x2732A0", VA = "0x10273EA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x273EE0", Offset = "0x2732E0", VA = "0x10273EE0")]
			set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062B")]
		private string playerPrefsKey_controllerAssignments
		{
			[Token(Token = "0x6001EF2")]
			[Address(RVA = "0x4BF3E0", Offset = "0x4BE7E0", VA = "0x104BF3E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x1700062C")]
		private bool loadControllerAssignments
		{
			[Token(Token = "0x6001EF3")]
			[Address(RVA = "0x4BF3C0", Offset = "0x4BE7C0", VA = "0x104BF3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062D")]
		private List<int> allActionIds
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x4BF1E0", Offset = "0x4BE5E0", VA = "0x104BF1E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700062E")]
		private string allActionIdsString
		{
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x4BF0E0", Offset = "0x4BE4E0", VA = "0x104BF0E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x4BEDD0", Offset = "0x4BE1D0", VA = "0x104BEDD0", Slot = "21")]
		public override void Save()
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x4BDE10", Offset = "0x4BD210", VA = "0x104BDE10", Slot = "22")]
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x4BDEC0", Offset = "0x4BD2C0", VA = "0x104BDEC0", Slot = "23")]
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x4BECF0", Offset = "0x4BE0F0", VA = "0x104BECF0", Slot = "24")]
		public override void SavePlayerData(int playerId)
		{
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x4BE5C0", Offset = "0x4BD9C0", VA = "0x104BE5C0", Slot = "25")]
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x4BD330", Offset = "0x4BC730", VA = "0x104BD330", Slot = "16")]
		public override void Load()
		{
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x4BB3D0", Offset = "0x4BA7D0", VA = "0x104BB3D0", Slot = "17")]
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x4BB470", Offset = "0x4BA870", VA = "0x104BB470", Slot = "18")]
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x4BD260", Offset = "0x4BC660", VA = "0x104BD260", Slot = "19")]
		public override void LoadPlayerData(int playerId)
		{
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x4BBB90", Offset = "0x4BAF90", VA = "0x104BBB90", Slot = "20")]
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x4BD4D0", Offset = "0x4BC8D0", VA = "0x104BD4D0", Slot = "28")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x4BD3B0", Offset = "0x4BC7B0", VA = "0x104BD3B0", Slot = "29")]
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x4BD4A0", Offset = "0x4BC8A0", VA = "0x104BD4A0", Slot = "32")]
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x4BD470", Offset = "0x4BC870", VA = "0x104BD470", Slot = "30")]
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x4BDF50", Offset = "0x4BD350", VA = "0x104BDF50", Slot = "26")]
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x4BB4F0", Offset = "0x4BA8F0", VA = "0x104BB4F0", Slot = "27")]
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x4BAF30", Offset = "0x4BA330", VA = "0x104BAF30")]
		private int LoadAll()
		{
			return 0;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x4BCFC0", Offset = "0x4BC3C0", VA = "0x104BCFC0")]
		private int LoadPlayerDataNow(int playerId)
		{
			return 0;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x4BD030", Offset = "0x4BC430", VA = "0x104BD030")]
		private int LoadPlayerDataNow(Player player)
		{
			return 0;
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x4BAD30", Offset = "0x4BA130", VA = "0x104BAD30")]
		private int LoadAllJoystickCalibrationData()
		{
			return 0;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x4BCA70", Offset = "0x4BBE70", VA = "0x104BCA70")]
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			return 0;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x4BC990", Offset = "0x4BBD90", VA = "0x104BC990")]
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return 0;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x4BCAF0", Offset = "0x4BBEF0", VA = "0x104BCAF0")]
		private int LoadJoystickData(int joystickId)
		{
			return 0;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x4BB380", Offset = "0x4BA780", VA = "0x104BB380")]
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x4BB360", Offset = "0x4BA760", VA = "0x104BB360")]
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x4BB710", Offset = "0x4BAB10", VA = "0x104BB710")]
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			return 0;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x4BB5A0", Offset = "0x4BA9A0", VA = "0x104BB5A0")]
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x4BBCC0", Offset = "0x4BB0C0", VA = "0x104BBCC0")]
		private int LoadInputBehaviors(int playerId)
		{
			return 0;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x4BBA00", Offset = "0x4BAE00", VA = "0x104BBA00")]
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			return 0;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x4BBAC0", Offset = "0x4BAEC0", VA = "0x104BBAC0")]
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			return 0;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x4BB290", Offset = "0x4BA690", VA = "0x104BB290")]
		private bool LoadControllerAssignmentsNow()
		{
			return default(bool);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x4BCCD0", Offset = "0x4BC0D0", VA = "0x104BCCD0")]
		private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x4BBF00", Offset = "0x4BB300", VA = "0x104BBF00")]
		private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			return default(bool);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x4BB0F0", Offset = "0x4BA4F0", VA = "0x104BB0F0")]
		private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			return null;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x4BBEA0", Offset = "0x4BB2A0", VA = "0x104BBEA0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0xE21C0", Offset = "0xE15C0")]
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			return null;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x4BD7D0", Offset = "0x4BCBD0", VA = "0x104BD7D0")]
		private void SaveAll()
		{
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x4BEB00", Offset = "0x4BDF00", VA = "0x104BEB00")]
		private void SavePlayerDataNow(int playerId)
		{
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x4BEB80", Offset = "0x4BDF80", VA = "0x104BEB80")]
		private void SavePlayerDataNow(Player player)
		{
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x4BD610", Offset = "0x4BCA10", VA = "0x104BD610")]
		private void SaveAllJoystickCalibrationData()
		{
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x4BE890", Offset = "0x4BDC90", VA = "0x104BE890")]
		private void SaveJoystickCalibrationData(int joystickId)
		{
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x4BE840", Offset = "0x4BDC40", VA = "0x104BE840")]
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x4BE940", Offset = "0x4BDD40", VA = "0x104BE940")]
		private void SaveJoystickData(int joystickId)
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x4BDDC0", Offset = "0x4BD1C0", VA = "0x104BDDC0")]
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x4BDD90", Offset = "0x4BD190", VA = "0x104BDD90")]
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x4BE310", Offset = "0x4BD710", VA = "0x104BE310")]
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x4BE200", Offset = "0x4BD600", VA = "0x104BE200")]
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x4BDFD0", Offset = "0x4BD3D0", VA = "0x104BDFD0")]
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x4BE710", Offset = "0x4BDB10", VA = "0x104BE710")]
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x4BE4A0", Offset = "0x4BD8A0", VA = "0x104BE4A0")]
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x4BE580", Offset = "0x4BD980", VA = "0x104BE580")]
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x4BD970", Offset = "0x4BCD70", VA = "0x104BD970")]
		private bool SaveControllerAssignments()
		{
			return default(bool);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x4B9A70", Offset = "0x4B8E70", VA = "0x104B9A70")]
		private bool ControllerAssignmentSaveDataExists()
		{
			return default(bool);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x4B9D00", Offset = "0x4B9100", VA = "0x104B9D00")]
		private string GetBasePlayerPrefsKey(Player player)
		{
			return null;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x4BA3C0", Offset = "0x4B97C0", VA = "0x104BA3C0")]
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x4B9D60", Offset = "0x4B9160", VA = "0x104B9D60")]
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x4B9FF0", Offset = "0x4B93F0", VA = "0x104B9FF0")]
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return null;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x4BABA0", Offset = "0x4B9FA0", VA = "0x104BABA0")]
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return null;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x4BAA90", Offset = "0x4B9E90", VA = "0x104BAA90")]
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return null;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x4BA5F0", Offset = "0x4B99F0", VA = "0x104BA5F0")]
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x4B9E30", Offset = "0x4B9230", VA = "0x104B9E30")]
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			return null;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x4BACD0", Offset = "0x4BA0D0", VA = "0x104BACD0")]
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			return null;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x4BAB40", Offset = "0x4B9F40", VA = "0x104BAB40")]
		private string GetInputBehaviorXml(Player player, int id)
		{
			return null;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x4B9610", Offset = "0x4B8A10", VA = "0x104B9610")]
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x4B9B30", Offset = "0x4B8F30", VA = "0x104B9B30")]
		private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			return null;
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x4BEE50", Offset = "0x4BE250", VA = "0x104BEE50")]
		private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			return default(bool);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x4BA670", Offset = "0x4B9A70", VA = "0x104BA670")]
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			return 0;
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x4BD580", Offset = "0x4BC980", VA = "0x104BD580")]
		private void RefreshLayoutManager(int playerId)
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x4BA490", Offset = "0x4B9890", VA = "0x104BA490")]
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			return null;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x4BF080", Offset = "0x4BE480", VA = "0x104BF080")]
		public UserDataStore_PlayerPrefs()
		{
		}

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		private const string logPrefix = "Rewired: ";

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		// Token: 0x040021AD RID: 8621
		[Token(Token = "0x40021AD")]
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		private const int controllerMapPPKeyVersion_original = 0;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		private const int controllerMapPPKeyVersion = 2;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE1FF0", Offset = "0xE13F0")]
		private bool isEnabled;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0xD")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2030", Offset = "0xE1430")]
		[SerializeField]
		private bool loadDataOnStart;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0xE")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2070", Offset = "0xE1470")]
		private bool loadJoystickAssignments;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0xF")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE20B0", Offset = "0xE14B0")]
		[SerializeField]
		private bool loadKeyboardAssignments;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE20F0", Offset = "0xE14F0")]
		[SerializeField]
		private bool loadMouseAssignments;

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Attribute(Name = "TooltipAttribute", RVA = "0xE2180", Offset = "0xE1580")]
		private string playerPrefsKeyPrefix;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x19")]
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x1A")]
		[NonSerialized]
		private bool wasJoystickEverDetected;

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		private List<int> __allActionIds;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private string __allActionIdsString;

		// Token: 0x02000549 RID: 1353
		[Token(Token = "0x2000549")]
		private class ControllerAssignmentSaveInfo
		{
			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00009648 File Offset: 0x00007848
			[Token(Token = "0x1700062F")]
			public int playerCount
			{
				[Token(Token = "0x6001F3B")]
				[Address(RVA = "0x8A80A0", Offset = "0x8A74A0", VA = "0x108A80A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001F3C RID: 7996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public ControllerAssignmentSaveInfo()
			{
			}

			// Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0x12FBF50", Offset = "0x12FB350", VA = "0x112FBF50")]
			public ControllerAssignmentSaveInfo(int playerCount)
			{
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x00009660 File Offset: 0x00007860
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0x12FBEE0", Offset = "0x12FB2E0", VA = "0x112FBEE0")]
			public int IndexOfPlayer(int playerId)
			{
				return 0;
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x00009678 File Offset: 0x00007878
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x12FBE70", Offset = "0x12FB270", VA = "0x112FBE70")]
			public bool ContainsPlayer(int playerId)
			{
				return default(bool);
			}

			// Token: 0x040021BE RID: 8638
			[Token(Token = "0x40021BE")]
			[FieldOffset(Offset = "0x8")]
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

			// Token: 0x0200054A RID: 1354
			[Token(Token = "0x200054A")]
			public class PlayerInfo
			{
				// Token: 0x17000630 RID: 1584
				// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00009690 File Offset: 0x00007890
				[Token(Token = "0x17000630")]
				public int joystickCount
				{
					[Token(Token = "0x6001F40")]
					[Address(RVA = "0xCD7210", Offset = "0xCD6610", VA = "0x10CD7210")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06001F41 RID: 8001 RVA: 0x000096A8 File Offset: 0x000078A8
				[Token(Token = "0x6001F41")]
				[Address(RVA = "0x12FCAC0", Offset = "0x12FBEC0", VA = "0x112FCAC0")]
				public int IndexOfJoystick(int joystickId)
				{
					return 0;
				}

				// Token: 0x06001F42 RID: 8002 RVA: 0x000096C0 File Offset: 0x000078C0
				[Token(Token = "0x6001F42")]
				[Address(RVA = "0x12FCA50", Offset = "0x12FBE50", VA = "0x112FCA50")]
				public bool ContainsJoystick(int joystickId)
				{
					return default(bool);
				}

				// Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001F43")]
				[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
				public PlayerInfo()
				{
				}

				// Token: 0x040021BF RID: 8639
				[Token(Token = "0x40021BF")]
				[FieldOffset(Offset = "0x8")]
				public int id;

				// Token: 0x040021C0 RID: 8640
				[Token(Token = "0x40021C0")]
				[FieldOffset(Offset = "0xC")]
				public bool hasKeyboard;

				// Token: 0x040021C1 RID: 8641
				[Token(Token = "0x40021C1")]
				[FieldOffset(Offset = "0xD")]
				public bool hasMouse;

				// Token: 0x040021C2 RID: 8642
				[Token(Token = "0x40021C2")]
				[FieldOffset(Offset = "0x10")]
				public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;
			}

			// Token: 0x0200054B RID: 1355
			[Token(Token = "0x200054B")]
			public class JoystickInfo
			{
				// Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6001F44")]
				[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
				public JoystickInfo()
				{
				}

				// Token: 0x040021C3 RID: 8643
				[Token(Token = "0x40021C3")]
				[FieldOffset(Offset = "0x8")]
				public Guid instanceGuid;

				// Token: 0x040021C4 RID: 8644
				[Token(Token = "0x40021C4")]
				[FieldOffset(Offset = "0x18")]
				public string hardwareIdentifier;

				// Token: 0x040021C5 RID: 8645
				[Token(Token = "0x40021C5")]
				[FieldOffset(Offset = "0x1C")]
				public int id;
			}
		}

		// Token: 0x0200054C RID: 1356
		[Token(Token = "0x200054C")]
		private class JoystickAssignmentHistoryInfo
		{
			// Token: 0x06001F45 RID: 8005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x12FC090", Offset = "0x12FB490", VA = "0x112FC090")]
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
			}

			// Token: 0x040021C6 RID: 8646
			[Token(Token = "0x40021C6")]
			[FieldOffset(Offset = "0x8")]
			public readonly Joystick joystick;

			// Token: 0x040021C7 RID: 8647
			[Token(Token = "0x40021C7")]
			[FieldOffset(Offset = "0xC")]
			public readonly int oldJoystickId;
		}

		// Token: 0x0200054D RID: 1357
		[Token(Token = "0x200054D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x06001F46 RID: 8006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x06001F47 RID: 8007 RVA: 0x000096D8 File Offset: 0x000078D8
			[Token(Token = "0x6001F47")]
			[Address(RVA = "0x5B5440", Offset = "0x5B4840", VA = "0x105B5440")]
			internal bool <LoadJoystickAssignmentsNow>b__0(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x040021C8 RID: 8648
			[Token(Token = "0x40021C8")]
			[FieldOffset(Offset = "0x8")]
			public Joystick joystick;
		}

		// Token: 0x0200054E RID: 1358
		[Token(Token = "0x200054E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass78_1
		{
			// Token: 0x06001F48 RID: 8008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass78_1()
			{
			}

			// Token: 0x06001F49 RID: 8009 RVA: 0x000096F0 File Offset: 0x000078F0
			[Token(Token = "0x6001F49")]
			[Address(RVA = "0x1302920", Offset = "0x1301D20", VA = "0x11302920")]
			internal bool <LoadJoystickAssignmentsNow>b__1(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x040021C9 RID: 8649
			[Token(Token = "0x40021C9")]
			[FieldOffset(Offset = "0x8")]
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo;
		}

		// Token: 0x0200054F RID: 1359
		[Token(Token = "0x200054F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <>c__DisplayClass78_2
		{
			// Token: 0x06001F4A RID: 8010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F4A")]
			[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
			public <>c__DisplayClass78_2()
			{
			}

			// Token: 0x06001F4B RID: 8011 RVA: 0x00009708 File Offset: 0x00007908
			[Token(Token = "0x6001F4B")]
			[Address(RVA = "0x5B5440", Offset = "0x5B4840", VA = "0x105B5440")]
			internal bool <LoadJoystickAssignmentsNow>b__2(UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x)
			{
				return default(bool);
			}

			// Token: 0x040021CA RID: 8650
			[Token(Token = "0x40021CA")]
			[FieldOffset(Offset = "0x8")]
			public Joystick match;
		}

		// Token: 0x02000550 RID: 1360
		[Token(Token = "0x2000550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
		private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F4C")]
			[Address(RVA = "0x284FF0", Offset = "0x2843F0", VA = "0x10284FF0")]
			[DebuggerHidden]
			public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state)
			{
			}

			// Token: 0x06001F4D RID: 8013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F4D")]
			[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06001F4E RID: 8014 RVA: 0x00009720 File Offset: 0x00007920
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x13003D0", Offset = "0x12FF7D0", VA = "0x113003D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000631")]
			private object Current
			{
				[Token(Token = "0x6001F4F")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06001F50 RID: 8016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x13004F0", Offset = "0x12FF8F0", VA = "0x113004F0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000632")]
			private object Current
			{
				[Token(Token = "0x6001F51")]
				[Address(RVA = "0x273E90", Offset = "0x273290", VA = "0x10273E90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040021CB RID: 8651
			[Token(Token = "0x40021CB")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			// Token: 0x040021CC RID: 8652
			[Token(Token = "0x40021CC")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			// Token: 0x040021CD RID: 8653
			[Token(Token = "0x40021CD")]
			[FieldOffset(Offset = "0x10")]
			public UserDataStore_PlayerPrefs <>4__this;
		}
	}
}
