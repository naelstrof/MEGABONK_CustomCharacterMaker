// Decompiled with JetBrains decompiler
// Type: AegisRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200004F")]
public class AegisRenderer : MonoBehaviour
{
  [Token(Token = "0x4000290")]
  [FieldOffset(Offset = "0x20")]
  public GameObject prefab;
  [Token(Token = "0x4000291")]
  [FieldOffset(Offset = "0x28")]
  private List<GameObject> prefabs;
  [Token(Token = "0x4000292")]
  [FieldOffset(Offset = "0x30")]
  private bool inited;
  [Token(Token = "0x4000293")]
  [FieldOffset(Offset = "0x34")]
  private int maxAmount;

  [Token(Token = "0x6000219")]
  [Address(RVA = "0x351FF0", Offset = "0x350BF0", Length = "0x58")]
  private void TryInit()
  {
  }

  [Token(Token = "0x600021A")]
  [Address(RVA = "0x351BA0", Offset = "0x3507A0", Length = "0x44F")]
  public void SetAmount(int amount)
  {
  }

  [Token(Token = "0x600021B")]
  [Address(RVA = "0x351AA0", Offset = "0x3506A0", Length = "0xFE")]
  private void HideAll()
  {
  }

  [Token(Token = "0x600021C")]
  [Address(RVA = "0x352050", Offset = "0x350C50", Length = "0x7E")]
  public AegisRenderer()
  {
  }
}
