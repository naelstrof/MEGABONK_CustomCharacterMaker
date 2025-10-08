// Decompiled with JetBrains decompiler
// Type: MapMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Token(Token = "0x200018B")]
public class MapMenu : MonoBehaviour
{
  [Token(Token = "0x4000B4E")]
  [FieldOffset(Offset = "0x20")]
  public Transform mapGridParent;
  [Token(Token = "0x4000B4F")]
  [FieldOffset(Offset = "0x28")]
  public GameObject mapPrefabUi;
  [Token(Token = "0x4000B50")]
  [FieldOffset(Offset = "0x30")]
  public MyButton b_confirm;
  [Token(Token = "0x4000B51")]
  [FieldOffset(Offset = "0x38")]
  public BackEscape windowBackEscape;
  [Token(Token = "0x4000B52")]
  [FieldOffset(Offset = "0x40")]
  private List<MyButtonMap> mapButtons;
  [Token(Token = "0x4000B53")]
  [FieldOffset(Offset = "0x48")]
  public TextMeshProUGUI t_buttonDisabledText;
  [Token(Token = "0x4000B54")]
  [FieldOffset(Offset = "0x50")]
  private MyButton selectedButton;
  [Token(Token = "0x4000B55")]
  [FieldOffset(Offset = "0x58")]
  public MapData selectedMap;

  [Token(Token = "0x60009ED")]
  [Address(RVA = "0x4F6E90", Offset = "0x4F5A90", Length = "0x653")]
  private void Start()
  {
  }

  [Token(Token = "0x60009EE")]
  [Address(RVA = "0x4F6E40", Offset = "0x4F5A40", Length = "0x4F")]
  private void RefreshArrow()
  {
  }

  [Token(Token = "0x60009EF")]
  [Address(RVA = "0x4F6C70", Offset = "0x4F5870", Length = "0x1C1")]
  private void OnSelectMap(MyButtonMap mapButton)
  {
  }

  [Token(Token = "0x60009F0")]
  [Address(RVA = "0x4F69B0", Offset = "0x4F55B0", Length = "0x9D")]
  private void OnConfirmMap(MyButtonMap mapButton)
  {
  }

  [Token(Token = "0x60009F1")]
  [Address(RVA = "0x4F74F0", Offset = "0x4F60F0", Length = "0x85")]
  private void Update()
  {
  }

  [Token(Token = "0x60009F2")]
  [Address(RVA = "0x4F6A50", Offset = "0x4F5650", Length = "0x216")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60009F3")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public void StartMap()
  {
  }

  [Token(Token = "0x60009F4")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public MapMenu()
  {
  }
}
