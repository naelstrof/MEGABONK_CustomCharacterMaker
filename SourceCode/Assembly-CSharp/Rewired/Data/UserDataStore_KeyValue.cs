// Decompiled with JetBrains decompiler
// Type: Rewired.Data.UserDataStore_KeyValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Rewired.Data
{
  [Token(Token = "0x200024E")]
  public abstract class UserDataStore_KeyValue : UserDataStore
  {
    [Token(Token = "0x4001117")]
    private static readonly string thisScriptName;
    [Token(Token = "0x4001118")]
    private const string logPrefix = "Rewired: ";
    [Token(Token = "0x4001119")]
    private const string key_controllerAssignments = "ControllerAssignments";
    [Token(Token = "0x400111A")]
    private const int controllerMapKeyVersion = 0;
    [Token(Token = "0x400111B")]
    private const int controllerElementByRoleMapKeyVersion = 0;
    [Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
    [SerializeField]
    [Token(Token = "0x400111C")]
    [FieldOffset(Offset = "0x20")]
    private bool _isEnabled;
    [Tooltip("Should saved data be loaded on start?")]
    [SerializeField]
    [Token(Token = "0x400111D")]
    [FieldOffset(Offset = "0x21")]
    private bool _loadDataOnStart;
    [Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
    [SerializeField]
    [Token(Token = "0x400111E")]
    [FieldOffset(Offset = "0x22")]
    private bool _loadJoystickAssignments;
    [Tooltip("Should Player Keyboard assignments be saved and loaded?")]
    [SerializeField]
    [Token(Token = "0x400111F")]
    [FieldOffset(Offset = "0x23")]
    private bool _loadKeyboardAssignments;
    [Tooltip("Should Player Mouse assignments be saved and loaded?")]
    [SerializeField]
    [Token(Token = "0x4001120")]
    [FieldOffset(Offset = "0x24")]
    private bool _loadMouseAssignments;
    [Tooltip("How should Action mapping data be saved?\n\nBy Controller: Data is stored per-controller. Action mappings apply only to the specific controller for which it was saved.\n\nBy Controller Element Role: Data is stored per-element on the controller if the controller element has a known role. Action mappings are mirrored on controller elements with the same role on all other controllers for the Player. Example: When saving Action mappings for a gamepad, element on all gamepads that have the same roles will inherit the mappings. This allows you to remap once for all compatible gamepads simultaneously, for example. This can extend beyond just gamepads, however. For example: On a console platform, a racing wheel with A, B, X, Y, D-Pad etc. elements will also reflect the same Action mappings if the gamepad is remapped. Action mappings for any controller elements that do not have known roles will be saved per-controller. Warning: Do not use this mode if you need to allow a Player to save different mappings for multiple controllers of the same type such as gamepads. (This option currently works best for gamepads and only miminally for other controller types.)")]
    [SerializeField]
    [Token(Token = "0x4001121")]
    [FieldOffset(Offset = "0x28")]
    private UserDataStore_KeyValue.ActionMappingSaveMode _actionMappingSaveMode;
    [Token(Token = "0x4001122")]
    [FieldOffset(Offset = "0x2C")]
    [NonSerialized]
    private bool _allowImpreciseJoystickAssignmentMatching;
    [Token(Token = "0x4001123")]
    [FieldOffset(Offset = "0x2D")]
    [NonSerialized]
    private bool _deferredJoystickAssignmentLoadPending;
    [Token(Token = "0x4001124")]
    [FieldOffset(Offset = "0x2E")]
    [NonSerialized]
    private bool _wasJoystickEverDetected;
    [Token(Token = "0x4001125")]
    [FieldOffset(Offset = "0x30")]
    [NonSerialized]
    private List<int> __allActionIds;
    [Token(Token = "0x4001126")]
    [FieldOffset(Offset = "0x38")]
    [NonSerialized]
    private string __allActionIdsString;
    [Token(Token = "0x4001127")]
    [FieldOffset(Offset = "0x40")]
    [NonSerialized]
    private readonly StringBuilder _sb;
    [Token(Token = "0x4001128")]
    [FieldOffset(Offset = "0x48")]
    [NonSerialized]
    private Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> _tempElementByRoleMaps;
    [Token(Token = "0x4001129")]
    [FieldOffset(Offset = "0x50")]
    [NonSerialized]
    private Dictionary<string, bool> _tempElementByRoleMapsEnabled;

    [Token(Token = "0x17000285")]
    public bool isEnabled
    {
      [Token(Token = "0x6001093"), Address(RVA = "0x36EB80", Offset = "0x36D780", Length = "0x5")] get => false;
      [Token(Token = "0x6001094"), Address(RVA = "0x386410", Offset = "0x385010", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000286")]
    public bool loadDataOnStart
    {
      [Token(Token = "0x6001095"), Address(RVA = "0x385F50", Offset = "0x384B50", Length = "0x5")] get => false;
      [Token(Token = "0x6001096"), Address(RVA = "0x386420", Offset = "0x385020", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000287")]
    public bool loadJoystickAssignments
    {
      [Token(Token = "0x6001097"), Address(RVA = "0x385F60", Offset = "0x384B60", Length = "0x5")] get => false;
      [Token(Token = "0x6001098"), Address(RVA = "0x386430", Offset = "0x385030", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000288")]
    public bool loadKeyboardAssignments
    {
      [Token(Token = "0x6001099"), Address(RVA = "0x385F70", Offset = "0x384B70", Length = "0x5")] get => false;
      [Token(Token = "0x600109A"), Address(RVA = "0x386440", Offset = "0x385040", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x17000289")]
    public bool loadMouseAssignments
    {
      [Token(Token = "0x600109B"), Address(RVA = "0x385F80", Offset = "0x384B80", Length = "0x5")] get => false;
      [Token(Token = "0x600109C"), Address(RVA = "0x386450", Offset = "0x385050", Length = "0x138")] set
      {
      }
    }

    [Token(Token = "0x1700028A")]
    public UserDataStore_KeyValue.ActionMappingSaveMode actionMappingSaveMode
    {
      [Token(Token = "0x600109D"), Address(RVA = "0x36C770", Offset = "0x36B370", Length = "0x4")] get => new UserDataStore_KeyValue.ActionMappingSaveMode();
      [Token(Token = "0x600109E"), Address(RVA = "0x36C7A0", Offset = "0x36B3A0", Length = "0x4")] set
      {
      }
    }

    [Token(Token = "0x1700028B")]
    protected abstract UserDataStore_KeyValue.IDataStore dataStore { [Token(Token = "0x600109F")] get; }

    [Token(Token = "0x1700028C")]
    private bool loadControllerAssignments
    {
      [Token(Token = "0x60010A0"), Address(RVA = "0x3863A0", Offset = "0x384FA0", Length = "0x14")] get => false;
    }

    [Token(Token = "0x1700028D")]
    private List<int> allActionIds
    {
      [Token(Token = "0x60010A1"), Address(RVA = "0x53D970", Offset = "0x53C570", Length = "0x2AA")] get => (List<int>) null;
    }

    [Token(Token = "0x1700028E")]
    private string allActionIdsString
    {
      [Token(Token = "0x60010A2"), Address(RVA = "0x53D810", Offset = "0x53C410", Length = "0x153")] get => (string) null;
    }

    [Token(Token = "0x60010A3")]
    [Address(RVA = "0x53D1E0", Offset = "0x53BDE0", Length = "0xD2")]
    public override void Save()
    {
    }

    [Token(Token = "0x60010A4")]
    [Address(RVA = "0x53B280", Offset = "0x539E80", Length = "0x112")]
    public override void SaveControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x60010A5")]
    [Address(RVA = "0x53B180", Offset = "0x539D80", Length = "0xF7")]
    public override void SaveControllerData(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x60010A6")]
    [Address(RVA = "0x53D050", Offset = "0x53BC50", Length = "0x181")]
    public override void SavePlayerData(int playerId)
    {
    }

    [Token(Token = "0x60010A7")]
    [Address(RVA = "0x53C620", Offset = "0x53B220", Length = "0x245")]
    public override void SaveInputBehavior(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x60010A8")]
    [Address(RVA = "0x53A160", Offset = "0x538D60", Length = "0xD2")]
    public override void Load()
    {
    }

    [Token(Token = "0x60010A9")]
    [Address(RVA = "0x536FE0", Offset = "0x535BE0", Length = "0x119")]
    public override void LoadControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x60010AA")]
    [Address(RVA = "0x536EE0", Offset = "0x535AE0", Length = "0xF7")]
    public override void LoadControllerData(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x60010AB")]
    [Address(RVA = "0x53A030", Offset = "0x538C30", Length = "0x12F")]
    public override void LoadPlayerData(int playerId)
    {
    }

    [Token(Token = "0x60010AC")]
    [Address(RVA = "0x538480", Offset = "0x537080", Length = "0x18C")]
    public override void LoadInputBehavior(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x60010AD")]
    [Address(RVA = "0x53A560", Offset = "0x539160", Length = "0x9D")]
    protected override void OnInitialize()
    {
    }

    [Token(Token = "0x60010AE")]
    [Address(RVA = "0x53A240", Offset = "0x538E40", Length = "0xCD")]
    protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x60010AF")]
    [Address(RVA = "0x53A530", Offset = "0x539130", Length = "0x2E")]
    protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x60010B0")]
    [Address(RVA = "0x53A310", Offset = "0x538F10", Length = "0x20")]
    protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
    {
    }

    [Token(Token = "0x60010B1")]
    [Address(RVA = "0x53BDE0", Offset = "0x53A9E0", Length = "0xC9")]
    public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x60010B2")]
    [Address(RVA = "0x537500", Offset = "0x536100", Length = "0xCE")]
    public override ControllerMap LoadControllerMap(
      int playerId,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (ControllerMap) null;
    }

    [Token(Token = "0x60010B3")]
    [Address(RVA = "0x5357A0", Offset = "0x5343A0", Length = "0x5E")]
    public virtual void ClearSaveData()
    {
    }

    [Token(Token = "0x60010B4")]
    [Address(RVA = "0x536AC0", Offset = "0x5356C0", Length = "0x1FF")]
    private int LoadAll() => 0;

    [Token(Token = "0x60010B5")]
    [Address(RVA = "0x539D00", Offset = "0x538900", Length = "0x76")]
    private int LoadPlayerDataNow(int playerId) => 0;

    [Token(Token = "0x60010B6")]
    [Address(RVA = "0x539D80", Offset = "0x538980", Length = "0x2AD")]
    private int LoadPlayerDataNow(Player player) => 0;

    [Token(Token = "0x60010B7")]
    [Address(RVA = "0x536830", Offset = "0x535430", Length = "0x287")]
    private int LoadAllJoystickCalibrationData() => 0;

    [Token(Token = "0x60010B8")]
    [Address(RVA = "0x539580", Offset = "0x538180", Length = "0xCC")]
    private int LoadJoystickCalibrationData(Joystick joystick) => 0;

    [Token(Token = "0x60010B9")]
    [Address(RVA = "0x539650", Offset = "0x538250", Length = "0x76")]
    private int LoadJoystickCalibrationData(int joystickId) => 0;

    [Token(Token = "0x60010BA")]
    [Address(RVA = "0x5396D0", Offset = "0x5382D0", Length = "0x316")]
    private int LoadJoystickData(int joystickId) => 0;

    [Token(Token = "0x60010BB")]
    [Address(RVA = "0x536E60", Offset = "0x535A60", Length = "0x73")]
    private int LoadControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      return 0;
    }

    [Token(Token = "0x60010BC")]
    [Address(RVA = "0x536E40", Offset = "0x535A40", Length = "0x15")]
    private int LoadControllerDataNow(ControllerType controllerType, int controllerId) => 0;

    [Token(Token = "0x60010BD")]
    [Address(RVA = "0x5375D0", Offset = "0x5361D0", Length = "0xCAD")]
    private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) => 0;

    [Token(Token = "0x60010BE")]
    [Address(RVA = "0x537300", Offset = "0x535F00", Length = "0x1F4")]
    private ControllerMap LoadControllerMap(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (ControllerMap) null;
    }

    [Token(Token = "0x60010BF")]
    [Address(RVA = "0x537100", Offset = "0x535D00", Length = "0x1F3")]
    private bool LoadControllerElementMapByRole(
      Player player,
      Controller controller,
      string role,
      int mapCategoryId,
      int layoutId,
      Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> elementByRoleMaps)
    {
      return false;
    }

    [Token(Token = "0x60010C0")]
    [Address(RVA = "0x538610", Offset = "0x537210", Length = "0x230")]
    private int LoadInputBehaviors(int playerId) => 0;

    [Token(Token = "0x60010C1")]
    [Address(RVA = "0x5383A0", Offset = "0x536FA0", Length = "0xD3")]
    private int LoadInputBehaviorNow(int playerId, int behaviorId) => 0;

    [Token(Token = "0x60010C2")]
    [Address(RVA = "0x538280", Offset = "0x536E80", Length = "0x116")]
    private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) => 0;

    [Token(Token = "0x60010C3")]
    [Address(RVA = "0x536DD0", Offset = "0x5359D0", Length = "0x67")]
    private bool LoadControllerAssignmentsNow() => false;

    [Token(Token = "0x60010C4")]
    [Address(RVA = "0x5399F0", Offset = "0x5385F0", Length = "0x30D")]
    private bool LoadKeyboardAndMouseAssignmentsNow(
      UserDataStore_KeyValue.ControllerAssignmentSaveInfo data)
    {
      return false;
    }

    [Token(Token = "0x60010C5")]
    [Address(RVA = "0x5388C0", Offset = "0x5374C0", Length = "0xCB3")]
    private bool LoadJoystickAssignmentsNow(
      UserDataStore_KeyValue.ControllerAssignmentSaveInfo data)
    {
      return false;
    }

    [Token(Token = "0x60010C6")]
    [Address(RVA = "0x536CC0", Offset = "0x5358C0", Length = "0x103")]
    private UserDataStore_KeyValue.ControllerAssignmentSaveInfo LoadControllerAssignmentData() => (UserDataStore_KeyValue.ControllerAssignmentSaveInfo) null;

    [Token(Token = "0x60010C7")]
    [Address(RVA = "0x538850", Offset = "0x537450", Length = "0x6D")]
    private IEnumerator LoadJoystickAssignmentsDeferred() => (IEnumerator) null;

    [Token(Token = "0x60010C8")]
    [Address(RVA = "0x53A910", Offset = "0x539510", Length = "0x341")]
    private void SaveAll()
    {
    }

    [Token(Token = "0x60010C9")]
    [Address(RVA = "0x53CDD0", Offset = "0x53B9D0", Length = "0xC0")]
    private void SavePlayerDataNow(int playerId)
    {
    }

    [Token(Token = "0x60010CA")]
    [Address(RVA = "0x53CEA0", Offset = "0x53BAA0", Length = "0x1A8")]
    private void SavePlayerDataNow(Player player)
    {
    }

    [Token(Token = "0x60010CB")]
    [Address(RVA = "0x53A690", Offset = "0x539290", Length = "0x272")]
    private void SaveAllJoystickCalibrationData()
    {
    }

    [Token(Token = "0x60010CC")]
    [Address(RVA = "0x53C980", Offset = "0x53B580", Length = "0x76")]
    private void SaveJoystickCalibrationData(int joystickId)
    {
    }

    [Token(Token = "0x60010CD")]
    [Address(RVA = "0x53CA00", Offset = "0x53B600", Length = "0xC7")]
    private void SaveJoystickCalibrationData(Joystick joystick)
    {
    }

    [Token(Token = "0x60010CE")]
    [Address(RVA = "0x53CAD0", Offset = "0x53B6D0", Length = "0x2F9")]
    private void SaveJoystickData(int joystickId)
    {
    }

    [Token(Token = "0x60010CF")]
    [Address(RVA = "0x53B110", Offset = "0x539D10", Length = "0x4E")]
    private void SaveControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
    }

    [Token(Token = "0x60010D0")]
    [Address(RVA = "0x53B160", Offset = "0x539D60", Length = "0x13")]
    private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x60010D1")]
    [Address(RVA = "0x53C1F0", Offset = "0x53ADF0", Length = "0x1E7")]
    private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
    {
    }

    [Token(Token = "0x60010D2")]
    [Address(RVA = "0x53BF70", Offset = "0x53AB70", Length = "0x272")]
    private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
    {
    }

    [Token(Token = "0x60010D3")]
    [Address(RVA = "0x53BEB0", Offset = "0x53AAB0", Length = "0xB2")]
    private void SaveControllerMap(Player player, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x60010D4")]
    [Address(RVA = "0x53BAA0", Offset = "0x53A6A0", Length = "0x33D")]
    private void SaveControllerMapByController(Player player, ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x60010D5")]
    [Address(RVA = "0x53B3A0", Offset = "0x539FA0", Length = "0x6F0")]
    private void SaveControllerMapByControllerElementRole(
      Player player,
      Controller controller,
      ControllerMap controllerMap)
    {
    }

    [Token(Token = "0x60010D6")]
    [Address(RVA = "0x534C80", Offset = "0x533880", Length = "0x190")]
    private bool AddControllerElementByRoleMapEntry(
      Player player,
      Controller controller,
      ActionElementMap elementMap,
      ref Dictionary<string, UserDataStore_KeyValue.ControllerElementByRoleMap> maps)
    {
      return false;
    }

    [Token(Token = "0x60010D7")]
    [Address(RVA = "0x53C870", Offset = "0x53B470", Length = "0x10C")]
    private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
    {
    }

    [Token(Token = "0x60010D8")]
    [Address(RVA = "0x53C3E0", Offset = "0x53AFE0", Length = "0x17F")]
    private void SaveInputBehaviorNow(int playerId, int behaviorId)
    {
    }

    [Token(Token = "0x60010D9")]
    [Address(RVA = "0x53C560", Offset = "0x53B160", Length = "0xB7")]
    private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
    }

    [Token(Token = "0x60010DA")]
    [Address(RVA = "0x53AC60", Offset = "0x539860", Length = "0x4AC")]
    private bool SaveControllerAssignments() => false;

    [Token(Token = "0x60010DB")]
    [Address(RVA = "0x535730", Offset = "0x534330", Length = "0x6E")]
    private static void AppendPlayerKey(StringBuilder sb, Player player)
    {
    }

    [Token(Token = "0x60010DC")]
    [Address(RVA = "0x535AC0", Offset = "0x5346C0", Length = "0x182")]
    private string GetControllerMapKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return (string) null;
    }

    [Token(Token = "0x60010DD")]
    [Address(RVA = "0x535C50", Offset = "0x534850", Length = "0x182")]
    private string GetControllerMapKnownActionIdsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return (string) null;
    }

    [Token(Token = "0x60010DE")]
    [Address(RVA = "0x5354B0", Offset = "0x5340B0", Length = "0x276")]
    private static void AppendControllerMapKeyCommonSuffix(
      StringBuilder sb,
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int keyVersion)
    {
    }

    [Token(Token = "0x60010DF")]
    [Address(RVA = "0x535390", Offset = "0x533F90", Length = "0x11F")]
    private static void AppendControllerElementByRoleMapKey(
      StringBuilder sb,
      string elementRole,
      int categoryId,
      int layoutId,
      int keyVersion)
    {
    }

    [Token(Token = "0x60010E0")]
    [Address(RVA = "0x536690", Offset = "0x535290", Length = "0x19E")]
    private string GetJoystickCalibrationMapKey(Joystick joystick) => (string) null;

    [Token(Token = "0x60010E1")]
    [Address(RVA = "0x536490", Offset = "0x535090", Length = "0x151")]
    private string GetInputBehaviorKey(Player player, int inputBehaviorId) => (string) null;

    [Token(Token = "0x60010E2")]
    [Address(RVA = "0x535990", Offset = "0x534590", Length = "0x12C")]
    private string GetControllerMapJson(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (string) null;
    }

    [Token(Token = "0x60010E3")]
    [Address(RVA = "0x535DE0", Offset = "0x5349E0", Length = "0x1FA")]
    private List<int> GetControllerMapKnownActionIds(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x60010E4")]
    [Address(RVA = "0x5365F0", Offset = "0x5351F0", Length = "0x98")]
    private string GetJoystickCalibrationMapJson(Joystick joystick) => (string) null;

    [Token(Token = "0x60010E5")]
    [Address(RVA = "0x5363E0", Offset = "0x534FE0", Length = "0xA8")]
    private string GetInputBehaviorJson(Player player, int id) => (string) null;

    [Token(Token = "0x60010E6")]
    [Address(RVA = "0x534E20", Offset = "0x533A20", Length = "0x56E")]
    private void AddDefaultMappingsForNewActions(
      ControllerIdentifier controllerIdentifier,
      ControllerMap controllerMap,
      List<int> knownActionIds)
    {
    }

    [Token(Token = "0x60010E7")]
    [Address(RVA = "0x535800", Offset = "0x534400", Length = "0x189")]
    private Joystick FindJoystickPrecise(
      UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
    {
      return (Joystick) null;
    }

    [Token(Token = "0x60010E8")]
    [Address(RVA = "0x53D2C0", Offset = "0x53BEC0", Length = "0x2B7")]
    private bool TryFindJoysticksImprecise(
      UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo,
      out List<Joystick> matches)
    {
      matches = (List<Joystick>) null;
      return false;
    }

    [Token(Token = "0x60010E9")]
    [Address(RVA = "0x53A600", Offset = "0x539200", Length = "0x89")]
    private void RefreshLayoutManager(int playerId)
    {
    }

    [Token(Token = "0x60010EA")]
    [Address(RVA = "0x53A330", Offset = "0x538F30", Length = "0x1F3")]
    private void OnControllerMapsSaved(Player player)
    {
    }

    [Token(Token = "0x60010EB")]
    [Address(RVA = "0x535FE0", Offset = "0x534BE0", Length = "0x3FA")]
    private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) => 0;

    [Token(Token = "0x60010EC")]
    [Address(RVA = "0x53D580", Offset = "0x53C180", Length = "0x160")]
    private static bool TryGetString(
      UserDataStore_KeyValue.IDataStore store,
      string key,
      out string result)
    {
      result = (string) null;
      return false;
    }

    [Token(Token = "0x60010ED")]
    [Address(RVA = "0x385B30", Offset = "0x384730", Length = "0xBA")]
    private static int SortOldestToNewest(ControllerMapSaveData a, ControllerMapSaveData b) => 0;

    [Token(Token = "0x60010EE")]
    [Address(RVA = "0x53D790", Offset = "0x53C390", Length = "0x75")]
    protected UserDataStore_KeyValue()
    {
    }

    [Token(Token = "0x60010EF")]
    [Address(RVA = "0x53D6E0", Offset = "0x53C2E0", Length = "0xA1")]
    static UserDataStore_KeyValue()
    {
    }

    [Token(Token = "0x200024F")]
    private class ControllerAssignmentSaveInfo
    {
      [Token(Token = "0x400112A")]
      [FieldOffset(Offset = "0x10")]
      public UserDataStore_KeyValue.ControllerAssignmentSaveInfo.PlayerInfo[] players;

      [Token(Token = "0x1700028F")]
      public int playerCount
      {
        [Token(Token = "0x60010F0"), Address(RVA = "0x36AF80", Offset = "0x369B80", Length = "0x12")] get => 0;
      }

      [Token(Token = "0x60010F1")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      public ControllerAssignmentSaveInfo()
      {
      }

      [Token(Token = "0x60010F2")]
      [Address(RVA = "0x36AD40", Offset = "0x369940", Length = "0x115")]
      public ControllerAssignmentSaveInfo(int playerCount)
      {
      }

      [Token(Token = "0x60010F3")]
      [Address(RVA = "0x36ACE0", Offset = "0x3698E0", Length = "0x5A")]
      public int IndexOfPlayer(int playerId) => 0;

      [Token(Token = "0x60010F4")]
      [Address(RVA = "0x36AC80", Offset = "0x369880", Length = "0x5F")]
      public bool ContainsPlayer(int playerId) => false;

      [Token(Token = "0x2000250")]
      public class PlayerInfo
      {
        [Token(Token = "0x400112B")]
        [FieldOffset(Offset = "0x10")]
        public int id;
        [Token(Token = "0x400112C")]
        [FieldOffset(Offset = "0x14")]
        public bool hasKeyboard;
        [Token(Token = "0x400112D")]
        [FieldOffset(Offset = "0x15")]
        public bool hasMouse;
        [Token(Token = "0x400112E")]
        [FieldOffset(Offset = "0x18")]
        public UserDataStore_KeyValue.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;

        [Token(Token = "0x17000290")]
        public int joystickCount
        {
          [Token(Token = "0x60010F5"), Address(RVA = "0x370FC0", Offset = "0x36FBC0", Length = "0x12")] get => 0;
        }

        [Token(Token = "0x60010F6")]
        [Address(RVA = "0x370F60", Offset = "0x36FB60", Length = "0x5A")]
        public int IndexOfJoystick(int joystickId) => 0;

        [Token(Token = "0x60010F7")]
        [Address(RVA = "0x370F00", Offset = "0x36FB00", Length = "0x5F")]
        public bool ContainsJoystick(int joystickId) => false;

        [Token(Token = "0x60010F8")]
        [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
        public PlayerInfo()
        {
        }
      }

      [Token(Token = "0x2000251")]
      public class JoystickInfo
      {
        [Token(Token = "0x400112F")]
        [FieldOffset(Offset = "0x10")]
        public Guid instanceGuid;
        [Token(Token = "0x4001130")]
        [FieldOffset(Offset = "0x20")]
        public string hardwareIdentifier;
        [Token(Token = "0x4001131")]
        [FieldOffset(Offset = "0x28")]
        public int id;

        [Token(Token = "0x60010F9")]
        [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
        public JoystickInfo()
        {
        }
      }
    }

    [Token(Token = "0x2000252")]
    private class JoystickAssignmentHistoryInfo
    {
      [Token(Token = "0x4001132")]
      [FieldOffset(Offset = "0x10")]
      public readonly Joystick joystick;
      [Token(Token = "0x4001133")]
      [FieldOffset(Offset = "0x18")]
      public readonly int oldJoystickId;

      [Token(Token = "0x60010FA")]
      [Address(RVA = "0x370110", Offset = "0x36ED10", Length = "0x8F")]
      public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
      {
      }
    }

    [Token(Token = "0x2000253")]
    protected interface IDataStore
    {
      [Token(Token = "0x60010FB")]
      bool Save();

      [Token(Token = "0x60010FC")]
      bool Load();

      [Token(Token = "0x60010FD")]
      bool Clear();

      [Token(Token = "0x60010FE")]
      bool TryGetValue(string key, out object result);

      [Token(Token = "0x60010FF")]
      bool SetValue(string key, object value);
    }

    [Token(Token = "0x2000254")]
    [Serializable]
    protected class ControllerElementByRoleMap
    {
      [DoNotSerialize]
      [Token(Token = "0x4001134")]
      [FieldOffset(Offset = "0x10")]
      public string role;
      [Token(Token = "0x4001135")]
      [FieldOffset(Offset = "0x18")]
      public List<UserDataStore_KeyValue.ControllerElementByRoleMap.Entry> data;

      [Preserve]
      [Token(Token = "0x6001100")]
      [Address(RVA = "0x36B6D0", Offset = "0x36A2D0", Length = "0x77")]
      public ControllerElementByRoleMap()
      {
      }

      [Token(Token = "0x6001101")]
      [Address(RVA = "0x36AFA0", Offset = "0x369BA0", Length = "0xF0")]
      public void Add(ActionElementMap elementMap)
      {
      }

      [Token(Token = "0x6001102")]
      [Address(RVA = "0x36B4D0", Offset = "0x36A0D0", Length = "0x1F2")]
      public override string ToString() => (string) null;

      [Token(Token = "0x6001103")]
      [Address(RVA = "0x36B2C0", Offset = "0x369EC0", Length = "0x7")]
      public string ToJson() => (string) null;

      [Token(Token = "0x6001104")]
      [Address(RVA = "0x36B1A0", Offset = "0x369DA0", Length = "0x82")]
      public static UserDataStore_KeyValue.ControllerElementByRoleMap FromJson(
        string role,
        string json)
      {
        return (UserDataStore_KeyValue.ControllerElementByRoleMap) null;
      }

      [Token(Token = "0x2000255")]
      [Serializable]
      public struct Entry
      {
        [Token(Token = "0x4001136")]
        [FieldOffset(Offset = "0x0")]
        public int actionId;
        [Token(Token = "0x4001137")]
        [FieldOffset(Offset = "0x4")]
        public ControllerElementType elementType;
        [Token(Token = "0x4001138")]
        [FieldOffset(Offset = "0x8")]
        public AxisRange axisRange;
        [Token(Token = "0x4001139")]
        [FieldOffset(Offset = "0xC")]
        public bool invert;
        [Token(Token = "0x400113A")]
        [FieldOffset(Offset = "0x10")]
        public Pole axisContribution;

        [Token(Token = "0x6001105")]
        [Address(RVA = "0x36DB60", Offset = "0x36C760", Length = "0x1B5")]
        public bool TryGetElementAssignment(
          ControllerType controllerType,
          Controller.Element targetElement,
          out ElementAssignment assignment)
        {
          assignment = new ElementAssignment();
          return false;
        }

        [Token(Token = "0x6001106")]
        [Address(RVA = "0x36D9A0", Offset = "0x36C5A0", Length = "0x1B9")]
        public override string ToString() => (string) null;
      }
    }

    [Token(Token = "0x2000256")]
    public enum ActionMappingSaveMode
    {
      [Token(Token = "0x400113C")] ByController,
      [Token(Token = "0x400113D")] ByControllerElementRole,
    }
  }
}
