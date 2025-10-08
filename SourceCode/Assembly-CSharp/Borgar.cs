// Decompiled with JetBrains decompiler
// Type: Borgar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000067")]
public class Borgar : MonoBehaviour
{
  [Token(Token = "0x4000343")]
  [FieldOffset(Offset = "0x20")]
  private int flatHeal;
  [Token(Token = "0x4000344")]
  [FieldOffset(Offset = "0x24")]
  private float ratioHeal;
  [Token(Token = "0x4000345")]
  [FieldOffset(Offset = "0x28")]
  private float timeoutAtTime;
  [Token(Token = "0x4000346")]
  [FieldOffset(Offset = "0x2C")]
  private float timeoutTime;

  [Token(Token = "0x600029F")]
  [Address(RVA = "0x45B300", Offset = "0x459F00", Length = "0x80")]
  public void Set(int flatHeal, float ratioHeal)
  {
  }

  [Token(Token = "0x60002A0")]
  [Address(RVA = "0x45B010", Offset = "0x459C10", Length = "0x2EC")]
  private void OnCollisionEnter(Collision collision)
  {
  }

  [Token(Token = "0x60002A1")]
  [Address(RVA = "0x45B380", Offset = "0x459F80", Length = "0x6B")]
  private void Update()
  {
  }

  [Token(Token = "0x60002A2")]
  [Address(RVA = "0x45AF30", Offset = "0x459B30", Length = "0xDA")]
  private void DestroyBorgar()
  {
  }

  [Token(Token = "0x60002A3")]
  [Address(RVA = "0x45B3F0", Offset = "0x459FF0", Length = "0xE")]
  public Borgar()
  {
  }
}
