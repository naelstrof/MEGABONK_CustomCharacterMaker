// Decompiled with JetBrains decompiler
// Type: NewRecordUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000193")]
public class NewRecordUI : MonoBehaviour
{
  [Token(Token = "0x4000B7A")]
  [FieldOffset(Offset = "0x20")]
  public GameObject content;
  [Token(Token = "0x4000B7B")]
  [FieldOffset(Offset = "0x28")]
  public RawImage background;
  [Token(Token = "0x4000B7C")]
  [FieldOffset(Offset = "0x30")]
  public RawImage itemDisplay;
  [Token(Token = "0x4000B7D")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI itemNameText;
  [Token(Token = "0x4000B7E")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI extraText;
  [Token(Token = "0x4000B7F")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_score;
  [Token(Token = "0x4000B80")]
  [FieldOffset(Offset = "0x50")]
  public ParticleSystem ps;
  [Token(Token = "0x4000B81")]
  [FieldOffset(Offset = "0x58")]
  public UiAnimation buttonAnimation;
  [Token(Token = "0x4000B82")]
  [FieldOffset(Offset = "0x60")]
  private float fadeInTime;
  [Token(Token = "0x4000B83")]
  [FieldOffset(Offset = "0x64")]
  private float fadeOutTime;
  [Token(Token = "0x4000B84")]
  [FieldOffset(Offset = "0x68")]
  private float cardDesiredScale;
  [Token(Token = "0x4000B85")]
  [FieldOffset(Offset = "0x6C")]
  private float textDesiredScale;
  [Token(Token = "0x4000B86")]
  [FieldOffset(Offset = "0x70")]
  private float desiredAlpha;
  [Token(Token = "0x4000B87")]
  [FieldOffset(Offset = "0x74")]
  private float yRotation;
  [Token(Token = "0x4000B88")]
  [FieldOffset(Offset = "0x78")]
  private float animatorTime;
  [Token(Token = "0x4000B89")]
  [FieldOffset(Offset = "0x7C")]
  private float animatorSpeed;
  [Token(Token = "0x4000B8A")]
  [FieldOffset(Offset = "0x80")]
  public AudioSource sfx;

  [Token(Token = "0x6000A2E")]
  [Address(RVA = "0x4FA730", Offset = "0x4F9330", Length = "0x158")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A2F")]
  [Address(RVA = "0x4FA890", Offset = "0x4F9490", Length = "0x7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A30")]
  [Address(RVA = "0x4FA220", Offset = "0x4F8E20", Length = "0x49B")]
  private void Animate()
  {
  }

  [Token(Token = "0x6000A31")]
  [Address(RVA = "0x4FA6C0", Offset = "0x4F92C0", Length = "0x67")]
  private IEnumerator ShowNewItem() => (IEnumerator) null;

  [Token(Token = "0x6000A32")]
  [Address(RVA = "0x4FA8A0", Offset = "0x4F94A0", Length = "0x2A")]
  public NewRecordUI()
  {
  }
}
