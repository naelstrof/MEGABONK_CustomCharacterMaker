// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.Spawning.New.BaseSummoner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Actors.Enemies;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Spawning.New
{
  [Token(Token = "0x2000412")]
  public abstract class BaseSummoner
  {
    [Token(Token = "0x4001AA4")]
    [FieldOffset(Offset = "0x10")]
    protected float credits;
    [Token(Token = "0x4001AA5")]
    [FieldOffset(Offset = "0x18")]
    private List<EnemyCard> cards;
    [Token(Token = "0x4001AA6")]
    [FieldOffset(Offset = "0x20")]
    private float giveCreditsTimer;
    [Token(Token = "0x4001AA7")]
    [FieldOffset(Offset = "0x24")]
    private float spendCreditsTimer;
    [Token(Token = "0x4001AA8")]
    [FieldOffset(Offset = "0x28")]
    protected int maxEnemiesPerSecond;
    [Token(Token = "0x4001AA9")]
    [FieldOffset(Offset = "0x2C")]
    protected int maxEnemiesPerCycle;
    [Token(Token = "0x4001AAA")]
    [FieldOffset(Offset = "0x30")]
    protected int enemiesThisSecond;
    [Token(Token = "0x4001AAB")]
    [FieldOffset(Offset = "0x34")]
    private int nextSecond;
    [Token(Token = "0x4001AAC")]
    [FieldOffset(Offset = "0x38")]
    protected int id;
    [Token(Token = "0x4001AAD")]
    [FieldOffset(Offset = "0x3C")]
    public bool slowmode;
    [Token(Token = "0x4001AAE")]
    [FieldOffset(Offset = "0x40")]
    private float slowmodeMultiplier;
    [Token(Token = "0x4001AAF")]
    [FieldOffset(Offset = "0x44")]
    private float slowmodeOverAtTime;
    [Token(Token = "0x4001AB0")]
    [FieldOffset(Offset = "0x48")]
    private bool isWaveMode;
    [Token(Token = "0x4001AB1")]
    [FieldOffset(Offset = "0x4C")]
    private float waveModeOverAtTime;
    [Token(Token = "0x4001AB2")]
    [FieldOffset(Offset = "0x50")]
    private List<EnemyCard> waveModeCards;
    [Token(Token = "0x4001AB3")]
    [FieldOffset(Offset = "0x58")]
    protected List<EEnemy> currentEnemies;
    [Token(Token = "0x4001AB4")]
    [FieldOffset(Offset = "0x60")]
    private List<Enemy> spawnedEnemies;

    [Token(Token = "0x6001D40")]
    [Address(RVA = "0x41D8A0", Offset = "0x41C4A0", Length = "0x369")]
    public BaseSummoner(int id, List<EEnemy> defaultEnemies)
    {
    }

    [Token(Token = "0x6001D41")]
    [Address(RVA = "0x41C1A0", Offset = "0x41ADA0", Length = "0x23E")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x6001D42")]
    [Address(RVA = "0x41D5E0", Offset = "0x41C1E0", Length = "0x2B6")]
    public void Tick()
    {
    }

    [Token(Token = "0x6001D43")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void TickExtra()
    {
    }

    [Token(Token = "0x6001D44")]
    [Address(RVA = "0x41C3E0", Offset = "0x41AFE0", Length = "0x31")]
    protected void GenerateCardsForSummoner(List<EEnemy> enemies)
    {
    }

    [Token(Token = "0x6001D45")]
    [Address(RVA = "0x41C420", Offset = "0x41B020", Length = "0x51E")]
    protected virtual List<EnemyCard> GenerateCards(List<EEnemy> enemies) => (List<EnemyCard>) null;

    [Token(Token = "0x6001D46")]
    [Address(RVA = "0x41CF20", Offset = "0x41BB20", Length = "0x34C")]
    private void RefreshCardWeights()
    {
    }

    [Token(Token = "0x6001D47")]
    [Address(RVA = "0x41C070", Offset = "0x41AC70", Length = "0xB2")]
    public void AddCredits()
    {
    }

    [Token(Token = "0x6001D48")]
    [Address(RVA = "0x41C940", Offset = "0x41B540", Length = "0x3D")]
    public float GetCreditsPerSecond() => 0.0f;

    [Token(Token = "0x6001D49")]
    [Address(RVA = "0x41D390", Offset = "0x41BF90", Length = "0x24A")]
    public virtual List<Enemy> SpendCredits(bool useWeights = true) => (List<Enemy>) null;

    [Token(Token = "0x6001D4A")]
    [Address(RVA = "0x41CA30", Offset = "0x41B630", Length = "0x4CC")]
    protected EnemyCard GetRandomCard(bool useWeights) => (EnemyCard) null;

    [Token(Token = "0x6001D4B")]
    [Address(RVA = "0x41D270", Offset = "0x41BE70", Length = "0x7E")]
    public void SetSlowmode(float multiplier, float duration)
    {
    }

    [Token(Token = "0x6001D4C")]
    [Address(RVA = "0x41D2F0", Offset = "0x41BEF0", Length = "0xA0")]
    public void SetWaveMode(List<EEnemy> waveEnemies, float duration)
    {
    }

    [Token(Token = "0x6001D4D")]
    [Address(RVA = "0x41C980", Offset = "0x41B580", Length = "0xA8")]
    protected float GetMultiplier() => 0.0f;

    [Token(Token = "0x6001D4E")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    protected virtual bool UseMultiplier() => false;

    [Token(Token = "0x6001D4F")]
    [Address(RVA = "0x41C130", Offset = "0x41AD30", Length = "0x64")]
    private bool CanEarnCredits() => false;

    [Token(Token = "0x6001D50")]
    [Address(RVA = "0x41CF10", Offset = "0x41BB10", Length = "0xD")]
    private void OnStatUpdated(EStat stat)
    {
    }

    [Token(Token = "0x6001D51")]
    [Address(RVA = "0x41CF00", Offset = "0x41BB00", Length = "0x7")]
    private void OnPlayerInventoryInitialized(PlayerInventory playerInventory)
    {
    }

    [Token(Token = "0x6001D52")]
    protected abstract void Init();

    [Token(Token = "0x6001D53")]
    protected abstract List<EEnemy> GetEnemies();

    [Token(Token = "0x6001D54")]
    public abstract float GetSummonInterval();

    [Token(Token = "0x6001D55")]
    public abstract float GetBaseCreditsPerSecond();

    [Token(Token = "0x6001D56")]
    public abstract float GetInitialCredits();

    [Token(Token = "0x6001D57")]
    public abstract int GetNumTargetEnemies();

    [Token(Token = "0x6001D58")]
    protected abstract bool UseDirectionBias();

    [Token(Token = "0x6001D59")]
    protected abstract bool ForceSpawn();
  }
}
