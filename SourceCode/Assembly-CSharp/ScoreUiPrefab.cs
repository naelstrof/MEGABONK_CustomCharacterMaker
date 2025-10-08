// Decompiled with JetBrains decompiler
// Type: ScoreUiPrefab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x200013E")]
public class ScoreUiPrefab : MonoBehaviour
{
  [Token(Token = "0x4000944")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_score;
  [Token(Token = "0x4000945")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_desc;
  [Token(Token = "0x4000946")]
  [FieldOffset(Offset = "0x30")]
  private float desiredScale;
  [Token(Token = "0x4000947")]
  [FieldOffset(Offset = "0x34")]
  private float startFadeTime;
  [Token(Token = "0x4000948")]
  [FieldOffset(Offset = "0x38")]
  private float fadeTime;
  [Token(Token = "0x4000949")]
  [FieldOffset(Offset = "0x3C")]
  public float bounceSpeed;
  [Token(Token = "0x400094A")]
  [FieldOffset(Offset = "0x40")]
  public float scaleSpeed;
  [Token(Token = "0x400094B")]
  [FieldOffset(Offset = "0x44")]
  private bool moveDesc;
  [Token(Token = "0x400094C")]
  [FieldOffset(Offset = "0x45")]
  private bool isActive;

  [Token(Token = "0x60007F8")]
  [Address(RVA = "0x4C5050", Offset = "0x4C3C50", Length = "0x2E6")]
  private void Update()
  {
  }

  [Token(Token = "0x60007F9")]
  [Address(RVA = "0x4C4D00", Offset = "0x4C3900", Length = "0x262")]
  public void SetScore(string description, string header)
  {
  }

  [Token(Token = "0x60007FA")]
  [Address(RVA = "0x4C4FB0", Offset = "0x4C3BB0", Length = "0x98")]
  private void StartFade()
  {
  }

  [Token(Token = "0x60007FB")]
  [Address(RVA = "0x4C4F70", Offset = "0x4C3B70", Length = "0x3E")]
  private void ShowDesc()
  {
  }

  [Token(Token = "0x60007FC")]
  [Address(RVA = "0x4C4CC0", Offset = "0x4C38C0", Length = "0x31")]
  private void DisableObject()
  {
  }

  [Token(Token = "0x60007FD")]
  [Address(RVA = "0x4C5340", Offset = "0x4C3F40", Length = "0x23")]
  public ScoreUiPrefab()
  {
  }
}
