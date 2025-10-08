// Decompiled with JetBrains decompiler
// Type: DetectPickups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000012")]
public class DetectPickups : MonoBehaviour
{
  [Token(Token = "0x4000042")]
  [FieldOffset(Offset = "0x20")]
  public SphereCollider collider;

  [Token(Token = "0x6000042")]
  [Address(RVA = "0x33C420", Offset = "0x33B020", Length = "0x2AE")]
  private void Start()
  {
  }

  [Token(Token = "0x6000043")]
  [Address(RVA = "0x33C380", Offset = "0x33AF80", Length = "0x45")]
  private void OnInventoryInit(PlayerInventory obj)
  {
  }

  [Token(Token = "0x6000044")]
  [Address(RVA = "0x33C140", Offset = "0x33AD40", Length = "0x23E")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000045")]
  [Address(RVA = "0x33C3D0", Offset = "0x33AFD0", Length = "0x44")]
  private void OnStatUpdated(EStat stat)
  {
  }

  [Token(Token = "0x6000046")]
  [Address(RVA = "0x33C380", Offset = "0x33AF80", Length = "0x45")]
  private void UpdateRadius()
  {
  }

  [Token(Token = "0x6000047")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public DetectPickups()
  {
  }
}
