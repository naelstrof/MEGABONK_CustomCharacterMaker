// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives.ActiveAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;

namespace Assets.Scripts.Inventory__Items__Pickups.AbilitiesActives
{
  [Token(Token = "0x2000409")]
  public abstract class ActiveAbility
  {
    [Token(Token = "0x4001A83")]
    [FieldOffset(Offset = "0x10")]
    protected float readyAtTime;

    [Token(Token = "0x6001D1D")]
    [Address(RVA = "0x41BF90", Offset = "0x41AB90", Length = "0xD2")]
    public void Use()
    {
    }

    [Token(Token = "0x6001D1E")]
    public abstract void Tick();

    [Token(Token = "0x6001D1F")]
    [Address(RVA = "0x41BF30", Offset = "0x41AB30", Length = "0x5D")]
    private bool IsReady() => false;

    [Token(Token = "0x6001D20")]
    public abstract void Init();

    [Token(Token = "0x6001D21")]
    public abstract void Cleanup();

    [Token(Token = "0x6001D22")]
    public abstract void UseImplementation();

    [Token(Token = "0x6001D23")]
    public abstract float GetCooldown();

    [Token(Token = "0x6001D24")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    protected ActiveAbility()
    {
    }
  }
}
