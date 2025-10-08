// Decompiled with JetBrains decompiler
// Type: AnimatedMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (MeshFilter))]
[Token(Token = "0x200000A")]
public class AnimatedMesh : MonoBehaviour
{
  [SerializeField]
  [Token(Token = "0x400001A")]
  [FieldOffset(Offset = "0x20")]
  private AnimatedMeshScriptableObject AnimationSO;
  [Token(Token = "0x400001B")]
  [FieldOffset(Offset = "0x28")]
  private MeshFilter Filter;
  [Header("Debug")]
  [SerializeField]
  [Token(Token = "0x400001C")]
  [FieldOffset(Offset = "0x30")]
  private int Tick;
  [SerializeField]
  [Token(Token = "0x400001D")]
  [FieldOffset(Offset = "0x34")]
  private int AnimationIndex;
  [SerializeField]
  [Token(Token = "0x400001E")]
  [FieldOffset(Offset = "0x38")]
  private string AnimationName;
  [Token(Token = "0x400001F")]
  [FieldOffset(Offset = "0x40")]
  private List<Mesh> AnimationMeshes;
  [Token(Token = "0x4000020")]
  [FieldOffset(Offset = "0x48")]
  public bool paused;
  [Token(Token = "0x4000022")]
  [FieldOffset(Offset = "0x58")]
  private float LastTickTime;
  [Token(Token = "0x4000023")]
  [FieldOffset(Offset = "0x5C")]
  private float tickInterval;
  [Token(Token = "0x4000024")]
  [FieldOffset(Offset = "0x60")]
  public bool testing;

  [Token(Token = "0x14000001")]
  public event AnimatedMesh.AnimationEndEvent OnAnimationEnd
  {
    [Token(Token = "0x600001A"), Address(RVA = "0x339040", Offset = "0x337C40", Length = "0x9E")] add
    {
    }
    [Token(Token = "0x600001B"), Address(RVA = "0x3390E0", Offset = "0x337CE0", Length = "0x9E")] remove
    {
    }
  }

  [Token(Token = "0x600001C")]
  [Address(RVA = "0x338E00", Offset = "0x337A00", Length = "0xE0")]
  public void SetAnimation(AnimatedMeshScriptableObject animation)
  {
  }

  [Token(Token = "0x600001D")]
  [Address(RVA = "0x338CC0", Offset = "0x3378C0", Length = "0x127")]
  private void Awake()
  {
  }

  [Token(Token = "0x600001E")]
  [Address(RVA = "0x338DF0", Offset = "0x3379F0", Length = "0x5")]
  public void Pause()
  {
  }

  [Token(Token = "0x600001F")]
  [Address(RVA = "0x338EF0", Offset = "0x337AF0", Length = "0x5")]
  public void UnPause()
  {
  }

  [Token(Token = "0x6000020")]
  [Address(RVA = "0x338F00", Offset = "0x337B00", Length = "0x122")]
  private void Update()
  {
  }

  [Token(Token = "0x6000021")]
  [Address(RVA = "0x339030", Offset = "0x337C30", Length = "0xE")]
  public AnimatedMesh()
  {
  }

  [Token(Token = "0x200000B")]
  public delegate void AnimationEndEvent(string Name);
}
