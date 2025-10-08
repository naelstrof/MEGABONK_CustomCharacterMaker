// Decompiled with JetBrains decompiler
// Type: KillsAndGoldCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000133")]
public class KillsAndGoldCounter : MonoBehaviour
{
  [Token(Token = "0x4000901")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_gold;
  [Token(Token = "0x4000902")]
  [FieldOffset(Offset = "0x28")]
  public TextMeshProUGUI t_kills;
  [Token(Token = "0x4000903")]
  [FieldOffset(Offset = "0x30")]
  public TextMeshProUGUI t_silver;
  [Token(Token = "0x4000904")]
  [FieldOffset(Offset = "0x38")]
  public TextMeshProUGUI t_chestPrice;
  [Token(Token = "0x4000905")]
  [FieldOffset(Offset = "0x40")]
  private string killsString;
  [Token(Token = "0x4000906")]
  [FieldOffset(Offset = "0x48")]
  private bool queuedKillsUpdate;
  [Token(Token = "0x4000907")]
  [FieldOffset(Offset = "0x49")]
  private bool queuedGoldUpdate;

  [Token(Token = "0x60007AB")]
  [Address(RVA = "0x4BC270", Offset = "0x4BAE70", Length = "0x11D")]
  private void Start()
  {
  }

  [Token(Token = "0x60007AC")]
  [Address(RVA = "0x4BB1E0", Offset = "0x4B9DE0", Length = "0x688")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007AD")]
  [Address(RVA = "0x4BB910", Offset = "0x4BA510", Length = "0x66D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60007AE")]
  [Address(RVA = "0x4BBF90", Offset = "0x4BAB90", Length = "0x36")]
  private void OnInventoryInitialized(PlayerInventory inv)
  {
  }

  [Token(Token = "0x60007AF")]
  [Address(RVA = "0x4BC5D0", Offset = "0x4BB1D0", Length = "0x31")]
  private void Update()
  {
  }

  [Token(Token = "0x60007B0")]
  [Address(RVA = "0x4BBFD0", Offset = "0x4BABD0", Length = "0x29")]
  private void OnRunStatChanged(string stat, float value)
  {
  }

  [Token(Token = "0x60007B1")]
  [Address(RVA = "0x4BBF80", Offset = "0x4BAB80", Length = "0x5")]
  private void OnGoldIncrease(PlayerInventory inv, int amount)
  {
  }

  [Token(Token = "0x60007B2")]
  [Address(RVA = "0x4BC520", Offset = "0x4BB120", Length = "0xA5")]
  private void UpdateKillCounter()
  {
  }

  [Token(Token = "0x60007B3")]
  [Address(RVA = "0x4BC390", Offset = "0x4BAF90", Length = "0x188")]
  private void UpdateGoldCounter()
  {
  }

  [Token(Token = "0x60007B4")]
  [Address(RVA = "0x4BC000", Offset = "0x4BAC00", Length = "0x211")]
  private void OnSilverChange(int delta)
  {
  }

  [Token(Token = "0x60007B5")]
  [Address(RVA = "0x4BB870", Offset = "0x4BA470", Length = "0x9F")]
  private void OnChestPriceIncreased()
  {
  }

  [Token(Token = "0x60007B6")]
  [Address(RVA = "0x4BC220", Offset = "0x4BAE20", Length = "0x4E")]
  private void OnSpawnFinished()
  {
  }

  [Token(Token = "0x60007B7")]
  [Address(RVA = "0x4BC610", Offset = "0x4BB210", Length = "0x6E")]
  public KillsAndGoldCounter()
  {
  }
}
