// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Managers.ParticleSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Managers
{
  [Token(Token = "0x2000359")]
  public class ParticleSpawner : MonoBehaviour
  {
    [Token(Token = "0x60017D9")]
    [Address(RVA = "0x3D5220", Offset = "0x3D3E20", Length = "0x97")]
    public static GameObject SpawnParticles(
      GameObject particles,
      Vector3 position,
      Quaternion rotation)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60017DA")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public ParticleSpawner()
    {
    }
  }
}
