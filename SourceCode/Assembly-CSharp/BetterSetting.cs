// Decompiled with JetBrains decompiler
// Type: BetterSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Settings___Saves.SaveFiles;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20001D8")]
public abstract class BetterSetting : MonoBehaviour
{
  [Token(Token = "0x4000D4B")]
  [FieldOffset(Offset = "0x20")]
  protected int value;
  [Token(Token = "0x4000D4C")]
  [FieldOffset(Offset = "0x24")]
  protected int settingType;
  [Token(Token = "0x4000D4D")]
  [FieldOffset(Offset = "0x28")]
  protected string[] options;
  [Token(Token = "0x4000D4E")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI settingName;
  [Token(Token = "0x4000D4F")]
  [FieldOffset(Offset = "0x38")]
  private string description;
  [Token(Token = "0x4000D50")]
  [FieldOffset(Offset = "0x40")]
  private Settings settings;
  [Token(Token = "0x4000D51")]
  [FieldOffset(Offset = "0x48")]
  public GameObject disabledOverlay;
  [Token(Token = "0x4000D52")]
  [FieldOffset(Offset = "0x50")]
  public TextMeshProUGUI t_disabledText;
  [Token(Token = "0x4000D53")]
  [FieldOffset(Offset = "0x58")]
  private bool hasSubscribed;
  [Token(Token = "0x4000D54")]
  [FieldOffset(Offset = "0x60")]
  private RectTransform rectTransform;
  [Token(Token = "0x4000D55")]
  [FieldOffset(Offset = "0x68")]
  private Action<string, object, CFSettings> saveAction;
  [Token(Token = "0x4000D56")]
  [FieldOffset(Offset = "0x70")]
  protected string _settingName;
  [Token(Token = "0x4000D57")]
  [FieldOffset(Offset = "0x78")]
  protected object _settingValue;
  [Token(Token = "0x4000D58")]
  [FieldOffset(Offset = "0x80")]
  private CFSettings cfSettings;
  [Token(Token = "0x4000D59")]
  [FieldOffset(Offset = "0x88")]
  private bool mouseOver;

  [Token(Token = "0x6000C24")]
  [Address(RVA = "0x500BF0", Offset = "0x4FF7F0", Length = "0x98")]
  protected void Awake()
  {
  }

  [Token(Token = "0x6000C25")]
  [Address(RVA = "0x501310", Offset = "0x4FFF10", Length = "0x6A")]
  private void Start()
  {
  }

  [Token(Token = "0x6000C26")]
  [Address(RVA = "0x500F80", Offset = "0x4FFB80", Length = "0x6D")]
  protected void OnDestroy()
  {
  }

  [Token(Token = "0x6000C27")]
  [Address(RVA = "0x500D80", Offset = "0x4FF980", Length = "0xF8")]
  private void Update()
  {
  }

  [Token(Token = "0x6000C28")]
  [Address(RVA = "0x501070", Offset = "0x4FFC70", Length = "0x296")]
  public virtual void SetSetting(
    Action<string, object, CFSettings> saveAction,
    string settingName,
    object currentValue,
    Settings settings,
    CFSettings cfSettings)
  {
  }

  [Token(Token = "0x6000C29")]
  [Address(RVA = "0x500FF0", Offset = "0x4FFBF0", Length = "0x63")]
  private void OnLocaleChanged(Locale locale)
  {
  }

  [Token(Token = "0x6000C2A")]
  [Address(RVA = "0x500FF0", Offset = "0x4FFBF0", Length = "0x63")]
  private void RefreshLanguage()
  {
  }

  [Token(Token = "0x6000C2B")]
  [Address(RVA = "0x501380", Offset = "0x4FFF80", Length = "0xD3")]
  public void UpdateValue()
  {
  }

  [Token(Token = "0x6000C2C")]
  public abstract void ControllerInputDir(int dir, float multiplier);

  [Token(Token = "0x6000C2D")]
  [Address(RVA = "0x500BB0", Offset = "0x4FF7B0", Length = "0x37")]
  protected void SaveValue()
  {
  }

  [Token(Token = "0x6000C2E")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected virtual void OnSetting()
  {
  }

  [Token(Token = "0x6000C2F")]
  protected abstract void ShowValue();

  [Token(Token = "0x6000C30")]
  [Address(RVA = "0x501060", Offset = "0x4FFC60", Length = "0x8")]
  private void OnMouseEnter()
  {
  }

  [Token(Token = "0x6000C31")]
  [Address(RVA = "0x500D80", Offset = "0x4FF980", Length = "0xF8")]
  private void CustomPointerHandler()
  {
  }

  [Token(Token = "0x6000C32")]
  [Address(RVA = "0x500C90", Offset = "0x4FF890", Length = "0xE6")]
  private void CheckExtraScripts()
  {
  }

  [Token(Token = "0x6000C33")]
  [Address(RVA = "0x500E80", Offset = "0x4FFA80", Length = "0x4F")]
  public void Disable(string disableText)
  {
  }

  [Token(Token = "0x6000C34")]
  [Address(RVA = "0x500ED0", Offset = "0x4FFAD0", Length = "0x20")]
  public void Enable()
  {
  }

  [Token(Token = "0x6000C35")]
  [Address(RVA = "0x500F00", Offset = "0x4FFB00", Length = "0x7F")]
  public bool IsDisabled() => false;

  [Token(Token = "0x6000C36")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  protected BetterSetting()
  {
  }
}
