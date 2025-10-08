// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Game.MapGeneration.MapEvents.MapEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Game.MapGeneration.MapEvents
{
  [Token(Token = "0x2000422")]
  public abstract class MapEvents
  {
    [Token(Token = "0x6001DC1")]
    public abstract void Tick();

    [Token(Token = "0x6001DC2")]
    public abstract void Init();

    [Token(Token = "0x6001DC3")]
    public abstract void Cleanup();

    [Token(Token = "0x6001DC4")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    protected MapEvents()
    {
    }
  }
}
