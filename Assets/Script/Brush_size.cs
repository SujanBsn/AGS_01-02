using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush_size : MonoBehaviour
{
    public LineRenderer brush;
    public static float SWidth, EWidth;

    public static void increase()
    {
        SWidth += 0.05f;
    }

    public static void decrease()
    {
        if (SWidth <= 0.2f)
        {
            SWidth = 0.2f;
        }
        SWidth -= 0.05f;
    }

    void Start()
    {
        SWidth = brush.startWidth;
        EWidth = brush.endWidth;
    }
    
    void Update()
    {
        EWidth = SWidth;
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            increase();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadMinus))
            {
                decrease();
            }
    }
}
