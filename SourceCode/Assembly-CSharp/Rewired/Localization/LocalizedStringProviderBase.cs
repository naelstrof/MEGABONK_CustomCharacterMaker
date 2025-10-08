// Decompiled with JetBrains decompiler
// Type: Rewired.Localization.LocalizedStringProviderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Localization
{
  [Token(Token = "0x2000273")]
  public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider
  {
    [SerializeField]
    [Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
    [Token(Token = "0x40011BE")]
    [FieldOffset(Offset = "0x20")]
    private bool _prefetch;

    [Token(Token = "0x170002D9")]
    public virtual bool prefetch
    {
      [Token(Token = "0x600124E"), Address(RVA = "0x36EB80", Offset = "0x36D780", Length = "0x5")] get => false;
      [Token(Token = "0x600124F"), Address(RVA = "0x3706B0", Offset = "0x36F2B0", Length = "0x131")] set
      {
      }
    }

    [Token(Token = "0x170002DA")]
    protected abstract bool initialized { [Token(Token = "0x6001250")] get; }

    [Token(Token = "0x6001251")]
    [Address(RVA = "0x3702F0", Offset = "0x36EEF0", Length = "0x4C")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x6001252")]
    [Address(RVA = "0x3701A0", Offset = "0x36EDA0", Length = "0x14C")]
    protected virtual void OnDisable()
    {
    }

    [Token(Token = "0x6001253")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x6001254")]
    [Address(RVA = "0x3704A0", Offset = "0x36F0A0", Length = "0x208")]
    protected virtual void TrySetLocalizedStringProvider()
    {
    }

    [Token(Token = "0x6001255")]
    protected abstract bool Initialize();

    [Token(Token = "0x6001256")]
    [Address(RVA = "0x370340", Offset = "0x36EF40", Length = "0x134")]
    public virtual void Reload()
    {
    }

    [Token(Token = "0x6001257")]
    protected abstract bool TryGetLocalizedString(string key, out string result);

    [Token(Token = "0x6001258")]
    [Address(RVA = "0x370480", Offset = "0x36F080", Length = "0x14")]
    bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x6001259")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected LocalizedStringProviderBase()
    {
    }
  }
}
