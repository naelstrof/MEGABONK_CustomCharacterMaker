// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUITextMeshProGlyphHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

namespace Rewired.Glyphs.UnityUI
{
  [AddComponentMenu("Rewired/Glyphs/Unity UI/Unity UI Text Mesh Pro Glyph Helper")]
  [RequireComponent(typeof (TextMeshProUGUI))]
  [Token(Token = "0x2000290")]
  public class UnityUITextMeshProGlyphHelper : MonoBehaviour
  {
    [Tooltip("Enter text into this field and not in the TMPro Text field directly. Text will be parsed for special tags, and the final result will be passed on to the Text Mesh Pro Text component. See the documentation for special tag format.")]
    [SerializeField]
    [TextArea(3, 10)]
    [Token(Token = "0x40011FD")]
    [FieldOffset(Offset = "0x20")]
    private string _text;
    [Tooltip("Optional reference to an object that defines options. If blank, the global default options will be used.")]
    [SerializeField]
    [Token(Token = "0x40011FE")]
    [FieldOffset(Offset = "0x28")]
    private ControllerElementGlyphSelectorOptionsSOBase _options;
    [Tooltip("Options that control how Text Mesh Pro displays Sprites.")]
    [SerializeField]
    [Token(Token = "0x40011FF")]
    [FieldOffset(Offset = "0x30")]
    private UnityUITextMeshProGlyphHelper.TMProSpriteOptions _spriteOptions;
    [Tooltip("Optional material for Sprites. If blank, the default material will be used.\nMaterial is instantiated for each Sprite Asset, so making changes to values in the base material later will not affect Sprites. Changing the base material at runtime will copy only certain properties from the new material to Sprite materials.")]
    [SerializeField]
    [Token(Token = "0x4001200")]
    [FieldOffset(Offset = "0x50")]
    private Material _baseSpriteMaterial;
    [Tooltip("If enabled, local values such as Sprite color will be used instead of the value on the base material.")]
    [SerializeField]
    [Token(Token = "0x4001201")]
    [FieldOffset(Offset = "0x58")]
    private bool _overrideSpriteMaterialProperties;
    [Tooltip("These properties will override the properties on the Sprite material if Override Sprite Material Properties is enabled.")]
    [SerializeField]
    [Token(Token = "0x4001202")]
    [FieldOffset(Offset = "0x5C")]
    private UnityUITextMeshProGlyphHelper.SpriteMaterialProperties _spriteMaterialProperties;
    [Token(Token = "0x4001203")]
    [FieldOffset(Offset = "0x70")]
    [NonSerialized]
    private TextMeshProUGUI _tmProText;
    [Token(Token = "0x4001204")]
    [FieldOffset(Offset = "0x78")]
    [NonSerialized]
    private string _textPrev;
    [Token(Token = "0x4001205")]
    [FieldOffset(Offset = "0x80")]
    [NonSerialized]
    private readonly StringBuilder _processTagSb;
    [Token(Token = "0x4001206")]
    [FieldOffset(Offset = "0x88")]
    [NonSerialized]
    private readonly StringBuilder _tempSb;
    [Token(Token = "0x4001207")]
    [FieldOffset(Offset = "0x90")]
    [NonSerialized]
    private readonly StringBuilder _tempSb2;
    [Token(Token = "0x4001208")]
    [FieldOffset(Offset = "0x98")]
    [NonSerialized]
    private UnityUITextMeshProGlyphHelper.Asset _primaryAsset;
    [Token(Token = "0x4001209")]
    [FieldOffset(Offset = "0xA0")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assignedAssets;
    [Token(Token = "0x400120A")]
    [FieldOffset(Offset = "0xA8")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.Asset> _assetsPool;
    [Token(Token = "0x400120B")]
    [FieldOffset(Offset = "0xB0")]
    [NonSerialized]
    private readonly List<ActionElementMap> _tempAems;
    [Token(Token = "0x400120C")]
    [FieldOffset(Offset = "0xB8")]
    [NonSerialized]
    private readonly List<Sprite> _tempGlyphs;
    [Token(Token = "0x400120D")]
    [FieldOffset(Offset = "0xC0")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.Asset> _dirtyAssets;
    [Token(Token = "0x400120E")]
    [FieldOffset(Offset = "0xC8")]
    [NonSerialized]
    private readonly List<string> _tempKeys;
    [Token(Token = "0x400120F")]
    [FieldOffset(Offset = "0xD0")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrTextTemp;
    [Token(Token = "0x4001210")]
    [FieldOffset(Offset = "0xD8")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.Asset> _currentlyUsedAssets;
    [Token(Token = "0x4001211")]
    [FieldOffset(Offset = "0xE0")]
    [NonSerialized]
    private readonly List<UnityUITextMeshProGlyphHelper.Tag> _currentTags;
    [Token(Token = "0x4001212")]
    [FieldOffset(Offset = "0xE8")]
    [NonSerialized]
    private Dictionary<string, string> _tempStringDictionary;
    [Token(Token = "0x4001213")]
    [FieldOffset(Offset = "0xF0")]
    [NonSerialized]
    private bool _initialized;
    [Token(Token = "0x4001214")]
    [FieldOffset(Offset = "0xF1")]
    [NonSerialized]
    private bool _rebuildRequired;
    [Token(Token = "0x4001215")]
    [FieldOffset(Offset = "0xF8")]
    [NonSerialized]
    private Texture2D _stubTexture;
    [Token(Token = "0x4001216")]
    [FieldOffset(Offset = "0x100")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> __controllerElementTagPool;
    [Token(Token = "0x4001217")]
    [FieldOffset(Offset = "0x108")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> __actionTagPool;
    [Token(Token = "0x4001218")]
    [FieldOffset(Offset = "0x110")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> __playerTagPool;
    [Token(Token = "0x4001219")]
    [FieldOffset(Offset = "0x118")]
    [NonSerialized]
    private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> __tagHandlers;
    [Token(Token = "0x400121A")]
    private static string[] __s_displayTypeNames;
    [Token(Token = "0x400121B")]
    private static UnityUITextMeshProGlyphHelper.DisplayType[] __s_displayTypeValues;
    [Token(Token = "0x400121C")]
    private static string[] __s_axisRangeNames;
    [Token(Token = "0x400121D")]
    private static AxisRange[] __s_axisRangeValues;

    [Token(Token = "0x1700030B")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> controllerElementTagPool
    {
      [Token(Token = "0x6001322"), Address(RVA = "0x39E7F0", Offset = "0x39D3F0", Length = "0x8F")] get => (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag>) null;
    }

    [Token(Token = "0x1700030C")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> actionTagPool
    {
      [Token(Token = "0x6001323"), Address(RVA = "0x39E760", Offset = "0x39D360", Length = "0x8F")] get => (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag>) null;
    }

    [Token(Token = "0x1700030D")]
    private UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> playerTagPool
    {
      [Token(Token = "0x6001324"), Address(RVA = "0x39E890", Offset = "0x39D490", Length = "0x8F")] get => (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag>) null;
    }

    [Token(Token = "0x1700030E")]
    private Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> tagHandlers
    {
      [Token(Token = "0x6001325"), Address(RVA = "0x39EDA0", Offset = "0x39D9A0", Length = "0x1BE")] get => (Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>) null;
    }

    [Token(Token = "0x1700030F")]
    public virtual string text
    {
      [Token(Token = "0x6001326"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (string) null;
      [Token(Token = "0x6001327"), Address(RVA = "0x39F5E0", Offset = "0x39E1E0", Length = "0x23")] set
      {
      }
    }

    [Token(Token = "0x17000310")]
    public virtual ControllerElementGlyphSelectorOptionsSOBase options
    {
      [Token(Token = "0x6001328"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (ControllerElementGlyphSelectorOptionsSOBase) null;
      [Token(Token = "0x6001329"), Address(RVA = "0x39F090", Offset = "0x39DC90", Length = "0x23")] set
      {
      }
    }

    [Token(Token = "0x17000311")]
    public virtual UnityUITextMeshProGlyphHelper.TMProSpriteOptions spriteOptions
    {
      [Token(Token = "0x600132A"), Address(RVA = "0x39ED80", Offset = "0x39D980", Length = "0x1B")] get => new UnityUITextMeshProGlyphHelper.TMProSpriteOptions();
      [Token(Token = "0x600132B"), Address(RVA = "0x39F2C0", Offset = "0x39DEC0", Length = "0x31C")] set
      {
      }
    }

    [Token(Token = "0x17000312")]
    public virtual Material baseSpriteMaterial
    {
      [Token(Token = "0x600132C"), Address(RVA = "0x36CC90", Offset = "0x36B890", Length = "0x5")] get => (Material) null;
      [Token(Token = "0x600132D"), Address(RVA = "0x39EF60", Offset = "0x39DB60", Length = "0x12A")] set
      {
      }
    }

    [Token(Token = "0x17000313")]
    public virtual bool overrideSpriteMaterialProperties
    {
      [Token(Token = "0x600132E"), Address(RVA = "0x39E880", Offset = "0x39D480", Length = "0x5")] get => false;
      [Token(Token = "0x600132F"), Address(RVA = "0x39F0C0", Offset = "0x39DCC0", Length = "0x161")] set
      {
      }
    }

    [Token(Token = "0x17000314")]
    public virtual UnityUITextMeshProGlyphHelper.SpriteMaterialProperties spriteMaterialProperties
    {
      [Token(Token = "0x6001330"), Address(RVA = "0x39ED70", Offset = "0x39D970", Length = "0xB")] get => new UnityUITextMeshProGlyphHelper.SpriteMaterialProperties();
      [Token(Token = "0x6001331"), Address(RVA = "0x39F230", Offset = "0x39DE30", Length = "0x82")] set
      {
      }
    }

    [Token(Token = "0x6001332")]
    [Address(RVA = "0x39B310", Offset = "0x399F10", Length = "0x152")]
    protected virtual void OnEnable()
    {
    }

    [Token(Token = "0x6001333")]
    [Address(RVA = "0x39C980", Offset = "0x39B580", Length = "0x7")]
    protected virtual void Start()
    {
    }

    [Token(Token = "0x6001334")]
    [Address(RVA = "0x39E240", Offset = "0x39CE40", Length = "0x94")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x6001335")]
    [Address(RVA = "0x39AF60", Offset = "0x399B60", Length = "0x3A2")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x6001336")]
    [Address(RVA = "0x399E50", Offset = "0x398A50", Length = "0xA5")]
    public virtual void ForceUpdate()
    {
    }

    [Token(Token = "0x6001337")]
    [Address(RVA = "0x399F00", Offset = "0x398B00", Length = "0x197")]
    protected virtual ControllerElementGlyphSelectorOptions GetOptionsOrDefault() => (ControllerElementGlyphSelectorOptions) null;

    [Token(Token = "0x6001338")]
    [Address(RVA = "0x39A650", Offset = "0x399250", Length = "0x15C")]
    private bool Initialize() => false;

    [Token(Token = "0x6001339")]
    [Address(RVA = "0x39A9D0", Offset = "0x3995D0", Length = "0x589")]
    private void MainUpdate()
    {
    }

    [Token(Token = "0x600133A")]
    [Address(RVA = "0x39B950", Offset = "0x39A550", Length = "0x1D0")]
    private bool ParseText(string text, out string newText)
    {
      newText = (string) null;
      return false;
    }

    [Token(Token = "0x600133B")]
    [Address(RVA = "0x39BB30", Offset = "0x39A730", Length = "0x3EA")]
    private bool ProcessNextTag(ref string text, StringBuilder sb) => false;

    [Token(Token = "0x600133C")]
    [Address(RVA = "0x39C190", Offset = "0x39AD90", Length = "0x270")]
    private bool ProcessTag_ControllerElement(
      string text,
      int startIndex,
      int count,
      out string replacement)
    {
      replacement = (string) null;
      return false;
    }

    [Token(Token = "0x600133D")]
    [Address(RVA = "0x39BF20", Offset = "0x39AB20", Length = "0x263")]
    private bool ProcessTag_Action(string text, int startIndex, int count, out string replacement)
    {
      replacement = (string) null;
      return false;
    }

    [Token(Token = "0x600133E")]
    [Address(RVA = "0x39C410", Offset = "0x39B010", Length = "0x25F")]
    private bool ProcessTag_Player(string text, int startIndex, int count, out string replacement)
    {
      replacement = (string) null;
      return false;
    }

    [Token(Token = "0x600133F")]
    [Address(RVA = "0x39D0C0", Offset = "0x39BCC0", Length = "0x202")]
    private bool TryCreateTMProString(
      List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphs,
      out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x6001340")]
    [Address(RVA = "0x39D3A0", Offset = "0x39BFA0", Length = "0x8B7")]
    private bool TryGetControllerElementGlyphsOrText(
      UnityUITextMeshProGlyphHelper.ControllerElementTag tag,
      List<UnityUITextMeshProGlyphHelper.GlyphOrText> results)
    {
      return false;
    }

    [Token(Token = "0x6001341")]
    [Address(RVA = "0x39D2D0", Offset = "0x39BED0", Length = "0xC1")]
    private bool TryGetActionDisplayName(
      UnityUITextMeshProGlyphHelper.ActionTag tag,
      out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x6001342")]
    [Address(RVA = "0x39DF40", Offset = "0x39CB40", Length = "0xBD")]
    private bool TryGetPlayerDisplayName(
      UnityUITextMeshProGlyphHelper.PlayerTag tag,
      out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x6001343")]
    [Address(RVA = "0x39C990", Offset = "0x39B590", Length = "0x721")]
    private bool TryAssignSprite(Sprite sprite, string key) => false;

    [Token(Token = "0x6001344")]
    [Address(RVA = "0x39C8E0", Offset = "0x39B4E0", Length = "0x8")]
    private void RequireRebuild()
    {
    }

    [Token(Token = "0x6001345")]
    [Address(RVA = "0x399C40", Offset = "0x398840", Length = "0xBF")]
    private void CreatePrimaryAsset()
    {
    }

    [Token(Token = "0x6001346")]
    [Address(RVA = "0x39A0A0", Offset = "0x398CA0", Length = "0x5A6")]
    private UnityUITextMeshProGlyphHelper.Asset GetOrCreateAsset(Sprite sprite) => (UnityUITextMeshProGlyphHelper.Asset) null;

    [Token(Token = "0x6001347")]
    [Address(RVA = "0x399B10", Offset = "0x398710", Length = "0x123")]
    private UnityUITextMeshProGlyphHelper.Asset CreateAsset() => (UnityUITextMeshProGlyphHelper.Asset) null;

    [Token(Token = "0x6001348")]
    [Address(RVA = "0x39C670", Offset = "0x39B270", Length = "0x266")]
    private void RemoveUnusedAssets()
    {
    }

    [Token(Token = "0x6001349")]
    [Address(RVA = "0x39C8F0", Offset = "0x39B4F0", Length = "0x82")]
    private void SetDirty(UnityUITextMeshProGlyphHelper.Asset asset)
    {
    }

    [Token(Token = "0x600134A")]
    [Address(RVA = "0x399D00", Offset = "0x398900", Length = "0x14C")]
    private void ForEachAsset(
      Action<UnityUITextMeshProGlyphHelper.Asset> callback)
    {
    }

    [Token(Token = "0x17000315")]
    private static int shaderPropertyId_color
    {
      [Token(Token = "0x600134B"), Address(RVA = "0x39ED30", Offset = "0x39D930", Length = "0x32")] get => 0;
    }

    [Token(Token = "0x17000316")]
    private static string[] s_displayTypeNames
    {
      [Token(Token = "0x600134C"), Address(RVA = "0x39EB30", Offset = "0x39D730", Length = "0xCC")] get => (string[]) null;
    }

    [Token(Token = "0x17000317")]
    private static UnityUITextMeshProGlyphHelper.DisplayType[] s_displayTypeValues
    {
      [Token(Token = "0x600134D"), Address(RVA = "0x39EC00", Offset = "0x39D800", Length = "0x121")] get => (UnityUITextMeshProGlyphHelper.DisplayType[]) null;
    }

    [Token(Token = "0x17000318")]
    private static string[] s_axisRangeNames
    {
      [Token(Token = "0x600134E"), Address(RVA = "0x39E920", Offset = "0x39D520", Length = "0xD3")] get => (string[]) null;
    }

    [Token(Token = "0x17000319")]
    private static AxisRange[] s_axisRangeValues
    {
      [Token(Token = "0x600134F"), Address(RVA = "0x39EA00", Offset = "0x39D600", Length = "0x121")] get => (AxisRange[]) null;
    }

    [Token(Token = "0x6001350")]
    [Address(RVA = "0x39B470", Offset = "0x39A070", Length = "0x4CF")]
    private static void ParseAttributes(
      string text,
      int startIndex,
      int count,
      StringBuilder sbKey,
      StringBuilder sbValue,
      Dictionary<string, string> results)
    {
    }

    [Token(Token = "0x6001351")]
    [Address(RVA = "0x39A950", Offset = "0x399550", Length = "0x41")]
    private static bool IsValidKeyChar(char c) => false;

    [Token(Token = "0x6001352")]
    [Address(RVA = "0x39A950", Offset = "0x399550", Length = "0x41")]
    private static bool IsValidTagNameChar(char c) => false;

    [Token(Token = "0x6001353")]
    [Address(RVA = "0x39A9A0", Offset = "0x3995A0", Length = "0x2D")]
    private static bool IsValidNonQuotedValueChar(char c) => false;

    [Token(Token = "0x6001354")]
    [Address(RVA = "0x39A7B0", Offset = "0x3993B0", Length = "0x174")]
    private static bool IsEqual(
      List<UnityUITextMeshProGlyphHelper.GlyphOrText> a,
      List<UnityUITextMeshProGlyphHelper.GlyphOrText> b)
    {
      return false;
    }

    [Token(Token = "0x6001355")]
    [Address(RVA = "0x39E2E0", Offset = "0x39CEE0", Length = "0x7E")]
    private static void WriteSpriteKey(StringBuilder sb, string key)
    {
    }

    [Token(Token = "0x6001356")]
    [Address(RVA = "0x39DC60", Offset = "0x39C860", Length = "0x2D1")]
    private static bool TryGetGlyphsOrText(
      ActionElementMap aem,
      UnityUITextMeshProGlyphHelper.DisplayType displayType,
      List<Sprite> glyphs,
      List<string> keys,
      List<UnityUITextMeshProGlyphHelper.GlyphOrText> results)
    {
      return false;
    }

    [Token(Token = "0x6001357")]
    [Address(RVA = "0x39A930", Offset = "0x399530", Length = "0xE")]
    private static bool IsGlyphAllowed(
      UnityUITextMeshProGlyphHelper.DisplayType displayType)
    {
      return false;
    }

    [Token(Token = "0x6001358")]
    [Address(RVA = "0x39A940", Offset = "0x399540", Length = "0x10")]
    private static bool IsTextAllowed(
      UnityUITextMeshProGlyphHelper.DisplayType displayType)
    {
      return false;
    }

    [Token(Token = "0x6001359")]
    [Address(RVA = "0x399830", Offset = "0x398430", Length = "0x21E")]
    private static void CopyMaterialProperties(Material source, Material destination)
    {
    }

    [Token(Token = "0x600135A")]
    [Address(RVA = "0x399A50", Offset = "0x398650", Length = "0xB9")]
    private static void CopySpriteMaterialPropertiesToMaterial(
      UnityUITextMeshProGlyphHelper.SpriteMaterialProperties properties,
      Material material)
    {
    }

    [Token(Token = "0x600135B")]
    [Address(RVA = "0x39E360", Offset = "0x39CF60", Length = "0x3F6")]
    public UnityUITextMeshProGlyphHelper()
    {
    }

    [Token(Token = "0x2000291")]
    private delegate bool ParseTagAttributesHandler(
      string text,
      int startIndex,
      int count,
      out string replacement);

    [Token(Token = "0x2000292")]
    private abstract class Tag
    {
      [Token(Token = "0x400121E")]
      [FieldOffset(Offset = "0x10")]
      public readonly UnityUITextMeshProGlyphHelper.Tag.TagType tagType;
      [Token(Token = "0x400121F")]
      [FieldOffset(Offset = "0x18")]
      private UnityUITextMeshProGlyphHelper.Tag.Pool _pool;

      [Token(Token = "0x6001362")]
      [Address(RVA = "0x3684F0", Offset = "0x3670F0", Length = "0x24")]
      protected Tag(UnityUITextMeshProGlyphHelper.Tag.TagType tagType)
      {
      }

      [Token(Token = "0x1700031A")]
      protected UnityUITextMeshProGlyphHelper.Tag.Pool pool
      {
        [Token(Token = "0x6001363"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (UnityUITextMeshProGlyphHelper.Tag.Pool) null;
        [Token(Token = "0x6001364"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x6001365")]
      [Address(RVA = "0x397FA0", Offset = "0x396BA0", Length = "0x20")]
      public void ReturnToPool()
      {
      }

      [Token(Token = "0x6001366")]
      protected abstract void Clear();

      [Token(Token = "0x6001367")]
      [Address(RVA = "0x397EB0", Offset = "0x396AB0", Length = "0xE7")]
      public static void Clear(List<UnityUITextMeshProGlyphHelper.Tag> list)
      {
      }

      [Token(Token = "0x2000293")]
      public enum TagType
      {
        [Token(Token = "0x4001221")] ControllerElement,
        [Token(Token = "0x4001222")] Action,
        [Token(Token = "0x4001223")] Player,
      }

      [Token(Token = "0x2000294")]
      public abstract class Pool
      {
        [Token(Token = "0x6001368")]
        public abstract bool Return(UnityUITextMeshProGlyphHelper.Tag obj);

        [Token(Token = "0x6001369")]
        [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
        protected Pool()
        {
        }
      }

      [Token(Token = "0x2000295")]
      public sealed class Pool<T> : UnityUITextMeshProGlyphHelper.Tag.Pool where T : UnityUITextMeshProGlyphHelper.Tag, new()
      {
        [Token(Token = "0x4001224")]
        [FieldOffset(Offset = "0x0")]
        private readonly List<T> _list;

        [Token(Token = "0x600136A")]
        [Address(RVA = "0x11BEF20", Offset = "0x11BDB20", Length = "0x7C")]
        public Pool()
        {
        }

        [Token(Token = "0x600136B")]
        [Address(RVA = "0x11BED10", Offset = "0x11BD910", Length = "0xBC")]
        public T Get() => default (T);

        [Token(Token = "0x600136C")]
        [Address(RVA = "0x11BEDD0", Offset = "0x11BD9D0", Length = "0x147")]
        public override bool Return(UnityUITextMeshProGlyphHelper.Tag obj) => false;
      }
    }

    [Token(Token = "0x2000296")]
    private sealed class ControllerElementTag : UnityUITextMeshProGlyphHelper.Tag
    {
      [Token(Token = "0x4001225")]
      [FieldOffset(Offset = "0x20")]
      public UnityUITextMeshProGlyphHelper.DisplayType type;
      [Token(Token = "0x4001226")]
      [FieldOffset(Offset = "0x24")]
      public int playerId;
      [Token(Token = "0x4001227")]
      [FieldOffset(Offset = "0x28")]
      public int actionId;
      [Token(Token = "0x4001228")]
      [FieldOffset(Offset = "0x2C")]
      public AxisRange actionRange;
      [Token(Token = "0x4001229")]
      [FieldOffset(Offset = "0x30")]
      private readonly List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrText;

      [Token(Token = "0x1700031B")]
      public List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphsOrText
      {
        [Token(Token = "0x600136D"), Address(RVA = "0x36C780", Offset = "0x36B380", Length = "0x5")] get => (List<UnityUITextMeshProGlyphHelper.GlyphOrText>) null;
      }

      [Token(Token = "0x600136E")]
      [Address(RVA = "0x388FE0", Offset = "0x387BE0", Length = "0x1F1")]
      public override string ToString() => (string) null;

      [Token(Token = "0x600136F")]
      [Address(RVA = "0x389AF0", Offset = "0x3886F0", Length = "0x92")]
      public ControllerElementTag()
        : base(new UnityUITextMeshProGlyphHelper.Tag.TagType())
      {
      }

      [Token(Token = "0x6001370")]
      [Address(RVA = "0x388F70", Offset = "0x387B70", Length = "0x6D")]
      protected override void Clear()
      {
      }

      [Token(Token = "0x6001371")]
      [Address(RVA = "0x3891E0", Offset = "0x387DE0", Length = "0x906")]
      public static bool TryParseString(
        string text,
        int startIndex,
        int count,
        StringBuilder sb1,
        StringBuilder sb2,
        Dictionary<string, string> workDictionary,
        UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> pool,
        out UnityUITextMeshProGlyphHelper.ControllerElementTag result)
      {
        result = (UnityUITextMeshProGlyphHelper.ControllerElementTag) null;
        return false;
      }
    }

    [Token(Token = "0x2000297")]
    private sealed class ActionTag : UnityUITextMeshProGlyphHelper.Tag
    {
      [Token(Token = "0x400122A")]
      [FieldOffset(Offset = "0x20")]
      public int actionId;
      [Token(Token = "0x400122B")]
      [FieldOffset(Offset = "0x24")]
      public AxisRange actionRange;
      [Token(Token = "0x400122C")]
      [FieldOffset(Offset = "0x28")]
      private string _displayName;

      [Token(Token = "0x1700031C")]
      public string displayName
      {
        [Token(Token = "0x6001372"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (string) null;
        [Token(Token = "0x6001373"), Address(RVA = "0x386DE0", Offset = "0x3859E0", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x6001374")]
      [Address(RVA = "0x386640", Offset = "0x385240", Length = "0x175")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6001375")]
      [Address(RVA = "0x386DB0", Offset = "0x3859B0", Length = "0x30")]
      public ActionTag()
        : base(new UnityUITextMeshProGlyphHelper.Tag.TagType())
      {
      }

      [Token(Token = "0x6001376")]
      [Address(RVA = "0x386620", Offset = "0x385220", Length = "0x1B")]
      protected override void Clear()
      {
      }

      [Token(Token = "0x6001377")]
      [Address(RVA = "0x3867C0", Offset = "0x3853C0", Length = "0x5EA")]
      public static bool TryParseString(
        string text,
        int startIndex,
        int count,
        StringBuilder sb1,
        StringBuilder sb2,
        Dictionary<string, string> workDictionary,
        UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> pool,
        out UnityUITextMeshProGlyphHelper.ActionTag result)
      {
        result = (UnityUITextMeshProGlyphHelper.ActionTag) null;
        return false;
      }
    }

    [Token(Token = "0x2000298")]
    private sealed class PlayerTag : UnityUITextMeshProGlyphHelper.Tag
    {
      [Token(Token = "0x400122D")]
      [FieldOffset(Offset = "0x20")]
      public int playerId;
      [Token(Token = "0x400122E")]
      [FieldOffset(Offset = "0x28")]
      private string _displayName;

      [Token(Token = "0x1700031D")]
      public string displayName
      {
        [Token(Token = "0x6001378"), Address(RVA = "0x36D750", Offset = "0x36C350", Length = "0x5")] get => (string) null;
        [Token(Token = "0x6001379"), Address(RVA = "0x386DE0", Offset = "0x3859E0", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x600137A")]
      [Address(RVA = "0x390B10", Offset = "0x38F710", Length = "0x121")]
      public override string ToString() => (string) null;

      [Token(Token = "0x600137B")]
      [Address(RVA = "0x3910B0", Offset = "0x38FCB0", Length = "0x30")]
      public PlayerTag()
        : base(new UnityUITextMeshProGlyphHelper.Tag.TagType())
      {
      }

      [Token(Token = "0x600137C")]
      [Address(RVA = "0x390AF0", Offset = "0x38F6F0", Length = "0x1A")]
      protected override void Clear()
      {
      }

      [Token(Token = "0x600137D")]
      [Address(RVA = "0x390C40", Offset = "0x38F840", Length = "0x466")]
      public static bool TryParseString(
        string text,
        int startIndex,
        int count,
        StringBuilder sb1,
        StringBuilder sb2,
        Dictionary<string, string> workDictionary,
        UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> pool,
        out UnityUITextMeshProGlyphHelper.PlayerTag result)
      {
        result = (UnityUITextMeshProGlyphHelper.PlayerTag) null;
        return false;
      }
    }

    [Token(Token = "0x2000299")]
    private struct GlyphOrText : IEquatable<UnityUITextMeshProGlyphHelper.GlyphOrText>
    {
      [Token(Token = "0x400122F")]
      [FieldOffset(Offset = "0x0")]
      public string glyphKey;
      [Token(Token = "0x4001230")]
      [FieldOffset(Offset = "0x8")]
      public Sprite sprite;
      [Token(Token = "0x4001231")]
      [FieldOffset(Offset = "0x10")]
      public string name;

      [Token(Token = "0x600137E")]
      [Address(RVA = "0x38E300", Offset = "0x38CF00", Length = "0xFA")]
      public override bool Equals(object obj) => false;

      [Token(Token = "0x600137F")]
      [Address(RVA = "0x38E400", Offset = "0x38D000", Length = "0x90")]
      public override int GetHashCode() => 0;

      [Token(Token = "0x6001380")]
      [Address(RVA = "0x38E230", Offset = "0x38CE30", Length = "0xCE")]
      public bool Equals(UnityUITextMeshProGlyphHelper.GlyphOrText other) => false;

      [Token(Token = "0x6001381")]
      [Address(RVA = "0x38E4A0", Offset = "0x38D0A0", Length = "0xF0")]
      public static bool operator ==(
        UnityUITextMeshProGlyphHelper.GlyphOrText a,
        UnityUITextMeshProGlyphHelper.GlyphOrText b)
      {
        return false;
      }

      [Token(Token = "0x6001382")]
      [Address(RVA = "0x38E590", Offset = "0x38D190", Length = "0xF5")]
      public static bool operator !=(
        UnityUITextMeshProGlyphHelper.GlyphOrText a,
        UnityUITextMeshProGlyphHelper.GlyphOrText b)
      {
        return false;
      }
    }

    [Token(Token = "0x200029A")]
    private class Asset
    {
      [Token(Token = "0x4001232")]
      [FieldOffset(Offset = "0x10")]
      public readonly uint id;
      [Token(Token = "0x4001233")]
      [FieldOffset(Offset = "0x18")]
      private UnityUITextMeshProGlyphHelper.ITMProSpriteAsset _spriteAsset;
      [Token(Token = "0x4001234")]
      [FieldOffset(Offset = "0x20")]
      private Material _material;
      [Token(Token = "0x4001235")]
      private static uint s_idCounter;
      [Token(Token = "0x4001236")]
      private static Shader __tmProShader;

      [Token(Token = "0x1700031E")]
      public UnityUITextMeshProGlyphHelper.ITMProSpriteAsset spriteAsset
      {
        [Token(Token = "0x6001383"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (UnityUITextMeshProGlyphHelper.ITMProSpriteAsset) null;
      }

      [Token(Token = "0x1700031F")]
      public Material material
      {
        [Token(Token = "0x6001384"), Address(RVA = "0x36C790", Offset = "0x36B390", Length = "0x5")] get => (Material) null;
      }

      [Token(Token = "0x6001385")]
      [Address(RVA = "0x387100", Offset = "0x385D00", Length = "0x39E")]
      public Asset(Material baseMaterial)
      {
      }

      [Token(Token = "0x6001386")]
      [Address(RVA = "0x386DF0", Offset = "0x3859F0", Length = "0x231")]
      public static Material CreateMaterial(Material baseMaterial, uint id) => (Material) null;

      [Token(Token = "0x6001387")]
      [Address(RVA = "0x387030", Offset = "0x385C30", Length = "0xCF")]
      public void Destroy()
      {
      }

      [Token(Token = "0x17000320")]
      private static Shader tmProShader
      {
        [Token(Token = "0x6001388"), Address(RVA = "0x3874A0", Offset = "0x3860A0", Length = "0xEC")] get => (Shader) null;
      }
    }

    [Token(Token = "0x200029B")]
    [Serializable]
    public struct TMProSpriteOptions : IEquatable<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>
    {
      [Tooltip("Scale.")]
      [SerializeField]
      [Token(Token = "0x4001237")]
      [FieldOffset(Offset = "0x0")]
      private float _scale;
      [Tooltip("This value will be multiplied by the Sprite width and height and applied to offset.")]
      [SerializeField]
      [Token(Token = "0x4001238")]
      [FieldOffset(Offset = "0x4")]
      private Vector2 _offsetSizeMultiplier;
      [Tooltip("An extra offset that is cumulative with Offset Size Multiplier.")]
      [SerializeField]
      [Token(Token = "0x4001239")]
      [FieldOffset(Offset = "0xC")]
      private Vector2 _extraOffset;
      [Tooltip("This value will be multiplied by the Sprite width applied to X Advance.")]
      [SerializeField]
      [Token(Token = "0x400123A")]
      [FieldOffset(Offset = "0x14")]
      private float _xAdvanceWidthMultiplier;
      [Tooltip("An extra offset that is cumulative with X Advance Width Multiplier.")]
      [SerializeField]
      [Token(Token = "0x400123B")]
      [FieldOffset(Offset = "0x18")]
      private float _extraXAdvance;

      [Token(Token = "0x17000321")]
      public float scale
      {
        [Token(Token = "0x6001389"), Address(RVA = "0x394B10", Offset = "0x393710", Length = "0x5")] get => 0.0f;
        [Token(Token = "0x600138A"), Address(RVA = "0x394CA0", Offset = "0x3938A0", Length = "0x5")] set
        {
        }
      }

      [Token(Token = "0x17000322")]
      public Vector2 offsetSizeMultiplier
      {
        [Token(Token = "0x600138B"), Address(RVA = "0x394AF0", Offset = "0x3936F0", Length = "0x13")] get => new Vector2();
        [Token(Token = "0x600138C"), Address(RVA = "0x394C90", Offset = "0x393890", Length = "0x5")] set
        {
        }
      }

      [Token(Token = "0x17000323")]
      public Vector2 extraOffset
      {
        [Token(Token = "0x600138D"), Address(RVA = "0x394AD0", Offset = "0x3936D0", Length = "0x13")] get => new Vector2();
        [Token(Token = "0x600138E"), Address(RVA = "0x394C80", Offset = "0x393880", Length = "0x5")] set
        {
        }
      }

      [Token(Token = "0x17000324")]
      public float xAdvanceWidthMultiplier
      {
        [Token(Token = "0x600138F"), Address(RVA = "0x3933A0", Offset = "0x391FA0", Length = "0x6")] get => 0.0f;
        [Token(Token = "0x6001390"), Address(RVA = "0x393400", Offset = "0x392000", Length = "0x6")] set
        {
        }
      }

      [Token(Token = "0x17000325")]
      public float extraXAdvance
      {
        [Token(Token = "0x6001391"), Address(RVA = "0x393390", Offset = "0x391F90", Length = "0x6")] get => 0.0f;
        [Token(Token = "0x6001392"), Address(RVA = "0x3933F0", Offset = "0x391FF0", Length = "0x6")] set
        {
        }
      }

      [Token(Token = "0x17000326")]
      public static UnityUITextMeshProGlyphHelper.TMProSpriteOptions Default
      {
        [Token(Token = "0x6001393"), Address(RVA = "0x394A90", Offset = "0x393690", Length = "0x31")] get => new UnityUITextMeshProGlyphHelper.TMProSpriteOptions();
      }

      [Token(Token = "0x6001394")]
      [Address(RVA = "0x394850", Offset = "0x393450", Length = "0xFD")]
      public override bool Equals(object obj) => false;

      [Token(Token = "0x6001395")]
      [Address(RVA = "0x3949E0", Offset = "0x3935E0", Length = "0xAF")]
      public override int GetHashCode() => 0;

      [Token(Token = "0x6001396")]
      [Address(RVA = "0x394950", Offset = "0x393550", Length = "0x8D")]
      public bool Equals(
        UnityUITextMeshProGlyphHelper.TMProSpriteOptions other)
      {
        return false;
      }

      [Token(Token = "0x6001397")]
      [Address(RVA = "0x394B20", Offset = "0x393720", Length = "0xAB")]
      public static bool operator ==(
        UnityUITextMeshProGlyphHelper.TMProSpriteOptions a,
        UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
      {
        return false;
      }

      [Token(Token = "0x6001398")]
      [Address(RVA = "0x394BD0", Offset = "0x3937D0", Length = "0xA7")]
      public static bool operator !=(
        UnityUITextMeshProGlyphHelper.TMProSpriteOptions a,
        UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
      {
        return false;
      }
    }

    [Token(Token = "0x200029C")]
    [Serializable]
    public struct SpriteMaterialProperties
    {
      [Tooltip("Sprite material color.")]
      [SerializeField]
      [Token(Token = "0x400123C")]
      [FieldOffset(Offset = "0x0")]
      private Color _color;

      [Token(Token = "0x17000327")]
      public Color color
      {
        [Token(Token = "0x6001399"), Address(RVA = "0x394430", Offset = "0x393030", Length = "0xA")] get => new Color();
        [Token(Token = "0x600139A"), Address(RVA = "0x394440", Offset = "0x393040", Length = "0x7")] set
        {
        }
      }

      [Token(Token = "0x17000328")]
      public static UnityUITextMeshProGlyphHelper.SpriteMaterialProperties Default
      {
        [Token(Token = "0x600139B"), Address(RVA = "0x394420", Offset = "0x393020", Length = "0xE")] get => new UnityUITextMeshProGlyphHelper.SpriteMaterialProperties();
      }
    }

    [Token(Token = "0x200029D")]
    private interface ITMProSprite
    {
      [Token(Token = "0x17000329")]
      uint id { [Token(Token = "0x600139C")] get; [Token(Token = "0x600139D")] set; }

      [Token(Token = "0x1700032A")]
      float width { [Token(Token = "0x600139E")] get; [Token(Token = "0x600139F")] set; }

      [Token(Token = "0x1700032B")]
      float height { [Token(Token = "0x60013A0")] get; [Token(Token = "0x60013A1")] set; }

      [Token(Token = "0x1700032C")]
      float xOffset { [Token(Token = "0x60013A2")] get; [Token(Token = "0x60013A3")] set; }

      [Token(Token = "0x1700032D")]
      float yOffset { [Token(Token = "0x60013A4")] get; [Token(Token = "0x60013A5")] set; }

      [Token(Token = "0x1700032E")]
      float xAdvance { [Token(Token = "0x60013A6")] get; [Token(Token = "0x60013A7")] set; }

      [Token(Token = "0x1700032F")]
      Vector2 position { [Token(Token = "0x60013A8")] get; [Token(Token = "0x60013A9")] set; }

      [Token(Token = "0x17000330")]
      Vector2 pivot { [Token(Token = "0x60013AA")] get; [Token(Token = "0x60013AB")] set; }

      [Token(Token = "0x17000331")]
      float scale { [Token(Token = "0x60013AC")] get; [Token(Token = "0x60013AD")] set; }

      [Token(Token = "0x17000332")]
      string name { [Token(Token = "0x60013AE")] get; [Token(Token = "0x60013AF")] set; }

      [Token(Token = "0x17000333")]
      uint unicode { [Token(Token = "0x60013B0")] get; [Token(Token = "0x60013B1")] set; }

      [Token(Token = "0x17000334")]
      int hashCode { [Token(Token = "0x60013B2")] get; [Token(Token = "0x60013B3")] set; }

      [Token(Token = "0x17000335")]
      Sprite sprite { [Token(Token = "0x60013B4")] get; [Token(Token = "0x60013B5")] set; }
    }

    [Token(Token = "0x200029E")]
    private interface ITMProSpriteAsset
    {
      [Token(Token = "0x17000336")]
      int spriteCount { [Token(Token = "0x60013B6")] get; }

      [Token(Token = "0x17000337")]
      Texture spriteSheet { [Token(Token = "0x60013B7")] get; [Token(Token = "0x60013B8")] set; }

      [Token(Token = "0x60013B9")]
      TMP_SpriteAsset GetSpriteAsset();

      [Token(Token = "0x60013BA")]
      UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index);

      [Token(Token = "0x60013BB")]
      void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite);

      [Token(Token = "0x60013BC")]
      bool Contains(string spriteName);

      [Token(Token = "0x60013BD")]
      void Clear();

      [Token(Token = "0x60013BE")]
      void UpdateLookupTables();

      [Token(Token = "0x60013BF")]
      void Destroy();
    }

    [Token(Token = "0x200029F")]
    private static class TMProAssetVersionHelper
    {
      [Token(Token = "0x400123D")]
      private static bool _isVersionSupportedChecked;

      [Token(Token = "0x60013C0")]
      [Address(RVA = "0x394450", Offset = "0x393050", Length = "0x42")]
      private static bool CheckVersionSupported() => false;

      [Token(Token = "0x60013C1")]
      [Address(RVA = "0x394680", Offset = "0x393280", Length = "0x1C8")]
      public static UnityUITextMeshProGlyphHelper.ITMProSprite CreateSprite() => (UnityUITextMeshProGlyphHelper.ITMProSprite) null;

      [Token(Token = "0x60013C2")]
      [Address(RVA = "0x3944A0", Offset = "0x3930A0", Length = "0x1D0")]
      public static UnityUITextMeshProGlyphHelper.ITMProSpriteAsset CreateSpriteAsset() => (UnityUITextMeshProGlyphHelper.ITMProSpriteAsset) null;
    }

    [Token(Token = "0x20002A0")]
    private class TMProSprite_AssetV1_0_0 : UnityUITextMeshProGlyphHelper.ITMProSprite
    {
      [Token(Token = "0x400123E")]
      [FieldOffset(Offset = "0x10")]
      public TMP_Sprite spriteInfo;

      [Token(Token = "0x60013C3")]
      [Address(RVA = "0x394CB0", Offset = "0x3938B0", Length = "0x66")]
      public TMProSprite_AssetV1_0_0()
      {
      }

      [Token(Token = "0x17000338")]
      public uint id
      {
        [Token(Token = "0x60013C4"), Address(RVA = "0x394D60", Offset = "0x393960", Length = "0x1A")] get => 0;
        [Token(Token = "0x60013C5"), Address(RVA = "0x394F20", Offset = "0x393B20", Length = "0x1A")] set
        {
        }
      }

      [Token(Token = "0x17000339")]
      public float width
      {
        [Token(Token = "0x60013C6"), Address(RVA = "0x394E60", Offset = "0x393A60", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013C7"), Address(RVA = "0x395060", Offset = "0x393C60", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x1700033A")]
      public float height
      {
        [Token(Token = "0x60013C8"), Address(RVA = "0x394D40", Offset = "0x393940", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013C9"), Address(RVA = "0x394F00", Offset = "0x393B00", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x1700033B")]
      public float xOffset
      {
        [Token(Token = "0x60013CA"), Address(RVA = "0x394EA0", Offset = "0x393AA0", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013CB"), Address(RVA = "0x3950A0", Offset = "0x393CA0", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x1700033C")]
      public float yOffset
      {
        [Token(Token = "0x60013CC"), Address(RVA = "0x394EC0", Offset = "0x393AC0", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013CD"), Address(RVA = "0x3950C0", Offset = "0x393CC0", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x1700033D")]
      public float xAdvance
      {
        [Token(Token = "0x60013CE"), Address(RVA = "0x394E80", Offset = "0x393A80", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013CF"), Address(RVA = "0x395080", Offset = "0x393C80", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x1700033E")]
      public Vector2 position
      {
        [Token(Token = "0x60013D0"), Address(RVA = "0x394DD0", Offset = "0x3939D0", Length = "0x29")] get => new Vector2();
        [Token(Token = "0x60013D1"), Address(RVA = "0x394FB0", Offset = "0x393BB0", Length = "0x32")] set
        {
        }
      }

      [Token(Token = "0x1700033F")]
      public Vector2 pivot
      {
        [Token(Token = "0x60013D2"), Address(RVA = "0x394DA0", Offset = "0x3939A0", Length = "0x29")] get => new Vector2();
        [Token(Token = "0x60013D3"), Address(RVA = "0x394F70", Offset = "0x393B70", Length = "0x32")] set
        {
        }
      }

      [Token(Token = "0x17000340")]
      public float scale
      {
        [Token(Token = "0x60013D4"), Address(RVA = "0x394E00", Offset = "0x393A00", Length = "0x1C")] get => 0.0f;
        [Token(Token = "0x60013D5"), Address(RVA = "0x394FF0", Offset = "0x393BF0", Length = "0x1C")] set
        {
        }
      }

      [Token(Token = "0x17000341")]
      public string name
      {
        [Token(Token = "0x60013D6"), Address(RVA = "0x394D80", Offset = "0x393980", Length = "0x1B")] get => (string) null;
        [Token(Token = "0x60013D7"), Address(RVA = "0x394F40", Offset = "0x393B40", Length = "0x23")] set
        {
        }
      }

      [Token(Token = "0x17000342")]
      public uint unicode
      {
        [Token(Token = "0x60013D8"), Address(RVA = "0x394E40", Offset = "0x393A40", Length = "0x1A")] get => 0;
        [Token(Token = "0x60013D9"), Address(RVA = "0x395040", Offset = "0x393C40", Length = "0x1A")] set
        {
        }
      }

      [Token(Token = "0x17000343")]
      public int hashCode
      {
        [Token(Token = "0x60013DA"), Address(RVA = "0x394D20", Offset = "0x393920", Length = "0x1A")] get => 0;
        [Token(Token = "0x60013DB"), Address(RVA = "0x394EE0", Offset = "0x393AE0", Length = "0x1A")] set
        {
        }
      }

      [Token(Token = "0x17000344")]
      public Sprite sprite
      {
        [Token(Token = "0x60013DC"), Address(RVA = "0x394E20", Offset = "0x393A20", Length = "0x1B")] get => (Sprite) null;
        [Token(Token = "0x60013DD"), Address(RVA = "0x395010", Offset = "0x393C10", Length = "0x23")] set
        {
        }
      }

      [Token(Token = "0x20002A1")]
      public class TMPro_SpriteAsset : UnityUITextMeshProGlyphHelper.ITMProSpriteAsset
      {
        [Token(Token = "0x400123F")]
        [FieldOffset(Offset = "0x10")]
        private TMP_SpriteAsset _spriteAsset;
        [Token(Token = "0x4001240")]
        [FieldOffset(Offset = "0x18")]
        private readonly List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0> _sprites;

        [Token(Token = "0x17000345")]
        public int spriteCount
        {
          [Token(Token = "0x60013DE"), Address(RVA = "0x396F70", Offset = "0x395B70", Length = "0x3C")] get => 0;
        }

        [Token(Token = "0x17000346")]
        public Texture spriteSheet
        {
          [Token(Token = "0x60013DF"), Address(RVA = "0x396FB0", Offset = "0x395BB0", Length = "0x1E")] get => (Texture) null;
          [Token(Token = "0x60013E0"), Address(RVA = "0x397020", Offset = "0x395C20", Length = "0x29")] set
          {
          }
        }

        [Token(Token = "0x60013E1")]
        [Address(RVA = "0x396E00", Offset = "0x395A00", Length = "0x12E")]
        public TMPro_SpriteAsset()
        {
        }

        [Token(Token = "0x60013E2")]
        [Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")]
        public TMP_SpriteAsset GetSpriteAsset() => (TMP_SpriteAsset) null;

        [Token(Token = "0x60013E3")]
        [Address(RVA = "0x396830", Offset = "0x395430", Length = "0x72")]
        public UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index) => (UnityUITextMeshProGlyphHelper.ITMProSprite) null;

        [Token(Token = "0x60013E4")]
        [Address(RVA = "0x396130", Offset = "0x394D30", Length = "0x214")]
        public void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite)
        {
        }

        [Token(Token = "0x60013E5")]
        [Address(RVA = "0x3963F0", Offset = "0x394FF0", Length = "0xA1")]
        public void Clear()
        {
        }

        [Token(Token = "0x60013E6")]
        [Address(RVA = "0x3965A0", Offset = "0x3951A0", Length = "0xB6")]
        public bool Contains(string spriteName) => false;

        [Token(Token = "0x60013E7")]
        [Address(RVA = "0x3968D0", Offset = "0x3954D0", Length = "0x1D")]
        public void UpdateLookupTables()
        {
        }

        [Token(Token = "0x60013E8")]
        [Address(RVA = "0x396700", Offset = "0x395300", Length = "0x94")]
        public void Destroy()
        {
        }
      }
    }

    [Token(Token = "0x20002A2")]
    private class TMProSprite_AssetV1_1_0 : UnityUITextMeshProGlyphHelper.ITMProSprite
    {
      [Token(Token = "0x4001241")]
      [FieldOffset(Offset = "0x10")]
      private readonly UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph _spriteGlyph;
      [Token(Token = "0x4001242")]
      [FieldOffset(Offset = "0x18")]
      private readonly UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter _spriteCharacter;
      [Token(Token = "0x4001243")]
      private static bool? s_isVersionSupported;

      [Token(Token = "0x60013E9")]
      [Address(RVA = "0x395250", Offset = "0x393E50", Length = "0xCB")]
      public TMProSprite_AssetV1_1_0()
      {
      }

      [Token(Token = "0x17000347")]
      public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph spriteGlyph
      {
        [Token(Token = "0x60013EA"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get => (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph) null;
      }

      [Token(Token = "0x17000348")]
      public UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter spriteCharacter
      {
        [Token(Token = "0x60013EB"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter) null;
      }

      [Token(Token = "0x17000349")]
      public uint id
      {
        [Token(Token = "0x60013EC"), Address(RVA = "0x395390", Offset = "0x393F90", Length = "0x26")] get => 0;
        [Token(Token = "0x60013ED"), Address(RVA = "0x395900", Offset = "0x394500", Length = "0x85")] set
        {
        }
      }

      [Token(Token = "0x1700034A")]
      public float width
      {
        [Token(Token = "0x60013EE"), Address(RVA = "0x395630", Offset = "0x394230", Length = "0x56")] get => 0.0f;
        [Token(Token = "0x60013EF"), Address(RVA = "0x395BB0", Offset = "0x3947B0", Length = "0x14C")] set
        {
        }
      }

      [Token(Token = "0x1700034B")]
      public float height
      {
        [Token(Token = "0x60013F0"), Address(RVA = "0x395330", Offset = "0x393F30", Length = "0x56")] get => 0.0f;
        [Token(Token = "0x60013F1"), Address(RVA = "0x3957B0", Offset = "0x3943B0", Length = "0x14C")] set
        {
        }
      }

      [Token(Token = "0x1700034C")]
      public float xOffset
      {
        [Token(Token = "0x60013F2"), Address(RVA = "0x3956F0", Offset = "0x3942F0", Length = "0x56")] get => 0.0f;
        [Token(Token = "0x60013F3"), Address(RVA = "0x395DA0", Offset = "0x3949A0", Length = "0x9E")] set
        {
        }
      }

      [Token(Token = "0x1700034D")]
      public float yOffset
      {
        [Token(Token = "0x60013F4"), Address(RVA = "0x395750", Offset = "0x394350", Length = "0x56")] get => 0.0f;
        [Token(Token = "0x60013F5"), Address(RVA = "0x395E40", Offset = "0x394A40", Length = "0x9E")] set
        {
        }
      }

      [Token(Token = "0x1700034E")]
      public float xAdvance
      {
        [Token(Token = "0x60013F6"), Address(RVA = "0x395690", Offset = "0x394290", Length = "0x56")] get => 0.0f;
        [Token(Token = "0x60013F7"), Address(RVA = "0x395D00", Offset = "0x394900", Length = "0x9E")] set
        {
        }
      }

      [Token(Token = "0x1700034F")]
      public Vector2 position
      {
        [Token(Token = "0x60013F8"), Address(RVA = "0x395430", Offset = "0x394030", Length = "0xB6")] get => new Vector2();
        [Token(Token = "0x60013F9"), Address(RVA = "0x3959C0", Offset = "0x3945C0", Length = "0xD1")] set
        {
        }
      }

      [Token(Token = "0x17000350")]
      public Vector2 pivot
      {
        [Token(Token = "0x60013FA"), Address(RVA = "0x395420", Offset = "0x394020", Length = "0x8")] get => new Vector2();
        [Token(Token = "0x60013FB"), Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")] set
        {
        }
      }

      [Token(Token = "0x17000351")]
      public float scale
      {
        [Token(Token = "0x60013FC"), Address(RVA = "0x3954F0", Offset = "0x3940F0", Length = "0x5A")] get => 0.0f;
        [Token(Token = "0x60013FD"), Address(RVA = "0x395AA0", Offset = "0x3946A0", Length = "0x66")] set
        {
        }
      }

      [Token(Token = "0x17000352")]
      public string name
      {
        [Token(Token = "0x60013FE"), Address(RVA = "0x3953C0", Offset = "0x393FC0", Length = "0x51")] get => (string) null;
        [Token(Token = "0x60013FF"), Address(RVA = "0x395990", Offset = "0x394590", Length = "0x2E")] set
        {
        }
      }

      [Token(Token = "0x17000353")]
      public uint unicode
      {
        [Token(Token = "0x6001400"), Address(RVA = "0x3955D0", Offset = "0x3941D0", Length = "0x58")] get => 0;
        [Token(Token = "0x6001401"), Address(RVA = "0x395B40", Offset = "0x394740", Length = "0x6E")] set
        {
        }
      }

      [Token(Token = "0x17000354")]
      public int hashCode
      {
        [Token(Token = "0x6001402"), Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")] get => 0;
        [Token(Token = "0x6001403"), Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")] set
        {
        }
      }

      [Token(Token = "0x17000355")]
      public Sprite sprite
      {
        [Token(Token = "0x6001404"), Address(RVA = "0x395550", Offset = "0x394150", Length = "0x7B")] get => (Sprite) null;
        [Token(Token = "0x6001405"), Address(RVA = "0x395B10", Offset = "0x394710", Length = "0x2E")] set
        {
        }
      }

      [Token(Token = "0x6001406")]
      [Address(RVA = "0x3950E0", Offset = "0x393CE0", Length = "0x165")]
      public static bool CheckVersionSupported() => false;

      [Token(Token = "0x20002A3")]
      public class TMPro_SpriteCharacter
      {
        [Token(Token = "0x4001244")]
        private const string typeFullName = "TMPro.TMP_SpriteCharacter";
        [Token(Token = "0x4001245")]
        [FieldOffset(Offset = "0x10")]
        private readonly object _source;
        [Token(Token = "0x4001246")]
        [FieldOffset(Offset = "0x18")]
        private readonly PropertyInfo _glyph;
        [Token(Token = "0x4001247")]
        [FieldOffset(Offset = "0x20")]
        private readonly PropertyInfo _unicode;
        [Token(Token = "0x4001248")]
        [FieldOffset(Offset = "0x28")]
        private readonly PropertyInfo _name;
        [Token(Token = "0x4001249")]
        [FieldOffset(Offset = "0x30")]
        private readonly PropertyInfo _scale;
        [Token(Token = "0x400124A")]
        [FieldOffset(Offset = "0x38")]
        private readonly PropertyInfo _glyphIndex;
        [Token(Token = "0x400124B")]
        private static System.Type s_type;

        [Token(Token = "0x17000356")]
        public object source
        {
          [Token(Token = "0x6001407"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get => (object) null;
        }

        [Token(Token = "0x17000357")]
        public Glyph glyph
        {
          [Token(Token = "0x6001408"), Address(RVA = "0x397670", Offset = "0x396270", Length = "0x8A")] get => (Glyph) null;
          [Token(Token = "0x6001409"), Address(RVA = "0x397860", Offset = "0x396460", Length = "0x28")] set
          {
          }
        }

        [Token(Token = "0x17000358")]
        public uint unicode
        {
          [Token(Token = "0x600140A"), Address(RVA = "0x3977B0", Offset = "0x3963B0", Length = "0x52")] get => 0;
          [Token(Token = "0x600140B"), Address(RVA = "0x397910", Offset = "0x396510", Length = "0x57")] set
          {
          }
        }

        [Token(Token = "0x17000359")]
        public string name
        {
          [Token(Token = "0x600140C"), Address(RVA = "0x397700", Offset = "0x396300", Length = "0x4B")] get => (string) null;
          [Token(Token = "0x600140D"), Address(RVA = "0x397890", Offset = "0x396490", Length = "0x28")] set
          {
          }
        }

        [Token(Token = "0x1700035A")]
        public float scale
        {
          [Token(Token = "0x600140E"), Address(RVA = "0x397750", Offset = "0x396350", Length = "0x54")] get => 0.0f;
          [Token(Token = "0x600140F"), Address(RVA = "0x3978C0", Offset = "0x3964C0", Length = "0x4F")] set
          {
          }
        }

        [Token(Token = "0x1700035B")]
        public uint glyphIndex
        {
          [Token(Token = "0x6001410"), Address(RVA = "0x397610", Offset = "0x396210", Length = "0x52")] get => 0;
          [Token(Token = "0x6001411"), Address(RVA = "0x397810", Offset = "0x396410", Length = "0x4D")] set
          {
          }
        }

        [Token(Token = "0x6001412")]
        [Address(RVA = "0x397210", Offset = "0x395E10", Length = "0x3FC")]
        public TMPro_SpriteCharacter()
        {
        }

        [Token(Token = "0x6001413")]
        [Address(RVA = "0x397050", Offset = "0x395C50", Length = "0x1B6")]
        private static System.Type GetReflectedType() => (System.Type) null;
      }

      [Token(Token = "0x20002A4")]
      public class TMPro_SpriteGlyph
      {
        [Token(Token = "0x400124C")]
        private const string typeFullName = "TMPro.TMP_SpriteGlyph";
        [Token(Token = "0x400124D")]
        [FieldOffset(Offset = "0x10")]
        private readonly Glyph _source;
        [Token(Token = "0x400124E")]
        [FieldOffset(Offset = "0x18")]
        private readonly FieldInfo _sprite;
        [Token(Token = "0x400124F")]
        private static System.Type s_type;

        [Token(Token = "0x1700035C")]
        public Glyph source
        {
          [Token(Token = "0x6001414"), Address(RVA = "0x36D7C0", Offset = "0x36C3C0", Length = "0x5")] get => (Glyph) null;
        }

        [Token(Token = "0x1700035D")]
        public Sprite sprite
        {
          [Token(Token = "0x6001415"), Address(RVA = "0x397E00", Offset = "0x396A00", Length = "0x75")] get => (Sprite) null;
          [Token(Token = "0x6001416"), Address(RVA = "0x397E80", Offset = "0x396A80", Length = "0x28")] set
          {
          }
        }

        [Token(Token = "0x6001417")]
        [Address(RVA = "0x397B70", Offset = "0x396770", Length = "0x28D")]
        public TMPro_SpriteGlyph()
        {
        }

        [Token(Token = "0x6001418")]
        [Address(RVA = "0x397970", Offset = "0x396570", Length = "0x1B6")]
        private static System.Type GetReflectedType() => (System.Type) null;

        [Token(Token = "0x6001419")]
        [Address(RVA = "0x397B30", Offset = "0x396730", Length = "0x35")]
        private static void Initialize(Glyph glyph)
        {
        }
      }

      [Token(Token = "0x20002A5")]
      public class TMPro_SpriteAsset : UnityUITextMeshProGlyphHelper.ITMProSpriteAsset
      {
        [Token(Token = "0x4001250")]
        [FieldOffset(Offset = "0x10")]
        private readonly PropertyInfo _spriteCharacterTable;
        [Token(Token = "0x4001251")]
        [FieldOffset(Offset = "0x18")]
        private readonly PropertyInfo _spriteGlyphTable;
        [Token(Token = "0x4001252")]
        [FieldOffset(Offset = "0x20")]
        private readonly IList _spriteCharacterTableList;
        [Token(Token = "0x4001253")]
        [FieldOffset(Offset = "0x28")]
        private readonly IList _spriteGlyphTableList;
        [Token(Token = "0x4001254")]
        [FieldOffset(Offset = "0x30")]
        private readonly List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0> _sprites;
        [Token(Token = "0x4001255")]
        [FieldOffset(Offset = "0x38")]
        private TMP_SpriteAsset _spriteAsset;

        [Token(Token = "0x1700035E")]
        public int spriteCount
        {
          [Token(Token = "0x600141A"), Address(RVA = "0x396F30", Offset = "0x395B30", Length = "0x3C")] get => 0;
        }

        [Token(Token = "0x1700035F")]
        public Texture spriteSheet
        {
          [Token(Token = "0x600141B"), Address(RVA = "0x396FD0", Offset = "0x395BD0", Length = "0x1E")] get => (Texture) null;
          [Token(Token = "0x600141C"), Address(RVA = "0x396FF0", Offset = "0x395BF0", Length = "0x29")] set
          {
          }
        }

        [Token(Token = "0x600141D")]
        [Address(RVA = "0x3968F0", Offset = "0x3954F0", Length = "0x502")]
        public TMPro_SpriteAsset()
        {
        }

        [Token(Token = "0x600141E")]
        [Address(RVA = "0x3967A0", Offset = "0x3953A0", Length = "0x5")]
        public TMP_SpriteAsset GetSpriteAsset() => (TMP_SpriteAsset) null;

        [Token(Token = "0x600141F")]
        [Address(RVA = "0x3967B0", Offset = "0x3953B0", Length = "0x72")]
        public UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index) => (UnityUITextMeshProGlyphHelper.ITMProSprite) null;

        [Token(Token = "0x6001420")]
        [Address(RVA = "0x395EE0", Offset = "0x394AE0", Length = "0x247")]
        public void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite)
        {
        }

        [Token(Token = "0x6001421")]
        [Address(RVA = "0x396350", Offset = "0x394F50", Length = "0x9F")]
        public void Clear()
        {
        }

        [Token(Token = "0x6001422")]
        [Address(RVA = "0x3964A0", Offset = "0x3950A0", Length = "0xF6")]
        public bool Contains(string spriteName) => false;

        [Token(Token = "0x6001423")]
        [Address(RVA = "0x3968B0", Offset = "0x3954B0", Length = "0x1D")]
        public void UpdateLookupTables()
        {
        }

        [Token(Token = "0x6001424")]
        [Address(RVA = "0x396660", Offset = "0x395260", Length = "0x94")]
        public void Destroy()
        {
        }
      }
    }

    [Token(Token = "0x20002A6")]
    private enum DisplayType
    {
      [Token(Token = "0x4001257")] Glyph,
      [Token(Token = "0x4001258")] Text,
      [Token(Token = "0x4001259")] GlyphOrText,
    }
  }
}
