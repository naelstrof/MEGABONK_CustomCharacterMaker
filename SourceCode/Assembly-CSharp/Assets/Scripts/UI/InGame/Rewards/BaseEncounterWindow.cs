// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Rewards.BaseEncounterWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.InGame.Rewards
{
  [Token(Token = "0x20002F7")]
  public abstract class BaseEncounterWindow : MonoBehaviour
  {
    [Token(Token = "0x6001586")]
    public abstract void Open(EEncounter encounterType);

    [Token(Token = "0x6001587")]
    public abstract void OnClose();

    [Token(Token = "0x6001588")]
    public abstract void ChooseOffer(int index);

    [Token(Token = "0x6001589")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    protected BaseEncounterWindow()
    {
    }
  }
}
