// Decompiled with JetBrains decompiler
// Type: TestDeleteMe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000118")]
public class TestDeleteMe : MonoBehaviour
{
  [Token(Token = "0x400085E")]
  [FieldOffset(Offset = "0x20")]
  private Material[] activeMaterials;
  [Token(Token = "0x400085F")]
  [FieldOffset(Offset = "0x28")]
  public Color colorFreeze;
  [Token(Token = "0x4000860")]
  [FieldOffset(Offset = "0x38")]
  public Color poisonColor;

  [Token(Token = "0x6000702")]
  [Address(RVA = "0x4C7CD0", Offset = "0x4C68D0", Length = "0x121")]
  private void Start()
  {
  }

  [Token(Token = "0x6000703")]
  [Address(RVA = "0x4C7E00", Offset = "0x4C6A00", Length = "0x46F")]
  private void Update()
  {
  }

  [Token(Token = "0x6000704")]
  [Address(RVA = "0x4C77F0", Offset = "0x4C63F0", Length = "0x151")]
  private void SetColorBleed()
  {
  }

  [Token(Token = "0x6000705")]
  [Address(RVA = "0x4C7AB0", Offset = "0x4C66B0", Length = "0xBB")]
  private void SetNothing()
  {
  }

  [Token(Token = "0x6000706")]
  [Address(RVA = "0x4C7950", Offset = "0x4C6550", Length = "0x153")]
  private void SetColorFreeze()
  {
  }

  [Token(Token = "0x6000707")]
  [Address(RVA = "0x4C7B70", Offset = "0x4C6770", Length = "0x153")]
  private void SetPoison()
  {
  }

  [Token(Token = "0x6000708")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TestDeleteMe()
  {
  }
}
