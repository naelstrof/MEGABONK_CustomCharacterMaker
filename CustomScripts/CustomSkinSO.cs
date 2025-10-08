using System.Collections;
using System.Collections.Generic;
using Assets.Scripts._Data;
using Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "CustomSkinSO", menuName = "ScriptableObjects/CustomSkinSO")]
public class CustomSkinSO : ScriptableObject
{
    public string skinName;
    public string description;
    public Texture2D icon;
    public List<Material> materials = new List<Material>();

    public ESkinType skinType = ESkinType.Default;
    
#if UNITY_EDITOR
    public JObject toJSON()
    {
        //var skinPath = AssetDatabase.GetAssetPath(this);
        var iconPath = AssetDatabase.GetAssetPath(icon);
        var materialPaths = new List<string>();
        foreach (var mat in materials)
        {
            var matPath = AssetDatabase.GetAssetPath(mat);
            Debug.Log(matPath);
            materialPaths.Add(AssetDatabase.GetAssetPath(mat));
        }
        
        return JObject.FromObject(new
        {
            //skinPath,
            skinName,
            description, 
            iconPath,
            materialPaths
        });
    }
    public string[] getAssetNameList()
    {
        List<string> list = new List<string>();
        list.Add(AssetDatabase.GetAssetPath(this));
        list.Add(AssetDatabase.GetAssetPath(icon));
        foreach (var mat in materials)
        {
            list.Add(AssetDatabase.GetAssetPath(mat));
        }
        
        return list.ToArray();
    }
#endif
    
}
