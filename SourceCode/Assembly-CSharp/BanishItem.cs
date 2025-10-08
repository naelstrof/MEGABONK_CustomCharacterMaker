// Decompiled with JetBrains decompiler
// Type: BanishItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000204")]
public class BanishItem : MonoBehaviour
{
  [Token(Token = "0x4000E2B")]
  [FieldOffset(Offset = "0x20")]
  public RawImage icon;
  [Token(Token = "0x4000E2C")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource audioSource;

  [Token(Token = "0x6000D3E")]
  [Address(RVA = "0x51CA90", Offset = "0x51B690", Length = "0x61")]
  public void Set(UnlockableBase unlockable)
  {
  }

  [Token(Token = "0x6000D3F")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public BanishItem()
  {
  }
}
