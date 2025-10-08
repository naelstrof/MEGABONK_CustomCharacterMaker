// Decompiled with JetBrains decompiler
// Type: InteractableMicrowave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000092")]
public class InteractableMicrowave : BaseInteractable
{
  [Token(Token = "0x4000499")]
  [FieldOffset(Offset = "0x58")]
  public Material matCommon;
  [Token(Token = "0x400049A")]
  [FieldOffset(Offset = "0x60")]
  public Material matRare;
  [Token(Token = "0x400049B")]
  [FieldOffset(Offset = "0x68")]
  public Material matEpic;
  [Token(Token = "0x400049C")]
  [FieldOffset(Offset = "0x70")]
  public Material matLegendary;
  [Token(Token = "0x400049D")]
  [FieldOffset(Offset = "0x78")]
  public Renderer meshRenderer;
  [Token(Token = "0x40004A0")]
  public static InteractableMicrowave currentlyInteracting;
  [Token(Token = "0x40004A2")]
  [FieldOffset(Offset = "0x90")]
  public Animator animator;
  [Token(Token = "0x40004A3")]
  [FieldOffset(Offset = "0x98")]
  public AudioSource sfxStart;
  [Token(Token = "0x40004A4")]
  [FieldOffset(Offset = "0xA0")]
  public AudioSource sfxFinish;
  [Token(Token = "0x40004A5")]
  [FieldOffset(Offset = "0xA8")]
  public GameObject particles;
  [Token(Token = "0x40004A6")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject explosion;
  [Token(Token = "0x40004A7")]
  [FieldOffset(Offset = "0xB8")]
  public RawImage itemIcon;
  [Token(Token = "0x40004A8")]
  [FieldOffset(Offset = "0xC0")]
  public Transform microwaveCenterTransform;
  [Token(Token = "0x40004A9")]
  [FieldOffset(Offset = "0xC8")]
  public GameObject exclamationMark;
  [Token(Token = "0x40004AA")]
  [FieldOffset(Offset = "0xD0")]
  public GameObject progressBar;
  [Token(Token = "0x40004AB")]
  [FieldOffset(Offset = "0xD8")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004AC")]
  [FieldOffset(Offset = "0xE0")]
  public GameObject cookingParticles;
  [Token(Token = "0x40004AD")]
  [FieldOffset(Offset = "0xE8")]
  public RawImage progressBarProgress;
  [Token(Token = "0x40004AE")]
  public static Action<EItem> A_Used;
  [Token(Token = "0x40004AF")]
  [FieldOffset(Offset = "0xF0")]
  private float readyAtTime;
  [Token(Token = "0x40004B0")]
  [FieldOffset(Offset = "0xF4")]
  private bool hasItem;
  [Token(Token = "0x40004B1")]
  [FieldOffset(Offset = "0xF8")]
  private EItem newItem;

  [field: Token(Token = "0x400049E")]
  [field: FieldOffset(Offset = "0x80")]
  [Token(Token = "0x1700001F")]
  public EItemRarity rarity { [Token(Token = "0x60003AD"), Address(RVA = "0x478A30", Offset = "0x477630", Length = "0x7")] get; [Token(Token = "0x60003AE"), Address(RVA = "0x478A50", Offset = "0x477650", Length = "0x7")] private set; }

  [field: Token(Token = "0x400049F")]
  [field: FieldOffset(Offset = "0x84")]
  [Token(Token = "0x17000020")]
  public int usesLeft { [Token(Token = "0x60003AF"), Address(RVA = "0x466EF0", Offset = "0x465AF0", Length = "0x7")] get; [Token(Token = "0x60003B0"), Address(RVA = "0x466F50", Offset = "0x465B50", Length = "0x7")] private set; }

  [field: Token(Token = "0x40004A1")]
  [field: FieldOffset(Offset = "0x88")]
  [Token(Token = "0x17000021")]
  public bool isCooking { [Token(Token = "0x60003B1"), Address(RVA = "0x37A320", Offset = "0x378F20", Length = "0x8")] get; [Token(Token = "0x60003B2"), Address(RVA = "0x478A40", Offset = "0x477640", Length = "0x7")] private set; }

  [Token(Token = "0x60003B3")]
  [Address(RVA = "0x478820", Offset = "0x477420", Length = "0x133")]
  private new void Start()
  {
  }

  [Token(Token = "0x60003B4")]
  [Address(RVA = "0x478310", Offset = "0x476F10", Length = "0x502")]
  public override bool Interact() => false;

  [Token(Token = "0x60003B5")]
  [Address(RVA = "0x478960", Offset = "0x477560", Length = "0xC1")]
  public void UseMicrowave(EItem eItemToCreate)
  {
  }

  [Token(Token = "0x60003B6")]
  [Address(RVA = "0x477F70", Offset = "0x476B70", Length = "0x76")]
  private IEnumerator CookItem(EItem itemToCreate) => (IEnumerator) null;

  [Token(Token = "0x60003B7")]
  [Address(RVA = "0x478080", Offset = "0x476C80", Length = "0x18")]
  private float GetCookTime() => 0.0f;

  [Token(Token = "0x60003B8")]
  [Address(RVA = "0x477FF0", Offset = "0x476BF0", Length = "0x8C")]
  private void Explode()
  {
  }

  [Token(Token = "0x60003B9")]
  [Address(RVA = "0x477EE0", Offset = "0x476AE0", Length = "0x8B")]
  public override bool CanInteract() => false;

  [Token(Token = "0x60003BA")]
  [Address(RVA = "0x4780A0", Offset = "0x476CA0", Length = "0x1D8")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003BB")]
  [Address(RVA = "0x478280", Offset = "0x476E80", Length = "0x56")]
  public int GetPrice() => 0;

  [Token(Token = "0x60003BC")]
  [Address(RVA = "0x4782E0", Offset = "0x476EE0", Length = "0x22")]
  private int GetUses(EItemRarity itemRarity) => 0;

  [Token(Token = "0x60003BD")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableMicrowave()
  {
  }
}
