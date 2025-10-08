using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts._Data;
using Assets.Scripts.Inventory__Items__Pickups.AbilitiesPassive;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomPassiveSO", menuName = "ScriptableObjects/CustomPassiveSO")]
public class CustomPassiveSO : ScriptableObject
{
    public string passiveName;
    public string passiveDescription;
    public Texture2D icon;
    public EPassive passive;

#if UNITY_EDITOR
    public JObject toJSON()
    {
        //var passivePath = AssetDatabase.GetAssetPath(this);
        var iconPath = AssetDatabase.GetAssetPath(icon);
        
        return JObject.FromObject(new { 
            //passivePath, 
            passiveName, 
            passiveDescription,
            passive, 
            iconPath 
        });
    }
    public string[] getAssetNameList()
    {
        System.Collections.Generic.List<string> list = new List<string>();
        //list.Add(AssetDatabase.GetAssetPath(this));
        list.Add(AssetDatabase.GetAssetPath(icon));
        return list.ToArray();
    }
#endif
    
}
