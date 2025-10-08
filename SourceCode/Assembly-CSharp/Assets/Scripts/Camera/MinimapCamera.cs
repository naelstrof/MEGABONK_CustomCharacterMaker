// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Camera.MinimapCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Camera
{
  [Token(Token = "0x2000446")]
  public class MinimapCamera : MonoBehaviour
  {
    [Token(Token = "0x4001BA4")]
    [FieldOffset(Offset = "0x20")]
    public Transform playerIcon;
    [Token(Token = "0x4001BA5")]
    [FieldOffset(Offset = "0x28")]
    public Transform arrowPrefab;
    [Token(Token = "0x4001BA6")]
    [FieldOffset(Offset = "0x30")]
    public bool staticOrientation;
    [Token(Token = "0x4001BA7")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 staticRotation;
    [Token(Token = "0x4001BA8")]
    [FieldOffset(Offset = "0x40")]
    public UnityEngine.Camera minimapCamera;
    [Token(Token = "0x4001BA9")]
    [FieldOffset(Offset = "0x48")]
    private bool bossSpotted;
    [Token(Token = "0x4001BAA")]
    [FieldOffset(Offset = "0x50")]
    private Transform bossSpawner;
    [Token(Token = "0x4001BAB")]
    public static Action<float> A_RotationUpdated;
    [Token(Token = "0x4001BAC")]
    [FieldOffset(Offset = "0x58")]
    private Quaternion lastRotation;
    [Token(Token = "0x4001BAD")]
    [FieldOffset(Offset = "0x68")]
    private Color bossColor;
    [Token(Token = "0x4001BAE")]
    [FieldOffset(Offset = "0x78")]
    private Color portalColor;
    [Token(Token = "0x4001BAF")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<Transform, MinimapArrow> arrowDict;

    [Token(Token = "0x6001E8D")]
    [Address(RVA = "0x44A1C0", Offset = "0x448DC0", Length = "0x551")]
    private void Start()
    {
    }

    [Token(Token = "0x6001E8E")]
    [Address(RVA = "0x449BC0", Offset = "0x4487C0", Length = "0x41C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001E8F")]
    [Address(RVA = "0x44A070", Offset = "0x448C70", Length = "0x42")]
    private void OnEnemySpawn(Enemy enemy)
    {
    }

    [Token(Token = "0x6001E90")]
    [Address(RVA = "0x449FE0", Offset = "0x448BE0", Length = "0x8F")]
    private void OnEnemyDied(Enemy enemy)
    {
    }

    [Token(Token = "0x6001E91")]
    [Address(RVA = "0x44A800", Offset = "0x449400", Length = "0x108")]
    private void TryFindBossSpawner()
    {
    }

    [Token(Token = "0x6001E92")]
    [Address(RVA = "0x44B350", Offset = "0x449F50", Length = "0x5BF")]
    private void Update()
    {
    }

    [Token(Token = "0x6001E93")]
    [Address(RVA = "0x44A720", Offset = "0x449320", Length = "0xDB")]
    private void StaticOrientation()
    {
    }

    [Token(Token = "0x6001E94")]
    [Address(RVA = "0x449940", Offset = "0x448540", Length = "0x1EE")]
    private void DynamicOrientation()
    {
    }

    [Token(Token = "0x6001E95")]
    [Address(RVA = "0x44AB80", Offset = "0x449780", Length = "0x7C9")]
    private void UpdateArrows()
    {
    }

    [Token(Token = "0x6001E96")]
    [Address(RVA = "0x44A910", Offset = "0x449510", Length = "0x268")]
    private void TrySpotBossSpawner()
    {
    }

    [Token(Token = "0x6001E97")]
    [Address(RVA = "0x449770", Offset = "0x448370", Length = "0x1CA")]
    private void AddArrow(Transform target, Color color)
    {
    }

    [Token(Token = "0x6001E98")]
    [Address(RVA = "0x44A0C0", Offset = "0x448CC0", Length = "0xF4")]
    private void RemoveArrow(Transform transform)
    {
    }

    [Token(Token = "0x6001E99")]
    [Address(RVA = "0x449B80", Offset = "0x448780", Length = "0x31")]
    private void OnBossSpawnerInteract()
    {
    }

    [Token(Token = "0x6001E9A")]
    [Address(RVA = "0x449B30", Offset = "0x448730", Length = "0x43")]
    private void OnBossSpawnerCompleted(bool openedPortal)
    {
    }

    [Token(Token = "0x6001E9B")]
    [Address(RVA = "0x44B910", Offset = "0x44A510", Length = "0x108")]
    public MinimapCamera()
    {
    }
  }
}
