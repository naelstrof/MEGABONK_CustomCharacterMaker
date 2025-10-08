// Decompiled with JetBrains decompiler
// Type: ControllerShaker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000088")]
public class ControllerShaker : MonoBehaviour
{
  [Token(Token = "0x6000360")]
  [Address(RVA = "0x45F2A0", Offset = "0x45DEA0", Length = "0x24D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000361")]
  [Address(RVA = "0x45F720", Offset = "0x45E320", Length = "0x24D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000362")]
  [Address(RVA = "0x45F9A0", Offset = "0x45E5A0", Length = "0x5D")]
  private void OnPlayerTakeDamage(PlayerHealth ph, DamageContainer dc, bool isShield)
  {
  }

  [Token(Token = "0x6000363")]
  [Address(RVA = "0x45F970", Offset = "0x45E570", Length = "0x26")]
  private void OnPlayerLanded(float speed)
  {
  }

  [Token(Token = "0x6000364")]
  [Address(RVA = "0x45FA00", Offset = "0x45E600", Length = "0x130")]
  public static void Shake(int motor, float intensity, float duration)
  {
  }

  [Token(Token = "0x6000365")]
  [Address(RVA = "0x45FB40", Offset = "0x45E740", Length = "0x33")]
  public static void StopShakes()
  {
  }

  [Token(Token = "0x6000366")]
  [Address(RVA = "0x45F4F0", Offset = "0x45E0F0", Length = "0x17C")]
  private static bool CanShake() => false;

  [Token(Token = "0x6000367")]
  [Address(RVA = "0x45F670", Offset = "0x45E270", Length = "0xA1")]
  private static float GetGlobalIntensity() => 0.0f;

  [Token(Token = "0x6000368")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ControllerShaker()
  {
  }
}
