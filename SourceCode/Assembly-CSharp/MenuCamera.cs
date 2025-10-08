// Decompiled with JetBrains decompiler
// Type: MenuCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000037")]
public class MenuCamera : MonoBehaviour
{
  [Token(Token = "0x400019A")]
  [FieldOffset(Offset = "0x20")]
  public Transform defaultTransform;
  [Token(Token = "0x400019B")]
  [FieldOffset(Offset = "0x28")]
  public Transform characterSelectionTransform;
  [Token(Token = "0x400019C")]
  [FieldOffset(Offset = "0x30")]
  private Transform currentTransform;
  [Token(Token = "0x400019D")]
  [FieldOffset(Offset = "0x38")]
  public Camera camera;

  [Token(Token = "0x6000180")]
  [Address(RVA = "0x35F160", Offset = "0x35DD60", Length = "0x37")]
  private void Start()
  {
  }

  [Token(Token = "0x6000181")]
  [Address(RVA = "0x35F120", Offset = "0x35DD20", Length = "0x11")]
  public void GoToCharacters()
  {
  }

  [Token(Token = "0x6000182")]
  [Address(RVA = "0x35F140", Offset = "0x35DD40", Length = "0x11")]
  public void GoToMain()
  {
  }

  [Token(Token = "0x6000183")]
  [Address(RVA = "0x35F1A0", Offset = "0x35DDA0", Length = "0x1E7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000184")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MenuCamera()
  {
  }
}
