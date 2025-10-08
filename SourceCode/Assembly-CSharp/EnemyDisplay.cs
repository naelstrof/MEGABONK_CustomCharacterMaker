// Decompiled with JetBrains decompiler
// Type: EnemyDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019A")]
public class EnemyDisplay : MonoBehaviour
{
  [Token(Token = "0x4000BB2")]
  [FieldOffset(Offset = "0x20")]
  public AnimatedMesh animatedMesh;
  [Token(Token = "0x4000BB3")]
  [FieldOffset(Offset = "0x28")]
  public MeshRenderer meshRenderer;
  [Token(Token = "0x4000BB4")]
  [FieldOffset(Offset = "0x30")]
  public Camera camera;
  [Token(Token = "0x4000BB5")]
  [FieldOffset(Offset = "0x38")]
  public LayerMask layerMask;
  [Token(Token = "0x4000BB6")]
  [FieldOffset(Offset = "0x3C")]
  private float cameraDistance;

  [Token(Token = "0x6000A57")]
  [Address(RVA = "0x4EC420", Offset = "0x4EB020", Length = "0x121")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A58")]
  [Address(RVA = "0x4EC810", Offset = "0x4EB410", Length = "0x121")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A59")]
  [Address(RVA = "0x4EC940", Offset = "0x4EB540", Length = "0x15E")]
  public void SetEnemy(EEnemy eEnemy)
  {
  }

  [Token(Token = "0x6000A5A")]
  [Address(RVA = "0x4EC550", Offset = "0x4EB150", Length = "0x2B6")]
  private void EncapsulateEnemyRenderer()
  {
  }

  [Token(Token = "0x6000A5B")]
  [Address(RVA = "0x4B3B20", Offset = "0x4B2720", Length = "0xE")]
  public EnemyDisplay()
  {
  }
}
