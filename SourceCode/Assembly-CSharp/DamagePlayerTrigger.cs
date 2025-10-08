// Decompiled with JetBrains decompiler
// Type: DamagePlayerTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000055")]
public class DamagePlayerTrigger : MonoBehaviour
{
  [Token(Token = "0x40002DD")]
  [FieldOffset(Offset = "0x20")]
  private Enemy enemy;
  [Token(Token = "0x40002DE")]
  [FieldOffset(Offset = "0x28")]
  public float activeTime;
  [Token(Token = "0x40002DF")]
  [FieldOffset(Offset = "0x2C")]
  private float stopTime;
  [Token(Token = "0x40002E0")]
  [FieldOffset(Offset = "0x30")]
  private bool done;

  [Token(Token = "0x6000251")]
  [Address(RVA = "0x359600", Offset = "0x358200", Length = "0x60")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000252")]
  [Address(RVA = "0x359A30", Offset = "0x358630", Length = "0xD")]
  public void Set(Enemy enemy)
  {
  }

  [Token(Token = "0x6000253")]
  [Address(RVA = "0x359660", Offset = "0x358260", Length = "0x3CF")]
  private void OnTriggerEnter(Collider other)
  {
  }

  [Token(Token = "0x6000254")]
  [Address(RVA = "0x359A40", Offset = "0x358640", Length = "0xE")]
  public DamagePlayerTrigger()
  {
  }
}
