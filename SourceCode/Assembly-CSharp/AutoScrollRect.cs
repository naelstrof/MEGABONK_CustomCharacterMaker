// Decompiled with JetBrains decompiler
// Type: AutoScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001EB")]
public class AutoScrollRect : MonoBehaviour
{
  [Token(Token = "0x4000DC6")]
  [FieldOffset(Offset = "0x20")]
  public ScrollRect scrollRect;
  [Token(Token = "0x4000DC7")]
  [FieldOffset(Offset = "0x28")]
  public RectTransform viewport;
  [Token(Token = "0x4000DC8")]
  [FieldOffset(Offset = "0x30")]
  public RectTransform content;
  [Token(Token = "0x4000DC9")]
  [FieldOffset(Offset = "0x38")]
  public GameObject lastSelected;

  [Token(Token = "0x6000CBE")]
  [Address(RVA = "0x51C8B0", Offset = "0x51B4B0", Length = "0x1D9")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CBF")]
  [Address(RVA = "0x51C5D0", Offset = "0x51B1D0", Length = "0x2DA")]
  private void EnsureVisible(RectTransform target, float padding = 20f)
  {
  }

  [Token(Token = "0x6000CC0")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AutoScrollRect()
  {
  }
}
