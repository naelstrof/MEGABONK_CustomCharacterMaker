// Decompiled with JetBrains decompiler
// Type: Shield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000AC")]
public class Shield : MonoBehaviour
{
  [Token(Token = "0x4000567")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 defaultScale;
  [Token(Token = "0x4000568")]
  [FieldOffset(Offset = "0x2C")]
  private float destroyTimer;
  [Token(Token = "0x4000569")]
  [FieldOffset(Offset = "0x30")]
  private Renderer renderer;
  [Token(Token = "0x400056A")]
  [FieldOffset(Offset = "0x38")]
  private Material shieldMaterial;
  [Token(Token = "0x400056B")]
  [FieldOffset(Offset = "0x40")]
  public AudioSource sfx;
  [Token(Token = "0x400056C")]
  [FieldOffset(Offset = "0x48")]
  private float defaultVolume;
  [Token(Token = "0x400056D")]
  [FieldOffset(Offset = "0x4C")]
  private float scaleTime;

  [Token(Token = "0x6000458")]
  [Address(RVA = "0x48E5E0", Offset = "0x48D1E0", Length = "0x242")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000459")]
  [Address(RVA = "0x48E830", Offset = "0x48D430", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600045A")]
  [Address(RVA = "0x48E960", Offset = "0x48D560", Length = "0x2B")]
  private void OnPickup(Pickup pickup)
  {
  }

  [Token(Token = "0x600045B")]
  [Address(RVA = "0x48EA40", Offset = "0x48D640", Length = "0x3D8")]
  private void Update()
  {
  }

  [Token(Token = "0x600045C")]
  [Address(RVA = "0x48E990", Offset = "0x48D590", Length = "0xA8")]
  private void UpdateAlpha(float alpha)
  {
  }

  [Token(Token = "0x600045D")]
  [Address(RVA = "0x48EE20", Offset = "0x48DA20", Length = "0xE")]
  public Shield()
  {
  }
}
