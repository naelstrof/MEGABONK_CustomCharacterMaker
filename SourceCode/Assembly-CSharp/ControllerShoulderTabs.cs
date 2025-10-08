// Decompiled with JetBrains decompiler
// Type: ControllerShoulderTabs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000191")]
public class ControllerShoulderTabs : MonoBehaviour
{
  [Token(Token = "0x4000B73")]
  [FieldOffset(Offset = "0x20")]
  public ButtonNavigationSelectionOnly tabs;
  [Token(Token = "0x4000B74")]
  [FieldOffset(Offset = "0x28")]
  public Window parentWindow;

  [Token(Token = "0x6000A27")]
  [Address(RVA = "0x4EC030", Offset = "0x4EAC30", Length = "0x89")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A28")]
  [Address(RVA = "0x4EC0C0", Offset = "0x4EACC0", Length = "0x18D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A29")]
  [Address(RVA = "0x4EBF40", Offset = "0x4EAB40", Length = "0xE1")]
  private void ShoulderNav(int dir)
  {
  }

  [Token(Token = "0x6000A2A")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ControllerShoulderTabs()
  {
  }
}
