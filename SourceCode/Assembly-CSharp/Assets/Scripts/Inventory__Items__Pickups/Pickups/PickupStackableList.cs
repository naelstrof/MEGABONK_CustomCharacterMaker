// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Pickups.PickupStackableList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Pickups
{
  [Token(Token = "0x200038C")]
  public class PickupStackableList
  {
    [Token(Token = "0x40017E9")]
    [FieldOffset(Offset = "0x10")]
    private int maxObjects;
    [Token(Token = "0x40017EA")]
    [FieldOffset(Offset = "0x14")]
    private EPickup ePickup;
    [Token(Token = "0x40017EB")]
    [FieldOffset(Offset = "0x18")]
    public LinkedList<Pickup> pickupsList;

    [Token(Token = "0x6001937")]
    [Address(RVA = "0x4190D0", Offset = "0x417CD0", Length = "0x97")]
    public PickupStackableList(int nMax, EPickup ePickup)
    {
    }

    [Token(Token = "0x6001938")]
    [Address(RVA = "0x418D10", Offset = "0x417910", Length = "0x22B")]
    public Pickup AddPickup(Vector3 pos) => (Pickup) null;

    [Token(Token = "0x6001939")]
    [Address(RVA = "0x418F40", Offset = "0x417B40", Length = "0x125")]
    private void CombineOldestObjects()
    {
    }

    [Token(Token = "0x600193A")]
    [Address(RVA = "0x419070", Offset = "0x417C70", Length = "0x53")]
    public void RemovePickup(Pickup pickup)
    {
    }
  }
}
