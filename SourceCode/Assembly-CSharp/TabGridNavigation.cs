// Decompiled with JetBrains decompiler
// Type: TabGridNavigation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001EE")]
public class TabGridNavigation : MonoBehaviour
{
  [Token(Token = "0x4000DCF")]
  [FieldOffset(Offset = "0x20")]
  public GameObject buttonsParent;

  [Token(Token = "0x6000CCB")]
  [Address(RVA = "0x52FD50", Offset = "0x52E950", Length = "0x3FC")]
  public void Set(Button tabButton)
  {
  }

  [Token(Token = "0x6000CCC")]
  [Address(RVA = "0x52F9F0", Offset = "0x52E5F0", Length = "0x35E")]
  private int ComputeRowLengthByPosition(List<Button> buttons) => 0;

  [Token(Token = "0x6000CCD")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TabGridNavigation()
  {
  }
}
