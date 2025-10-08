// Decompiled with JetBrains decompiler
// Type: InteractableShadyGuy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x2000098")]
public class InteractableShadyGuy : BaseInteractable
{
  [Token(Token = "0x40004C0")]
  [FieldOffset(Offset = "0x58")]
  public Material matRare;
  [Token(Token = "0x40004C1")]
  [FieldOffset(Offset = "0x60")]
  public Material matEpic;
  [Token(Token = "0x40004C2")]
  [FieldOffset(Offset = "0x68")]
  public Material matLegendary;
  [Token(Token = "0x40004C3")]
  [FieldOffset(Offset = "0x70")]
  public SkinnedMeshRenderer meshRenderer;
  [Token(Token = "0x40004C4")]
  [FieldOffset(Offset = "0x78")]
  public GameObject smokeFx;
  [Token(Token = "0x40004C5")]
  [FieldOffset(Offset = "0x80")]
  public RandomSfx purchaseSfx;
  [Token(Token = "0x40004C6")]
  [FieldOffset(Offset = "0x88")]
  public GameObject[] hideAfterPurchase;
  [Token(Token = "0x40004C7")]
  [FieldOffset(Offset = "0x90")]
  public EItemRarity rarity;
  [Token(Token = "0x40004C8")]
  [FieldOffset(Offset = "0x98")]
  public List<ItemData> items;
  [Token(Token = "0x40004C9")]
  [FieldOffset(Offset = "0xA0")]
  public List<int> prices;
  [Token(Token = "0x40004CA")]
  public static InteractableShadyGuy currentlyInteracting;
  [Token(Token = "0x40004CB")]
  [FieldOffset(Offset = "0xA8")]
  private float[] pricesMultipliers;
  [Token(Token = "0x40004CC")]
  [FieldOffset(Offset = "0xB0")]
  private string dissapearText;
  [Token(Token = "0x40004CD")]
  [FieldOffset(Offset = "0xB8")]
  private bool done;

  [Token(Token = "0x60003D9")]
  [Address(RVA = "0x479530", Offset = "0x478130", Length = "0x1B3")]
  private new void Start()
  {
  }

  [Token(Token = "0x60003DA")]
  [Address(RVA = "0x479080", Offset = "0x477C80", Length = "0x12D")]
  private void FindItems()
  {
  }

  [Token(Token = "0x60003DB")]
  [Address(RVA = "0x4796F0", Offset = "0x4782F0", Length = "0x2BC")]
  private void UpdatePrices()
  {
  }

  [Token(Token = "0x60003DC")]
  [Address(RVA = "0x4792A0", Offset = "0x477EA0", Length = "0x123")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x60003DD")]
  [Address(RVA = "0x479200", Offset = "0x477E00", Length = "0x9A")]
  public override bool Interact() => false;

  [Token(Token = "0x60003DE")]
  [Address(RVA = "0x4791B0", Offset = "0x477DB0", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003DF")]
  [Address(RVA = "0x4793D0", Offset = "0x477FD0", Length = "0x15C")]
  private void OnShadyGuyDone()
  {
  }

  [Token(Token = "0x60003E0")]
  [Address(RVA = "0x478E20", Offset = "0x477A20", Length = "0x258")]
  private void Disappear()
  {
  }

  [Token(Token = "0x60003E1")]
  [Address(RVA = "0x478E10", Offset = "0x477A10", Length = "0xB")]
  public override bool CanInteract() => false;

  [Token(Token = "0x60003E2")]
  [Address(RVA = "0x4799B0", Offset = "0x4785B0", Length = "0x59")]
  public InteractableShadyGuy()
  {
  }
}
