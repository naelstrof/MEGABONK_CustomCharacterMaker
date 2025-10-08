// Decompiled with JetBrains decompiler
// Type: Rewired.InputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired
{
  [AddComponentMenu("Rewired/Input Manager")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Token(Token = "0x2000244")]
  public sealed class InputManager : InputManager_Base
  {
    [Token(Token = "0x40010FE")]
    [FieldOffset(Offset = "0x58")]
    private bool ignoreRecompile;

    [Token(Token = "0x6001044")]
    [Address(RVA = "0x5275D0", Offset = "0x5261D0", Length = "0x98")]
    protected override void OnInitialized()
    {
    }

    [Token(Token = "0x6001045")]
    [Address(RVA = "0x5275C0", Offset = "0x5261C0", Length = "0x7")]
    protected override void OnDeinitialized()
    {
    }

    [Token(Token = "0x6001046")]
    [Address(RVA = "0x527520", Offset = "0x526120", Length = "0x42")]
    protected override void DetectPlatform()
    {
    }

    [Token(Token = "0x6001047")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void CheckRecompile()
    {
    }

    [Token(Token = "0x6001048")]
    [Address(RVA = "0x527570", Offset = "0x526170", Length = "0x44")]
    protected override IExternalTools GetExternalTools() => (IExternalTools) null;

    [Token(Token = "0x6001049")]
    [Address(RVA = "0x527470", Offset = "0x526070", Length = "0xA7")]
    private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel) => false;

    [Token(Token = "0x600104A")]
    [Address(RVA = "0x5275D0", Offset = "0x5261D0", Length = "0x98")]
    private void SubscribeEvents()
    {
    }

    [Token(Token = "0x600104B")]
    [Address(RVA = "0x527680", Offset = "0x526280", Length = "0x8E")]
    private void UnsubscribeEvents()
    {
    }

    [Token(Token = "0x600104C")]
    [Address(RVA = "0x527670", Offset = "0x526270", Length = "0x7")]
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x600104D")]
    [Address(RVA = "0x527710", Offset = "0x526310", Length = "0x7")]
    public InputManager()
    {
    }
  }
}
