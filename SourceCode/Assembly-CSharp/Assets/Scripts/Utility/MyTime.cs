// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Utility.MyTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

namespace Assets.Scripts.Utility
{
  [Token(Token = "0x20002E5")]
  public static class MyTime
  {
    [Token(Token = "0x40013BF")]
    public static bool paused;
    [Token(Token = "0x40013C0")]
    public static float time;
    [Token(Token = "0x40013C1")]
    public static float deltaTime;
    [Token(Token = "0x40013C2")]
    public static float fixedDeltaTime;
    [Token(Token = "0x40013C4")]
    public static int tick;
    [Token(Token = "0x40013C5")]
    public static int unpauseTick;
    [Token(Token = "0x40013C6")]
    public static float stageTimer;
    [Token(Token = "0x40013C7")]
    public static float runTimer;
    [Token(Token = "0x40013C8")]
    public static float finalSwarmTimer;
    [Token(Token = "0x40013C9")]
    public static float difficultyTimer;
    [Token(Token = "0x40013CA")]
    public static Action<bool> A_Pause;
    [Token(Token = "0x40013CB")]
    public static Action A_Tick;
    [Token(Token = "0x40013CC")]
    public static Action A_TimeScaleChange;
    [Token(Token = "0x40013CD")]
    private static float timescaleTimeRemaining;

    [field: Token(Token = "0x40013C3")]
    [Token(Token = "0x1700037B")]
    public static float timeScale { [Token(Token = "0x6001538"), Address(RVA = "0x3B28E0", Offset = "0x3B14E0", Length = "0x50")] get; [Token(Token = "0x6001539"), Address(RVA = "0x3B2930", Offset = "0x3B1530", Length = "0x5D")] private set; }

    [Token(Token = "0x600153A")]
    [Address(RVA = "0x3B1CF0", Offset = "0x3B08F0", Length = "0x1FB")]
    public static void Init()
    {
    }

    [Token(Token = "0x600153B")]
    [Address(RVA = "0x3B19C0", Offset = "0x3B05C0", Length = "0x1FB")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x600153C")]
    [Address(RVA = "0x3B1EF0", Offset = "0x3B0AF0", Length = "0xC3")]
    private static void OnNewRunStarted()
    {
    }

    [Token(Token = "0x600153D")]
    [Address(RVA = "0x3B1FC0", Offset = "0x3B0BC0", Length = "0x1B1")]
    private static void OnNewStageStarted()
    {
    }

    [Token(Token = "0x600153E")]
    [Address(RVA = "0x3B2480", Offset = "0x3B1080", Length = "0x418")]
    public static void Update()
    {
    }

    [Token(Token = "0x600153F")]
    [Address(RVA = "0x3B1BC0", Offset = "0x3B07C0", Length = "0x12A")]
    public static void FixedUpdate()
    {
    }

    [Token(Token = "0x6001540")]
    [Address(RVA = "0x3B22E0", Offset = "0x3B0EE0", Length = "0xCD")]
    public static void SetTimeScale(float newTimeScale, float duration)
    {
    }

    [Token(Token = "0x6001541")]
    [Address(RVA = "0x3B2230", Offset = "0x3B0E30", Length = "0xA7")]
    private static void ResetTimeScale()
    {
    }

    [Token(Token = "0x6001542")]
    [Address(RVA = "0x3B2180", Offset = "0x3B0D80", Length = "0xA2")]
    public static void Pause()
    {
    }

    [Token(Token = "0x6001543")]
    [Address(RVA = "0x3B23B0", Offset = "0x3B0FB0", Length = "0xC9")]
    public static void Unpause()
    {
    }

    [Token(Token = "0x6001544")]
    [Address(RVA = "0x3B28A0", Offset = "0x3B14A0", Length = "0x3A")]
    static MyTime()
    {
    }
  }
}
