// Decompiled with JetBrains decompiler
// Type: ReturnWeaponWui
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200020A")]
public class ReturnWeaponWui : MonoBehaviour
{
  [Token(Token = "0x4000E55")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000E56")]
  [FieldOffset(Offset = "0x28")]
  private Transform target;
  [Token(Token = "0x4000E57")]
  [FieldOffset(Offset = "0x30")]
  private Vector3 targetOffset;
  [Token(Token = "0x4000E58")]
  [FieldOffset(Offset = "0x3C")]
  private float scale;
  [Token(Token = "0x4000E59")]
  [FieldOffset(Offset = "0x40")]
  private bool useScaleDown;
  [Token(Token = "0x4000E5A")]
  [FieldOffset(Offset = "0x44")]
  private int phase;
  [Token(Token = "0x4000E5B")]
  [FieldOffset(Offset = "0x48")]
  private float timer;
  [Token(Token = "0x4000E5C")]
  [FieldOffset(Offset = "0x4C")]
  private float moveUpTimer;
  [Token(Token = "0x4000E5D")]
  [FieldOffset(Offset = "0x50")]
  private float moveUpTime;
  [Token(Token = "0x4000E5E")]
  [FieldOffset(Offset = "0x54")]
  private float floatAbovePlayerHeadTime;
  [Token(Token = "0x4000E5F")]
  [FieldOffset(Offset = "0x58")]
  private float scaleDownTime;

  [Token(Token = "0x6000D62")]
  [Address(RVA = "0x52C290", Offset = "0x52AE90", Length = "0x183")]
  public void Set(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000D63")]
  [Address(RVA = "0x52C420", Offset = "0x52B020", Length = "0x76D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D64")]
  [Address(RVA = "0x52CB90", Offset = "0x52B790", Length = "0x15")]
  public ReturnWeaponWui()
  {
  }
}
