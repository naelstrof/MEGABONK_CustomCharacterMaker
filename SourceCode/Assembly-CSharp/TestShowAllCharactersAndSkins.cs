// Decompiled with JetBrains decompiler
// Type: TestShowAllCharactersAndSkins
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000119")]
public class TestShowAllCharactersAndSkins : MonoBehaviour
{
  [Token(Token = "0x4000861")]
  [FieldOffset(Offset = "0x20")]
  public CharacterData[] characters;
  [Token(Token = "0x4000862")]
  [FieldOffset(Offset = "0x28")]
  public SkinData[] skins;
  [Token(Token = "0x4000863")]
  [FieldOffset(Offset = "0x30")]
  public Transform startPoint;
  [Token(Token = "0x4000864")]
  [FieldOffset(Offset = "0x38")]
  public GameObject playerRendererPrefab;
  [Token(Token = "0x4000865")]
  [FieldOffset(Offset = "0x40")]
  public float xSpacing;
  [Token(Token = "0x4000866")]
  [FieldOffset(Offset = "0x44")]
  public float zSpacing;

  [Token(Token = "0x6000709")]
  [Address(RVA = "0x4C8700", Offset = "0x4C7300", Length = "0x7")]
  private void Start()
  {
  }

  [Token(Token = "0x600070A")]
  [Address(RVA = "0x4C8270", Offset = "0x4C6E70", Length = "0x487")]
  private void SpawnAllCharactersAndSkins()
  {
  }

  [Token(Token = "0x600070B")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public TestShowAllCharactersAndSkins()
  {
  }
}
