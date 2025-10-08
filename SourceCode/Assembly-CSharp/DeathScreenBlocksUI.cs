// Decompiled with JetBrains decompiler
// Type: DeathScreenBlocksUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200014A")]
public class DeathScreenBlocksUI : MonoBehaviour
{
  [Token(Token = "0x40009AC")]
  [FieldOffset(Offset = "0x20")]
  public Material material;
  [Token(Token = "0x40009AD")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audio;
  [Token(Token = "0x40009AE")]
  [FieldOffset(Offset = "0x30")]
  private bool started;
  [Token(Token = "0x40009AF")]
  [FieldOffset(Offset = "0x34")]
  private float transitionTime;
  [Token(Token = "0x40009B0")]
  [FieldOffset(Offset = "0x38")]
  private float timer;

  [Token(Token = "0x6000859")]
  [Address(RVA = "0x4D0D70", Offset = "0x4CF970", Length = "0x8C")]
  public void StartTransition(float transitionTime)
  {
  }

  [Token(Token = "0x600085A")]
  [Address(RVA = "0x4D0E00", Offset = "0x4CFA00", Length = "0x84")]
  private void Update()
  {
  }

  [Token(Token = "0x600085B")]
  [Address(RVA = "0x4D0E90", Offset = "0x4CFA90", Length = "0xE")]
  public DeathScreenBlocksUI()
  {
  }
}
