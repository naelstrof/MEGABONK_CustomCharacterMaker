// Decompiled with JetBrains decompiler
// Type: IButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001CB")]
public interface IButton
{
  [Token(Token = "0x6000BAB")]
  void Select();

  [Token(Token = "0x6000BAC")]
  void Deselect(IButton newButton);

  [Token(Token = "0x6000BAD")]
  Button GetButton();

  [Token(Token = "0x6000BAE")]
  GameObject GetAssociatedContent();

  [Token(Token = "0x6000BAF")]
  bool IsTabSelectable();

  [Token(Token = "0x6000BB0")]
  void Enable();

  [Token(Token = "0x6000BB1")]
  void Disable();
}
