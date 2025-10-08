// Decompiled with JetBrains decompiler
// Type: Water
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x2000083")]
public class Water : MonoBehaviour
{
  [Token(Token = "0x4000407")]
  [FieldOffset(Offset = "0x20")]
  public MeshRenderer waterUpper;
  [Token(Token = "0x4000408")]
  [FieldOffset(Offset = "0x28")]
  public MeshRenderer waterUnder;
  [Token(Token = "0x4000409")]
  [FieldOffset(Offset = "0x30")]
  private bool isCameraUnder;
  [Token(Token = "0x400040A")]
  [FieldOffset(Offset = "0x31")]
  private bool isPlayerUnder;
  [Token(Token = "0x400040B")]
  [FieldOffset(Offset = "0x32")]
  private bool isDamageZone;
  [Token(Token = "0x400040C")]
  [FieldOffset(Offset = "0x38")]
  private MapData mapData;
  [Token(Token = "0x400040D")]
  [FieldOffset(Offset = "0x40")]
  private StageData stageData;
  [Token(Token = "0x400040F")]
  public static Action<Water> A_CameraEnterWater;
  [Token(Token = "0x4000410")]
  public static Action<Water> A_CameraExitWater;
  [Token(Token = "0x4000411")]
  public static Action<Water> A_PlayerEnterWater;
  [Token(Token = "0x4000412")]
  public static Action<Water> A_PlayerExitWater;
  [Token(Token = "0x4000413")]
  [FieldOffset(Offset = "0x58")]
  private GameObject splashFx;
  [Token(Token = "0x4000414")]
  [FieldOffset(Offset = "0x60")]
  public GameObject lavaSplashFx;
  [Token(Token = "0x4000415")]
  [FieldOffset(Offset = "0x68")]
  public Material lavaMaterial;
  [Token(Token = "0x4000416")]
  [FieldOffset(Offset = "0x70")]
  private float nextDamageTime;
  [Token(Token = "0x4000417")]
  [FieldOffset(Offset = "0x74")]
  private float damageInterval;
  [Token(Token = "0x4000418")]
  [FieldOffset(Offset = "0x78")]
  private float damage;
  [Token(Token = "0x4000419")]
  [FieldOffset(Offset = "0x7C")]
  private float threshold;
  [Token(Token = "0x400041A")]
  [FieldOffset(Offset = "0x80")]
  private float nextSplashTime;
  [Token(Token = "0x400041B")]
  [FieldOffset(Offset = "0x84")]
  private float splashInterval;

  [field: Token(Token = "0x400040E")]
  [field: FieldOffset(Offset = "0x48")]
  [Token(Token = "0x1700001A")]
  public Color color { [Token(Token = "0x6000333"), Address(RVA = "0x474940", Offset = "0x473540", Length = "0xB")] get; [Token(Token = "0x6000334"), Address(RVA = "0x474950", Offset = "0x473550", Length = "0x8")] private set; }

  [Token(Token = "0x6000335")]
  [Address(RVA = "0x473FE0", Offset = "0x472BE0", Length = "0x120")]
  public void Set(MapData mapData, StageData stageData)
  {
  }

  [Token(Token = "0x6000336")]
  [Address(RVA = "0x473F40", Offset = "0x472B40", Length = "0x93")]
  public void SetFloorIsLava()
  {
  }

  [Token(Token = "0x6000337")]
  [Address(RVA = "0x473D80", Offset = "0x472980", Length = "0x1BE")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000338")]
  [Address(RVA = "0x474110", Offset = "0x472D10", Length = "0x7F7")]
  private void Update()
  {
  }

  [Token(Token = "0x6000339")]
  [Address(RVA = "0x474910", Offset = "0x473510", Length = "0x26")]
  public Water()
  {
  }
}
