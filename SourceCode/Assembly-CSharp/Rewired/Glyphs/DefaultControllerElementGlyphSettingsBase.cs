// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.DefaultControllerElementGlyphSettingsBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x200027B")]
  public abstract class DefaultControllerElementGlyphSettingsBase : MonoBehaviour
  {
    [Tooltip("The Controller element glyph options.")]
    [SerializeField]
    [Token(Token = "0x40011D2")]
    [FieldOffset(Offset = "0x20")]
    private ControllerElementGlyphSelectorOptions _options;
    [Tooltip("The prefab used for each glyph or text object.")]
    [SerializeField]
    [Token(Token = "0x40011D3")]
    [FieldOffset(Offset = "0x28")]
    private GameObject _glyphOrTextPrefab;

    [Token(Token = "0x170002E8")]
    public ControllerElementGlyphSelectorOptions options
    {
      [Token(Token = "0x6001293"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (ControllerElementGlyphSelectorOptions) null;
      [Token(Token = "0x6001294"), Address(RVA = "0x36D790", Offset = "0x36C390", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x170002E9")]
    public GameObject glyphOrTextPrefab
    {
      [Token(Token = "0x6001295"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (GameObject) null;
      [Token(Token = "0x6001296"), Address(RVA = "0x36D760", Offset = "0x36C360", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x6001297")]
    [Address(RVA = "0x36D690", Offset = "0x36C290", Length = "0x11")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x6001298")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void OnDisable()
    {
    }

    [Token(Token = "0x6001299")]
    [Address(RVA = "0x36D710", Offset = "0x36C310", Length = "0x32")]
    protected virtual void SetDefaults()
    {
    }

    [Token(Token = "0x600129A")]
    [Address(RVA = "0x36D6B0", Offset = "0x36C2B0", Length = "0x52")]
    protected virtual void SetDefaultOptions()
    {
    }

    [Token(Token = "0x600129B")]
    protected abstract void SetDefaultGlyphOrTextPrefab();

    [Token(Token = "0x600129C")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected DefaultControllerElementGlyphSettingsBase()
    {
    }
  }
}
