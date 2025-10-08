// Decompiled with JetBrains decompiler
// Type: MenuParticles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Coffee.UIExtensions;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000D9")]
public class MenuParticles : MonoBehaviour
{
  [Token(Token = "0x400073B")]
  [FieldOffset(Offset = "0x20")]
  public GameObject coinEffect;
  [Token(Token = "0x400073C")]
  [FieldOffset(Offset = "0x28")]
  public GameObject cointEffectParent;
  [Token(Token = "0x400073D")]
  [FieldOffset(Offset = "0x30")]
  public UIParticleAttractor coinAttractor;
  [Token(Token = "0x400073E")]
  public static MenuParticles Instance;

  [Token(Token = "0x600061E")]
  [Address(RVA = "0x49F460", Offset = "0x49E060", Length = "0x51")]
  private void Awake()
  {
  }

  [Token(Token = "0x600061F")]
  [Address(RVA = "0x49F4C0", Offset = "0x49E0C0", Length = "0x284")]
  public void CoinEffect(Vector3 position)
  {
  }

  [Token(Token = "0x6000620")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void OnCoinCollected()
  {
  }

  [Token(Token = "0x6000621")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MenuParticles()
  {
  }
}
