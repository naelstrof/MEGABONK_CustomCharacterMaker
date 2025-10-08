// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.HUD.ScoreUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.HUD
{
  [Token(Token = "0x2000300")]
  public class ScoreUi : MonoBehaviour
  {
    [Token(Token = "0x400146A")]
    [FieldOffset(Offset = "0x20")]
    public RandomSfx scoreSound;
    [Token(Token = "0x400146B")]
    [FieldOffset(Offset = "0x28")]
    public RandomSfx negativeSound;
    [Token(Token = "0x400146C")]
    [FieldOffset(Offset = "0x30")]
    private bool moveDesc;
    [Token(Token = "0x400146D")]
    [FieldOffset(Offset = "0x38")]
    private Queue<ScoreContainer> scoreQueue;
    [Token(Token = "0x400146E")]
    [FieldOffset(Offset = "0x40")]
    private List<ScoreUiPrefab> prefabs;
    [Token(Token = "0x400146F")]
    [FieldOffset(Offset = "0x48")]
    public GameObject prefab;
    [Token(Token = "0x4001470")]
    [FieldOffset(Offset = "0x50")]
    private bool isActive;
    [Token(Token = "0x4001471")]
    [FieldOffset(Offset = "0x54")]
    private float readyTime;

    [Token(Token = "0x60015AB")]
    [Address(RVA = "0x3B7AF0", Offset = "0x3B66F0", Length = "0x139")]
    public void AddScore(string description, string header, bool isPositive = true)
    {
    }

    [Token(Token = "0x60015AC")]
    [Address(RVA = "0x3B7C30", Offset = "0x3B6830", Length = "0x1A9")]
    public void AddScore(StatModifier statModifier, bool isPositive)
    {
    }

    [Token(Token = "0x60015AD")]
    [Address(RVA = "0x3B8150", Offset = "0x3B6D50", Length = "0x8B")]
    private void Update()
    {
    }

    [Token(Token = "0x60015AE")]
    [Address(RVA = "0x3B7DE0", Offset = "0x3B69E0", Length = "0x365")]
    private void SetScore()
    {
    }

    [Token(Token = "0x60015AF")]
    [Address(RVA = "0x3B81E0", Offset = "0x3B6DE0", Length = "0xBD")]
    public ScoreUi()
    {
    }
  }
}
