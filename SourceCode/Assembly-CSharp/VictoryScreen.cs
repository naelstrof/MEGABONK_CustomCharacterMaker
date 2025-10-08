// Decompiled with JetBrains decompiler
// Type: VictoryScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000195")]
public class VictoryScreen : MonoBehaviour
{
  [Token(Token = "0x4000B8E")]
  [FieldOffset(Offset = "0x20")]
  public GameObject content;
  [Token(Token = "0x4000B8F")]
  [FieldOffset(Offset = "0x28")]
  public RawImage background;
  [Token(Token = "0x4000B90")]
  [FieldOffset(Offset = "0x30")]
  public RawImage itemDisplay;
  [Token(Token = "0x4000B91")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI itemNameText;
  [Token(Token = "0x4000B92")]
  [FieldOffset(Offset = "0x40")]
  public TextMeshProUGUI extraText;
  [Token(Token = "0x4000B93")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_score;
  [Token(Token = "0x4000B94")]
  [FieldOffset(Offset = "0x50")]
  public ParticleSystem ps;
  [Token(Token = "0x4000B95")]
  [FieldOffset(Offset = "0x58")]
  public GameObject btnContinue;
  [Token(Token = "0x4000B96")]
  [FieldOffset(Offset = "0x60")]
  public GameObject coinFx;
  [Token(Token = "0x4000B97")]
  [FieldOffset(Offset = "0x68")]
  public UiAnimation buttonAnimation;
  [Token(Token = "0x4000B98")]
  [FieldOffset(Offset = "0x70")]
  private float fadeInTime;
  [Token(Token = "0x4000B99")]
  [FieldOffset(Offset = "0x74")]
  private float fadeOutTime;
  [Token(Token = "0x4000B9A")]
  [FieldOffset(Offset = "0x78")]
  private float cardDesiredScale;
  [Token(Token = "0x4000B9B")]
  [FieldOffset(Offset = "0x7C")]
  private float textDesiredScale;
  [Token(Token = "0x4000B9C")]
  [FieldOffset(Offset = "0x80")]
  private float desiredAlpha;
  [Token(Token = "0x4000B9D")]
  [FieldOffset(Offset = "0x84")]
  private float yRotation;
  [Token(Token = "0x4000B9E")]
  [FieldOffset(Offset = "0x88")]
  public AudioSource silverSfx;
  [Token(Token = "0x4000B9F")]
  [FieldOffset(Offset = "0x90")]
  public AudioSource silverSfxFinish;
  [Token(Token = "0x4000BA0")]
  [FieldOffset(Offset = "0x98")]
  private float animatorTime;
  [Token(Token = "0x4000BA1")]
  [FieldOffset(Offset = "0x9C")]
  private float animatorSpeed;
  [Token(Token = "0x4000BA2")]
  [FieldOffset(Offset = "0xA0")]
  public AudioSource sfx;
  [Token(Token = "0x4000BA3")]
  [FieldOffset(Offset = "0xA8")]
  private bool silverStarted;
  [Token(Token = "0x4000BA4")]
  [FieldOffset(Offset = "0xAC")]
  private int maxSilver;
  [Token(Token = "0x4000BA5")]
  [FieldOffset(Offset = "0xB0")]
  private float silverTimer;
  [Token(Token = "0x4000BA6")]
  [FieldOffset(Offset = "0xB4")]
  private float silverAnimateTime;

  [Token(Token = "0x6000A39")]
  [Address(RVA = "0x500690", Offset = "0x4FF290", Length = "0x284")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A3A")]
  [Address(RVA = "0x500920", Offset = "0x4FF520", Length = "0x7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A3B")]
  [Address(RVA = "0x500450", Offset = "0x4FF050", Length = "0x112")]
  private Color GetBackgroundColor() => new Color();

  [Token(Token = "0x6000A3C")]
  [Address(RVA = "0x4FF9B0", Offset = "0x4FE5B0", Length = "0x891")]
  private void Animate()
  {
  }

  [Token(Token = "0x6000A3D")]
  [Address(RVA = "0x500250", Offset = "0x4FEE50", Length = "0x1FE")]
  private void FinishSilverCounter()
  {
  }

  [Token(Token = "0x6000A3E")]
  [Address(RVA = "0x500570", Offset = "0x4FF170", Length = "0xA2")]
  private void ShowButton()
  {
  }

  [Token(Token = "0x6000A3F")]
  [Address(RVA = "0x500620", Offset = "0x4FF220", Length = "0x67")]
  private IEnumerator ShowNewItem() => (IEnumerator) null;

  [Token(Token = "0x6000A40")]
  [Address(RVA = "0x500930", Offset = "0x4FF530", Length = "0x85")]
  public VictoryScreen()
  {
  }
}
