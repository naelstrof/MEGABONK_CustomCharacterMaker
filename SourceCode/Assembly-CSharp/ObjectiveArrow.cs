// Decompiled with JetBrains decompiler
// Type: ObjectiveArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200013A")]
public class ObjectiveArrow : MonoBehaviour
{
  [Token(Token = "0x4000929")]
  [FieldOffset(Offset = "0x20")]
  public Transform tutorialArrow;
  [Token(Token = "0x400092A")]
  [FieldOffset(Offset = "0x28")]
  public RectTransform canvasRect;
  [Token(Token = "0x400092C")]
  [FieldOffset(Offset = "0x38")]
  private float hideAtDistance;
  [Token(Token = "0x400092D")]
  [FieldOffset(Offset = "0x3C")]
  private float timeout;
  [Token(Token = "0x400092E")]
  [FieldOffset(Offset = "0x40")]
  private float targetAtTime;
  [Token(Token = "0x400092F")]
  [FieldOffset(Offset = "0x44")]
  private float minTime;
  [Token(Token = "0x4000930")]
  [FieldOffset(Offset = "0x48")]
  private Vector3 targetSize;
  [Token(Token = "0x4000931")]
  [FieldOffset(Offset = "0x54")]
  private Vector3 fromScale;
  [Token(Token = "0x4000932")]
  [FieldOffset(Offset = "0x60")]
  private float timer;
  [Token(Token = "0x4000933")]
  [FieldOffset(Offset = "0x64")]
  private float scaleTime;

  [field: Token(Token = "0x400092B")]
  [field: FieldOffset(Offset = "0x30")]
  [Token(Token = "0x17000049")]
  public Transform target { [Token(Token = "0x60007D5"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get; [Token(Token = "0x60007D6"), Address(RVA = "0x370A90", Offset = "0x36F690", Length = "0xD")] set; }

  [Token(Token = "0x60007D7")]
  [Address(RVA = "0x4BF7A0", Offset = "0x4BE3A0", Length = "0xE2")]
  private void Awake()
  {
  }

  [Token(Token = "0x60007D8")]
  [Address(RVA = "0x4BF970", Offset = "0x4BE570", Length = "0x134")]
  public void SetTarget(Transform t, Vector3 offset, float hideAtDistance, float timeout)
  {
  }

  [Token(Token = "0x60007D9")]
  [Address(RVA = "0x4BFAB0", Offset = "0x4BE6B0", Length = "0xB3")]
  private void Show()
  {
  }

  [Token(Token = "0x60007DA")]
  [Address(RVA = "0x4BF890", Offset = "0x4BE490", Length = "0x88")]
  private void Hide()
  {
  }

  [Token(Token = "0x60007DB")]
  [Address(RVA = "0x4BF920", Offset = "0x4BE520", Length = "0x4F")]
  private bool IsHidden() => false;

  [Token(Token = "0x60007DC")]
  [Address(RVA = "0x4BFDD0", Offset = "0x4BE9D0", Length = "0x123")]
  private void UpdateSize()
  {
  }

  [Token(Token = "0x60007DD")]
  [Address(RVA = "0x4BFF00", Offset = "0x4BEB00", Length = "0x3EA")]
  private void Update()
  {
  }

  [Token(Token = "0x60007DE")]
  [Address(RVA = "0x4BFB70", Offset = "0x4BE770", Length = "0x25B")]
  private void TargetFollowItem()
  {
  }

  [Token(Token = "0x60007DF")]
  [Address(RVA = "0x4C0390", Offset = "0x4BEF90", Length = "0x22D")]
  private Vector3 calculateWorldPosition(Vector3 position, Camera camera) => new Vector3();

  [Token(Token = "0x60007E0")]
  [Address(RVA = "0x4C02F0", Offset = "0x4BEEF0", Length = "0x99")]
  public ObjectiveArrow()
  {
  }
}
