// Decompiled with JetBrains decompiler
// Type: EnemyDissolve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x200000E")]
public class EnemyDissolve : MonoBehaviour
{
  [Token(Token = "0x4000029")]
  [FieldOffset(Offset = "0x20")]
  public Material dissolveMaterial;
  [Token(Token = "0x400002A")]
  [FieldOffset(Offset = "0x28")]
  private float dissolveDuration;
  [Token(Token = "0x400002B")]
  [FieldOffset(Offset = "0x2C")]
  private float dissolveAmount;
  [Token(Token = "0x400002C")]
  [FieldOffset(Offset = "0x30")]
  private float displaceAmount;
  [Token(Token = "0x400002D")]
  [FieldOffset(Offset = "0x34")]
  private float displaceTarget;
  [Token(Token = "0x400002E")]
  [FieldOffset(Offset = "0x38")]
  private bool isDissolving;
  [Token(Token = "0x400002F")]
  [FieldOffset(Offset = "0x40")]
  public Renderer enemyRenderer;
  [Token(Token = "0x4000030")]
  [FieldOffset(Offset = "0x48")]
  private MaterialPropertyBlock mpb;
  [Token(Token = "0x4000031")]
  [FieldOffset(Offset = "0x50")]
  public Enemy enemy;
  [Token(Token = "0x4000032")]
  [FieldOffset(Offset = "0x58")]
  public Action A_DissolveFinished;

  [Token(Token = "0x6000027")]
  [Address(RVA = "0x33D610", Offset = "0x33C210", Length = "0x145")]
  private void Update()
  {
  }

  [Token(Token = "0x6000028")]
  [Address(RVA = "0x33D530", Offset = "0x33C130", Length = "0xDE")]
  public void StartDissolve()
  {
  }

  [Token(Token = "0x6000029")]
  [Address(RVA = "0x33D460", Offset = "0x33C060", Length = "0xC8")]
  public void Reset()
  {
  }

  [Token(Token = "0x600002A")]
  [Address(RVA = "0x33D760", Offset = "0x33C360", Length = "0x15")]
  public EnemyDissolve()
  {
  }
}
