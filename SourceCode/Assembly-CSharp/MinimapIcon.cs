// Decompiled with JetBrains decompiler
// Type: MinimapIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000209")]
public class MinimapIcon : MonoBehaviour
{
  [Token(Token = "0x4000E53")]
  [FieldOffset(Offset = "0x20")]
  public bool isStatic;
  [Token(Token = "0x4000E54")]
  [FieldOffset(Offset = "0x21")]
  public bool alignToCamera;

  [Token(Token = "0x6000D5F")]
  [Address(RVA = "0x529690", Offset = "0x528290", Length = "0xB4")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D60")]
  [Address(RVA = "0x529750", Offset = "0x528350", Length = "0x1DF")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D61")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MinimapIcon()
  {
  }
}
