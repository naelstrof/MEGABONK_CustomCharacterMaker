// Decompiled with JetBrains decompiler
// Type: UiTextPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001F7")]
public class UiTextPopup : MonoBehaviour
{
  [Token(Token = "0x4000DF5")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_text;
  [Token(Token = "0x4000DF6")]
  [FieldOffset(Offset = "0x28")]
  public GameObject parent;
  [Token(Token = "0x4000DF7")]
  [FieldOffset(Offset = "0x30")]
  public CanvasGroup canvasGroup;
  [Token(Token = "0x4000DF8")]
  [FieldOffset(Offset = "0x38")]
  private float startFadeTime;
  [Token(Token = "0x4000DF9")]
  [FieldOffset(Offset = "0x3C")]
  private float fadeTime;
  [Token(Token = "0x4000DFA")]
  [FieldOffset(Offset = "0x40")]
  private float upSpeed;
  [Token(Token = "0x4000DFB")]
  [FieldOffset(Offset = "0x44")]
  private float scaleSpeed;
  [Token(Token = "0x4000DFC")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 desiredScale;
  [Token(Token = "0x4000DFD")]
  [FieldOffset(Offset = "0x58")]
  public RandomSfx sfx;
  [Token(Token = "0x4000DFE")]
  [FieldOffset(Offset = "0x60")]
  public RectTransform overlayCanvas;
  [Token(Token = "0x4000DFF")]
  [FieldOffset(Offset = "0x68")]
  private bool fading;
  [Token(Token = "0x4000E00")]
  [FieldOffset(Offset = "0x6C")]
  private float fadeTimer;

  [Token(Token = "0x6000CF9")]
  [Address(RVA = "0x533CE0", Offset = "0x5328E0", Length = "0x1C")]
  public Vector2 TransformCameraToOverlaySpace(Vector3 position) => new Vector2();

  [Token(Token = "0x6000CFA")]
  [Address(RVA = "0x533A00", Offset = "0x532600", Length = "0x65")]
  public void SetTextCameraSpace(string text, Vector3 position, Color color, float desiredScale = 1f)
  {
  }

  [Token(Token = "0x6000CFB")]
  [Address(RVA = "0x533A70", Offset = "0x532670", Length = "0x215")]
  public void SetText(string text, Vector3 position, Color color, float desiredScale = 1f)
  {
  }

  [Token(Token = "0x6000CFC")]
  [Address(RVA = "0x533C90", Offset = "0x532890", Length = "0x4C")]
  private void StartFade()
  {
  }

  [Token(Token = "0x6000CFD")]
  [Address(RVA = "0x533D00", Offset = "0x532900", Length = "0x341")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CFE")]
  [Address(RVA = "0x5339D0", Offset = "0x5325D0", Length = "0x20")]
  private void HideObject()
  {
  }

  [Token(Token = "0x6000CFF")]
  [Address(RVA = "0x534050", Offset = "0x532C50", Length = "0x23")]
  public UiTextPopup()
  {
  }
}
