// Decompiled with JetBrains decompiler
// Type: AnimatedMeshScriptableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200000C")]
public class AnimatedMeshScriptableObject : ScriptableObject
{
  [Token(Token = "0x4000025")]
  [FieldOffset(Offset = "0x18")]
  public int AnimationFPS;
  [Token(Token = "0x4000026")]
  [FieldOffset(Offset = "0x20")]
  public List<AnimatedMeshScriptableObject.Animation> Animations;

  [Token(Token = "0x6000026")]
  [Address(RVA = "0x338C40", Offset = "0x337840", Length = "0x77")]
  public AnimatedMeshScriptableObject()
  {
  }

  [Token(Token = "0x200000D")]
  [Serializable]
  public struct Animation
  {
    [Token(Token = "0x4000027")]
    [FieldOffset(Offset = "0x0")]
    public string Name;
    [Token(Token = "0x4000028")]
    [FieldOffset(Offset = "0x8")]
    public List<Mesh> Meshes;
  }
}
