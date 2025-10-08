// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.DynamicWindows.DWindowPrompt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using TMPro;

namespace Assets.Scripts.UI.DynamicWindows
{
  [Token(Token = "0x2000304")]
  public class DWindowPrompt : DWindowBase
  {
    [Token(Token = "0x4001479")]
    [FieldOffset(Offset = "0x28")]
    public TextMeshProUGUI t_header;
    [Token(Token = "0x400147A")]
    [FieldOffset(Offset = "0x30")]
    public TextMeshProUGUI t_content;
    [Token(Token = "0x400147B")]
    [FieldOffset(Offset = "0x38")]
    private Action A_Accept;

    [Token(Token = "0x60015B7")]
    [Address(RVA = "0x3A75B0", Offset = "0x3A61B0", Length = "0x79")]
    public void Set(string header, string content, Action A_Accept)
    {
    }

    [Token(Token = "0x60015B8")]
    [Address(RVA = "0x3A74E0", Offset = "0x3A60E0", Length = "0x6A")]
    public void Accept()
    {
    }

    [Token(Token = "0x60015B9")]
    [Address(RVA = "0x3A7550", Offset = "0x3A6150", Length = "0x56")]
    public void Close()
    {
    }

    [Token(Token = "0x60015BA")]
    [Address(RVA = "0x3A74D0", Offset = "0x3A60D0", Length = "0xE")]
    public DWindowPrompt()
    {
    }
  }
}
