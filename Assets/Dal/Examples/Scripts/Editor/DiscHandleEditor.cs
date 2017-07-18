
using UnityEngine;                                                              // Name this script "DiscHandleEditor"
using UnityEditor;

namespace Dal.Examples
{
#if UNITY_EDITOR                                                                // this sentence will exclude for building
    [CustomEditor(typeof(Disc))]
    [CanEditMultipleObjects]
    public class DiscEditor : Editor
    {
        public void OnSceneGUI()
        {
            var t = (target as Disc);

            EditorGUI.BeginChangeCheck();
            var rot = Handles.Disc(t.rot, t.transform.position, new Vector3(1, 1, 0), 5, false, 1);

            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Disc Rotate");
                t.rot = rot;
                t.Update();
            }
        }
    }
#endif
}

#region References
// From https://docs.unity3d.com/ScriptReference/Handles.Disc.html
#endregion