// <auto-generated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </auto-generated>

using UnityEditor;
using UnityEngine;

namespace Unity3D.Whiskey.Editor
{
#if UNITY_EDITOR
    [UnityEditor.CanEditMultipleObjects]
    [UnityEditor.CustomEditor(typeof(GameObjectEvent))]
    public class GameObjectEventEditor : UnityEditor.Editor
    {
        private GameObject v;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            UnityEngine.GUI.enabled = UnityEngine.Application.isPlaying;

#pragma warning disable CS0618 // Type or member is obsolete
            v = (GameObject) UnityEditor.EditorGUILayout.ObjectField(v, typeof(GameObject));
#pragma warning restore CS0618 // Type or member is obsolete

            if (UnityEngine.GUILayout.Button("Raise"))
            {
                foreach (var tgt in targets)
                {
                    (tgt as GameObjectEvent).Raise((GameObject)v);
                }
            }
        }
    }
#endif
}

