using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player_Inventory))]
public class InventoryEditor : Editor
{
    SerializedProperty inventory;
    SerializedProperty invisImagePrefab;
    SerializedProperty inventoryImageEmpty;


    private void OnEnable()
    {
        inventory = serializedObject.FindProperty("inventory");
        invisImagePrefab = serializedObject.FindProperty("invisImagePrefab");
        inventoryImageEmpty = serializedObject.FindProperty("inventoryImageEmpty");
    }

    public override void OnInspectorGUI()
    {
        Player_Inventory inv = (Player_Inventory)target;

        serializedObject.Update();

        EditorGUILayout.PropertyField(inventory);

        EditorGUILayout.LabelField("");
        EditorGUILayout.LabelField("UI Representation");
        inv.useUI = EditorGUILayout.Toggle("Use UI", inv.useUI);


        if (inv.useUI)
        {
            EditorGUILayout.PropertyField(invisImagePrefab);
            EditorGUILayout.PropertyField(inventoryImageEmpty);
            inv.padding = EditorGUILayout.FloatField("Padding", inv.padding);
        }

        serializedObject.ApplyModifiedProperties();

    }

}
