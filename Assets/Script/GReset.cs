using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GReset : MonoBehaviour
{
    public static void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public static void capture()
    {
        Capture.TakeScreenShot_Static(Screen.width, Screen.height);
    }
}
