// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.UI.DynamicWindows.DWindowBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.DynamicWindows
{
  [Token(Token = "0x2000303")]
  public class DWindowBase : MonoBehaviour
  {
    [Token(Token = "0x4001478")]
    [FieldOffset(Offset = "0x20")]
    private int rebuildAfterFrames;

    [Token(Token = "0x60015B4")]
    [Address(RVA = "0x3A74C0", Offset = "0x3A60C0", Length = "0x8")]
    protected void QueueRebuild()
    {
    }

    [Token(Token = "0x60015B5")]
    [Address(RVA = "0x3A72D0", Offset = "0x3A5ED0", Length = "0x1E4")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x60015B6")]
    [Address(RVA = "0x3A74D0", Offset = "0x3A60D0", Length = "0xE")]
    public DWindowBase()
    {
    }
  }
}
