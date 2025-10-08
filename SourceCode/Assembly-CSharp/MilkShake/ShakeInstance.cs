// Decompiled with JetBrains decompiler
// Type: MilkShake.ShakeInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

namespace MilkShake
{
  [Token(Token = "0x20002B9")]
  [Serializable]
  public class ShakeInstance
  {
    [Token(Token = "0x4001295")]
    [FieldOffset(Offset = "0x10")]
    public ShakeParameters ShakeParameters;
    [Token(Token = "0x4001296")]
    [FieldOffset(Offset = "0x18")]
    public float StrengthScale;
    [Token(Token = "0x4001297")]
    [FieldOffset(Offset = "0x1C")]
    public float RoughnessScale;
    [Token(Token = "0x4001298")]
    [FieldOffset(Offset = "0x20")]
    public bool RemoveWhenStopped;
    [Token(Token = "0x400129B")]
    [FieldOffset(Offset = "0x2C")]
    private int baseSeed;
    [Token(Token = "0x400129C")]
    [FieldOffset(Offset = "0x30")]
    private float seed1;
    [Token(Token = "0x400129D")]
    [FieldOffset(Offset = "0x34")]
    private float seed2;
    [Token(Token = "0x400129E")]
    [FieldOffset(Offset = "0x38")]
    private float seed3;
    [Token(Token = "0x400129F")]
    [FieldOffset(Offset = "0x3C")]
    private float noiseTimer;
    [Token(Token = "0x40012A0")]
    [FieldOffset(Offset = "0x40")]
    private float fadeTimer;
    [Token(Token = "0x40012A1")]
    [FieldOffset(Offset = "0x44")]
    private float fadeInTime;
    [Token(Token = "0x40012A2")]
    [FieldOffset(Offset = "0x48")]
    private float fadeOutTime;
    [Token(Token = "0x40012A3")]
    [FieldOffset(Offset = "0x4C")]
    private float pauseTimer;
    [Token(Token = "0x40012A4")]
    [FieldOffset(Offset = "0x50")]
    private float pauseFadeTime;
    [Token(Token = "0x40012A5")]
    [FieldOffset(Offset = "0x54")]
    private int lastUpdatedFrame;

    [field: Token(Token = "0x4001299")]
    [field: FieldOffset(Offset = "0x24")]
    [Token(Token = "0x17000367")]
    public ShakeState State { [Token(Token = "0x6001465"), Address(RVA = "0x393100", Offset = "0x391D00", Length = "0x4")] get; [Token(Token = "0x6001466"), Address(RVA = "0x393120", Offset = "0x391D20", Length = "0x4")] private set; }

    [field: Token(Token = "0x400129A")]
    [field: FieldOffset(Offset = "0x28")]
    [Token(Token = "0x17000368")]
    public bool IsPaused { [Token(Token = "0x6001467"), Address(RVA = "0x3930F0", Offset = "0x391CF0", Length = "0x5")] get; [Token(Token = "0x6001468"), Address(RVA = "0x393110", Offset = "0x391D10", Length = "0x4")] private set; }

    [Token(Token = "0x17000369")]
    public bool IsFinished
    {
      [Token(Token = "0x6001469"), Address(RVA = "0x3930E0", Offset = "0x391CE0", Length = "0xE")] get => false;
    }

    [Token(Token = "0x1700036A")]
    public float CurrentStrength
    {
      [Token(Token = "0x600146A"), Address(RVA = "0x3930B0", Offset = "0x391CB0", Length = "0x26")] get => 0.0f;
    }

    [Token(Token = "0x1700036B")]
    public float CurrentRoughness
    {
      [Token(Token = "0x600146B"), Address(RVA = "0x393080", Offset = "0x391C80", Length = "0x26")] get => 0.0f;
    }

    [Token(Token = "0x600146C")]
    [Address(RVA = "0x392D00", Offset = "0x391900", Length = "0xEF")]
    public ShakeInstance(int? seed = null)
    {
    }

    [Token(Token = "0x600146D")]
    [Address(RVA = "0x392B50", Offset = "0x391750", Length = "0x1A7")]
    public ShakeInstance(IShakeParameters shakeData, int? seed = null)
    {
    }

    [Token(Token = "0x600146E")]
    [Address(RVA = "0x3927C0", Offset = "0x3913C0", Length = "0x38D")]
    public ShakeResult UpdateShake(float deltaTime) => new ShakeResult();

    [Token(Token = "0x600146F")]
    [Address(RVA = "0x392760", Offset = "0x391360", Length = "0xD")]
    public void Start(float fadeTime)
    {
    }

    [Token(Token = "0x6001470")]
    [Address(RVA = "0x392770", Offset = "0x391370", Length = "0x11")]
    public void Stop(float fadeTime, bool removeWhenStopped)
    {
    }

    [Token(Token = "0x6001471")]
    [Address(RVA = "0x392720", Offset = "0x391320", Length = "0x19")]
    public void Pause(float fadeTime)
    {
    }

    [Token(Token = "0x6001472")]
    [Address(RVA = "0x392740", Offset = "0x391340", Length = "0x19")]
    public void Resume(float fadeTime)
    {
    }

    [Token(Token = "0x6001473")]
    [Address(RVA = "0x392790", Offset = "0x391390", Length = "0x30")]
    public void TogglePaused(float fadeTime)
    {
    }

    [Token(Token = "0x6001474")]
    [Address(RVA = "0x392E20", Offset = "0x391A20", Length = "0x122")]
    private Vector3 getPositionShake() => new Vector3();

    [Token(Token = "0x6001475")]
    [Address(RVA = "0x392F50", Offset = "0x391B50", Length = "0x12B")]
    private Vector3 getRotationShake() => new Vector3();

    [Token(Token = "0x6001476")]
    [Address(RVA = "0x392DF0", Offset = "0x3919F0", Length = "0x23")]
    private float getNoise(float x, float y) => 0.0f;
  }
}
