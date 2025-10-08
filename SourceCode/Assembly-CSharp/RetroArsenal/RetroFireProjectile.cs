// Decompiled with JetBrains decompiler
// Type: RetroArsenal.RetroFireProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace RetroArsenal
{
  [Token(Token = "0x200045D")]
  public class RetroFireProjectile : MonoBehaviour
  {
    [Token(Token = "0x4001CB4")]
    [FieldOffset(Offset = "0x20")]
    public GameObject[] projectiles;
    [Header("GUI Links")]
    [Token(Token = "0x4001CB5")]
    [FieldOffset(Offset = "0x28")]
    public Text missileNameText;
    [Token(Token = "0x4001CB6")]
    [FieldOffset(Offset = "0x30")]
    public Toggle fullAutoButton;
    [Token(Token = "0x4001CB7")]
    [FieldOffset(Offset = "0x38")]
    public Slider speedSlider;
    [Token(Token = "0x4001CB8")]
    [FieldOffset(Offset = "0x40")]
    public bool cleanUpMissileName;
    [Header("Projectile Settings")]
    [Token(Token = "0x4001CB9")]
    [FieldOffset(Offset = "0x48")]
    public Transform spawnPosition;
    [HideInInspector]
    [Token(Token = "0x4001CBA")]
    [FieldOffset(Offset = "0x50")]
    public int currentProjectile;
    [Token(Token = "0x4001CBB")]
    [FieldOffset(Offset = "0x54")]
    public float speed;
    [Token(Token = "0x4001CBC")]
    [FieldOffset(Offset = "0x58")]
    public float spawnOffset;
    [Header("Firing Settings")]
    [Token(Token = "0x4001CBD")]
    [FieldOffset(Offset = "0x5C")]
    public float fireRate;
    [Token(Token = "0x4001CBE")]
    [FieldOffset(Offset = "0x60")]
    public bool isFullAuto;
    [Header("Gun Settings")]
    [Token(Token = "0x4001CBF")]
    [FieldOffset(Offset = "0x68")]
    public GameObject gunPrefab;
    [Token(Token = "0x4001CC0")]
    [FieldOffset(Offset = "0x70")]
    public float gunOffset;
    [Token(Token = "0x4001CC1")]
    [FieldOffset(Offset = "0x74")]
    private bool canShoot;
    [Token(Token = "0x4001CC2")]
    [FieldOffset(Offset = "0x78")]
    private GameObject instantiatedGun;

    [Token(Token = "0x6001F81")]
    [Address(RVA = "0x456D50", Offset = "0x455950", Length = "0x326")]
    private void Start()
    {
    }

    [Token(Token = "0x6001F82")]
    [Address(RVA = "0x457700", Offset = "0x456300", Length = "0x308")]
    private void Update()
    {
    }

    [Token(Token = "0x6001F83")]
    [Address(RVA = "0x456CE0", Offset = "0x4558E0", Length = "0x67")]
    private IEnumerator Shoot() => (IEnumerator) null;

    [Token(Token = "0x6001F84")]
    [Address(RVA = "0x456890", Offset = "0x455490", Length = "0x441")]
    private void ShootProjectile()
    {
    }

    [Token(Token = "0x6001F85")]
    [Address(RVA = "0x457250", Offset = "0x455E50", Length = "0x4A5")]
    private void UpdateGunPositionAndRotation()
    {
    }

    [Token(Token = "0x6001F86")]
    [Address(RVA = "0x457A40", Offset = "0x456640", Length = "0x3C")]
    public void nextEffect()
    {
    }

    [Token(Token = "0x6001F87")]
    [Address(RVA = "0x457A80", Offset = "0x456680", Length = "0x39")]
    public void previousEffect()
    {
    }

    [Token(Token = "0x6001F88")]
    [Address(RVA = "0x457080", Offset = "0x455C80", Length = "0x1C5")]
    private void UpdateDisplayName()
    {
    }

    [Token(Token = "0x6001F89")]
    [Address(RVA = "0x456690", Offset = "0x455290", Length = "0x1E7")]
    private string CleanUpMissileName(string name) => (string) null;

    [Token(Token = "0x6001F8A")]
    [Address(RVA = "0x456880", Offset = "0x455480", Length = "0x6")]
    private void OnSpeedSliderChanged(float value)
    {
    }

    [Token(Token = "0x6001F8B")]
    [Address(RVA = "0x457A10", Offset = "0x456610", Length = "0x2B")]
    public RetroFireProjectile()
    {
    }
  }
}
