// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.DamageSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x200032B")]
  public class DamageSource
  {
    [Token(Token = "0x4001572")]
    [FieldOffset(Offset = "0x10")]
    public string damageSource;
    [Token(Token = "0x4001573")]
    [FieldOffset(Offset = "0x18")]
    public float addedAtTime;
    [Token(Token = "0x4001574")]
    [FieldOffset(Offset = "0x1C")]
    public float damage;

    [Token(Token = "0x600167F")]
    [Address(RVA = "0x3A7D50", Offset = "0x3A6950", Length = "0x44")]
    public DamageSource(string damageSource, float addedAtTime)
    {
    }

    [Token(Token = "0x6001680")]
    [Address(RVA = "0x3A7720", Offset = "0x3A6320", Length = "0xB")]
    public void AddDamage(float d)
    {
    }

    [Token(Token = "0x6001681")]
    [Address(RVA = "0x3A7AE0", Offset = "0x3A66E0", Length = "0x260")]
    public int GetLevel() => 0;

    [Token(Token = "0x6001682")]
    [Address(RVA = "0x3A7730", Offset = "0x3A6330", Length = "0x3AA")]
    public Texture GetIcon() => (Texture) null;
  }
}
