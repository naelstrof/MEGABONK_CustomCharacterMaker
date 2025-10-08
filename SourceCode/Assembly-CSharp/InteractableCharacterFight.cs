// Decompiled with JetBrains decompiler
// Type: InteractableCharacterFight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x2000091")]
public class InteractableCharacterFight : BaseInteractable
{
  [Token(Token = "0x4000491")]
  [FieldOffset(Offset = "0x58")]
  public CharacterData character;
  [Token(Token = "0x4000492")]
  [FieldOffset(Offset = "0x60")]
  public EnemyData enemyData;
  [Token(Token = "0x4000493")]
  [FieldOffset(Offset = "0x68")]
  private bool done;
  [Token(Token = "0x4000494")]
  [FieldOffset(Offset = "0x70")]
  public LocalizedString interactString;
  [Token(Token = "0x4000495")]
  [FieldOffset(Offset = "0x78")]
  public GameObject chargeFx;
  [Token(Token = "0x4000496")]
  [FieldOffset(Offset = "0x80")]
  public GameObject explodeFx;
  [Token(Token = "0x4000497")]
  [FieldOffset(Offset = "0x88")]
  public Material enemyMat2;
  [Token(Token = "0x4000498")]
  [FieldOffset(Offset = "0x90")]
  public Enemy myEnemy;

  [Token(Token = "0x60003A6")]
  [Address(RVA = "0x477650", Offset = "0x476250", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x60003A7")]
  [Address(RVA = "0x477860", Offset = "0x476460", Length = "0x140")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x60003A8")]
  [Address(RVA = "0x4779B0", Offset = "0x4765B0", Length = "0x1C9")]
  private void OnEnemyDied(Enemy enemy, DamageContainer dc)
  {
  }

  [Token(Token = "0x60003A9")]
  [Address(RVA = "0x4777C0", Offset = "0x4763C0", Length = "0x93")]
  public override bool Interact() => false;

  [Token(Token = "0x60003AA")]
  [Address(RVA = "0x477B80", Offset = "0x476780", Length = "0x359")]
  private void SpawnEnemy()
  {
  }

  [Token(Token = "0x60003AB")]
  [Address(RVA = "0x4777A0", Offset = "0x4763A0", Length = "0x1D")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003AC")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableCharacterFight()
  {
  }
}
