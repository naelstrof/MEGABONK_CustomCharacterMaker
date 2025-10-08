// Decompiled with JetBrains decompiler
// Type: AudioManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000024")]
public class AudioManager : MonoBehaviour
{
  [Token(Token = "0x4000133")]
  [FieldOffset(Offset = "0x20")]
  public AudioSource xp;
  [Token(Token = "0x4000134")]
  [FieldOffset(Offset = "0x28")]
  public AudioSource gold;
  [Token(Token = "0x4000135")]
  [FieldOffset(Offset = "0x30")]
  public AudioSource silver;
  [Token(Token = "0x4000136")]
  [FieldOffset(Offset = "0x38")]
  private float xpPitch;
  [Token(Token = "0x4000137")]
  [FieldOffset(Offset = "0x3C")]
  private float xpPitchDefault;
  [Token(Token = "0x4000138")]
  [FieldOffset(Offset = "0x40")]
  private float xpPitchMax;
  [Token(Token = "0x4000139")]
  [FieldOffset(Offset = "0x44")]
  private float baseXpVolume;
  [Token(Token = "0x400013A")]
  [FieldOffset(Offset = "0x48")]
  private float baseGoldVolume;
  [Token(Token = "0x400013B")]
  [FieldOffset(Offset = "0x50")]
  public RandomSfx uiClick;
  [Token(Token = "0x400013C")]
  [FieldOffset(Offset = "0x58")]
  public RandomSfx uiSelect;
  [Token(Token = "0x400013D")]
  [FieldOffset(Offset = "0x60")]
  public RandomSfx uiInputSet;
  [Token(Token = "0x400013E")]
  [FieldOffset(Offset = "0x68")]
  public RandomSfx uiAbort;
  [Token(Token = "0x400013F")]
  [FieldOffset(Offset = "0x70")]
  public RandomSfx customSfx;
  [Token(Token = "0x4000140")]
  [FieldOffset(Offset = "0x78")]
  public RandomSfx purchaseSfx;
  [Token(Token = "0x4000141")]
  [FieldOffset(Offset = "0x80")]
  public RandomSfx bullseye;
  [Token(Token = "0x4000142")]
  [FieldOffset(Offset = "0x88")]
  public RandomSfx newMenuButton;
  [Token(Token = "0x4000143")]
  public static AudioManager Instance;
  [Token(Token = "0x4000144")]
  [FieldOffset(Offset = "0x90")]
  private float xpAndGoldVolume;
  [Token(Token = "0x4000145")]
  [FieldOffset(Offset = "0x94")]
  private int xpPerInterval;
  [Token(Token = "0x4000146")]
  [FieldOffset(Offset = "0x98")]
  private int goldPerInterval;
  [Token(Token = "0x4000147")]
  [FieldOffset(Offset = "0x9C")]
  private float interval;
  [Token(Token = "0x4000148")]
  [FieldOffset(Offset = "0xA0")]
  private float nextIntervalCheck;
  [Token(Token = "0x4000149")]
  [FieldOffset(Offset = "0xA4")]
  private int maxPerInterval;
  [Token(Token = "0x400014A")]
  [FieldOffset(Offset = "0xA8")]
  private int minPerInterval;
  [Token(Token = "0x400014B")]
  [FieldOffset(Offset = "0xAC")]
  private float xpVolumeMultiplier;
  [Token(Token = "0x400014C")]
  [FieldOffset(Offset = "0xB0")]
  private float goldVolumeMultiplier;
  [Token(Token = "0x400014D")]
  [FieldOffset(Offset = "0xB4")]
  private float nextMenuSelectTime;
  [Token(Token = "0x400014E")]
  [FieldOffset(Offset = "0xB8")]
  private float nextMenuEnterTime;
  [Token(Token = "0x400014F")]
  [FieldOffset(Offset = "0xBC")]
  private float minSelectInterval;
  [Token(Token = "0x4000150")]
  [FieldOffset(Offset = "0xC0")]
  private bool queueSelect;
  [Token(Token = "0x4000151")]
  [FieldOffset(Offset = "0xC1")]
  private bool queueEnter;

  [Token(Token = "0x6000118")]
  [Address(RVA = "0x3393A0", Offset = "0x337FA0", Length = "0x103")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000119")]
  [Address(RVA = "0x339AE0", Offset = "0x3386E0", Length = "0x25D")]
  private void Start()
  {
  }

  [Token(Token = "0x600011A")]
  [Address(RVA = "0x339550", Offset = "0x338150", Length = "0x25D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600011B")]
  [Address(RVA = "0x3397B0", Offset = "0x3383B0", Length = "0x105")]
  private void OnSettingUpdate(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x600011C")]
  [Address(RVA = "0x3397B0", Offset = "0x3383B0", Length = "0x105")]
  private void UpdateVolumes()
  {
  }

  [Token(Token = "0x600011D")]
  [Address(RVA = "0x339AB0", Offset = "0x3386B0", Length = "0x2A")]
  public void PlayXp()
  {
  }

  [Token(Token = "0x600011E")]
  [Address(RVA = "0x339970", Offset = "0x338570", Length = "0x2A")]
  public void PlayGold()
  {
  }

  [Token(Token = "0x600011F")]
  [Address(RVA = "0x339A90", Offset = "0x338690", Length = "0x1D")]
  public void PlaySilver()
  {
  }

  [Token(Token = "0x6000120")]
  [Address(RVA = "0x3399A0", Offset = "0x3385A0", Length = "0x2C")]
  public void PlayNewMenuButton()
  {
  }

  [Token(Token = "0x6000121")]
  [Address(RVA = "0x339D40", Offset = "0x338940", Length = "0x2AB")]
  private void Update()
  {
  }

  [Token(Token = "0x6000122")]
  [Address(RVA = "0x3394E0", Offset = "0x3380E0", Length = "0x69")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000123")]
  [Address(RVA = "0x339910", Offset = "0x338510", Length = "0x55")]
  public void PlayButtonSelect()
  {
  }

  [Token(Token = "0x6000124")]
  [Address(RVA = "0x3398C0", Offset = "0x3384C0", Length = "0x41")]
  public void PlayButtonEnter()
  {
  }

  [Token(Token = "0x6000125")]
  [Address(RVA = "0x3399D0", Offset = "0x3385D0", Length = "0xB9")]
  public void PlaySfx(AudioClip clip)
  {
  }

  [Token(Token = "0x6000126")]
  [Address(RVA = "0x3394B0", Offset = "0x3380B0", Length = "0x2C")]
  public void Bullseye()
  {
  }

  [Token(Token = "0x6000127")]
  [Address(RVA = "0x339FF0", Offset = "0x338BF0", Length = "0x5B")]
  public AudioManager()
  {
  }
}
