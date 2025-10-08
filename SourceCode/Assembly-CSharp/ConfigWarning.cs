// Decompiled with JetBrains decompiler
// Type: ConfigWarning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using TMPro;
using UnityEngine;

[Token(Token = "0x200011D")]
public class ConfigWarning : MonoBehaviour
{
  [Token(Token = "0x400087D")]
  [FieldOffset(Offset = "0x20")]
  public GameObject overlay;
  [Token(Token = "0x400087E")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_warning;
  [Token(Token = "0x400087F")]
  [FieldOffset(Offset = "0x30")]
  public TextSizer textSizer;
  [Token(Token = "0x4000880")]
  [FieldOffset(Offset = "0x38")]
  private string configFilePath;
  [Token(Token = "0x4000881")]
  public static ConfigWarning Instance;

  [Token(Token = "0x600071E")]
  [Address(RVA = "0x4B3B30", Offset = "0x4B2730", Length = "0xD3")]
  private void Awake()
  {
  }

  [Token(Token = "0x600071F")]
  [Address(RVA = "0x4B3E20", Offset = "0x4B2A20", Length = "0xB")]
  public void OpenFile()
  {
  }

  [Token(Token = "0x6000720")]
  [Address(RVA = "0x4B3E30", Offset = "0x4B2A30", Length = "0xA9")]
  public void RefreshFile()
  {
  }

  [Token(Token = "0x6000721")]
  [Address(RVA = "0x4B3D70", Offset = "0x4B2970", Length = "0xA9")]
  public void LoadBackup()
  {
  }

  [Token(Token = "0x6000722")]
  [Address(RVA = "0x4B3EE0", Offset = "0x4B2AE0", Length = "0x1CD")]
  public void ResetFile()
  {
  }

  [Token(Token = "0x6000723")]
  [Address(RVA = "0x4B3C40", Offset = "0x4B2840", Length = "0x127")]
  public void IgnoreWarning()
  {
  }

  [Token(Token = "0x6000724")]
  [Address(RVA = "0x4B4160", Offset = "0x4B2D60", Length = "0xAB")]
  public void ShowWarning(string e, string filePath)
  {
  }

  [Token(Token = "0x6000725")]
  [Address(RVA = "0x4B40B0", Offset = "0x4B2CB0", Length = "0xA1")]
  private IEnumerator ShowWarningCoroutine(string e, string filepath) => (IEnumerator) null;

  [Token(Token = "0x6000726")]
  [Address(RVA = "0x4B3C10", Offset = "0x4B2810", Length = "0x20")]
  public void HideWarning()
  {
  }

  [Token(Token = "0x6000727")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ConfigWarning()
  {
  }
}
