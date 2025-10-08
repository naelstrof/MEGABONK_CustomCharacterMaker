// Decompiled with JetBrains decompiler
// Type: EnemyRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Combat.EnemyDebuffs;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200000F")]
public class EnemyRenderer : MonoBehaviour
{
  [Token(Token = "0x4000033")]
  [FieldOffset(Offset = "0x20")]
  public Enemy enemy;
  [Token(Token = "0x4000034")]
  [FieldOffset(Offset = "0x28")]
  public Renderer enemyRenderer;
  [Token(Token = "0x4000035")]
  [FieldOffset(Offset = "0x30")]
  private MaterialPropertyBlock propertyBlock;
  [Token(Token = "0x4000036")]
  [FieldOffset(Offset = "0x38")]
  private Color freezeColorSpecular;
  [Token(Token = "0x4000037")]
  [FieldOffset(Offset = "0x48")]
  private Color freezeColorAlbedo;
  [Token(Token = "0x4000038")]
  [FieldOffset(Offset = "0x58")]
  private Color stunColorSpecular;
  [Token(Token = "0x4000039")]
  [FieldOffset(Offset = "0x68")]
  private Color stunColorAlbedo;
  [Token(Token = "0x400003A")]
  [FieldOffset(Offset = "0x78")]
  private Color echoColorSpecular;
  [Token(Token = "0x400003B")]
  [FieldOffset(Offset = "0x88")]
  private Color echoColorAlbedo;
  [Token(Token = "0x400003C")]
  [FieldOffset(Offset = "0x98")]
  private Color charmColorAlbedo;
  [Token(Token = "0x400003D")]
  [FieldOffset(Offset = "0xA8")]
  private Color charmColorSpecular;
  [Token(Token = "0x400003E")]
  [FieldOffset(Offset = "0xB8")]
  private Color lastSetSpecularColor;

  [Token(Token = "0x600002B")]
  [Address(RVA = "0x33D870", Offset = "0x33C470", Length = "0x1DF")]
  private void Awake()
  {
  }

  [Token(Token = "0x600002C")]
  [Address(RVA = "0x33DBE0", Offset = "0x33C7E0", Length = "0x1DF")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600002D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void Reset()
  {
  }

  [Token(Token = "0x600002E")]
  [Address(RVA = "0x33E0E0", Offset = "0x33CCE0", Length = "0xCF")]
  public void Set(EnemyData enemyData)
  {
  }

  [Token(Token = "0x600002F")]
  [Address(RVA = "0x33DBD0", Offset = "0x33C7D0", Length = "0x8")]
  private void OnDebuffAdded(EDebuff debuff)
  {
  }

  [Token(Token = "0x6000030")]
  [Address(RVA = "0x33DA50", Offset = "0x33C650", Length = "0x179")]
  private void GetDebuffColor(out Color specular, out Color albedo)
  {
    specular = new Color();
    albedo = new Color();
  }

  [Token(Token = "0x6000031")]
  [Address(RVA = "0x33DBD0", Offset = "0x33C7D0", Length = "0x8")]
  private void OnDebuffRemoved(EDebuff debuff)
  {
  }

  [Token(Token = "0x6000032")]
  [Address(RVA = "0x33E010", Offset = "0x33CC10", Length = "0xC5")]
  public void SetInvulnerable(bool invulnerable)
  {
  }

  [Token(Token = "0x6000033")]
  [Address(RVA = "0x33DDC0", Offset = "0x33C9C0", Length = "0x24D")]
  private void RefreshColor(EDebuff debuff)
  {
  }

  [Token(Token = "0x6000034")]
  [Address(RVA = "0x33E1B0", Offset = "0x33CDB0", Length = "0x18A")]
  public EnemyRenderer()
  {
  }
}
