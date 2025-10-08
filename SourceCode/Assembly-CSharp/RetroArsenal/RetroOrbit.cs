// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroOrbit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000461")]
  public class RetroOrbit : MonoBehaviour
  {
    [Token(Token = "0x4001CCF")]
    [FieldOffset(Offset = "0x20")]
    public Transform target;
    [Token(Token = "0x4001CD0")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 cameraOffset;
    [Token(Token = "0x4001CD1")]
    [FieldOffset(Offset = "0x34")]
    public float defaultDistance;
    [Token(Token = "0x4001CD2")]
    [FieldOffset(Offset = "0x38")]
    private float _currentDistance;
    [Token(Token = "0x4001CD3")]
    [FieldOffset(Offset = "0x3C")]
    public float xSpeed;
    [Token(Token = "0x4001CD4")]
    [FieldOffset(Offset = "0x40")]
    public float ySpeed;
    [Token(Token = "0x4001CD5")]
    [FieldOffset(Offset = "0x44")]
    public float yMinLimit;
    [Token(Token = "0x4001CD6")]
    [FieldOffset(Offset = "0x48")]
    public float yMaxLimit;
    [Token(Token = "0x4001CD7")]
    [FieldOffset(Offset = "0x4C")]
    public float distanceMin;
    [Token(Token = "0x4001CD8")]
    [FieldOffset(Offset = "0x50")]
    public float distanceMax;
    [Token(Token = "0x4001CD9")]
    [FieldOffset(Offset = "0x54")]
    public float zoomLerpSpeed;
    [Token(Token = "0x4001CDA")]
    [FieldOffset(Offset = "0x58")]
    public float smoothingFactor;
    [Token(Token = "0x4001CDB")]
    [FieldOffset(Offset = "0x5C")]
    public float collisionOffset;
    [Token(Token = "0x4001CDC")]
    [FieldOffset(Offset = "0x60")]
    private float rotationYAxis;
    [Token(Token = "0x4001CDD")]
    [FieldOffset(Offset = "0x64")]
    private float rotationXAxis;
    [Token(Token = "0x4001CDE")]
    [FieldOffset(Offset = "0x68")]
    private float velocityX;
    [Token(Token = "0x4001CDF")]
    [FieldOffset(Offset = "0x6C")]
    private float velocityY;
    [Token(Token = "0x4001CE0")]
    [FieldOffset(Offset = "0x70")]
    private Vector3 originalTargetPosition;

    [Token(Token = "0x6001F9C")]
    [Address(RVA = "0x458190", Offset = "0x456D90", Length = "0x10C")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F9D")]
    [Address(RVA = "0x457B90", Offset = "0x456790", Length = "0x5F8")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6001F9E")]
    [Address(RVA = "0x4582A0", Offset = "0x456EA0", Length = "0x74")]
    public RetroOrbit()
    {
    }
  }
}
