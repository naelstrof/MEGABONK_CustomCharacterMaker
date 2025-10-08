// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

namespace RetroArsenal
{
  [Token(Token = "0x2000466")]
  public class RetroTarget : MonoBehaviour
  {
    [Token(Token = "0x4001CF5")]
    [FieldOffset(Offset = "0x20")]
    public TargetEffects effects;
    [Header("General Settings")]
    [Token(Token = "0x4001CF6")]
    [FieldOffset(Offset = "0x28")]
    public int hitsToDestroy;
    [Token(Token = "0x4001CF7")]
    [FieldOffset(Offset = "0x2C")]
    public float respawnTime;
    [Header("Squash & Stretch")]
    [Token(Token = "0x4001CF8")]
    [FieldOffset(Offset = "0x30")]
    public bool enableSquashAndStretch;
    [Token(Token = "0x4001CF9")]
    [FieldOffset(Offset = "0x34")]
    public float duration;
    [Token(Token = "0x4001CFA")]
    [FieldOffset(Offset = "0x38")]
    public Vector3 squashScale;
    [Token(Token = "0x4001CFB")]
    [FieldOffset(Offset = "0x44")]
    public Vector3 stretchScale;
    [Token(Token = "0x4001CFC")]
    [FieldOffset(Offset = "0x50")]
    private Renderer targetRenderer;
    [Token(Token = "0x4001CFD")]
    [FieldOffset(Offset = "0x58")]
    private Collider targetCollider;
    [Token(Token = "0x4001CFE")]
    [FieldOffset(Offset = "0x60")]
    private AudioSource audioSource;
    [Token(Token = "0x4001CFF")]
    [FieldOffset(Offset = "0x68")]
    private int currentHits;
    [Token(Token = "0x4001D00")]
    [FieldOffset(Offset = "0x6C")]
    private Vector3 originalScale;

    [Token(Token = "0x6001FB2")]
    [Address(RVA = "0x45A1D0", Offset = "0x458DD0", Length = "0xD3")]
    private void Start()
    {
    }

    [Token(Token = "0x6001FB3")]
    [Address(RVA = "0x459F60", Offset = "0x458B60", Length = "0x1FC")]
    private void SpawnTarget()
    {
    }

    [Token(Token = "0x6001FB4")]
    [Address(RVA = "0x459EF0", Offset = "0x458AF0", Length = "0x67")]
    private IEnumerator Respawn() => (IEnumerator) null;

    [Token(Token = "0x6001FB5")]
    [Address(RVA = "0x459D20", Offset = "0x458920", Length = "0x1CE")]
    public void OnHit()
    {
    }

    [Token(Token = "0x6001FB6")]
    [Address(RVA = "0x45A160", Offset = "0x458D60", Length = "0x67")]
    private IEnumerator SquashAndStretch() => (IEnumerator) null;

    [Token(Token = "0x6001FB7")]
    [Address(RVA = "0x459A70", Offset = "0x458670", Length = "0x2A8")]
    private void DestroyTarget()
    {
    }

    [Token(Token = "0x6001FB8")]
    [Address(RVA = "0x45A2B0", Offset = "0x458EB0", Length = "0x58")]
    public RetroTarget()
    {
    }
  }
}
