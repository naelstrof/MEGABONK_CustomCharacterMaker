// Decompiled with JetBrains decompiler
// Type: EnumSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;

[Token(Token = "0x20001D9")]
public class EnumSetting : BetterSetting
{
  [Token(Token = "0x4000D5A")]
  [FieldOffset(Offset = "0x90")]
  public TextMeshProUGUI valueText;

  [Token(Token = "0x6000C37")]
  [Address(RVA = "0x504DC0", Offset = "0x5039C0", Length = "0xCA")]
  public void UpdateValue(int dir)
  {
  }

  [Token(Token = "0x6000C38")]
  [Address(RVA = "0x504AB0", Offset = "0x5036B0", Length = "0xCA")]
  public override void ControllerInputDir(int dir, float multiplier)
  {
  }

  [Token(Token = "0x6000C39")]
  [Address(RVA = "0x504B80", Offset = "0x503780", Length = "0x23A")]
  protected override void ShowValue()
  {
  }

  [Token(Token = "0x6000C3A")]
  [Address(RVA = "0x500A00", Offset = "0x4FF600", Length = "0x3B")]
  private int GetValue() => 0;

  [Token(Token = "0x6000C3B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public EnumSetting()
  {
  }
}
