// Decompiled with JetBrains decompiler
// Type: Actors.Enemies.EnemySpawnParticles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

namespace Actors.Enemies
{
  [Token(Token = "0x20002CD")]
  public class EnemySpawnParticles : MonoBehaviour
  {
    [Token(Token = "0x4001337")]
    [FieldOffset(Offset = "0x20")]
    public RandomSfx audio;
    [Token(Token = "0x4001338")]
    [FieldOffset(Offset = "0x28")]
    public ParticleSystem ps;

    [Token(Token = "0x60014ED")]
    [Address(RVA = "0x38DD30", Offset = "0x38C930", Length = "0xF7")]
    public void Set(Enemy enemy)
    {
    }

    [Token(Token = "0x60014EE")]
    [Address(RVA = "0x38DB60", Offset = "0x38C760", Length = "0x1C5")]
    public void Release()
    {
    }

    [Token(Token = "0x60014EF")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public EnemySpawnParticles()
    {
    }
  }
}
