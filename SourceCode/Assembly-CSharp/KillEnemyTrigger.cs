// Decompiled with JetBrains decompiler
// Type: KillEnemyTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200006A")]
public class KillEnemyTrigger : MonoBehaviour
{
  [Token(Token = "0x4000349")]
  [FieldOffset(Offset = "0x20")]
  private float bossPercentage;

  [Token(Token = "0x60002B2")]
  [Address(RVA = "0x468D40", Offset = "0x467940", Length = "0x198")]
  private void OnTriggerEnter(Collider collider)
  {
  }

  [Token(Token = "0x60002B3")]
  [Address(RVA = "0x468EE0", Offset = "0x467AE0", Length = "0xE")]
  public KillEnemyTrigger()
  {
  }
}
