// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Actors.DamageContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Combat;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Actors
{
  [Token(Token = "0x200044F")]
  public class DamageContainer
  {
    [Token(Token = "0x4001BE6")]
    public const string unknownDamageSource = "Unkown";
    [Token(Token = "0x4001BE7")]
    [FieldOffset(Offset = "0x10")]
    public Vector3 direction;
    [Token(Token = "0x4001BE8")]
    [FieldOffset(Offset = "0x1C")]
    public float damage;
    [Token(Token = "0x4001BE9")]
    [FieldOffset(Offset = "0x20")]
    public bool crit;
    [Token(Token = "0x4001BEA")]
    [FieldOffset(Offset = "0x24")]
    public float knockback;
    [Token(Token = "0x4001BEB")]
    [FieldOffset(Offset = "0x28")]
    public Enemy enemy;
    [Token(Token = "0x4001BEC")]
    [FieldOffset(Offset = "0x30")]
    public EDamageEffect damageEffect;
    [Token(Token = "0x4001BED")]
    [FieldOffset(Offset = "0x34")]
    public EElement element;
    [Token(Token = "0x4001BEE")]
    [FieldOffset(Offset = "0x38")]
    public float procCoefficient;
    [Token(Token = "0x4001BEF")]
    [FieldOffset(Offset = "0x40")]
    public string damageSource;
    [Token(Token = "0x4001BF0")]
    [FieldOffset(Offset = "0x48")]
    public int damageBlockedByArmor;
    [Token(Token = "0x4001BF1")]
    [FieldOffset(Offset = "0x4C")]
    public DcFlags flags;

    [Token(Token = "0x6001EC5")]
    [Address(RVA = "0x43D240", Offset = "0x43BE40", Length = "0x6C")]
    public DamageContainer(float procCoefficient, string damageSource)
    {
    }

    [Token(Token = "0x6001EC6")]
    [Address(RVA = "0x43D1B0", Offset = "0x43BDB0", Length = "0x89")]
    public void Reuse(float procCoefficient, string damageSource)
    {
    }

    [Token(Token = "0x6001EC7")]
    [Address(RVA = "0x43D110", Offset = "0x43BD10", Length = "0xA0")]
    public Color GetColor() => new Color();
  }
}
