// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.InGame.Levelup.EncounterWindows
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI.InGame.Levelup
{
  [Token(Token = "0x20002F5")]
  public class EncounterWindows : MonoBehaviour
  {
    [Token(Token = "0x400142D")]
    [FieldOffset(Offset = "0x20")]
    public BaseEncounterWindow levelupScreen;
    [Token(Token = "0x400142E")]
    [FieldOffset(Offset = "0x28")]
    public BaseEncounterWindow genericEncounterWindow;
    [Token(Token = "0x400142F")]
    [FieldOffset(Offset = "0x30")]
    public BaseEncounterWindow chestWindow;
    [Token(Token = "0x4001430")]
    [FieldOffset(Offset = "0x38")]
    public BaseEncounterWindow itemPickWindow;
    [Token(Token = "0x4001431")]
    [FieldOffset(Offset = "0x40")]
    public BaseEncounterWindow microwaveWindow;
    [Token(Token = "0x4001432")]
    [FieldOffset(Offset = "0x48")]
    private BaseEncounterWindow activeEncounterWindow;
    [Token(Token = "0x4001433")]
    [FieldOffset(Offset = "0x50")]
    private Queue<EEncounter> rewardQueue;
    [Token(Token = "0x4001435")]
    [FieldOffset(Offset = "0x59")]
    private bool closedEncounterThisFrame;
    [Token(Token = "0x4001436")]
    private static List<EEncounter> nextMapQueue;
    [Token(Token = "0x4001437")]
    public static Action A_WindowOpened;
    [Token(Token = "0x4001438")]
    public static Action A_WindowClosed;
    [Token(Token = "0x4001439")]
    [FieldOffset(Offset = "0x5C")]
    public int currentLevel;

    [field: Token(Token = "0x4001434")]
    [field: FieldOffset(Offset = "0x58")]
    [Token(Token = "0x1700037C")]
    public bool encounterInProgress { [Token(Token = "0x6001575"), Address(RVA = "0x39E880", Offset = "0x39D480", Length = "0x5")] get; [Token(Token = "0x6001576"), Address(RVA = "0x3AAD30", Offset = "0x3A9930", Length = "0x4")] private set; }

    [Token(Token = "0x6001577")]
    [Address(RVA = "0x3A9B10", Offset = "0x3A8710", Length = "0x444")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001578")]
    [Address(RVA = "0x3A9F80", Offset = "0x3A8B80", Length = "0x444")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001579")]
    [Address(RVA = "0x3AA3D0", Offset = "0x3A8FD0", Length = "0x95")]
    private void OnGameOver()
    {
    }

    [Token(Token = "0x600157A")]
    [Address(RVA = "0x3AA5A0", Offset = "0x3A91A0", Length = "0x1C2")]
    private void OnPortalClosed()
    {
    }

    [Token(Token = "0x600157B")]
    [Address(RVA = "0x3AAA00", Offset = "0x3A9600", Length = "0x63")]
    private bool QueueEncountersForNextMap() => false;

    [Token(Token = "0x600157C")]
    [Address(RVA = "0x3A9F60", Offset = "0x3A8B60", Length = "0xD")]
    public bool HasEncounter() => false;

    [Token(Token = "0x600157D")]
    [Address(RVA = "0x3A99A0", Offset = "0x3A85A0", Length = "0x163")]
    public void AddEncounter(EEncounter rewardWindowType)
    {
    }

    [Token(Token = "0x600157E")]
    [Address(RVA = "0x3AAA70", Offset = "0x3A9670", Length = "0xF8")]
    public void RewardFinished()
    {
    }

    [Token(Token = "0x600157F")]
    [Address(RVA = "0x3AA770", Offset = "0x3A9370", Length = "0x25C")]
    private void PopReward()
    {
    }

    [Token(Token = "0x6001580")]
    [Address(RVA = "0x3AA470", Offset = "0x3A9070", Length = "0x22")]
    private void OnInventoryInitialized(PlayerInventory inventory)
    {
    }

    [Token(Token = "0x6001581")]
    [Address(RVA = "0x3A9F70", Offset = "0x3A8B70", Length = "0x5")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6001582")]
    [Address(RVA = "0x3AAB70", Offset = "0x3A9770", Length = "0xA6")]
    private void Start()
    {
    }

    [Token(Token = "0x6001583")]
    [Address(RVA = "0x3AA4A0", Offset = "0x3A90A0", Length = "0xFB")]
    private void OnLevelUp(int level)
    {
    }

    [Token(Token = "0x6001584")]
    [Address(RVA = "0x3AACB0", Offset = "0x3A98B0", Length = "0x77")]
    public EncounterWindows()
    {
    }

    [Token(Token = "0x6001585")]
    [Address(RVA = "0x3AAC20", Offset = "0x3A9820", Length = "0x84")]
    static EncounterWindows()
    {
    }
  }
}
