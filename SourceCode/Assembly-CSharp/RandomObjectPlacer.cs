// Decompiled with JetBrains decompiler
// Type: RandomObjectPlacer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.MapGeneration;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200007C")]
public class RandomObjectPlacer : MonoBehaviour
{
  [Token(Token = "0x40003CE")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 center;
  [Token(Token = "0x40003CF")]
  [FieldOffset(Offset = "0x2C")]
  public Vector3 size;
  [Token(Token = "0x40003D0")]
  [FieldOffset(Offset = "0x38")]
  private int numChargeShrines;
  [Token(Token = "0x40003D1")]
  [FieldOffset(Offset = "0x40")]
  public RandomMapObject[] randomObjects;
  [Token(Token = "0x40003D2")]
  [FieldOffset(Offset = "0x48")]
  public RandomMapObject chargeShrineSpawns;
  [Token(Token = "0x40003D3")]
  [FieldOffset(Offset = "0x50")]
  public RandomMapObject greedShrines;
  [Token(Token = "0x40003D4")]
  [FieldOffset(Offset = "0x58")]
  private int index;

  [Token(Token = "0x600030C")]
  [Address(RVA = "0x46C4D0", Offset = "0x46B0D0", Length = "0x123")]
  public void GenerateInteractables()
  {
  }

  [Token(Token = "0x600030D")]
  [Address(RVA = "0x46C600", Offset = "0x46B200", Length = "0x5E")]
  public void Generate(RandomMapObject[] objects)
  {
  }

  [Token(Token = "0x600030E")]
  [Address(RVA = "0x46C6C0", Offset = "0x46B2C0", Length = "0x9D3")]
  private void RandomObjectSpawner(RandomMapObject randomObject)
  {
  }

  [Token(Token = "0x600030F")]
  [Address(RVA = "0x46C660", Offset = "0x46B260", Length = "0x5E")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x6000310")]
  [Address(RVA = "0x46D0A0", Offset = "0x46BCA0", Length = "0xE")]
  public RandomObjectPlacer()
  {
  }
}
