// <auto-generated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </auto-generated>

using UnityEngine;

namespace Unity3D.Whiskey.Editor
{
#if UNITY_EDITOR
    [UnityEditor.CanEditMultipleObjects]
    [UnityEditor.CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : UnityEditor.Editor
    {
        private float v;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            UnityEngine.GUI.enabled = UnityEngine.Application.isPlaying;

            v = UnityEditor.EditorGUILayout.FloatField(v);

            if (UnityEngine.GUILayout.Button("Raise"))
            {
                foreach (var tgt in targets)
                {
                    (tgt as FloatEvent).Raise(v);
                }
            }
        }
    }
#endif
}
