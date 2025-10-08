// Decompiled with JetBrains decompiler
// Type: VersionNumber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000122")]
public class VersionNumber : MonoBehaviour
{
  [Token(Token = "0x4000899")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_version;

  [Token(Token = "0x6000744")]
  [Address(RVA = "0x4CAEC0", Offset = "0x4C9AC0", Length = "0x1BC")]
  private void Start()
  {
  }

  [Token(Token = "0x6000745")]
  [Address(RVA = "0x4CACF0", Offset = "0x4C98F0", Length = "0x138")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000746")]
  [Address(RVA = "0x4CAE30", Offset = "0x4C9A30", Length = "0x89")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000747")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public VersionNumber()
  {
  }
}
