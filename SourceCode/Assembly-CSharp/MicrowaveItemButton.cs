// Decompiled with JetBrains decompiler
// Type: MicrowaveItemButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x2000169")]
public class MicrowaveItemButton : MyButton
{
  [Token(Token = "0x4000A8B")]
  [FieldOffset(Offset = "0x58")]
  public RawImage icon;
  [Token(Token = "0x4000A8C")]
  [FieldOffset(Offset = "0x60")]
  private MicrowaveUi microwaveUi;
  [Token(Token = "0x4000A8D")]
  [FieldOffset(Offset = "0x68")]
  private ItemData itemData;

  [Token(Token = "0x6000920")]
  [Address(RVA = "0x4D6FC0", Offset = "0x4D5BC0", Length = "0xA7")]
  public void Set(MicrowaveUi microwaveUi, EItem eItem)
  {
  }

  [Token(Token = "0x6000921")]
  [Address(RVA = "0x4D6D60", Offset = "0x4D5960", Length = "0x258")]
  public void SelectUpgrade()
  {
  }

  [Token(Token = "0x6000922")]
  [Address(RVA = "0x4D7070", Offset = "0x4D5C70", Length = "0x5")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000923")]
  [Address(RVA = "0x4D7080", Offset = "0x4D5C80", Length = "0x5")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000924")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000925")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MicrowaveItemButton()
  {
  }
}
