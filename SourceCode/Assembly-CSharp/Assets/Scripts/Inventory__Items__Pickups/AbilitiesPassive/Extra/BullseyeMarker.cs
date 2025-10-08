// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Extra.BullseyeMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive.Extra
{
  [Token(Token = "0x2000408")]
  public class BullseyeMarker : MonoBehaviour
  {
    [Token(Token = "0x4001A81")]
    [FieldOffset(Offset = "0x20")]
    private Enemy markedEnemy;
    [Token(Token = "0x4001A82")]
    [FieldOffset(Offset = "0x28")]
    private float doneAtTime;

    [Token(Token = "0x6001D15")]
    [Address(RVA = "0x41DC20", Offset = "0x41C820", Length = "0x241")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001D16")]
    [Address(RVA = "0x41E060", Offset = "0x41CC60", Length = "0x241")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001D17")]
    [Address(RVA = "0x41E330", Offset = "0x41CF30", Length = "0xA5")]
    public void Set(Enemy enemy, float duration)
    {
    }

    [Token(Token = "0x6001D18")]
    [Address(RVA = "0x41E3E0", Offset = "0x41CFE0", Length = "0x3F6")]
    private void Update()
    {
    }

    [Token(Token = "0x6001D19")]
    [Address(RVA = "0x41E2B0", Offset = "0x41CEB0", Length = "0x76")]
    private void OnEnemyReleasedFromPool(Enemy enemy)
    {
    }

    [Token(Token = "0x6001D1A")]
    [Address(RVA = "0x41E2B0", Offset = "0x41CEB0", Length = "0x76")]
    private void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x6001D1B")]
    [Address(RVA = "0x41DE70", Offset = "0x41CA70", Length = "0x1EA")]
    private void Cleanup()
    {
    }

    [Token(Token = "0x6001D1C")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public BullseyeMarker()
    {
    }
  }
}
