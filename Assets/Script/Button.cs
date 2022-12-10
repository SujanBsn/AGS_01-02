using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI red_value, green_value, blue_value, Brush_value;
    public static float red_num = 0, blue_num = 0, green_num = 0;
    public static int Brush_num = 5;

    public void Update()
    {
        Brush_value.text = Brush_num.ToString();
    }


    public void OnButtonPressRed()
    {
        Draw.check = true;
        Brush_colour.red();
        red_num += .5f;
        if (red_num > 16) red_num = 0;
        red_value.text= red_num.ToString();
    }
    public void OnButtonPressBlue()
    {
        Draw.check = true;
        Brush_colour.blue();
        blue_num += .5f;
        if (blue_num > 16) blue_num = 0;
        blue_value.text = blue_num.ToString();
    }
    public void OnButtonPressGreen()
    {
        Draw.check = true;
        Brush_colour.green();
        green_num += .5f;
        if (green_num > 16) green_num = 0;
        green_value.text = green_num.ToString();
    }
    /*public void OnButtonPressAlpha()
    {
        Brush_colour.alpha();
    }*/
    public void OnButtonPressCapture()
    {
        Draw.check = true;
        GReset.capture();
    } 
    public void OnButtonPressIncreaseSize()
    {
        Draw.check = true;
        Brush_size.increase();
        Brush_num++;
        Brush_value.text = Brush_num.ToString();
    } 
    public void OnButtonPressDecreaseSize()
    {
        Draw.check = true;
        Brush_size.decrease();
        Brush_num--;
        if (Brush_num < 1) Brush_num = 1;
        Brush_value.text = Brush_num.ToString();
    }
    public void OnButtonPressResetScene()
    {
        GReset.Reset();
    }
    public void OnButtonPressResetColour()
    {
        Brush_colour.CReset();
        green_num = 0; 
        red_num = 0; 
        blue_num = 0;

        green_value.text = green_num.ToString();
        red_value.text = red_num.ToString();
        blue_value.text = blue_num.ToString();
    }

}
