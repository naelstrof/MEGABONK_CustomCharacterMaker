// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroLoopScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x200045F")]
  public class RetroLoopScript : MonoBehaviour
  {
    [Token(Token = "0x4001CC6")]
    [FieldOffset(Offset = "0x20")]
    public GameObject chosenEffect;
    [Token(Token = "0x4001CC7")]
    [FieldOffset(Offset = "0x28")]
    public float loopTimeLimit;
    [Header("Spawn options")]
    [Token(Token = "0x4001CC8")]
    [FieldOffset(Offset = "0x2C")]
    public bool disableLights;
    [Token(Token = "0x4001CC9")]
    [FieldOffset(Offset = "0x2D")]
    public bool disableSound;
    [Token(Token = "0x4001CCA")]
    [FieldOffset(Offset = "0x30")]
    public float spawnScale;

    [Token(Token = "0x6001F92")]
    [Address(RVA = "0x457B30", Offset = "0x456730", Length = "0x3C")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F93")]
    [Address(RVA = "0x457B30", Offset = "0x456730", Length = "0x3C")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x6001F94")]
    [Address(RVA = "0x457AC0", Offset = "0x4566C0", Length = "0x67")]
    private IEnumerator EffectLoop() => (IEnumerator) null;

    [Token(Token = "0x6001F95")]
    [Address(RVA = "0x457B70", Offset = "0x456770", Length = "0x1B")]
    public RetroLoopScript()
    {
    }
  }
}
