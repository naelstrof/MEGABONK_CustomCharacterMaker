// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Camera.MinimapArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Camera
{
  [Token(Token = "0x2000445")]
  public class MinimapArrow : MonoBehaviour
  {
    [Token(Token = "0x4001BA2")]
    [FieldOffset(Offset = "0x20")]
    public Transform target;
    [Token(Token = "0x4001BA3")]
    [FieldOffset(Offset = "0x28")]
    public MeshRenderer arrowRenderer;

    [Token(Token = "0x6001E8B")]
    [Address(RVA = "0x4496A0", Offset = "0x4482A0", Length = "0xC9")]
    public void Set(Transform target, Color color)
    {
    }

    [Token(Token = "0x6001E8C")]
    [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
    public MinimapArrow()
    {
    }
  }
}
