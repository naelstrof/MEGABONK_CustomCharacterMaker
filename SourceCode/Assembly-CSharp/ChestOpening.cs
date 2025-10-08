// Decompiled with JetBrains decompiler
// Type: ChestOpening
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Interactables;
using Cpp2ILInjected;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000041")]
public class ChestOpening : MonoBehaviour
{
  [Token(Token = "0x40001D2")]
  [FieldOffset(Offset = "0x20")]
  public SkinnedMeshRenderer chestRenderer;
  [Token(Token = "0x40001D3")]
  [FieldOffset(Offset = "0x28")]
  public Animator chestAnimator;
  [Token(Token = "0x40001D4")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource sfxOpen;
  [Token(Token = "0x40001D5")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource sfxBuildup;
  [Token(Token = "0x40001D6")]
  [FieldOffset(Offset = "0x40")]
  public AudioSource sfxBuildupIntro;
  [Token(Token = "0x40001D7")]
  [FieldOffset(Offset = "0x48")]
  private bool spinning;
  [Token(Token = "0x40001D8")]
  [FieldOffset(Offset = "0x49")]
  private bool opened;
  [Token(Token = "0x40001D9")]
  [FieldOffset(Offset = "0x50")]
  public AudioClip buildupCommon;
  [Token(Token = "0x40001DA")]
  [FieldOffset(Offset = "0x58")]
  public AudioClip buildupRare;
  [Token(Token = "0x40001DB")]
  [FieldOffset(Offset = "0x60")]
  public AudioClip buildupEpic;
  [Token(Token = "0x40001DC")]
  [FieldOffset(Offset = "0x68")]
  public AudioClip buildupLegendary;
  [Token(Token = "0x40001DD")]
  [FieldOffset(Offset = "0x70")]
  public AudioClip skipCommon;
  [Token(Token = "0x40001DE")]
  [FieldOffset(Offset = "0x78")]
  public AudioClip skipRare;
  [Token(Token = "0x40001DF")]
  [FieldOffset(Offset = "0x80")]
  public AudioClip skipEpic;
  [Token(Token = "0x40001E0")]
  [FieldOffset(Offset = "0x88")]
  public AudioClip skipLegendary;
  [Token(Token = "0x40001E1")]
  [FieldOffset(Offset = "0x90")]
  public GameObject backgroundParticles;
  [Token(Token = "0x40001E2")]
  [FieldOffset(Offset = "0x98")]
  public ParticleSystem itemShine;
  [Token(Token = "0x40001E3")]
  [FieldOffset(Offset = "0xA0")]
  public ParticleSystem backgroundGlow;
  [Token(Token = "0x40001E4")]
  [FieldOffset(Offset = "0xA8")]
  public ParticleSystem[] psChestEmission;
  [Token(Token = "0x40001E5")]
  [FieldOffset(Offset = "0xB0")]
  public GameObject particlesCoinsParent;
  [Token(Token = "0x40001E6")]
  [FieldOffset(Offset = "0xB8")]
  public Mesh meshNormal;
  [Token(Token = "0x40001E7")]
  [FieldOffset(Offset = "0xC0")]
  public Mesh meshFree;
  [Token(Token = "0x40001E8")]
  [FieldOffset(Offset = "0xC8")]
  public Mesh meshEvil;
  [Token(Token = "0x40001E9")]
  [FieldOffset(Offset = "0xD0")]
  public Material matNormal;
  [Token(Token = "0x40001EA")]
  [FieldOffset(Offset = "0xD8")]
  public Material matFree;
  [Token(Token = "0x40001EB")]
  [FieldOffset(Offset = "0xE0")]
  public Material matEvil;
  [Token(Token = "0x40001EC")]
  [FieldOffset(Offset = "0xE8")]
  public Camera cam;
  [Token(Token = "0x40001ED")]
  public static Action<ItemData> A_ChestFinished;
  [Token(Token = "0x40001EE")]
  [FieldOffset(Offset = "0xF0")]
  private ItemData itemData;
  [Token(Token = "0x40001EF")]
  [FieldOffset(Offset = "0xF8")]
  private List<ItemData> rollingItems;
  [Token(Token = "0x40001F0")]
  [FieldOffset(Offset = "0x100")]
  public RawImage itemIcon;
  [Token(Token = "0x40001F1")]
  [FieldOffset(Offset = "0x108")]
  private int index;
  [Token(Token = "0x40001F2")]
  private const float updateRate = 0.06f;
  [Token(Token = "0x40001F3")]
  [FieldOffset(Offset = "0x10C")]
  private float nextIconUpdate;
  [Token(Token = "0x40001F4")]
  [FieldOffset(Offset = "0x110")]
  private Vector3 desiredPosition;
  [Token(Token = "0x40001F5")]
  [FieldOffset(Offset = "0x120")]
  public GameObject fxCommon;
  [Token(Token = "0x40001F6")]
  [FieldOffset(Offset = "0x128")]
  public GameObject fxRare;
  [Token(Token = "0x40001F7")]
  [FieldOffset(Offset = "0x130")]
  public GameObject fxEpic;
  [Token(Token = "0x40001F8")]
  [FieldOffset(Offset = "0x138")]
  public GameObject fxLegendary;
  [Token(Token = "0x40001F9")]
  [FieldOffset(Offset = "0x140")]
  public GameObject fxCorrupted;
  [Token(Token = "0x40001FA")]
  [FieldOffset(Offset = "0x148")]
  public GameObject fxFinal;
  [Token(Token = "0x40001FB")]
  [FieldOffset(Offset = "0x150")]
  public Texture[] testSpinTextures;
  [Token(Token = "0x40001FC")]
  [FieldOffset(Offset = "0x158")]
  private bool canSkip;
  [Token(Token = "0x40001FD")]
  [FieldOffset(Offset = "0x159")]
  private bool skipped;
  [Token(Token = "0x40001FE")]
  [FieldOffset(Offset = "0x15C")]
  private float desiredFov;
  [Token(Token = "0x40001FF")]
  [FieldOffset(Offset = "0x160")]
  private float defaultFov;
  [Token(Token = "0x4000200")]
  [FieldOffset(Offset = "0x164")]
  private float timeBetweenTiers;

  [Token(Token = "0x60001C0")]
  [Address(RVA = "0x3568D0", Offset = "0x3554D0", Length = "0x260")]
  public void SetChest(EChest chestType)
  {
  }

  [Token(Token = "0x60001C1")]
  [Address(RVA = "0x356B40", Offset = "0x355740", Length = "0xCD")]
  private void SetRender(EChest chest)
  {
  }

  [Token(Token = "0x60001C2")]
  [Address(RVA = "0x3565F0", Offset = "0x3551F0", Length = "0x2D0")]
  public void OpenChest(ItemData itemData)
  {
  }

  [Token(Token = "0x60001C3")]
  [Address(RVA = "0x356C10", Offset = "0x355810", Length = "0x54A")]
  private void Update()
  {
  }

  [Token(Token = "0x60001C4")]
  [Address(RVA = "0x356560", Offset = "0x355160", Length = "0x84")]
  private IEnumerator AnimateOpening(ItemData itemData) => (IEnumerator) null;

  [Token(Token = "0x60001C5")]
  [Address(RVA = "0x3564D0", Offset = "0x3550D0", Length = "0x84")]
  private IEnumerator AnimateEffects(ItemData itemData) => (IEnumerator) null;

  [Token(Token = "0x60001C6")]
  [Address(RVA = "0x357160", Offset = "0x355D60", Length = "0x46")]
  public ChestOpening()
  {
  }
}
