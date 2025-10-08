// Decompiled with JetBrains decompiler
// Type: ShrineLogs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000162")]
public class ShrineLogs : MonoBehaviour
{
  [Token(Token = "0x4000A5B")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x4000A5C")]
  private static List<StatModifier> backLog;
  [Token(Token = "0x4000A5D")]
  private static List<StatModifier> shownLog;
  [Token(Token = "0x4000A5E")]
  [FieldOffset(Offset = "0x28")]
  private bool isInitialized;

  [Token(Token = "0x60008ED")]
  [Address(RVA = "0x4DD760", Offset = "0x4DC360", Length = "0x13C")]
  private void Start()
  {
  }

  [Token(Token = "0x60008EE")]
  [Address(RVA = "0x4DD670", Offset = "0x4DC270", Length = "0xE3")]
  public static void Reset()
  {
  }

  [Token(Token = "0x60008EF")]
  [Address(RVA = "0x4DD2A0", Offset = "0x4DBEA0", Length = "0x3C7")]
  public void AddLog(StatModifier statModifier, bool isNew = true)
  {
  }

  [Token(Token = "0x60008F0")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ShrineLogs()
  {
  }

  [Token(Token = "0x60008F1")]
  [Address(RVA = "0x4DD8A0", Offset = "0x4DC4A0", Length = "0xCE")]
  static ShrineLogs()
  {
  }
}
