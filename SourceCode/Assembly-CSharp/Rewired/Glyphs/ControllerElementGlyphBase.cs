// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Glyphs
{
  [Token(Token = "0x2000275")]
  public abstract class ControllerElementGlyphBase : MonoBehaviour
  {
    [Tooltip("If set, when glyph/text objects are created, they will be instantiated from this prefab. If left blank, the global default prefab will be used.")]
    [SerializeField]
    [Token(Token = "0x40011C2")]
    [FieldOffset(Offset = "0x20")]
    private GameObject _glyphOrTextPrefab;
    [Tooltip("Determines what types of objects are allowed.")]
    [SerializeField]
    [Token(Token = "0x40011C3")]
    [FieldOffset(Offset = "0x28")]
    private ControllerElementGlyphBase.AllowedTypes _allowedTypes;
    [Token(Token = "0x40011C4")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    private readonly List<ControllerElementGlyphBase.GlyphOrTextObject> _entries;
    [Token(Token = "0x40011C5")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private List<object> _tempGlyphs;
    [Token(Token = "0x40011C6")]
    [FieldOffset(Offset = "0x40")]
    [NonSerialized]
    private GameObject _lastGlyphOrTextPrefab;

    [Token(Token = "0x170002DE")]
    public virtual GameObject glyphOrTextPrefab
    {
      [Token(Token = "0x6001262"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (GameObject) null;
      [Token(Token = "0x6001263"), Address(RVA = "0x36C7B0", Offset = "0x36B3B0", Length = "0x2F")] set
      {
      }
    }

    [Token(Token = "0x170002DF")]
    public virtual ControllerElementGlyphBase.AllowedTypes allowedTypes
    {
      [Token(Token = "0x6001264"), Address(RVA = "0x36C770", Offset = "0x36B370", Length = "0x4")] get => new ControllerElementGlyphBase.AllowedTypes();
      [Token(Token = "0x6001265"), Address(RVA = "0x36C7A0", Offset = "0x36B3A0", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x170002E0")]
    protected List<ControllerElementGlyphBase.GlyphOrTextObject> entries
    {
      [Token(Token = "0x6001266"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get => (List<ControllerElementGlyphBase.GlyphOrTextObject>) null;
    }

    [Token(Token = "0x6001267")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void Awake()
    {
    }

    [Token(Token = "0x6001268")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x6001269")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x600126A")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x600126B")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected virtual void OnDisable()
    {
    }

    [Token(Token = "0x600126C")]
    [Address(RVA = "0x36C580", Offset = "0x36B180", Length = "0x12C")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x600126D")]
    [Address(RVA = "0x36C040", Offset = "0x36AC40", Length = "0x11")]
    public virtual void RequireRebuild()
    {
    }

    [Token(Token = "0x600126E")]
    [Address(RVA = "0x36B7D0", Offset = "0x36A3D0", Length = "0xFF")]
    protected virtual void ClearObjects()
    {
    }

    [Token(Token = "0x600126F")]
    [Address(RVA = "0x36BD70", Offset = "0x36A970", Length = "0xB2")]
    protected virtual void EvaluateObjectVisibility()
    {
    }

    [Token(Token = "0x6001270")]
    [Address(RVA = "0x36BE30", Offset = "0x36AA30", Length = "0x15")]
    protected virtual void EvaluateObjectVisibility(Transform transform)
    {
    }

    [Token(Token = "0x6001271")]
    [Address(RVA = "0x36BC20", Offset = "0x36A820", Length = "0x148")]
    protected virtual void EvaluateObjectVisibility(
      Transform transform,
      List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
    {
    }

    [Token(Token = "0x6001272")]
    [Address(RVA = "0x36C060", Offset = "0x36AC60", Length = "0x2A2")]
    protected virtual int ShowGlyphsOrText(
      ActionElementMap actionElementMap,
      Transform parent,
      List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
    {
      return 0;
    }

    [Token(Token = "0x6001273")]
    [Address(RVA = "0x36C310", Offset = "0x36AF10", Length = "0x48")]
    protected virtual int ShowGlyphsOrText(ActionElementMap actionElementMap) => 0;

    [Token(Token = "0x6001274")]
    [Address(RVA = "0x36C360", Offset = "0x36AF60", Length = "0x1B7")]
    protected virtual int ShowGlyphsOrText(
      ControllerElementIdentifier elementIdentifier,
      AxisRange axisRange,
      Transform parent,
      List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
    {
      return 0;
    }

    [Token(Token = "0x6001275")]
    [Address(RVA = "0x36C520", Offset = "0x36B120", Length = "0x5D")]
    protected virtual int ShowGlyphsOrText(
      ControllerElementIdentifier elementIdentifier,
      AxisRange axisRange)
    {
      return 0;
    }

    [Token(Token = "0x6001276")]
    [Address(RVA = "0x36BF70", Offset = "0x36AB70", Length = "0xB2")]
    protected virtual void Hide()
    {
    }

    [Token(Token = "0x6001277")]
    [Address(RVA = "0x36BE50", Offset = "0x36AA50", Length = "0x83")]
    protected virtual GameObject GetGlyphOrTextPrefabOrDefault() => (GameObject) null;

    [Token(Token = "0x6001278")]
    protected abstract GameObject GetDefaultGlyphOrTextPrefab();

    [Token(Token = "0x6001279")]
    [Address(RVA = "0x36B8D0", Offset = "0x36A4D0", Length = "0x34A")]
    protected virtual bool CreateObjectsAsNeeded(
      Transform parent,
      List<ControllerElementGlyphBase.GlyphOrTextObject> entries,
      int count)
    {
      return false;
    }

    [Token(Token = "0x600127A")]
    [Address(RVA = "0x36C030", Offset = "0x36AC30", Length = "0x10")]
    protected virtual bool IsAllowed(
      ControllerElementGlyphBase.AllowedTypes allowedType)
    {
      return false;
    }

    [Token(Token = "0x600127B")]
    [Address(RVA = "0x36BEE0", Offset = "0x36AAE0", Length = "0x86")]
    protected static int GetGlyphs(ActionElementMap actionElementMap, List<object> results) => 0;

    [Token(Token = "0x600127C")]
    [Address(RVA = "0x36C6B0", Offset = "0x36B2B0", Length = "0xBD")]
    protected ControllerElementGlyphBase()
    {
    }

    [Token(Token = "0x2000276")]
    protected class GlyphOrTextObject
    {
      [Token(Token = "0x40011C7")]
      [FieldOffset(Offset = "0x10")]
      private GlyphOrTextBase _glyphOrText;
      [Token(Token = "0x40011C8")]
      [FieldOffset(Offset = "0x18")]
      private int _frame;
      [Token(Token = "0x40011C9")]
      [FieldOffset(Offset = "0x1C")]
      private bool _isVisible;

      [Token(Token = "0x170002E1")]
      public virtual bool isVisible
      {
        [Token(Token = "0x600127D"), Address(RVA = "0x36E080", Offset = "0x36CC80", Length = "0x5")] get => false;
        [Token(Token = "0x600127E"), Address(RVA = "0x36E090", Offset = "0x36CC90", Length = "0x4")] protected set
        {
        }
      }

      [Token(Token = "0x170002E2")]
      public GlyphOrTextBase glyphOrText
      {
        [Token(Token = "0x600127F"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get => (GlyphOrTextBase) null;
        [Token(Token = "0x6001280"), Address(RVA = "0x36D7D0", Offset = "0x36C3D0", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x6001281")]
      [Address(RVA = "0x36E040", Offset = "0x36CC40", Length = "0x31")]
      public GlyphOrTextObject(GlyphOrTextBase glyphOrText)
      {
      }

      [Token(Token = "0x6001282")]
      [Address(RVA = "0x36DF00", Offset = "0x36CB00", Length = "0x9A")]
      public virtual void ShowGlyph(object glyph)
      {
      }

      [Token(Token = "0x6001283")]
      [Address(RVA = "0x36DFA0", Offset = "0x36CBA0", Length = "0x9A")]
      public virtual void ShowText(string text)
      {
      }

      [Token(Token = "0x6001284")]
      [Address(RVA = "0x36DE70", Offset = "0x36CA70", Length = "0x85")]
      public virtual void Hide()
      {
      }

      [Token(Token = "0x6001285")]
      [Address(RVA = "0x36DE30", Offset = "0x36CA30", Length = "0x39")]
      public virtual void HideIfIdle()
      {
      }

      [Token(Token = "0x6001286")]
      [Address(RVA = "0x36DD80", Offset = "0x36C980", Length = "0xAC")]
      public virtual void Destroy()
      {
      }
    }

    [Token(Token = "0x2000277")]
    public enum AllowedTypes
    {
      [Token(Token = "0x40011CB")] All,
      [Token(Token = "0x40011CC")] Glyphs,
      [Token(Token = "0x40011CD")] Text,
    }
  }
}
