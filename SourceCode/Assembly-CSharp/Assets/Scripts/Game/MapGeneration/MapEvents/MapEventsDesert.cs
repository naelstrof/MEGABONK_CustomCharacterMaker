// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.MapGeneration.MapEvents.MapEventsDesert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;

namespace Assets.Scripts.Game.MapGeneration.MapEvents
{
  [Token(Token = "0x2000423")]
  public class MapEventsDesert : Assets.Scripts.Game.MapGeneration.MapEvents.MapEvents
  {
    [Token(Token = "0x4001AFD")]
    [FieldOffset(Offset = "0x10")]
    public bool ENABLE_SANDSTORM;
    [Token(Token = "0x4001AFE")]
    [FieldOffset(Offset = "0x14")]
    private int numStorms;
    [Token(Token = "0x4001AFF")]
    [FieldOffset(Offset = "0x18")]
    private List<float> stormTimes;
    [Token(Token = "0x4001B00")]
    [FieldOffset(Offset = "0x20")]
    private float minDuration;
    [Token(Token = "0x4001B01")]
    [FieldOffset(Offset = "0x24")]
    private float maxDuration;
    [Token(Token = "0x4001B02")]
    private static bool isActiveStorm;
    [Token(Token = "0x4001B03")]
    [FieldOffset(Offset = "0x28")]
    private float nextStormTime;
    [Token(Token = "0x4001B04")]
    [FieldOffset(Offset = "0x2C")]
    private float stormOverAtTime;
    [Token(Token = "0x4001B05")]
    [FieldOffset(Offset = "0x30")]
    private int stormIndex;
    [Token(Token = "0x4001B06")]
    public static float currentStormStartedAtTime;
    [Token(Token = "0x4001B07")]
    [FieldOffset(Offset = "0x34")]
    private float tumbleweedSpawnInterval;
    [Token(Token = "0x4001B08")]
    [FieldOffset(Offset = "0x38")]
    private float lastSpawnedTumbleweedTime;

    [Token(Token = "0x1700038C")]
    private float minGapBetweenStorms
    {
      [Token(Token = "0x6001DC5"), Address(RVA = "0x449690", Offset = "0x448290", Length = "0xE")] get => 0.0f;
    }

    [Token(Token = "0x6001DC6")]
    [Address(RVA = "0x448AF0", Offset = "0x4476F0", Length = "0x440")]
    public override void Init()
    {
    }

    [Token(Token = "0x6001DC7")]
    [Address(RVA = "0x448AB0", Offset = "0x4476B0", Length = "0x36")]
    public override void Cleanup()
    {
    }

    [Token(Token = "0x6001DC8")]
    [Address(RVA = "0x448F40", Offset = "0x447B40", Length = "0x36")]
    public static bool IsActiveStorm() => false;

    [Token(Token = "0x6001DC9")]
    [Address(RVA = "0x4494F0", Offset = "0x4480F0", Length = "0x10E")]
    public override void Tick()
    {
    }

    [Token(Token = "0x6001DCA")]
    [Address(RVA = "0x449250", Offset = "0x447E50", Length = "0x294")]
    private void TickStorms()
    {
    }

    [Token(Token = "0x6001DCB")]
    [Address(RVA = "0x448F80", Offset = "0x447B80", Length = "0xD0")]
    private void SpawnTumbleWeeds()
    {
    }

    [Token(Token = "0x6001DCC")]
    [Address(RVA = "0x449060", Offset = "0x447C60", Length = "0x10D")]
    private void StartStorm()
    {
    }

    [Token(Token = "0x6001DCD")]
    [Address(RVA = "0x449170", Offset = "0x447D70", Length = "0xDC")]
    private void StopStorm()
    {
    }

    [Token(Token = "0x6001DCE")]
    [Address(RVA = "0x449600", Offset = "0x448200", Length = "0x90")]
    public MapEventsDesert()
    {
    }
  }
}
