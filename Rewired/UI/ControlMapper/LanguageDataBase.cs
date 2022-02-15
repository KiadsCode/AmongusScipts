using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2000596")]
	[Serializable]
	public abstract class LanguageDataBase : ScriptableObject
	{
		// Token: 0x0600238C RID: 9100
		[Token(Token = "0x600238C")]
		public abstract void Initialize();

		// Token: 0x0600238D RID: 9101
		[Token(Token = "0x600238D")]
		public abstract string GetCustomEntry(string key);

		// Token: 0x0600238E RID: 9102
		[Token(Token = "0x600238E")]
		public abstract bool ContainsCustomEntryKey(string key);

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600238F RID: 9103
		[Token(Token = "0x17000764")]
		public abstract string yes { [Token(Token = "0x600238F")] get; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002390 RID: 9104
		[Token(Token = "0x17000765")]
		public abstract string no { [Token(Token = "0x6002390")] get; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002391 RID: 9105
		[Token(Token = "0x17000766")]
		public abstract string add { [Token(Token = "0x6002391")] get; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002392 RID: 9106
		[Token(Token = "0x17000767")]
		public abstract string replace { [Token(Token = "0x6002392")] get; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002393 RID: 9107
		[Token(Token = "0x17000768")]
		public abstract string remove { [Token(Token = "0x6002393")] get; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002394 RID: 9108
		[Token(Token = "0x17000769")]
		public abstract string swap { [Token(Token = "0x6002394")] get; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002395 RID: 9109
		[Token(Token = "0x1700076A")]
		public abstract string cancel { [Token(Token = "0x6002395")] get; }

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002396 RID: 9110
		[Token(Token = "0x1700076B")]
		public abstract string none { [Token(Token = "0x6002396")] get; }

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002397 RID: 9111
		[Token(Token = "0x1700076C")]
		public abstract string okay { [Token(Token = "0x6002397")] get; }

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002398 RID: 9112
		[Token(Token = "0x1700076D")]
		public abstract string done { [Token(Token = "0x6002398")] get; }

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002399 RID: 9113
		[Token(Token = "0x1700076E")]
		public abstract string default_ { [Token(Token = "0x6002399")] get; }

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600239A RID: 9114
		[Token(Token = "0x1700076F")]
		public abstract string assignControllerWindowTitle { [Token(Token = "0x600239A")] get; }

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600239B RID: 9115
		[Token(Token = "0x17000770")]
		public abstract string assignControllerWindowMessage { [Token(Token = "0x600239B")] get; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600239C RID: 9116
		[Token(Token = "0x17000771")]
		public abstract string controllerAssignmentConflictWindowTitle { [Token(Token = "0x600239C")] get; }

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600239D RID: 9117
		[Token(Token = "0x17000772")]
		public abstract string elementAssignmentPrePollingWindowMessage { [Token(Token = "0x600239D")] get; }

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600239E RID: 9118
		[Token(Token = "0x17000773")]
		public abstract string elementAssignmentConflictWindowMessage { [Token(Token = "0x600239E")] get; }

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600239F RID: 9119
		[Token(Token = "0x17000774")]
		public abstract string mouseAssignmentConflictWindowTitle { [Token(Token = "0x600239F")] get; }

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060023A0 RID: 9120
		[Token(Token = "0x17000775")]
		public abstract string calibrateControllerWindowTitle { [Token(Token = "0x60023A0")] get; }

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060023A1 RID: 9121
		[Token(Token = "0x17000776")]
		public abstract string calibrateAxisStep1WindowTitle { [Token(Token = "0x60023A1")] get; }

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060023A2 RID: 9122
		[Token(Token = "0x17000777")]
		public abstract string calibrateAxisStep2WindowTitle { [Token(Token = "0x60023A2")] get; }

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060023A3 RID: 9123
		[Token(Token = "0x17000778")]
		public abstract string inputBehaviorSettingsWindowTitle { [Token(Token = "0x60023A3")] get; }

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060023A4 RID: 9124
		[Token(Token = "0x17000779")]
		public abstract string restoreDefaultsWindowTitle { [Token(Token = "0x60023A4")] get; }

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060023A5 RID: 9125
		[Token(Token = "0x1700077A")]
		public abstract string actionColumnLabel { [Token(Token = "0x60023A5")] get; }

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060023A6 RID: 9126
		[Token(Token = "0x1700077B")]
		public abstract string keyboardColumnLabel { [Token(Token = "0x60023A6")] get; }

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060023A7 RID: 9127
		[Token(Token = "0x1700077C")]
		public abstract string mouseColumnLabel { [Token(Token = "0x60023A7")] get; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060023A8 RID: 9128
		[Token(Token = "0x1700077D")]
		public abstract string controllerColumnLabel { [Token(Token = "0x60023A8")] get; }

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060023A9 RID: 9129
		[Token(Token = "0x1700077E")]
		public abstract string removeControllerButtonLabel { [Token(Token = "0x60023A9")] get; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060023AA RID: 9130
		[Token(Token = "0x1700077F")]
		public abstract string calibrateControllerButtonLabel { [Token(Token = "0x60023AA")] get; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060023AB RID: 9131
		[Token(Token = "0x17000780")]
		public abstract string assignControllerButtonLabel { [Token(Token = "0x60023AB")] get; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060023AC RID: 9132
		[Token(Token = "0x17000781")]
		public abstract string inputBehaviorSettingsButtonLabel { [Token(Token = "0x60023AC")] get; }

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060023AD RID: 9133
		[Token(Token = "0x17000782")]
		public abstract string doneButtonLabel { [Token(Token = "0x60023AD")] get; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060023AE RID: 9134
		[Token(Token = "0x17000783")]
		public abstract string restoreDefaultsButtonLabel { [Token(Token = "0x60023AE")] get; }

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060023AF RID: 9135
		[Token(Token = "0x17000784")]
		public abstract string controllerSettingsGroupLabel { [Token(Token = "0x60023AF")] get; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060023B0 RID: 9136
		[Token(Token = "0x17000785")]
		public abstract string playersGroupLabel { [Token(Token = "0x60023B0")] get; }

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060023B1 RID: 9137
		[Token(Token = "0x17000786")]
		public abstract string assignedControllersGroupLabel { [Token(Token = "0x60023B1")] get; }

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060023B2 RID: 9138
		[Token(Token = "0x17000787")]
		public abstract string settingsGroupLabel { [Token(Token = "0x60023B2")] get; }

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060023B3 RID: 9139
		[Token(Token = "0x17000788")]
		public abstract string mapCategoriesGroupLabel { [Token(Token = "0x60023B3")] get; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060023B4 RID: 9140
		[Token(Token = "0x17000789")]
		public abstract string restoreDefaultsWindowMessage { [Token(Token = "0x60023B4")] get; }

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060023B5 RID: 9141
		[Token(Token = "0x1700078A")]
		public abstract string calibrateWindow_deadZoneSliderLabel { [Token(Token = "0x60023B5")] get; }

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060023B6 RID: 9142
		[Token(Token = "0x1700078B")]
		public abstract string calibrateWindow_zeroSliderLabel { [Token(Token = "0x60023B6")] get; }

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060023B7 RID: 9143
		[Token(Token = "0x1700078C")]
		public abstract string calibrateWindow_sensitivitySliderLabel { [Token(Token = "0x60023B7")] get; }

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060023B8 RID: 9144
		[Token(Token = "0x1700078D")]
		public abstract string calibrateWindow_invertToggleLabel { [Token(Token = "0x60023B8")] get; }

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060023B9 RID: 9145
		[Token(Token = "0x1700078E")]
		public abstract string calibrateWindow_calibrateButtonLabel { [Token(Token = "0x60023B9")] get; }

		// Token: 0x060023BA RID: 9146
		[Token(Token = "0x60023BA")]
		public abstract string GetControllerAssignmentConflictWindowMessage(string joystickName, string otherPlayerName, string currentPlayerName);

		// Token: 0x060023BB RID: 9147
		[Token(Token = "0x60023BB")]
		public abstract string GetJoystickElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x060023BC RID: 9148
		[Token(Token = "0x60023BC")]
		public abstract string GetJoystickElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x060023BD RID: 9149
		[Token(Token = "0x60023BD")]
		public abstract string GetKeyboardElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x060023BE RID: 9150
		[Token(Token = "0x60023BE")]
		public abstract string GetMouseElementAssignmentPollingWindowMessage(string actionName);

		// Token: 0x060023BF RID: 9151
		[Token(Token = "0x60023BF")]
		public abstract string GetMouseElementAssignmentPollingWindowMessage_FullAxisFieldOnly(string actionName);

		// Token: 0x060023C0 RID: 9152
		[Token(Token = "0x60023C0")]
		public abstract string GetElementAlreadyInUseBlocked(string elementName);

		// Token: 0x060023C1 RID: 9153
		[Token(Token = "0x60023C1")]
		public abstract string GetElementAlreadyInUseCanReplace(string elementName, bool allowConflicts);

		// Token: 0x060023C2 RID: 9154
		[Token(Token = "0x60023C2")]
		public abstract string GetMouseAssignmentConflictWindowMessage(string otherPlayerName, string thisPlayerName);

		// Token: 0x060023C3 RID: 9155
		[Token(Token = "0x60023C3")]
		public abstract string GetCalibrateAxisStep1WindowMessage(string axisName);

		// Token: 0x060023C4 RID: 9156
		[Token(Token = "0x60023C4")]
		public abstract string GetCalibrateAxisStep2WindowMessage(string axisName);

		// Token: 0x060023C5 RID: 9157
		[Token(Token = "0x60023C5")]
		public abstract string GetPlayerName(int playerId);

		// Token: 0x060023C6 RID: 9158
		[Token(Token = "0x60023C6")]
		public abstract string GetControllerName(Controller controller);

		// Token: 0x060023C7 RID: 9159
		[Token(Token = "0x60023C7")]
		public abstract string GetElementIdentifierName(ActionElementMap actionElementMap);

		// Token: 0x060023C8 RID: 9160
		[Token(Token = "0x60023C8")]
		public abstract string GetElementIdentifierName(Controller controller, int elementIdentifierId, AxisRange axisRange);

		// Token: 0x060023C9 RID: 9161
		[Token(Token = "0x60023C9")]
		public abstract string GetElementIdentifierName(KeyCode keyCode, ModifierKeyFlags modifierKeyFlags);

		// Token: 0x060023CA RID: 9162
		[Token(Token = "0x60023CA")]
		public abstract string GetActionName(int actionId);

		// Token: 0x060023CB RID: 9163
		[Token(Token = "0x60023CB")]
		public abstract string GetActionName(int actionId, AxisRange axisRange);

		// Token: 0x060023CC RID: 9164
		[Token(Token = "0x60023CC")]
		public abstract string GetMapCategoryName(int id);

		// Token: 0x060023CD RID: 9165
		[Token(Token = "0x60023CD")]
		public abstract string GetActionCategoryName(int id);

		// Token: 0x060023CE RID: 9166
		[Token(Token = "0x60023CE")]
		public abstract string GetLayoutName(ControllerType controllerType, int id);

		// Token: 0x060023CF RID: 9167
		[Token(Token = "0x60023CF")]
		public abstract string ModifierKeyFlagsToString(ModifierKeyFlags flags);

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x4A2960", Offset = "0x4A1D60", VA = "0x104A2960")]
		protected LanguageDataBase()
		{
		}
	}
}
