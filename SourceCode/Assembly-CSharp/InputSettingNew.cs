// Decompiled with JetBrains decompiler
// Type: InputSettingNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using System;
using System.Collections.Generic;

[Token(Token = "0x20001DC")]
public class InputSettingNew : BetterSetting
{
  [Token(Token = "0x4000D5F")]
  [FieldOffset(Offset = "0x90")]
  public MyGlyphDisplay[] glyphContainers;
  [Token(Token = "0x4000D60")]
  [FieldOffset(Offset = "0x98")]
  public MyButtonSetting b_settingButton;
  [Token(Token = "0x4000D61")]
  [FieldOffset(Offset = "0xA0")]
  private Controller currentController;
  [Token(Token = "0x4000D62")]
  [FieldOffset(Offset = "0xA8")]
  private bool isController;
  [Token(Token = "0x4000D63")]
  [FieldOffset(Offset = "0xAC")]
  private int actionId;
  [Token(Token = "0x4000D64")]
  [FieldOffset(Offset = "0xB0")]
  private bool isInitialized;
  [Token(Token = "0x4000D65")]
  private static int selectedIndex;
  [Token(Token = "0x4000D66")]
  private static Dictionary<InputSettingNew.InputKey, int> elementToGlyphPosition;
  [Token(Token = "0x4000D67")]
  [FieldOffset(Offset = "0xB8")]
  private InputSettingNew.Hostage hostage;
  [Token(Token = "0x4000D68")]
  [FieldOffset(Offset = "0xC0")]
  private ActionElementMap aemKeyboard;
  [Token(Token = "0x4000D69")]
  [FieldOffset(Offset = "0xC8")]
  private ActionElementMap aemMouse;
  [Token(Token = "0x4000D6A")]
  [FieldOffset(Offset = "0xD0")]
  private ActionElementMap aemController;
  [Token(Token = "0x4000D6B")]
  public static Action A_MappingUpdated;

  [Token(Token = "0x6000C48")]
  [Address(RVA = "0x5058B0", Offset = "0x5044B0", Length = "0x4C8")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000C49")]
  [Address(RVA = "0x5071C0", Offset = "0x505DC0", Length = "0x514")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000C4A")]
  [Address(RVA = "0x47D460", Offset = "0x47C060", Length = "0x11")]
  private void OnMappingUpdated()
  {
  }

  [Token(Token = "0x6000C4B")]
  [Address(RVA = "0x5076E0", Offset = "0x5062E0", Length = "0x74")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000C4C")]
  [Address(RVA = "0x505D80", Offset = "0x504980", Length = "0x82")]
  private void CheckController()
  {
  }

  [Token(Token = "0x6000C4D")]
  [Address(RVA = "0x508470", Offset = "0x507070", Length = "0x8C")]
  private void StartHover()
  {
  }

  [Token(Token = "0x6000C4E")]
  [Address(RVA = "0x5085B0", Offset = "0x5071B0", Length = "0x8C")]
  private void StopHover()
  {
  }

  [Token(Token = "0x6000C4F")]
  [Address(RVA = "0x505F40", Offset = "0x504B40", Length = "0x136")]
  public override void ControllerInputDir(int dir, float multiplier)
  {
  }

  [Token(Token = "0x6000C50")]
  [Address(RVA = "0x506CF0", Offset = "0x5058F0", Length = "0xA0")]
  private ControllerMap GetControllerMap() => (ControllerMap) null;

  [Token(Token = "0x6000C51")]
  [Address(RVA = "0x506DA0", Offset = "0x5059A0", Length = "0x9A")]
  private ControllerMap GetKeyboardMap() => (ControllerMap) null;

  [Token(Token = "0x6000C52")]
  [Address(RVA = "0x506E40", Offset = "0x505A40", Length = "0x9C")]
  private ControllerMap GetMouseMap() => (ControllerMap) null;

  [Token(Token = "0x6000C53")]
  [Address(RVA = "0x508500", Offset = "0x507100", Length = "0xA7")]
  public void StartListening()
  {
  }

  [Token(Token = "0x6000C54")]
  [Address(RVA = "0x506080", Offset = "0x504C80", Length = "0xEC")]
  public void ForceListen(int index)
  {
  }

  [Token(Token = "0x6000C55")]
  [Address(RVA = "0x506170", Offset = "0x504D70", Length = "0x43F")]
  private List<InputMapper.Context> GetContextController() => (List<InputMapper.Context>) null;

  [Token(Token = "0x6000C56")]
  [Address(RVA = "0x5065B0", Offset = "0x5051B0", Length = "0x730")]
  private List<InputMapper.Context> GetContextKeyboardAndMouse() => (List<InputMapper.Context>) null;

  [Token(Token = "0x6000C57")]
  [Address(RVA = "0x508710", Offset = "0x507310", Length = "0x172")]
  private void TryInit()
  {
  }

  [Token(Token = "0x6000C58")]
  [Address(RVA = "0x507D10", Offset = "0x506910", Length = "0x757")]
  protected override void ShowValue()
  {
  }

  [Token(Token = "0x6000C59")]
  [Address(RVA = "0x5077F0", Offset = "0x5063F0", Length = "0x518")]
  private void ShowMapBindings(IList<ControllerMap> maps)
  {
  }

  [Token(Token = "0x6000C5A")]
  [Address(RVA = "0x506F40", Offset = "0x505B40", Length = "0xED")]
  private bool IsElementMapFilteredOut(ActionElementMap actionElementMap) => false;

  [Token(Token = "0x6000C5B")]
  [Address(RVA = "0x507030", Offset = "0x505C30", Length = "0xEE")]
  private void ModifyContext(InputMapper.Context context)
  {
  }

  [Token(Token = "0x6000C5C")]
  [Address(RVA = "0x505E10", Offset = "0x504A10", Length = "0x12B")]
  private void ClearGlyphs()
  {
  }

  [Token(Token = "0x6000C5D")]
  [Address(RVA = "0x5077A0", Offset = "0x5063A0", Length = "0x44")]
  private void RefreshController(Controller c)
  {
  }

  [Token(Token = "0x6000C5E")]
  [Address(RVA = "0x507120", Offset = "0x505D20", Length = "0x9E")]
  private void OnControlsReset()
  {
  }

  [Token(Token = "0x6000C5F")]
  [Address(RVA = "0x508A00", Offset = "0x507600", Length = "0x2C8")]
  public void UpdateMapping(bool result, ActionElementMap newActionElementMap)
  {
  }

  [Token(Token = "0x6000C60")]
  [Address(RVA = "0x508980", Offset = "0x507580", Length = "0x70")]
  public void TryRemoveInputKey(ActionElementMap aem)
  {
  }

  [Token(Token = "0x6000C61")]
  [Address(RVA = "0x508890", Offset = "0x507490", Length = "0xEE")]
  private void TryRemoveInputKey(InputSettingNew.InputKey key)
  {
  }

  [Token(Token = "0x6000C62")]
  [Address(RVA = "0x508640", Offset = "0x507240", Length = "0xCE")]
  private void TryAddInputKey(ActionElementMap aem, int index)
  {
  }

  [Token(Token = "0x6000C63")]
  [Address(RVA = "0x506EE0", Offset = "0x505AE0", Length = "0x5C")]
  public InputSettingNew.InputKey GetNewInputKey(ActionElementMap aem) => new InputSettingNew.InputKey();

  [Token(Token = "0x6000C64")]
  [Address(RVA = "0x507760", Offset = "0x506360", Length = "0x3C")]
  private void OnInputMapped(InputMapper.InputMappedEventData obj)
  {
  }

  [Token(Token = "0x6000C65")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public InputSettingNew()
  {
  }

  [Token(Token = "0x6000C66")]
  [Address(RVA = "0x508CD0", Offset = "0x5078D0", Length = "0x9D")]
  static InputSettingNew()
  {
  }

  [Token(Token = "0x20001DD")]
  private class Hostage
  {
    [Token(Token = "0x4000D6C")]
    [FieldOffset(Offset = "0x10")]
    public ActionElementMap actionElementMap;
    [Token(Token = "0x4000D6D")]
    [FieldOffset(Offset = "0x18")]
    public Controller controller;
    [Token(Token = "0x4000D6E")]
    [FieldOffset(Offset = "0x20")]
    public int elementIdentifierId;

    [Token(Token = "0x6000C67")]
    [Address(RVA = "0x5055E0", Offset = "0x5041E0", Length = "0x62")]
    public Hostage(ActionElementMap actionElementMap)
    {
    }
  }

  [Token(Token = "0x20001DE")]
  public struct InputKey : IEquatable<InputSettingNew.InputKey>
  {
    [Token(Token = "0x4000D6F")]
    [FieldOffset(Offset = "0x0")]
    public int elementId;
    [Token(Token = "0x4000D70")]
    [FieldOffset(Offset = "0x4")]
    public ControllerType controllerType;
    [Token(Token = "0x4000D71")]
    [FieldOffset(Offset = "0x8")]
    public int controllerId;

    [Token(Token = "0x6000C68")]
    [Address(RVA = "0x505700", Offset = "0x504300", Length = "0x1B")]
    public bool Equals(InputSettingNew.InputKey other) => false;

    [Token(Token = "0x6000C69")]
    [Address(RVA = "0x505650", Offset = "0x504250", Length = "0xA7")]
    public override bool Equals(object obj) => false;

    [Token(Token = "0x6000C6A")]
    [Address(RVA = "0x505720", Offset = "0x504320", Length = "0x87")]
    public override int GetHashCode() => 0;
  }
}
