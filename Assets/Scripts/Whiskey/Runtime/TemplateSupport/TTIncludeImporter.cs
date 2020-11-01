using UnityEngine;
using System.IO;

#if UNITY_EDITOR
using UnityEditor.Experimental.AssetImporters;

/// <summary>
/// A baby TTInclude importer so the editor can show ttinclude contents
/// </summary>
[ScriptedImporter(1, "ttinclude")]
public class TTIncludeImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var asset = new TextAsset(File.ReadAllText(ctx.assetPath));
        ctx.AddObjectToAsset("text", asset);
        ctx.SetMainObject(asset);
    }
}
#endif
