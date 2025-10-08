// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
  [AddComponentMenu("Rewired/Rewired Event System")]
  [Token(Token = "0x2000269")]
  public class RewiredEventSystem : EventSystem
  {
    [Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
    [SerializeField]
    [Token(Token = "0x400117E")]
    [FieldOffset(Offset = "0x60")]
    private bool _alwaysUpdate;

    [Token(Token = "0x170002AA")]
    public bool alwaysUpdate
    {
      [Token(Token = "0x60011A7"), Address(RVA = "0x371820", Offset = "0x370420", Length = "0x5")] get => false;
      [Token(Token = "0x60011A8"), Address(RVA = "0x371830", Offset = "0x370430", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x60011A9")]
    [Address(RVA = "0x3716A0", Offset = "0x3702A0", Length = "0x123")]
    protected override void Update()
    {
    }

    [Token(Token = "0x60011AA")]
    [Address(RVA = "0x3717D0", Offset = "0x3703D0", Length = "0x49")]
    public RewiredEventSystem()
    {
    }
  }
}
