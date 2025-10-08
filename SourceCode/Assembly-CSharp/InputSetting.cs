// Decompiled with JetBrains decompiler
// Type: InputSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

[Token(Token = "0x20001DA")]
public class InputSetting : BetterSetting
{
  [Token(Token = "0x4000D5B")]
  [FieldOffset(Offset = "0x90")]
  public KeyDisplay[] keyDisplays;
  [Token(Token = "0x4000D5C")]
  [FieldOffset(Offset = "0x98")]
  private int listenSlot;

  [Token(Token = "0x6000C3C")]
  [Address(RVA = "0x508D70", Offset = "0x507970", Length = "0x14A")]
  private new void Awake()
  {
  }

  [Token(Token = "0x6000C3D")]
  [Address(RVA = "0x508EC0", Offset = "0x507AC0", Length = "0x140")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000C3E")]
  [Address(RVA = "0x47D460", Offset = "0x47C060", Length = "0x11")]
  private void OnControllerChange(EControllerType controllerType)
  {
  }

  [Token(Token = "0x6000C3F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void ControllerInputDir(int dir, float multiplier)
  {
  }

  [Token(Token = "0x6000C40")]
  [Address(RVA = "0x509120", Offset = "0x507D20", Length = "0xCF")]
  protected override void ShowValue()
  {
  }

  [Token(Token = "0x6000C41")]
  [Address(RVA = "0x5091F0", Offset = "0x507DF0", Length = "0x7")]
  public void StartListening(int slot)
  {
  }

  [Token(Token = "0x6000C42")]
  [Address(RVA = "0x509010", Offset = "0x507C10", Length = "0x103")]
  public void SetKey(int keyCode)
  {
  }

  [Token(Token = "0x6000C43")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public InputSetting()
  {
  }
}
