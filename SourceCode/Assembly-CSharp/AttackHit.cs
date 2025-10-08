// Decompiled with JetBrains decompiler
// Type: AttackHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Pool;

[Token(Token = "0x20000B2")]
public class AttackHit : MonoBehaviour
{
  [Token(Token = "0x4000598")]
  [FieldOffset(Offset = "0x20")]
  public float timeout;
  [Token(Token = "0x4000599")]
  [FieldOffset(Offset = "0x28")]
  public RandomSfx randomSfx;
  [Token(Token = "0x400059A")]
  [FieldOffset(Offset = "0x30")]
  public ParticleSystem ps;
  [Token(Token = "0x400059B")]
  [FieldOffset(Offset = "0x38")]
  public ObjectPool<GameObject> pool;
  [Token(Token = "0x400059C")]
  [FieldOffset(Offset = "0x40")]
  public AudioClip enemyHitSfx;
  [Token(Token = "0x400059D")]
  [FieldOffset(Offset = "0x48")]
  public AudioClip wallHitSfx;

  [Token(Token = "0x6000480")]
  [Address(RVA = "0x4750A0", Offset = "0x473CA0", Length = "0x194")]
  public void Play(bool hitEnemy, bool useSfx)
  {
  }

  [Token(Token = "0x6000481")]
  [Address(RVA = "0x475240", Offset = "0x473E40", Length = "0x5D")]
  private void ReleaseToPool()
  {
  }

  [Token(Token = "0x6000482")]
  [Address(RVA = "0x475020", Offset = "0x473C20", Length = "0x74")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000483")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public AttackHit()
  {
  }
}
