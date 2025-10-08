// Decompiled with JetBrains decompiler
// Type: Rewired.Localization.LocalizedStringProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Localization
{
  [AddComponentMenu("Rewired/Localization/Localized String Provider")]
  [Token(Token = "0x2000272")]
  public class LocalizedStringProvider : LocalizedStringProviderBase
  {
    [SerializeField]
    [Tooltip("A JSON file containing localizied string key value pairs.")]
    [Token(Token = "0x40011BB")]
    [FieldOffset(Offset = "0x28")]
    private TextAsset _localizedStringsFile;
    [Token(Token = "0x40011BC")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    private Dictionary<string, string> _dictionary;
    [Token(Token = "0x40011BD")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private bool _initialized;

    [Token(Token = "0x170002D6")]
    protected virtual Dictionary<string, string> dictionary
    {
      [Token(Token = "0x6001245"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get => (Dictionary<string, string>) null;
      [Token(Token = "0x6001246"), Address(RVA = "0x370A90", Offset = "0x36F690", Length = "0xD")] set
      {
      }
    }

    [Token(Token = "0x170002D7")]
    public virtual TextAsset localizedStringsFile
    {
      [Token(Token = "0x6001247"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (TextAsset) null;
      [Token(Token = "0x6001248"), Address(RVA = "0x370AA0", Offset = "0x36F6A0", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x170002D8")]
    protected override bool initialized
    {
      [Token(Token = "0x6001249"), Address(RVA = "0x370A80", Offset = "0x36F680", Length = "0x5")] get => false;
    }

    [Token(Token = "0x600124A")]
    [Address(RVA = "0x3707F0", Offset = "0x36F3F0", Length = "0x25")]
    protected override bool Initialize() => false;

    [Token(Token = "0x600124B")]
    [Address(RVA = "0x3708B0", Offset = "0x36F4B0", Length = "0x14E")]
    protected virtual bool TryLoadLocalizedStringData() => false;

    [Token(Token = "0x600124C")]
    [Address(RVA = "0x370820", Offset = "0x36F420", Length = "0x8C")]
    protected override bool TryGetLocalizedString(string key, out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x600124D")]
    [Address(RVA = "0x370A00", Offset = "0x36F600", Length = "0x77")]
    public LocalizedStringProvider()
    {
    }
  }
}
