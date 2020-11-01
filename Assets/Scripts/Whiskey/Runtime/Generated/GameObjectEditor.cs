
// <auto-generated>
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// </auto-generated>

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FasterGames.Whiskey
{
#if UNITY_EDITOR
/// <summary>
/// Custom editor for <see cref="GameObjectEvent"/>s
/// </summary>
[UnityEditor.CanEditMultipleObjects]
[UnityEditor.CustomEditor(typeof(GameObjectEvent))]
public class GameObjectEventEditor : UnityEditor.Editor
{
    /// <summary>
    /// Storage for data to raise the event with
    /// </summary>
    private GameObject v;

    /// <inheritdoc/>
    public override void OnInspectorGUI()
    {
        UnityEngine.GUI.enabled = UnityEngine.Application.isPlaying;

        UnityEditor.EditorGUILayout.LabelField("Listener" + " (" + (targets.Length > 1 ? "Multi" : "Single") + ") Count", SumTargetListeners().ToString());

        v = (GameObject)UnityEditor.EditorGUILayout.ObjectField(v, typeof(GameObject), allowSceneObjects: true);

        if (UnityEngine.GUILayout.Button("Raise"))
        {
            foreach (var tgt in targets)
            {
                var evt = (GameObjectEvent)tgt;
                evt.Trigger(v);
            }
        }
    }

    /// <summary>
    /// Internal helper to count attached listeners
    /// </summary>
    private int SumTargetListeners()
    {
        int res = 0;
        foreach (var tgt in targets)
        {
            var evt = (GameObjectEvent)tgt;
            res += evt.Count;
        }

        return res;
    }
}
#endif

}
