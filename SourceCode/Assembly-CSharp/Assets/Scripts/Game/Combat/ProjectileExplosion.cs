// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Combat.ProjectileExplosion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Game.Combat
{
  [Token(Token = "0x2000428")]
  public class ProjectileExplosion : MonoBehaviour
  {
    [Token(Token = "0x4001B22")]
    [FieldOffset(Offset = "0x20")]
    private WeaponAttack weaponAttack;
    [Token(Token = "0x4001B23")]
    [FieldOffset(Offset = "0x28")]
    public GameObject collisionEffect;
    [Token(Token = "0x4001B24")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 effectPos;
    [Token(Token = "0x4001B25")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 effectDir;
    [Token(Token = "0x4001B26")]
    [FieldOffset(Offset = "0x48")]
    private bool useAudio;

    [Token(Token = "0x6001DE3")]
    [Address(RVA = "0x44FE60", Offset = "0x44EA60", Length = "0x28B")]
    public void Set(
      WeaponAttack weaponAttack,
      float radius,
      Vector3 position,
      float defaultRadius)
    {
    }

    [Token(Token = "0x6001DE4")]
    [Address(RVA = "0x44F9E0", Offset = "0x44E5E0", Length = "0x47F")]
    public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
    {
    }

    [Token(Token = "0x6001DE5")]
    [Address(RVA = "0x4500F0", Offset = "0x44ECF0", Length = "0x68")]
    private void SpawnEffect()
    {
    }

    [Token(Token = "0x6001DE6")]
    [Address(RVA = "0x450160", Offset = "0x44ED60", Length = "0xB")]
    public ProjectileExplosion()
    {
    }
  }
}
