// Decompiled with JetBrains decompiler
// Type: CrosshairUi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000146")]
public class CrosshairUi : MonoBehaviour
{
  [Token(Token = "0x4000982")]
  [FieldOffset(Offset = "0x20")]
  public Image crosshairOuter;
  [Token(Token = "0x4000983")]
  [FieldOffset(Offset = "0x28")]
  public RawImage crosshairInner;
  [Token(Token = "0x4000984")]
  [FieldOffset(Offset = "0x30")]
  public RectTransform parentCrosshair;
  [Token(Token = "0x4000985")]
  [FieldOffset(Offset = "0x38")]
  public CanvasGroup group;
  [Token(Token = "0x4000986")]
  [FieldOffset(Offset = "0x40")]
  public Color hoveringEnemyColor;
  [Token(Token = "0x4000987")]
  [FieldOffset(Offset = "0x50")]
  public Color hoveringMarkedEnemyColor;
  [Token(Token = "0x4000988")]
  [FieldOffset(Offset = "0x60")]
  public float movingSize;
  [Token(Token = "0x4000989")]
  [FieldOffset(Offset = "0x64")]
  public float airborneSize;
  [Token(Token = "0x400098A")]
  [FieldOffset(Offset = "0x68")]
  private float globalSizeMultiplier;
  [Token(Token = "0x400098B")]
  [FieldOffset(Offset = "0x6C")]
  private float defaultSize;
  [Token(Token = "0x400098C")]
  [FieldOffset(Offset = "0x70")]
  private float desiredSize;
  [Token(Token = "0x400098D")]
  [FieldOffset(Offset = "0x74")]
  private bool hoveringEnemy;
  [Token(Token = "0x400098E")]
  [FieldOffset(Offset = "0x75")]
  private bool isVisible;
  [Token(Token = "0x400098F")]
  private static float yMin;
  [Token(Token = "0x4000990")]
  private static float yMax;

  [Token(Token = "0x6000830")]
  [Address(RVA = "0x4CF020", Offset = "0x4CDC20", Length = "0x32F")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000831")]
  [Address(RVA = "0x4CFAF0", Offset = "0x4CE6F0", Length = "0x32F")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000832")]
  [Address(RVA = "0x4D00E0", Offset = "0x4CECE0", Length = "0xE1")]
  private void Start()
  {
  }

  [Token(Token = "0x6000833")]
  [Address(RVA = "0x4CF350", Offset = "0x4CDF50", Length = "0x173")]
  private void CheckVisible()
  {
  }

  [Token(Token = "0x6000834")]
  [Address(RVA = "0x4D01D0", Offset = "0x4CEDD0", Length = "0x289")]
  private void Update()
  {
  }

  [Token(Token = "0x6000835")]
  [Address(RVA = "0x4CF5B0", Offset = "0x4CE1B0", Length = "0x33C")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000836")]
  [Address(RVA = "0x4CF4D0", Offset = "0x4CE0D0", Length = "0xDE")]
  private void FindDesiredSize()
  {
  }

  [Token(Token = "0x6000837")]
  [Address(RVA = "0x4CF8F0", Offset = "0x4CE4F0", Length = "0x197")]
  public static Vector3 GetCrosshairRaycastPosition() => new Vector3();

  [Token(Token = "0x6000838")]
  [Address(RVA = "0x4CFA90", Offset = "0x4CE690", Length = "0x5D")]
  public static Vector3 GetCrosshairUiPosition() => new Vector3();

  [Token(Token = "0x6000839")]
  [Address(RVA = "0x4CFE20", Offset = "0x4CEA20", Length = "0x8D")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x600083A")]
  [Address(RVA = "0x4CFEB0", Offset = "0x4CEAB0", Length = "0xD")]
  private void OnWeaponAdded(WeaponBase weapon)
  {
  }

  [Token(Token = "0x600083B")]
  [Address(RVA = "0x4CFEB0", Offset = "0x4CEAB0", Length = "0xD")]
  private void OnWeaponRemoved(WeaponBase weapon)
  {
  }

  [Token(Token = "0x600083C")]
  [Address(RVA = "0x4CFF80", Offset = "0x4CEB80", Length = "0x150")]
  private void RefreshSize()
  {
  }

  [Token(Token = "0x600083D")]
  [Address(RVA = "0x4CFEC0", Offset = "0x4CEAC0", Length = "0xB7")]
  private void RefreshAlpha()
  {
  }

  [Token(Token = "0x600083E")]
  [Address(RVA = "0x4D04B0", Offset = "0x4CF0B0", Length = "0x23")]
  public CrosshairUi()
  {
  }

  [Token(Token = "0x600083F")]
  [Address(RVA = "0x4D0460", Offset = "0x4CF060", Length = "0x4E")]
  static CrosshairUi()
  {
  }
}
