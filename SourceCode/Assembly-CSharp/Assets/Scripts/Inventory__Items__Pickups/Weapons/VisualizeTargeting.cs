// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.VisualizeTargeting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x2000367")]
  public class VisualizeTargeting : MonoBehaviour
  {
    [Token(Token = "0x400173F")]
    [FieldOffset(Offset = "0x20")]
    private Enemy target;

    [Token(Token = "0x600184D")]
    [Address(RVA = "0x3F9150", Offset = "0x3F7D50", Length = "0xC0")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x600184E")]
    [Address(RVA = "0x3F9220", Offset = "0x3F7E20", Length = "0x165")]
    private void Update()
    {
    }

    [Token(Token = "0x600184F")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public VisualizeTargeting()
    {
    }
  }
}
