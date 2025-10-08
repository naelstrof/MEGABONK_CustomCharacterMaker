// Decompiled with JetBrains decompiler
// Type: GameOverDamageSourcesUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200014E")]
public class GameOverDamageSourcesUi : MonoBehaviour
{
  [Token(Token = "0x40009D0")]
  [FieldOffset(Offset = "0x20")]
  public GameObject damageSourcePrefab;
  [Token(Token = "0x40009D1")]
  [FieldOffset(Offset = "0x28")]
  public Transform damageSourceParent;

  [Token(Token = "0x600086B")]
  [Address(RVA = "0x4D3B20", Offset = "0x4D2720", Length = "0x3AB")]
  private void Start()
  {
  }

  [Token(Token = "0x600086C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public GameOverDamageSourcesUi()
  {
  }
}
