// Decompiled with JetBrains decompiler
// Type: EnemyStatusSymbols
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000153")]
public class EnemyStatusSymbols : MonoBehaviour
{
  [Token(Token = "0x40009E5")]
  [FieldOffset(Offset = "0x20")]
  public GameObject elite;
  [Token(Token = "0x40009E6")]
  [FieldOffset(Offset = "0x28")]
  public GameObject boss;
  [Token(Token = "0x40009E7")]
  [FieldOffset(Offset = "0x30")]
  public GameObject challenge;
  [Token(Token = "0x40009E8")]
  [FieldOffset(Offset = "0x38")]
  public GameObject bossMinimapIcon;
  [Token(Token = "0x40009E9")]
  [FieldOffset(Offset = "0x40")]
  public float size;
  [Token(Token = "0x40009EA")]
  [FieldOffset(Offset = "0x44")]
  public float padding;

  [Token(Token = "0x600087D")]
  [Address(RVA = "0x4D38C0", Offset = "0x4D24C0", Length = "0x258")]
  public void Set(bool isElite, bool isBoss, bool isChallenge)
  {
  }

  [Token(Token = "0x600087E")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public EnemyStatusSymbols()
  {
  }
}
