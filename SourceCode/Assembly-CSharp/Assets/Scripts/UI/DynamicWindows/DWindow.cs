// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.DynamicWindows.DWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.UI.DynamicWindows
{
  [Token(Token = "0x2000302")]
  public class DWindow : DWindowBase
  {
    [Token(Token = "0x4001475")]
    [FieldOffset(Offset = "0x28")]
    public TextMeshProUGUI t_header;
    [Token(Token = "0x4001476")]
    [FieldOffset(Offset = "0x30")]
    public TextMeshProUGUI t_content;
    [Token(Token = "0x4001477")]
    [FieldOffset(Offset = "0x38")]
    public TextMeshProUGUI t_button;

    [Token(Token = "0x60015B1")]
    [Address(RVA = "0x3A7690", Offset = "0x3A6290", Length = "0x85")]
    public void Set(string header, string content, string buttonText = "Okey")
    {
    }

    [Token(Token = "0x60015B2")]
    [Address(RVA = "0x3A7630", Offset = "0x3A6230", Length = "0x56")]
    public void Close()
    {
    }

    [Token(Token = "0x60015B3")]
    [Address(RVA = "0x3A74D0", Offset = "0x3A60D0", Length = "0xE")]
    public DWindow()
    {
    }
  }
}
