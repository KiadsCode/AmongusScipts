using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x97C30", Offset = "0x97030")]
	public class ExternalTools : IExternalTools
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public static Func<object> getPlatformInitializerDelegate
		{
			[Token(Token = "0x6001E90")]
			[Address(RVA = "0x3A5350", Offset = "0x3A4750", VA = "0x103A5350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x3A5460", Offset = "0x3A4860", VA = "0x103A5460")]
			set
			{
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public ExternalTools()
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "7")]
		public void Destroy()
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x17000623")]
		public bool isEditorPaused
		{
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x28A630", Offset = "0x289A30", VA = "0x1028A630", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06001E95 RID: 7829 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x3A5260", Offset = "0x3A4660", VA = "0x103A5260", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x3A5380", Offset = "0x3A4780", VA = "0x103A5380", Slot = "6")]
			remove
			{
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x3A4E90", Offset = "0x3A4290", VA = "0x103A4E90", Slot = "8")]
		public object GetPlatformInitializer()
		{
			return null;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x3A4E60", Offset = "0x3A4260", VA = "0x103A4E60", Slot = "9")]
		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "10")]
		public bool IsEditorSceneViewFocused()
		{
			return default(bool);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "11")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return default(bool);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06001E9B RID: 7835 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000003")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x3A52C0", Offset = "0x3A46C0", VA = "0x103A52C0", Slot = "14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			add
			{
			}
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0x3A53E0", Offset = "0x3A47E0", VA = "0x103A53E0", Slot = "15")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
			remove
			{
			}
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "12")]
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return 0;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x3A5220", Offset = "0x3A4620", VA = "0x103A5220", Slot = "13")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0UL;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "16")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return default(bool);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x3A5230", Offset = "0x3A4630", VA = "0x103A5230", Slot = "17")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "18")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0U;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "19")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "20")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return default(bool);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "21")]
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "22")]
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "23")]
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x3A4ED0", Offset = "0x3A42D0", VA = "0x103A4ED0", Slot = "24")]
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x3A4F00", Offset = "0x3A4300", VA = "0x103A4F00", Slot = "25")]
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x3A4F50", Offset = "0x3A4350", VA = "0x103A4F50", Slot = "26")]
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "27")]
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "28")]
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "29")]
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "30")]
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "31")]
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "32")]
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "33")]
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "34")]
		public bool PS4Input_PadIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "35")]
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x3A4CC0", Offset = "0x3A40C0", VA = "0x103A4CC0", Slot = "36")]
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return 0;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "37")]
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "38")]
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "39")]
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "40")]
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "41")]
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x3A4ED0", Offset = "0x3A42D0", VA = "0x103A4ED0", Slot = "42")]
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "43")]
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "44")]
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "45")]
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "46")]
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "47")]
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "48")]
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "49")]
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "50")]
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "51")]
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "52")]
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "53")]
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "54")]
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x3A4ED0", Offset = "0x3A42D0", VA = "0x103A4ED0", Slot = "55")]
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "56")]
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "57")]
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "58")]
		public bool PS4Input_AimIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "59")]
		public void PS4Input_AimResetLightSphere(int id)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "60")]
		public void PS4Input_AimResetOrientation(int id)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "61")]
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "62")]
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "63")]
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "64")]
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680", Slot = "65")]
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "66")]
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return default(Vector3);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x3A4EA0", Offset = "0x3A42A0", VA = "0x103A4EA0", Slot = "67")]
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return default(Vector3);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "68")]
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return 0;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "69")]
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return 0;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x2D7E70", Offset = "0x2D7270", VA = "0x102D7E70", Slot = "70")]
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return default(bool);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "71")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return 0;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "72")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return 0;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "73")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return 0;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x3A4F90", Offset = "0x3A4390", VA = "0x103A4F90", Slot = "74")]
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return 0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "75")]
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return 0;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x394F70", Offset = "0x394370", VA = "0x10394F70", Slot = "76")]
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return 0;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x3A4DF0", Offset = "0x3A41F0", VA = "0x103A4DF0", Slot = "77")]
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x3A4CC0", Offset = "0x3A40C0", VA = "0x103A4CC0", Slot = "78")]
		public int GetAndroidAPILevel()
		{
			return 0;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x3A5000", Offset = "0x3A4400", VA = "0x103A5000", Slot = "79")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return default(bool);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x3A5110", Offset = "0x3A4510", VA = "0x103A5110", Slot = "80")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x17000624")]
		public bool UnityInput_IsTouchPressureSupported
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x3A5340", Offset = "0x3A4740", VA = "0x103A5340", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x3A4FD0", Offset = "0x3A43D0", VA = "0x103A4FD0", Slot = "82")]
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return 0f;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0x3A4FB0", Offset = "0x3A43B0", VA = "0x103A4FB0", Slot = "83")]
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return 0f;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x3A4C60", Offset = "0x3A4060", VA = "0x103A4C60", Slot = "84")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x3A4D60", Offset = "0x3A4160", VA = "0x103A4D60", Slot = "85")]
		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x3A4CD0", Offset = "0x3A40D0", VA = "0x103A4CD0", Slot = "86")]
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return null;
		}

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x0")]
		private static Func<object> _getPlatformInitializerDelegate;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x8")]
		private bool _isEditorPaused;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0xC")]
		private Action<bool> _EditorPausedStateChangedEvent;
	}
}
