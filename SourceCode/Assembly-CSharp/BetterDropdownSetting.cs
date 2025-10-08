// Decompiled with JetBrains decompiler
// Type: BetterDropdownSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;

[Token(Token = "0x20001D7")]
public class BetterDropdownSetting : BetterSetting
{
  [Token(Token = "0x4000D49")]
  [FieldOffset(Offset = "0x90")]
  public TextMeshProUGUI title;
  [Token(Token = "0x4000D4A")]
  [FieldOffset(Offset = "0x98")]
  public MyButton resButton;

  [Token(Token = "0x6000C1E")]
  [Address(RVA = "0x5009C0", Offset = "0x4FF5C0", Length = "0x38")]
  public override void ControllerInputDir(int dir, float multiplier)
  {
  }

  [Token(Token = "0x6000C1F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnSetting()
  {
  }

  [Token(Token = "0x6000C20")]
  [Address(RVA = "0x500BB0", Offset = "0x4FF7B0", Length = "0x37")]
  public void ValueChanged()
  {
  }

  [Token(Token = "0x6000C21")]
  [Address(RVA = "0x500A40", Offset = "0x4FF640", Length = "0x16D")]
  protected override void ShowValue()
  {
  }

  [Token(Token = "0x6000C22")]
  [Address(RVA = "0x500A00", Offset = "0x4FF600", Length = "0x3B")]
  private int GetValue() => 0;

  [Token(Token = "0x6000C23")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public BetterDropdownSetting()
  {
  }
}
