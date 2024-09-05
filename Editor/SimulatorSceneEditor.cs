namespace SSE
{
    using UnityEngine;
    using UnityEditor;
    using UnityEditor.SceneManagement;

    public class SimulatorSceneEditor : EditorWindow
    {
        private bool fixStartScene = false;

        [MenuItem( "Extra/SimulatorSceneEditor" )]
        public static void Create()
        {
            EditorWindow wnd = GetWindow<SimulatorSceneEditor>();
            wnd.titleContent = new GUIContent("SimulatorSceneEditro");
        }

        private void OnGUI()
        {

            if( fixStartScene = GUILayout.Toggle(fixStartScene, "fix start scene"))
            {
                EditorSceneManager.playModeStartScene = (SceneAsset)EditorGUILayout.ObjectField(new GUIContent("Start Scene"), EditorSceneManager.playModeStartScene, typeof(SceneAsset), false);
            }
            else
            {
                EditorSceneManager.playModeStartScene = null;
            }
        }
    }
}


