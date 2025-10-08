// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Settings___Saves.AboutText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Settings___Saves
{
  [Token(Token = "0x2000314")]
  public class AboutText : MonoBehaviour
  {
    [Token(Token = "0x40014E0")]
    [FieldOffset(Offset = "0x20")]
    public TextMeshProUGUI text;

    [Token(Token = "0x6001620")]
    [Address(RVA = "0x3A2450", Offset = "0x3A1050", Length = "0x7D")]
    public void SetText(string header, string body)
    {
    }

    [Token(Token = "0x6001621")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public AboutText()
    {
    }
  }
}
