// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroPitchRandomizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x200046A")]
  public class RetroPitchRandomizer : MonoBehaviour
  {
    [Token(Token = "0x4001D1C")]
    [FieldOffset(Offset = "0x20")]
    public float randomPercent;

    [Token(Token = "0x6001FC9")]
    [Address(RVA = "0x458320", Offset = "0x456F20", Length = "0xB7")]
    private void Start()
    {
    }

    [Token(Token = "0x6001FCA")]
    [Address(RVA = "0x4583E0", Offset = "0x456FE0", Length = "0xE")]
    public RetroPitchRandomizer()
    {
    }
  }
}
