// Decompiled with JetBrains decompiler
// Type: PlayerFx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using MilkShake;
using UnityEngine;

[Token(Token = "0x200001A")]
public class PlayerFx : MonoBehaviour
{
  [Token(Token = "0x40000E2")]
  [FieldOffset(Offset = "0x20")]
  public GameObject jumpFx;
  [Token(Token = "0x40000E3")]
  [FieldOffset(Offset = "0x28")]
  public GameObject landFx;
  [Token(Token = "0x40000E4")]
  [FieldOffset(Offset = "0x30")]
  public PlayerMovement playerMovement;
  [Token(Token = "0x40000E5")]
  [FieldOffset(Offset = "0x38")]
  public ShakePreset landingShake;

  [Token(Token = "0x60000C5")]
  [Address(RVA = "0x3414A0", Offset = "0x3400A0", Length = "0x222")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000C6")]
  [Address(RVA = "0x3416D0", Offset = "0x3402D0", Length = "0x222")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000C7")]
  [Address(RVA = "0x341900", Offset = "0x340500", Length = "0x1F4")]
  private void OnJumped(PlayerMovement obj)
  {
  }

  [Token(Token = "0x60000C8")]
  [Address(RVA = "0x341B00", Offset = "0x340700", Length = "0x25B")]
  private void OnLanded(float fallSpeed)
  {
  }

  [Token(Token = "0x60000C9")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public PlayerFx()
  {
  }
}
