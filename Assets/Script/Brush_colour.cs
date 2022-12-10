using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush_colour : MonoBehaviour
{
    public static Brush_colour colour;
    public static Color myColour;
    public static float afloat;
    public static float rfloat;
    public static float bfloat;
    public static float gfloat;

  
    public Renderer myRenderer;
    public GameObject brushcolor;
    
    void Start()
    {
        myRenderer = gameObject.GetComponent<Renderer>();
        colour = this;
    }

    /*public static void alpha()
    {
        if (afloat < 16)
        {
            afloat += 0.5f;

        }
        else
        {
            afloat = 0;
        }
    }*/
    public static void red()
    {
        if (rfloat < 16)
        {
            rfloat += 0.5f;
        }
        else
        {
            rfloat = 0;
        }
    }
    public static void green()
    {
        if (gfloat < 16)
        {
            gfloat += 0.5f;
        }
        else
        {
            gfloat = 0;
        }
    }
    public static void blue()
    {
        if (bfloat < 16)
        {
            bfloat += 0.5f;
        }
        else
        {
            bfloat = 0;
        }
    }
    public static void CReset()
    {
        afloat = 0;
        rfloat = 0;
        gfloat = 0;
        bfloat = 0;
    }

    void Update()
    {
       /* if (Input.GetKey(KeyCode.A))
        {
            alpha();
        }
        
        if (Input.GetKey(KeyCode.R))
        {
            red();
        }
        if (Input.GetKey(KeyCode.B))
        {
            blue();
        }
        if (Input.GetKey(KeyCode.G))
        {
            green();
        }*/
        myColour = new Color(rfloat, gfloat, bfloat, afloat);
    }
}
