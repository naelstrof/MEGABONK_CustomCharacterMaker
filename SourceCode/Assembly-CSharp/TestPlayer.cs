// Decompiled with JetBrains decompiler
// Type: TestPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Player;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001D")]
public class TestPlayer : MonoBehaviour
{
  [Token(Token = "0x4000113")]
  [FieldOffset(Offset = "0x20")]
  public ECharacter character;
  [Token(Token = "0x4000114")]
  [FieldOffset(Offset = "0x28")]
  public MyPlayer player;
  [Token(Token = "0x4000115")]
  [FieldOffset(Offset = "0x30")]
  public MapData testMapData;
  [Token(Token = "0x4000116")]
  [FieldOffset(Offset = "0x38")]
  public StageData testStageData;

  [Token(Token = "0x60000F8")]
  [Address(RVA = "0x3514F0", Offset = "0x3500F0", Length = "0x8B")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000F9")]
  [Address(RVA = "0x351580", Offset = "0x350180", Length = "0x15A")]
  private void Start()
  {
  }

  [Token(Token = "0x60000FA")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TestPlayer()
  {
  }
}
