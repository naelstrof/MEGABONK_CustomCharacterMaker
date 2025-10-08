// Decompiled with JetBrains decompiler
// Type: KeyListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20001D3")]
public class KeyListener : MonoBehaviour
{
  [Token(Token = "0x4000D18")]
  [FieldOffset(Offset = "0x20")]
  public InputSettingNew currentlyChanging;
  [Token(Token = "0x4000D19")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI alertText;
  [Token(Token = "0x4000D1A")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_countdown;
  [Token(Token = "0x4000D1B")]
  [FieldOffset(Offset = "0x38")]
  public RawImage overlay;
  [Token(Token = "0x4000D1D")]
  [FieldOffset(Offset = "0x44")]
  private float readyForKeyTime;
  [Token(Token = "0x4000D1E")]
  [FieldOffset(Offset = "0x48")]
  private List<InputMapper.Context> contexts;
  [Token(Token = "0x4000D1F")]
  [FieldOffset(Offset = "0x50")]
  public GameObject window;
  [Token(Token = "0x4000D20")]
  [FieldOffset(Offset = "0x58")]
  private bool result;
  [Token(Token = "0x4000D21")]
  [FieldOffset(Offset = "0x5C")]
  private float timeout;
  [Token(Token = "0x4000D22")]
  public static KeyListener Instance;
  [Token(Token = "0x4000D23")]
  [FieldOffset(Offset = "0x60")]
  private List<InputMapper> mappers;
  [Token(Token = "0x4000D25")]
  [FieldOffset(Offset = "0x70")]
  private EventSystem eventSystem;
  [Token(Token = "0x4000D26")]
  [FieldOffset(Offset = "0x78")]
  private GameObject focusedObject;
  [Token(Token = "0x4000D27")]
  [FieldOffset(Offset = "0x80")]
  private bool hasSet;
  [Token(Token = "0x4000D28")]
  public static bool hasChangedKey;

  [field: Token(Token = "0x4000D1C")]
  [field: FieldOffset(Offset = "0x40")]
  [Token(Token = "0x17000074")]
  public bool justClosed { [Token(Token = "0x6000BF6"), Address(RVA = "0x3FC020", Offset = "0x3FAC20", Length = "0x5")] get; [Token(Token = "0x6000BF7"), Address(RVA = "0x3FC030", Offset = "0x3FAC30", Length = "0x4")] set; }

  [Token(Token = "0x6000BF8")]
  [Address(RVA = "0x50A240", Offset = "0x508E40", Length = "0xFB")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000BF9")]
  [Address(RVA = "0x50AC00", Offset = "0x509800", Length = "0x294")]
  public void StartListening(InputSettingNew listener, List<InputMapper.Context> contexts)
  {
  }

  [field: Token(Token = "0x4000D24")]
  [field: FieldOffset(Offset = "0x68")]
  [Token(Token = "0x17000075")]
  public bool isListening { [Token(Token = "0x6000BFA"), Address(RVA = "0x50B480", Offset = "0x50A080", Length = "0x5")] get; [Token(Token = "0x6000BFB"), Address(RVA = "0x50B490", Offset = "0x50A090", Length = "0x4")] private set; }

  [Token(Token = "0x6000BFC")]
  [Address(RVA = "0x50A340", Offset = "0x508F40", Length = "0x32")]
  private bool CanChange() => false;

  [Token(Token = "0x6000BFD")]
  [Address(RVA = "0x50A7A0", Offset = "0x5093A0", Length = "0x22")]
  private void OnInputMapped(InputMapper.InputMappedEventData mapEvent)
  {
  }

  [Token(Token = "0x6000BFE")]
  [Address(RVA = "0x50B1B0", Offset = "0x509DB0", Length = "0xFB")]
  private void StopMappers()
  {
  }

  [Token(Token = "0x6000BFF")]
  [Address(RVA = "0x50A7D0", Offset = "0x5093D0", Length = "0x422")]
  private bool OnIsElementAllowed(ControllerPollingInfo info) => false;

  [Token(Token = "0x6000C00")]
  [Address(RVA = "0x50B2B0", Offset = "0x509EB0", Length = "0x14D")]
  private void Update()
  {
  }

  [Token(Token = "0x6000C01")]
  [Address(RVA = "0x50AEA0", Offset = "0x509AA0", Length = "0x306")]
  private void StartMappers()
  {
  }

  [Token(Token = "0x6000C02")]
  [Address(RVA = "0x50A580", Offset = "0x509180", Length = "0x21C")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C03")]
  [Address(RVA = "0x50A380", Offset = "0x508F80", Length = "0x1A7")]
  private void CloseListener(ActionElementMap newActionElementMap)
  {
  }

  [Token(Token = "0x6000C04")]
  [Address(RVA = "0x50A530", Offset = "0x509130", Length = "0x3E")]
  private void Close()
  {
  }

  [Token(Token = "0x6000C05")]
  [Address(RVA = "0x3FA710", Offset = "0x3F9310", Length = "0x5")]
  private void Cooldown()
  {
  }

  [Token(Token = "0x6000C06")]
  [Address(RVA = "0x50A570", Offset = "0x509170", Length = "0xD")]
  public bool IsListening() => false;

  [Token(Token = "0x6000C07")]
  [Address(RVA = "0x50B400", Offset = "0x50A000", Length = "0x7E")]
  public KeyListener()
  {
  }
}
