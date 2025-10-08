// Decompiled with JetBrains decompiler
// Type: InputTipUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Utility.Controllers;
using Cpp2ILInjected;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x200012E")]
public class InputTipUi : MonoBehaviour
{
  [Token(Token = "0x40008E7")]
  [FieldOffset(Offset = "0x20")]
  public MyGlyphDisplay glyphContainer;
  [Token(Token = "0x40008E8")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_tip;
  [Token(Token = "0x40008E9")]
  [FieldOffset(Offset = "0x30")]
  public CanvasGroup group;
  [Token(Token = "0x40008EA")]
  [FieldOffset(Offset = "0x38")]
  public AudioSource audio;
  [Token(Token = "0x40008EB")]
  [FieldOffset(Offset = "0x40")]
  private Vector3 defaultPosition;
  [Token(Token = "0x40008EC")]
  [FieldOffset(Offset = "0x50")]
  private string currentAction;
  [Token(Token = "0x40008ED")]
  [FieldOffset(Offset = "0x58")]
  private float timeout;
  [Token(Token = "0x40008EE")]
  [FieldOffset(Offset = "0x5C")]
  private float fadeTime;
  [Token(Token = "0x40008EF")]
  [FieldOffset(Offset = "0x60")]
  private float delay;
  [Token(Token = "0x40008F0")]
  [FieldOffset(Offset = "0x64")]
  private bool isShowingTip;
  [Token(Token = "0x40008F1")]
  [FieldOffset(Offset = "0x65")]
  private bool skipping;
  [Token(Token = "0x40008F2")]
  [FieldOffset(Offset = "0x68")]
  private Queue<InputTip> tipQueue;

  [Token(Token = "0x600078D")]
  [Address(RVA = "0x4B8A50", Offset = "0x4B7650", Length = "0x25C")]
  private void Awake()
  {
  }

  [Token(Token = "0x600078E")]
  [Address(RVA = "0x4B8CB0", Offset = "0x4B78B0", Length = "0x223")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600078F")]
  [Address(RVA = "0x4B9280", Offset = "0x4B7E80", Length = "0x131")]
  public void SetTip(string tip, string action, float extraDelay = 0.0f)
  {
  }

  [Token(Token = "0x6000790")]
  [Address(RVA = "0x4B9510", Offset = "0x4B8110", Length = "0x29B")]
  private void Update()
  {
  }

  [Token(Token = "0x6000791")]
  [Address(RVA = "0x4B9450", Offset = "0x4B8050", Length = "0xB2")]
  private void SkipTip()
  {
  }

  [Token(Token = "0x6000792")]
  [Address(RVA = "0x4B93C0", Offset = "0x4B7FC0", Length = "0x84")]
  private IEnumerator ShowTip(InputTip inputTip) => (IEnumerator) null;

  [Token(Token = "0x6000793")]
  [Address(RVA = "0x4B9160", Offset = "0x4B7D60", Length = "0x11D")]
  private void OnWeaponAdded(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x6000794")]
  [Address(RVA = "0x4B8EE0", Offset = "0x4B7AE0", Length = "0x27F")]
  private void OnRunStarted()
  {
  }

  [Token(Token = "0x6000795")]
  [Address(RVA = "0x4B97B0", Offset = "0x4B83B0", Length = "0x8C")]
  public InputTipUi()
  {
  }
}
