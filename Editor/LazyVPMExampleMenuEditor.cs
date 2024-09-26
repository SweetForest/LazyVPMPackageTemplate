using UnityEditor;
using UnityEngine;
namespace sweetforest.example {





public class LazyVPMExampleMenuEditor : EditorWindow
{
    [MenuItem("LazyVPMExampleMenu/Example")]
    public static void ShowWindow()
    {
        GetWindow<LazyVPMExampleMenuEditor>("Lazy VPM Example Menu");
    }

    private void OnGUI()
    {
        GUILayout.Label("Don't forget to delete example files in Assets/Packages", EditorStyles.boldLabel);

   
    }


}
}