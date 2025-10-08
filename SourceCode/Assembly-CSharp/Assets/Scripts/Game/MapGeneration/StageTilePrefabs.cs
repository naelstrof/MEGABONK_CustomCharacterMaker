// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.MapGeneration.StageTilePrefabs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace Assets.Scripts.Game.MapGeneration
{
  [Token(Token = "0x2000421")]
  [Serializable]
  public class StageTilePrefabs
  {
    [Token(Token = "0x4001AFB")]
    [FieldOffset(Offset = "0x10")]
    public GameObject[] flatTilePrefabs;
    [Token(Token = "0x4001AFC")]
    [FieldOffset(Offset = "0x18")]
    public float populateTilesRatio;

    [Token(Token = "0x6001DC0")]
    [Address(RVA = "0x453350", Offset = "0x451F50", Length = "0xE")]
    public StageTilePrefabs()
    {
    }
  }
}
