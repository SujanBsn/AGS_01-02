using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Capture : MonoBehaviour {

    private  static Capture instance;
    private bool takeScreenshotOnNextFrame;

    private Camera Mycamera;
    private void Awake()
    {
        instance = this;
        Mycamera = gameObject.GetComponent<Camera>();
    }

    private void OnPostRender()
    {
        if (takeScreenshotOnNextFrame)
        {
            takeScreenshotOnNextFrame= false;
            RenderTexture renderTexture= Mycamera.targetTexture;

            Texture2D renderResult = new Texture2D(renderTexture.width,renderTexture.height,TextureFormat.ARGB32,false);
            Rect rect = new Rect(0,0, renderTexture.width,renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);

            byte[] byteArray = renderResult.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/CameraShot.png", byteArray);
            Debug.Log("Saved CameraScreenshot.png");

            RenderTexture.ReleaseTemporary(renderTexture);
            Mycamera.targetTexture = null;
        }
            
    }

    private void takescreenshot(int width, int height)
    {
        Mycamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenshotOnNextFrame= true;
    }

    public static void TakeScreenShot_Static(int width, int height)
    {
        instance.takescreenshot(width, height);
    }
   
}