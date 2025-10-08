// Decompiled with JetBrains decompiler
// Type: SlideEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000102")]
public class SlideEffect : MonoBehaviour
{
  [Token(Token = "0x40007F3")]
  [FieldOffset(Offset = "0x20")]
  public PlayerMovement playerMovement;
  [Token(Token = "0x40007F4")]
  [FieldOffset(Offset = "0x28")]
  public GameObject parent;
  [Token(Token = "0x40007F5")]
  [FieldOffset(Offset = "0x30")]
  public GameObject dirtParticles;
  [Token(Token = "0x40007F6")]
  [FieldOffset(Offset = "0x38")]
  private float minSpeed;

  [Token(Token = "0x60006C1")]
  [Address(RVA = "0x4C5370", Offset = "0x4C3F70", Length = "0x26")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006C2")]
  [Address(RVA = "0x4C53A0", Offset = "0x4C3FA0", Length = "0x3B9")]
  private void Update()
  {
  }

  [Token(Token = "0x60006C3")]
  [Address(RVA = "0x4C5760", Offset = "0x4C4360", Length = "0xE")]
  public SlideEffect()
  {
  }
}
