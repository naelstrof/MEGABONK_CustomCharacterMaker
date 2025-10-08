// Decompiled with JetBrains decompiler
// Type: RetroArsenalLib.RetroVFXLibrary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace RetroArsenalLib
{
  [Token(Token = "0x2000458")]
  public class RetroVFXLibrary : MonoBehaviour
  {
    [Token(Token = "0x4001C8A")]
    public static RetroVFXLibrary GlobalAccess;
    [Token(Token = "0x4001C8B")]
    [FieldOffset(Offset = "0x20")]
    public int TotalEffects;
    [Token(Token = "0x4001C8C")]
    [FieldOffset(Offset = "0x24")]
    public int CurrentParticleEffectIndex;
    [Token(Token = "0x4001C8D")]
    [FieldOffset(Offset = "0x28")]
    public int CurrentParticleEffectNum;
    [Token(Token = "0x4001C8E")]
    [FieldOffset(Offset = "0x30")]
    public Vector3[] ParticleEffectSpawnOffsets;
    [Token(Token = "0x4001C8F")]
    [FieldOffset(Offset = "0x38")]
    public float[] ParticleEffectLifetimes;
    [Token(Token = "0x4001C90")]
    [FieldOffset(Offset = "0x40")]
    public GameObject[] ParticleEffectPrefabs;
    [Token(Token = "0x4001C91")]
    [FieldOffset(Offset = "0x48")]
    private List<Transform> currentActivePEList;
    [Token(Token = "0x4001C92")]
    [FieldOffset(Offset = "0x50")]
    private StringBuilder effectNameBuilder;

    [Token(Token = "0x6001F63")]
    [Address(RVA = "0x451D50", Offset = "0x450950", Length = "0xC6")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001F64")]
    [Address(RVA = "0x452010", Offset = "0x450C10", Length = "0x2A")]
    public string GetCurrentPENameString() => (string) null;

    [Token(Token = "0x6001F65")]
    [Address(RVA = "0x452070", Offset = "0x450C70", Length = "0x30")]
    public void PreviousParticleEffect()
    {
    }

    [Token(Token = "0x6001F66")]
    [Address(RVA = "0x452040", Offset = "0x450C40", Length = "0x2B")]
    public void NextParticleEffect()
    {
    }

    [Token(Token = "0x6001F67")]
    [Address(RVA = "0x451E20", Offset = "0x450A20", Length = "0x1EC")]
    private void DestroyLoopingParticleEffects()
    {
    }

    [Token(Token = "0x6001F68")]
    [Address(RVA = "0x452360", Offset = "0x450F60", Length = "0x127")]
    private void UpdateEffectNameString()
    {
    }

    [Token(Token = "0x6001F69")]
    [Address(RVA = "0x4520A0", Offset = "0x450CA0", Length = "0x2BF")]
    public void SpawnParticleEffect(Vector3 positionInWorldToSpawn)
    {
    }

    [Token(Token = "0x6001F6A")]
    [Address(RVA = "0x452490", Offset = "0x451090", Length = "0xAC")]
    public RetroVFXLibrary()
    {
    }
  }
}
