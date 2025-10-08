// Decompiled with JetBrains decompiler
// Type: SpawnInteractables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200007D")]
public class SpawnInteractables : MonoBehaviour
{
  [Token(Token = "0x40003D5")]
  [FieldOffset(Offset = "0x20")]
  public GameObject chest;
  [Token(Token = "0x40003D6")]
  [FieldOffset(Offset = "0x28")]
  public GameObject chestFree;
  [Token(Token = "0x40003D7")]
  [FieldOffset(Offset = "0x30")]
  private float chestDensity;
  [Token(Token = "0x40003D8")]
  [FieldOffset(Offset = "0x34")]
  private float shrineDensity;
  [Token(Token = "0x40003D9")]
  [FieldOffset(Offset = "0x38")]
  private float chanceForFreeChest;
  [Token(Token = "0x40003DA")]
  [FieldOffset(Offset = "0x3C")]
  private int numChests;
  [Token(Token = "0x40003DB")]
  [FieldOffset(Offset = "0x40")]
  private int numShrines;
  [Token(Token = "0x40003DC")]
  [FieldOffset(Offset = "0x44")]
  private int numRails;
  [Token(Token = "0x40003DD")]
  [FieldOffset(Offset = "0x48")]
  public GameObject[] rails;
  [Token(Token = "0x40003DE")]
  [FieldOffset(Offset = "0x50")]
  private Vector3 worldArea;
  [Token(Token = "0x40003DF")]
  [FieldOffset(Offset = "0x5C")]
  private Vector3 worldCenter;
  [Token(Token = "0x40003E0")]
  [FieldOffset(Offset = "0x68")]
  private float areaMagnitude;

  [Token(Token = "0x6000311")]
  [Address(RVA = "0x46D950", Offset = "0x46C550", Length = "0x26")]
  public void SetArea(Vector3 worldArea, Vector3 worldCenter, float mag)
  {
  }

  [Token(Token = "0x6000312")]
  [Address(RVA = "0x46EAE0", Offset = "0x46D6E0", Length = "0x33")]
  public void SpawnShit()
  {
  }

  [Token(Token = "0x6000313")]
  [Address(RVA = "0x46D980", Offset = "0x46C580", Length = "0x4E9")]
  public void SpawnChests()
  {
  }

  [Token(Token = "0x6000314")]
  [Address(RVA = "0x46EB20", Offset = "0x46D720", Length = "0x609")]
  public void SpawnShrines()
  {
  }

  [Token(Token = "0x6000315")]
  [Address(RVA = "0x46DE70", Offset = "0x46CA70", Length = "0x310")]
  private void SpawnOther()
  {
  }

  [Token(Token = "0x6000316")]
  [Address(RVA = "0x46E190", Offset = "0x46CD90", Length = "0x943")]
  private void SpawnRails()
  {
  }

  [Token(Token = "0x6000317")]
  [Address(RVA = "0x46F130", Offset = "0x46DD30", Length = "0x2A")]
  public SpawnInteractables()
  {
  }
}
