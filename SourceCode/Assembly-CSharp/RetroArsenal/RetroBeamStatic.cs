// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroBeamStatic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000469")]
  public class RetroBeamStatic : MonoBehaviour
  {
    [Header("Prefabs")]
    [Token(Token = "0x4001D0A")]
    [FieldOffset(Offset = "0x20")]
    public GameObject beamLineRendererPrefab;
    [Token(Token = "0x4001D0B")]
    [FieldOffset(Offset = "0x28")]
    public GameObject beamStartPrefab;
    [Token(Token = "0x4001D0C")]
    [FieldOffset(Offset = "0x30")]
    public GameObject beamEndPrefab;
    [Token(Token = "0x4001D0D")]
    [FieldOffset(Offset = "0x38")]
    private GameObject beamStart;
    [Token(Token = "0x4001D0E")]
    [FieldOffset(Offset = "0x40")]
    private GameObject beamEnd;
    [Token(Token = "0x4001D0F")]
    [FieldOffset(Offset = "0x48")]
    private GameObject beam;
    [Token(Token = "0x4001D10")]
    [FieldOffset(Offset = "0x50")]
    private LineRenderer line;
    [Header("Beam Options")]
    [Token(Token = "0x4001D11")]
    [FieldOffset(Offset = "0x58")]
    public bool beamCollides;
    [Token(Token = "0x4001D12")]
    [FieldOffset(Offset = "0x5C")]
    public float beamLength;
    [Token(Token = "0x4001D13")]
    [FieldOffset(Offset = "0x60")]
    public float beamEndOffset;
    [Token(Token = "0x4001D14")]
    [FieldOffset(Offset = "0x64")]
    public float textureScrollSpeed;
    [Token(Token = "0x4001D15")]
    [FieldOffset(Offset = "0x68")]
    public float textureLengthScale;
    [Header("Width Pulse Options")]
    [Token(Token = "0x4001D16")]
    [FieldOffset(Offset = "0x6C")]
    public float widthMultiplier;
    [Token(Token = "0x4001D17")]
    [FieldOffset(Offset = "0x70")]
    private float customWidth;
    [Token(Token = "0x4001D18")]
    [FieldOffset(Offset = "0x74")]
    private float originalWidth;
    [Token(Token = "0x4001D19")]
    [FieldOffset(Offset = "0x78")]
    private float lerpValue;
    [Token(Token = "0x4001D1A")]
    [FieldOffset(Offset = "0x7C")]
    public float pulseSpeed;
    [Token(Token = "0x4001D1B")]
    [FieldOffset(Offset = "0x80")]
    private bool pulseExpanding;

    [Token(Token = "0x6001FC5")]
    [Address(RVA = "0x456620", Offset = "0x455220", Length = "0x3A")]
    private void Start()
    {
    }

    [Token(Token = "0x6001FC6")]
    [Address(RVA = "0x455A20", Offset = "0x454620", Length = "0x87A")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x6001FC7")]
    [Address(RVA = "0x4562A0", Offset = "0x454EA0", Length = "0x375")]
    public void SpawnBeam()
    {
    }

    [Token(Token = "0x6001FC8")]
    [Address(RVA = "0x456660", Offset = "0x455260", Length = "0x2E")]
    public RetroBeamStatic()
    {
    }
  }
}
