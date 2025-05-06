using UnityEditor;
using UnityEngine;

namespace Five.UI
{
#if UNITY_EDITOR
    [CustomEditor(typeof(MockupImage))]
    public class MockupImageEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUILayout.Space(10);

            var mockupImage = (MockupImage)target;

            if (GUILayout.Button("Opaque"))
            {
                mockupImage.SetOpaque();
                EditorUtility.SetDirty(mockupImage); // Mark as dirty to force Unity to refresh the inspector
                SceneView.RepaintAll();
                Undo.RecordObject(mockupImage, "Change Opacity");
            }

            GUILayout.Space(5);

            if (GUILayout.Button("Transparent"))
            {
                mockupImage.SetTransparent();
                EditorUtility.SetDirty(mockupImage); // Mark as dirty to force Unity to refresh the inspector
                SceneView.RepaintAll();
                Undo.RecordObject(mockupImage, "Change Opacity");
            }
        }
    }
#endif
}
