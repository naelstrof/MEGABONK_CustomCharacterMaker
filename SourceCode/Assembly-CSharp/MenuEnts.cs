// Decompiled with JetBrains decompiler
// Type: MenuEnts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000FE")]
public class MenuEnts : MonoBehaviour
{
  [Token(Token = "0x40007E2")]
  [FieldOffset(Offset = "0x20")]
  public GameObject entPrefab;
  [Token(Token = "0x40007E3")]
  [FieldOffset(Offset = "0x28")]
  public Transform leftPos;
  [Token(Token = "0x40007E4")]
  [FieldOffset(Offset = "0x30")]
  public Transform rightPos;
  [Token(Token = "0x40007E5")]
  [FieldOffset(Offset = "0x38")]
  private float baseSpeed;
  [Token(Token = "0x40007E6")]
  [FieldOffset(Offset = "0x40")]
  private List<MenuEnts.EntData> ents;

  [Token(Token = "0x60006B5")]
  [Address(RVA = "0x4BD750", Offset = "0x4BC350", Length = "0x5E6")]
  private void Start()
  {
  }

  [Token(Token = "0x60006B6")]
  [Address(RVA = "0x4BDD40", Offset = "0x4BC940", Length = "0x3F7")]
  private void Update()
  {
  }

  [Token(Token = "0x60006B7")]
  [Address(RVA = "0x4BD630", Offset = "0x4BC230", Length = "0x111")]
  private void FaceDirection(Transform tr, int dir)
  {
  }

  [Token(Token = "0x60006B8")]
  [Address(RVA = "0x4BE140", Offset = "0x4BCD40", Length = "0xE")]
  public MenuEnts()
  {
  }

  [Token(Token = "0x20000FF")]
  private class EntData
  {
    [Token(Token = "0x40007E7")]
    [FieldOffset(Offset = "0x10")]
    public GameObject obj;
    [Token(Token = "0x40007E8")]
    [FieldOffset(Offset = "0x18")]
    public int dir;
    [Token(Token = "0x40007E9")]
    [FieldOffset(Offset = "0x1C")]
    public float speed;

    [Token(Token = "0x60006B9")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public EntData()
    {
    }
  }
}
