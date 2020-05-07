using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Scope = UnityEngine.GUI.Scope;

[CustomEditor(typeof(Scope))]
public class ScaleEditor : Editor
{
 public override void OnInspectorGUI()
 {
       // Scope scaleBeingInspected = target as Scene;
        base.OnInspectorGUI();
        if (GUILayout.Button("Update Scale"))
        {
           //scaleBeingInspected.UpdateScale();
        }
 }


}

