// Decompiled with JetBrains decompiler
// Type: BossMeteor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200006D")]
public class BossMeteor : MonoBehaviour
{
  [Token(Token = "0x4000356")]
  [FieldOffset(Offset = "0x20")]
  public Transform destination;
  [Token(Token = "0x4000357")]
  [FieldOffset(Offset = "0x28")]
  public float speed;
  [Token(Token = "0x4000358")]
  [FieldOffset(Offset = "0x30")]
  public GameObject explosionFx;
  [Token(Token = "0x4000359")]
  [FieldOffset(Offset = "0x38")]
  public FianlBossCinematic cinematic;

  [Token(Token = "0x60002BC")]
  [Address(RVA = "0x45B400", Offset = "0x45A000", Length = "0x358")]
  private void Update()
  {
  }

  [Token(Token = "0x60002BD")]
  [Address(RVA = "0x45B760", Offset = "0x45A360", Length = "0xE")]
  public BossMeteor()
  {
  }
}
