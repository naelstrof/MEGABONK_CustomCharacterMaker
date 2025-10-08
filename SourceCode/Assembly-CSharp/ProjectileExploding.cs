// Decompiled with JetBrains decompiler
// Type: ProjectileExploding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C0")]
public class ProjectileExploding : ProjectileBasic
{
  [Token(Token = "0x4000659")]
  [FieldOffset(Offset = "0x70")]
  public float explosionRadius;
  [Token(Token = "0x400065A")]
  [FieldOffset(Offset = "0x74")]
  private float fxCooldown;
  [Token(Token = "0x400065B")]
  [FieldOffset(Offset = "0x78")]
  public GameObject explosionEffect;

  [Token(Token = "0x600050F")]
  [Address(RVA = "0x4A54F0", Offset = "0x4A40F0", Length = "0x3A9")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000510")]
  [Address(RVA = "0x4A58A0", Offset = "0x4A44A0", Length = "0x587")]
  private void Hitscan(Collider collider)
  {
  }

  [Token(Token = "0x6000511")]
  [Address(RVA = "0x4A5E30", Offset = "0x4A4A30", Length = "0x15")]
  public ProjectileExploding()
  {
  }
}
