using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Weapon))]
public class WeaponEditor : Editor
{
    SerializedProperty projectile;
    SerializedProperty projectileSpawnTransform;
    SerializedProperty attackSound;
    SerializedProperty projectileData;



    private void OnEnable()
    {
        projectile = serializedObject.FindProperty("projectilePrefab");
        projectileSpawnTransform = serializedObject.FindProperty("projectileSpawnPosition");
        attackSound = serializedObject.FindProperty("attackSoundEffect");
        projectileData = serializedObject.FindProperty("projectile");

    }
    public override void OnInspectorGUI()
    {
        Weapon weapon = (Weapon) target;

        
        serializedObject.Update();

        weapon.weaponOwner = (Weapon.Owner) EditorGUILayout.EnumPopup("Weapon Owner", weapon.weaponOwner);
        weapon.weaponType = (Weapon.WeaponType) EditorGUILayout.EnumPopup("Weapon Type", weapon.weaponType);

        if (weapon.weaponType == Weapon.WeaponType.Melee)
        {
            weapon.weaponDamage = EditorGUILayout.IntField("Weapon Damage", weapon.weaponDamage);
        }
        else if (weapon.weaponType == Weapon.WeaponType.Ranged)
        {
            weapon.instantFire = EditorGUILayout.Toggle("Instant Fire", weapon.instantFire);
            EditorGUILayout.PropertyField(projectile);
            EditorGUILayout.PropertyField(projectileSpawnTransform);
            
        }
        else if (weapon.weaponType == Weapon.WeaponType.Projectile)
        {
            weapon.weaponDamage = EditorGUILayout.IntField("Weapon Damage", weapon.weaponDamage);
            EditorGUILayout.PropertyField(projectileData);
        }

        EditorGUILayout.PropertyField(attackSound);

        serializedObject.ApplyModifiedProperties();

    
    }


}
