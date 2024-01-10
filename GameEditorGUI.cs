using UnityEngine;
using UnityEditor;
using Player;


[CustomEditor (typeof (CombinationLock))]
internal class CombinationLockGUI : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CombinationLock combinationLock = (CombinationLock)target;
        EditorGUILayout.Space(15f);
        EditorStyles.label.normal.textColor = Color.red;
        EditorGUILayout.LabelField("Password Functions", EditorStyles.selectionRect);
        EditorStyles.label.normal.textColor = Color.white;


        EditorGUILayout.BeginHorizontal();

        // ~~ Password Button 1 ~~
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("1", EditorStyles.boldLabel, GUILayout.Width(width: 15f), GUILayout.ExpandWidth(true));
        if (GUILayout.Button("+"))
        {
            combinationLock.Rotate1Numeric();
        }
        EditorGUILayout.LabelField("Change Passord 1", EditorStyles.helpBox);
        EditorGUILayout.EndVertical();



        // ~~ Password Button 2 ~~
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("2", EditorStyles.boldLabel, GUILayout.Width(width: 15f), GUILayout.ExpandWidth(true));
        if (GUILayout.Button("+"))
        {
            combinationLock.Rotate2Numeric();
        }
        EditorGUILayout.LabelField("Change Passord 2", EditorStyles.helpBox);
        EditorGUILayout.EndVertical();



        // ~~ Password Buttond 3 ~~
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("3", EditorStyles.boldLabel, GUILayout.Width(width: 15f), GUILayout.ExpandWidth(true));
        if (GUILayout.Button("+"))
        {
            combinationLock.Rotate3Numeric();
        }
        EditorGUILayout.LabelField("Change Passord 3", EditorStyles.helpBox);
        EditorGUILayout.EndVertical();



        // ~~ Password Button 4 ~~
        EditorGUILayout.BeginVertical();
        EditorGUILayout.LabelField("4", EditorStyles.boldLabel, GUILayout.Width(width: 15f), GUILayout.ExpandWidth(true));
        if (GUILayout.Button("+"))
        {
            combinationLock.Rotate4Numeric();
        }
        EditorGUILayout.LabelField("Change Passord 4", EditorStyles.helpBox);
        EditorGUILayout.EndVertical();

        EditorGUILayout.EndHorizontal();




        EditorGUILayout.LabelField("____________________", EditorStyles.boldLabel);










        if (GUILayout.Button("Random Password"))
        {
            combinationLock.RandomPassword();
        }



        GUILayout.BeginHorizontal();


        GUILayout.BeginVertical();
        EditorGUILayout.LabelField("If you are locked, reset the numbers!", EditorStyles.helpBox);
        if (GUILayout.Button("Reset Lock"))
        {
            combinationLock.ResetLock();
        }
        GUILayout.EndVertical();


        GUILayout.BeginVertical();
        EditorGUILayout.LabelField("Shuffle the numbers in the lock", EditorStyles.helpBox);
        if (GUILayout.Button("Random Value"))
        {
            combinationLock.RandomLockValue();
            combinationLock.LockValueTransformEqualing();
        }
        GUILayout.EndVertical();


        GUILayout.EndHorizontal();
        if (GUILayout.Button("Enter Password"))
        {
            combinationLock.EnterPassword();
        }
    }
}