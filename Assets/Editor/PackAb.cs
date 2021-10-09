using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class PackAb : MonoBehaviour {
    [MenuItem("buildAB/windows", false, 100)]
    public static void BuildWindowsResource()
    {
        TextEditor te = new TextEditor();
        string streamPath = Application.streamingAssetsPath;
        if (Directory.Exists(streamPath))
        {
            Directory.Delete(streamPath, true);
        }
        Directory.CreateDirectory(streamPath);
        BuildPipeline.BuildAssetBundles(streamPath, BuildAssetBundleOptions.None, BuildTarget.Android);
    }
}
