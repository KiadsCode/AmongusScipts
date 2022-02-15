using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000377 RID: 887
[Token(Token = "0x2000377")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0xDD960", Offset = "0xDCD60")]
public class ControllerManager : MonoBehaviour
{
	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06001305 RID: 4869 RVA: 0x00006630 File Offset: 0x00004830
	[Token(Token = "0x170002CF")]
	public bool IsUiControllerActive
	{
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x7FAC10", Offset = "0x7FA010", VA = "0x107FAC10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x7F6120", Offset = "0x7F5520", VA = "0x107F6120")]
	private void Awake()
	{
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x7F9D40", Offset = "0x7F9140", VA = "0x107F9D40")]
	private void SceneManager_activeSceneChanged(Scene from, Scene to)
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x7F9D60", Offset = "0x7F9160", VA = "0x107F9D60")]
	private void SceneManager_sceneUnloaded(Scene scene)
	{
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x7F9FE0", Offset = "0x7F93E0", VA = "0x107F9FE0")]
	private void Start()
	{
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x7F8550", Offset = "0x7F7950", VA = "0x107F8550")]
	public bool IsMenuActiveAtAll(string menuName)
	{
		return default(bool);
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x7F89F0", Offset = "0x7F7DF0", VA = "0x107F89F0")]
	private void OnInputTypeChanged()
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x7F8710", Offset = "0x7F7B10", VA = "0x107F8710")]
	public void NewScene(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = false)
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x7F8FE0", Offset = "0x7F83E0", VA = "0x107F8FE0")]
	public void OpenOverlayMenu(string menuName, UiElement backButton)
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x7F8F70", Offset = "0x7F8370", VA = "0x107F8F70")]
	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection)
	{
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x7F8C90", Offset = "0x7F8090", VA = "0x107F8C90")]
	public void OpenOverlayMenu(string menuName, UiElement backButton, UiElement defaultSelection, List<UiElement> selectableElements, bool gridNav = false)
	{
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x7F8070", Offset = "0x7F7470", VA = "0x107F8070")]
	public ControllerUiElementsState GetMenu(string menuName)
	{
		return null;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x7F9040", Offset = "0x7F8440", VA = "0x107F9040")]
	public void OpenSpecificMenu(string menuNameToOpen)
	{
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x7F9170", Offset = "0x7F8570", VA = "0x107F9170")]
	private void OpenTopmostMenu()
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x7F9EC0", Offset = "0x7F92C0", VA = "0x107F9EC0")]
	public void SetUpSelectables(ControllerUiElementsState state, UiElement defaultSelection, List<UiElement> selectables)
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x7F9E50", Offset = "0x7F9250", VA = "0x107F9E50")]
	public void SetDefaultSelection(UiElement defaultSelection, [Optional] List<UiElement> selectableElements)
	{
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x7F9DD0", Offset = "0x7F91D0", VA = "0x107F9DD0")]
	public void SetBackButton(UiElement backButton)
	{
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x7F5E00", Offset = "0x7F5200", VA = "0x107F5E00")]
	public void AddSelectableUiElement(UiElement uiElement, bool forceSelect = false)
	{
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x7F9A30", Offset = "0x7F8E30", VA = "0x107F9A30")]
	public void RemoveSelectableUiElement(UiElement uiElement)
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x7F5ED0", Offset = "0x7F52D0", VA = "0x107F5ED0")]
	public void AddSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x7F9B00", Offset = "0x7F8F00", VA = "0x107F9B00")]
	public void RemoveSelectableUiElement(UiElement uiElement, ControllerUiElementsState menu)
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x7F63C0", Offset = "0x7F57C0", VA = "0x107F63C0")]
	public void ClearDestroyedSelectableUiElements()
	{
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x7F64D0", Offset = "0x7F58D0", VA = "0x107F64D0")]
	public void ClearDestroyedSelectableUiElements(ControllerUiElementsState state)
	{
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x7F67C0", Offset = "0x7F5BC0", VA = "0x107F67C0")]
	public void CloseOverlayMenu(string menuName)
	{
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x7F65E0", Offset = "0x7F59E0", VA = "0x107F65E0")]
	public void CloseAndResetAll()
	{
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x7F9BC0", Offset = "0x7F8FC0", VA = "0x107F9BC0")]
	public void ResetAll()
	{
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x7FA1B0", Offset = "0x7F95B0", VA = "0x107FA1B0")]
	private void Update()
	{
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x7F6DC0", Offset = "0x7F61C0", VA = "0x107F6DC0")]
	private AxisDirection FindClosestDirection(Vector2 direction)
	{
		return AxisDirection.None;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00006678 File Offset: 0x00004878
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x7F5F80", Offset = "0x7F5380", VA = "0x107F5F80")]
	private float AngleBetweenVector2(Vector2 vec1, Vector2 vec2, Vector2 direction)
	{
		return 0f;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x7F7CB0", Offset = "0x7F70B0", VA = "0x107F7CB0")]
	private UiElement FindUiElementByRaycast(Vector2 origin, Vector2 direction, float radius)
	{
		return null;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x7F7690", Offset = "0x7F6A90", VA = "0x107F7690")]
	private UiElement FindUiElementByExplicitNavigation(UiElement startingPoint, AxisDirection direction)
	{
		return null;
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x7F7780", Offset = "0x7F6B80", VA = "0x107F7780")]
	private UiElement FindUiElementByGridDirection(Vector2 origin, AxisDirection direction, float orthogonalOffsetThreshold)
	{
		return null;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x7F6F20", Offset = "0x7F6320", VA = "0x107F6F20")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xDDAB0", Offset = "0xDCEB0")]
	private UiElement FindUiElementByDistance(Vector2 origin, AxisDirection direction)
	{
		return null;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x7F84E0", Offset = "0x7F78E0", VA = "0x107F84E0")]
	private void VerticalAxisInputForSlideBar(float v, SlideBar slideBar, bool dpadDetected)
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x7F84E0", Offset = "0x7F78E0", VA = "0x107F84E0")]
	private void HorizontalAxisInputForSlideBar(float h, SlideBar slideBar, bool dpadDetected)
	{
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x7F8190", Offset = "0x7F7590", VA = "0x107F8190")]
	private void HighlightSelection(UiElement selection)
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x7F9E40", Offset = "0x7F9240", VA = "0x107F9E40")]
	public void SetCurrentSelected(UiElement selection)
	{
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x7F9810", Offset = "0x7F8C10", VA = "0x107F9810")]
	public void PickTopSelectable()
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0xDDB20", Offset = "0xDCF20")]
	public void PrintSelectableUiList()
	{
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x273680", Offset = "0x272A80", VA = "0x10273680")]
	[Attribute(Name = "ConditionalAttribute", RVA = "0xDDB20", Offset = "0xDCF20")]
	public void ClearSelectableUiList()
	{
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x7FAB30", Offset = "0x7F9F30", VA = "0x107FAB30")]
	public ControllerManager()
	{
	}

	// Token: 0x0400135E RID: 4958
	[Token(Token = "0x400135E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ControllerManager Instance;

	// Token: 0x0400135F RID: 4959
	[Token(Token = "0x400135F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	[HideInInspector]
	private int playerId;

	// Token: 0x04001360 RID: 4960
	[Token(Token = "0x4001360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Player player;

	// Token: 0x04001361 RID: 4961
	[Token(Token = "0x4001361")]
	private const string DISCONNECT_POPUP_MENUNAME = "DisconnectPopup";

	// Token: 0x04001362 RID: 4962
	[Token(Token = "0x4001362")]
	private const float DELTA_SINCE_LAST_BUTTON_HIGHLIGHT_THRESHOLD = 0.25f;

	// Token: 0x04001363 RID: 4963
	[Token(Token = "0x4001363")]
	private const float DELTA_SINCE_LAST_SLIDER_MOVEMENT_THRESHOLD = 0.1f;

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool inputDetectedLastFrame;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject PrefabMouseCursorForConsole;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private GameObject ConsoleMouse;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool IsButtonHeld;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ControllerUiElementsState CurrentUiState;

	// Token: 0x04001369 RID: 4969
	[Token(Token = "0x4001369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<ControllerUiElementsState> CurrentUiStateStack;

	// Token: 0x0400136A RID: 4970
	[Token(Token = "0x400136A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float deltaSinceLastUiHighlight;

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool disabledVirtualCursor;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int frameDelaySinceInputChanged;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x400136D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<Vector2, AxisDirection> directions;

	// Token: 0x0400136E RID: 4974
	[Token(Token = "0x400136E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private string currentScene;

	// Token: 0x02000378 RID: 888
	[Token(Token = "0x2000378")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x952B0", Offset = "0x946B0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001330")]
		[Address(RVA = "0x273A00", Offset = "0x272E00", VA = "0x10273A00")]
		public <>c()
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x6001331")]
		[Address(RVA = "0x78D210", Offset = "0x78C610", VA = "0x1078D210")]
		internal bool <ClearDestroyedSelectableUiElements>b__39_0(UiElement item)
		{
			return default(bool);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x6001332")]
		[Address(RVA = "0x78D260", Offset = "0x78C660", VA = "0x1078D260")]
		internal bool <ClearDestroyedSelectableUiElements>b__40_0(UiElement item)
		{
			return default(bool);
		}

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ControllerManager.<>c <>9;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Predicate<UiElement> <>9__39_0;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<UiElement> <>9__40_0;
	}
}
