// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroFireBeam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace RetroArsenal
{
  [Token(Token = "0x200045C")]
  public class RetroFireBeam : MonoBehaviour
  {
    [Header("Prefabs")]
    [Token(Token = "0x4001CA3")]
    [FieldOffset(Offset = "0x20")]
    public GameObject[] beamLineRendererPrefab;
    [Token(Token = "0x4001CA4")]
    [FieldOffset(Offset = "0x28")]
    public GameObject[] beamStartPrefab;
    [Token(Token = "0x4001CA5")]
    [FieldOffset(Offset = "0x30")]
    public GameObject[] beamEndPrefab;
    [Token(Token = "0x4001CA6")]
    [FieldOffset(Offset = "0x38")]
    private BeamType currentBeam;
    [Token(Token = "0x4001CA7")]
    [FieldOffset(Offset = "0x40")]
    private GameObject beamStart;
    [Token(Token = "0x4001CA8")]
    [FieldOffset(Offset = "0x48")]
    private GameObject beamEnd;
    [Token(Token = "0x4001CA9")]
    [FieldOffset(Offset = "0x50")]
    private GameObject beam;
    [Token(Token = "0x4001CAA")]
    [FieldOffset(Offset = "0x58")]
    private LineRenderer line;
    [Token(Token = "0x4001CAB")]
    [FieldOffset(Offset = "0x60")]
    private Transform beamTransform;
    [Token(Token = "0x4001CAC")]
    [FieldOffset(Offset = "0x68")]
    private float textureScrollOffset;
    [Header("Adjustable Variables")]
    [Token(Token = "0x4001CAD")]
    [FieldOffset(Offset = "0x6C")]
    public float beamEndOffset;
    [Token(Token = "0x4001CAE")]
    [FieldOffset(Offset = "0x70")]
    public float textureScrollSpeed;
    [Token(Token = "0x4001CAF")]
    [FieldOffset(Offset = "0x74")]
    public float textureLengthScale;
    [Header("Put Sliders here (Optional)")]
    [Token(Token = "0x4001CB0")]
    [FieldOffset(Offset = "0x78")]
    public Slider endOffsetSlider;
    [Token(Token = "0x4001CB1")]
    [FieldOffset(Offset = "0x80")]
    public Slider scrollSpeedSlider;
    [Header("UI Text object to show beam name")]
    [Token(Token = "0x4001CB2")]
    [FieldOffset(Offset = "0x88")]
    public Text textBeamName;
    [Token(Token = "0x4001CB3")]
    [FieldOffset(Offset = "0x90")]
    private bool isFiringBeam;

    [Token(Token = "0x6001F7B")]
    [Address(RVA = "0x450FC0", Offset = "0x44FBC0", Length = "0x186")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F7C")]
    [Address(RVA = "0x450810", Offset = "0x44F410", Length = "0x2DA")]
    private void CreateBeamObjects()
    {
    }

    [Token(Token = "0x6001F7D")]
    [Address(RVA = "0x451250", Offset = "0x44FE50", Length = "0x338")]
    private void Update()
    {
    }

    [Token(Token = "0x6001F7E")]
    [Address(RVA = "0x451150", Offset = "0x44FD50", Length = "0xF9")]
    private void UpdateBeam()
    {
    }

    [Token(Token = "0x6001F7F")]
    [Address(RVA = "0x450AF0", Offset = "0x44F6F0", Length = "0x4CC")]
    private void ShootBeamInDir(Vector3 start, Vector3 dir)
    {
    }

    [Token(Token = "0x6001F80")]
    [Address(RVA = "0x451590", Offset = "0x450190", Length = "0x1C")]
    public RetroFireBeam()
    {
    }
  }
}
