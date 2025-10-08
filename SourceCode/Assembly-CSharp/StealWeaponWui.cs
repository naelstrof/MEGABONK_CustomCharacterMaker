// Decompiled with JetBrains decompiler
// Type: StealWeaponWui
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200020B")]
public class StealWeaponWui : MonoBehaviour
{
  [Token(Token = "0x4000E60")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000E61")]
  [FieldOffset(Offset = "0x28")]
  private Transform target;
  [Token(Token = "0x4000E62")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 targetOffset;
  [Token(Token = "0x4000E63")]
  [FieldOffset(Offset = "0x3C")]
  private float scale;
  [Token(Token = "0x4000E64")]
  [FieldOffset(Offset = "0x40")]
  private bool useScaleDown;
  [Token(Token = "0x4000E65")]
  [FieldOffset(Offset = "0x44")]
  private int phase;
  [Token(Token = "0x4000E66")]
  [FieldOffset(Offset = "0x48")]
  private float timer;
  [Token(Token = "0x4000E67")]
  [FieldOffset(Offset = "0x4C")]
  private float moveUpTimer;
  [Token(Token = "0x4000E68")]
  [FieldOffset(Offset = "0x50")]
  private float moveUpTime;
  [Token(Token = "0x4000E69")]
  [FieldOffset(Offset = "0x54")]
  private float floatAbovePlayerHeadTime;
  [Token(Token = "0x4000E6A")]
  [FieldOffset(Offset = "0x58")]
  private float moveTime;

  [Token(Token = "0x6000D65")]
  [Address(RVA = "0x52F060", Offset = "0x52DC60", Length = "0x1DB")]
  public void Set(
    UnlockableBase unlockable,
    Transform target,
    Vector3 targetOffset,
    float hoverTime,
    float moveTime,
    float scale,
    bool useScaleDown = false)
  {
  }

  [Token(Token = "0x6000D66")]
  [Address(RVA = "0x52F240", Offset = "0x52DE40", Length = "0x78D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D67")]
  [Address(RVA = "0x52F9D0", Offset = "0x52E5D0", Length = "0x15")]
  public StealWeaponWui()
  {
  }
}
