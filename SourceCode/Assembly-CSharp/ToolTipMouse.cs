// Decompiled with JetBrains decompiler
// Type: ToolTipMouse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001F6")]
public class ToolTipMouse : MonoBehaviour
{
  [Token(Token = "0x4000DF0")]
  [FieldOffset(Offset = "0x20")]
  public GameObject parent;
  [Token(Token = "0x4000DF1")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_tooltip;
  [Token(Token = "0x4000DF2")]
  [FieldOffset(Offset = "0x30")]
  private bool opening;
  [Token(Token = "0x4000DF3")]
  [FieldOffset(Offset = "0x34")]
  private float lerpValue;
  [Token(Token = "0x4000DF4")]
  [FieldOffset(Offset = "0x38")]
  private float scaleTime;

  [Token(Token = "0x6000CF3")]
  [Address(RVA = "0x5312D0", Offset = "0x52FED0", Length = "0x29B")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000CF4")]
  [Address(RVA = "0x531570", Offset = "0x530170", Length = "0x229")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000CF5")]
  [Address(RVA = "0x5317A0", Offset = "0x5303A0", Length = "0x1CD")]
  private void OpenTooltip(string linkID, Vector2 position)
  {
  }

  [Token(Token = "0x6000CF6")]
  [Address(RVA = "0x3A4260", Offset = "0x3A2E60", Length = "0x5")]
  private void CloseTooltip(string linkID)
  {
  }

  [Token(Token = "0x6000CF7")]
  [Address(RVA = "0x531970", Offset = "0x530570", Length = "0x17D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CF8")]
  [Address(RVA = "0x531AF0", Offset = "0x5306F0", Length = "0xE")]
  public ToolTipMouse()
  {
  }
}
