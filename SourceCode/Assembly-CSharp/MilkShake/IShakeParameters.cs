// Decompiled with JetBrains decompiler
// Type: MilkShake.IShakeParameters
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace MilkShake
{
  [Token(Token = "0x20002B8")]
  public interface IShakeParameters
  {
    [Token(Token = "0x17000360")]
    ShakeType ShakeType { [Token(Token = "0x6001457")] get; [Token(Token = "0x6001458")] set; }

    [Token(Token = "0x17000361")]
    float Strength { [Token(Token = "0x6001459")] get; [Token(Token = "0x600145A")] set; }

    [Token(Token = "0x17000362")]
    float Roughness { [Token(Token = "0x600145B")] get; [Token(Token = "0x600145C")] set; }

    [Token(Token = "0x17000363")]
    float FadeIn { [Token(Token = "0x600145D")] get; [Token(Token = "0x600145E")] set; }

    [Token(Token = "0x17000364")]
    float FadeOut { [Token(Token = "0x600145F")] get; [Token(Token = "0x6001460")] set; }

    [Token(Token = "0x17000365")]
    Vector3 PositionInfluence { [Token(Token = "0x6001461")] get; [Token(Token = "0x6001462")] set; }

    [Token(Token = "0x17000366")]
    Vector3 RotationInfluence { [Token(Token = "0x6001463")] get; [Token(Token = "0x6001464")] set; }
  }
}
