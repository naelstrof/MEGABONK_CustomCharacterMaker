// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Camera.CameraShakerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Inventory__Items__Pickups;
using Cpp2ILInjected;
using MilkShake;
using UnityEngine;

namespace Assets.Scripts.Camera
{
  [Token(Token = "0x2000444")]
  public class CameraShakerController : MonoBehaviour
  {
    [Token(Token = "0x4001B9A")]
    [FieldOffset(Offset = "0x20")]
    public Shaker shaker;
    [Token(Token = "0x4001B9B")]
    [FieldOffset(Offset = "0x28")]
    public ShakePreset damageShake;
    [Token(Token = "0x4001B9C")]
    [FieldOffset(Offset = "0x30")]
    public ShakePreset objectImpactShake;
    [Token(Token = "0x4001B9D")]
    [FieldOffset(Offset = "0x38")]
    public ShakePreset grindShake;
    [Token(Token = "0x4001B9E")]
    [FieldOffset(Offset = "0x40")]
    public ShakePreset pylonSpawnShake;
    [Token(Token = "0x4001B9F")]
    [FieldOffset(Offset = "0x48")]
    private float damageShakeCooldown;
    [Token(Token = "0x4001BA0")]
    [FieldOffset(Offset = "0x4C")]
    private float damageNextShakeReadyTime;
    [Token(Token = "0x4001BA1")]
    [FieldOffset(Offset = "0x50")]
    private ShakeInstance grindShakeInstance;

    [Token(Token = "0x6001E82")]
    [Address(RVA = "0x43B0B0", Offset = "0x439CB0", Length = "0x559")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001E83")]
    [Address(RVA = "0x43B760", Offset = "0x43A360", Length = "0x559")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6001E84")]
    [Address(RVA = "0x43BE50", Offset = "0x43AA50", Length = "0x124")]
    private void Start()
    {
    }

    [Token(Token = "0x6001E85")]
    [Address(RVA = "0x43BDA0", Offset = "0x43A9A0", Length = "0xA3")]
    private void OnSettingUpdated(string setting, object oldValue, object newValue)
    {
    }

    [Token(Token = "0x6001E86")]
    [Address(RVA = "0x43B610", Offset = "0x43A210", Length = "0x141")]
    private void OnDamage(PlayerHealth ph, DamageContainer dc, bool shieldDamage)
    {
    }

    [Token(Token = "0x6001E87")]
    [Address(RVA = "0x43BD30", Offset = "0x43A930", Length = "0x3A")]
    private void OnObjectImpact(float shakeMultiplier)
    {
    }

    [Token(Token = "0x6001E88")]
    [Address(RVA = "0x43BCC0", Offset = "0x43A8C0", Length = "0x68")]
    private void OnGrindToggle(bool isGrinding)
    {
    }

    [Token(Token = "0x6001E89")]
    [Address(RVA = "0x43BD70", Offset = "0x43A970", Length = "0x28")]
    private void OnPylonsStarted()
    {
    }

    [Token(Token = "0x6001E8A")]
    [Address(RVA = "0x43BF80", Offset = "0x43AB80", Length = "0xE")]
    public CameraShakerController()
    {
    }
  }
}
