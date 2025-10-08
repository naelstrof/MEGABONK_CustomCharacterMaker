// Decompiled with JetBrains decompiler
// Type: TargetOfInterestUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000155")]
public class TargetOfInterestUi : MonoBehaviour
{
  [Token(Token = "0x40009FB")]
  [FieldOffset(Offset = "0x20")]
  public List<TargetOfInterestPrefab> prefabs;
  [Token(Token = "0x40009FC")]
  [FieldOffset(Offset = "0x28")]
  private HashSet<Enemy> activeTargets;
  [Token(Token = "0x40009FD")]
  [FieldOffset(Offset = "0x30")]
  private List<Enemy> queuedTargets;
  [Token(Token = "0x40009FE")]
  [FieldOffset(Offset = "0x38")]
  private Queue<Enemy> addTargetQueue;

  [Token(Token = "0x6000889")]
  [Address(RVA = "0x4E11A0", Offset = "0x4DFDA0", Length = "0x41B")]
  private void Awake()
  {
  }

  [Token(Token = "0x600088A")]
  [Address(RVA = "0x4E16E0", Offset = "0x4E02E0", Length = "0x235")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600088B")]
  [Address(RVA = "0x4E1A10", Offset = "0x4E0610", Length = "0x53")]
  private void OnTargetOfInterestSpawned(Enemy enemy)
  {
  }

  [Token(Token = "0x600088C")]
  [Address(RVA = "0x4E1C40", Offset = "0x4E0840", Length = "0x1C0")]
  private void Update()
  {
  }

  [Token(Token = "0x600088D")]
  [Address(RVA = "0x4E15C0", Offset = "0x4E01C0", Length = "0x113")]
  private void DequeueEnemies(Enemy enemy)
  {
  }

  [Token(Token = "0x600088E")]
  [Address(RVA = "0x4E1920", Offset = "0x4E0520", Length = "0xED")]
  private void OnEnemyReleasedFromPool(Enemy enemy)
  {
  }

  [Token(Token = "0x600088F")]
  [Address(RVA = "0x4E1A70", Offset = "0x4E0670", Length = "0x1C2")]
  private void RefreshPrefabs()
  {
  }

  [Token(Token = "0x6000890")]
  [Address(RVA = "0x4E1E10", Offset = "0x4E0A10", Length = "0x103")]
  public TargetOfInterestUi()
  {
  }
}
