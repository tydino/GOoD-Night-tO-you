using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class screenShotter : MonoBehaviour
{
    public Camera setToDepthOnly;
    public string fullPath;
    public void Start(){
         Camera camera = setToDepthOnly;

         RenderTexture rt = new RenderTexture(256, 256, 24);
         camera.targetTexture = rt;
         Texture2D screenShot = new Texture2D(256, 256, TextureFormat.ARGB32, false);
         camera.Render();
         RenderTexture.active = rt;
         screenShot.ReadPixels(new Rect(0, 0, 256, 256), 0, 0);
         camera.targetTexture = null;
         RenderTexture.active = null;

         if (Application.isEditor){
            DestroyImmediate(rt);
         }
         else{
            Destroy(rt);
         }

         byte[] bytes = screenShot.EncodeToPNG();
         System.IO.File.WriteAllBytes(fullPath, bytes);
         #if UNITY_EDITOR
         AssetDatabase.Refresh();
         #endif
    }
}
