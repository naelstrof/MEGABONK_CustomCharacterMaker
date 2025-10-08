// Decompiled with JetBrains decompiler
// Type: ItemPurchasedUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200019B")]
public class ItemPurchasedUI : MonoBehaviour
{
  [Token(Token = "0x4000BB7")]
  [FieldOffset(Offset = "0x20")]
  public GameObject content;
  [Token(Token = "0x4000BB8")]
  [FieldOffset(Offset = "0x28")]
  public RawImage background;
  [Token(Token = "0x4000BB9")]
  [FieldOffset(Offset = "0x30")]
  public RawImage itemDisplay;
  [Token(Token = "0x4000BBA")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI itemNameText;
  [Token(Token = "0x4000BBB")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI extraText;
  [Token(Token = "0x4000BBC")]
  [FieldOffset(Offset = "0x48")]
  public ParticleSystem ps;
  [Token(Token = "0x4000BBD")]
  [FieldOffset(Offset = "0x50")]
  private bool hasClaimedAchievement;
  [Token(Token = "0x4000BBE")]
  [FieldOffset(Offset = "0x54")]
  private float fadeInTime;
  [Token(Token = "0x4000BBF")]
  [FieldOffset(Offset = "0x58")]
  private float fadeOutTime;
  [Token(Token = "0x4000BC0")]
  [FieldOffset(Offset = "0x5C")]
  private float cardDesiredScale;
  [Token(Token = "0x4000BC1")]
  [FieldOffset(Offset = "0x60")]
  private float textDesiredScale;
  [Token(Token = "0x4000BC2")]
  [FieldOffset(Offset = "0x64")]
  private float desiredAlpha;
  [Token(Token = "0x4000BC3")]
  [FieldOffset(Offset = "0x68")]
  private float yRotation;
  [Token(Token = "0x4000BC4")]
  [FieldOffset(Offset = "0x6C")]
  private float animatorTime;
  [Token(Token = "0x4000BC5")]
  [FieldOffset(Offset = "0x70")]
  private float animatorSpeed;
  [Token(Token = "0x4000BC6")]
  [FieldOffset(Offset = "0x78")]
  public AudioSource sfx;
  [Token(Token = "0x4000BC7")]
  [FieldOffset(Offset = "0x80")]
  public Texture silverIcon;

  [Token(Token = "0x6000A5C")]
  [Address(RVA = "0x4EE2E0", Offset = "0x4ECEE0", Length = "0x32F")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A5D")]
  [Address(RVA = "0x4EE650", Offset = "0x4ED250", Length = "0x32F")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000A5E")]
  [Address(RVA = "0x4EE980", Offset = "0x4ED580", Length = "0x24")]
  private void OnSkinPurchased(SkinData skinData)
  {
  }

  [Token(Token = "0x6000A5F")]
  [Address(RVA = "0x4EE980", Offset = "0x4ED580", Length = "0x24")]
  private void OnItemPurchased(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000A60")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void OnAchievementClaimed(MyAchievement achievement)
  {
  }

  [Token(Token = "0x6000A61")]
  [Address(RVA = "0x4EEAD0", Offset = "0x4ED6D0", Length = "0x7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A62")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Test()
  {
  }

  [Token(Token = "0x6000A63")]
  [Address(RVA = "0x4EDE40", Offset = "0x4ECA40", Length = "0x49B")]
  private void Animate()
  {
  }

  [Token(Token = "0x6000A64")]
  [Address(RVA = "0x4EEA40", Offset = "0x4ED640", Length = "0x84")]
  private IEnumerator ShowNewItem(UnlockableBase unlockable) => (IEnumerator) null;

  [Token(Token = "0x6000A65")]
  [Address(RVA = "0x4EE9B0", Offset = "0x4ED5B0", Length = "0x84")]
  private IEnumerator ShowNewItem(MyAchievement achievement) => (IEnumerator) null;

  [Token(Token = "0x6000A66")]
  [Address(RVA = "0x4EE610", Offset = "0x4ED210", Length = "0x3D")]
  public void Close()
  {
  }

  [Token(Token = "0x6000A67")]
  [Address(RVA = "0x4EEAE0", Offset = "0x4ED6E0", Length = "0x2A")]
  public ItemPurchasedUI()
  {
  }
}
