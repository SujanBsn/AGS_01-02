using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Draw : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush, transfer;
    public GameObject brushinstance;
    LineRenderer currentLineRenderer;
    public Vector2 mousepos;
    Vector2 LastPos;

    public static bool check = false;

    // public static List<GameObject> otherClones = new List<GameObject>();
    // public int count = otherClones.Count;
    // public int index, z_pos;


    public void Update()
    {
        if (check == true)
        {
            StartCoroutine(Wait());
        }
        else Drawing();      
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1);
        check = false;
    }


    void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
           
            //count = otherClones.Count;

            /*This sets the correct hierarchy of the gameobjects.
            int count1 = count;
            for (int i=0; i<count; i++)
            {
                otherClones[i].transform.SetSiblingIndex(count1);
                count1--;
            }*/
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();

            //This had to be placed here to ensure that it runs after obtaining a reference.
            currentLineRenderer.startWidth = Brush_size.SWidth;
            currentLineRenderer.endWidth = Brush_size.EWidth;
        }
        else
        {
            currentLineRenderer = null;
        }
    }

    void CreateBrush()
    {
            brushinstance = Instantiate(brush);
            //brushinstance.name = "Clone" + count;
            //otherClones.Add(brushinstance);

            //transfer = otherClones[count];
            //index = brushinstance.transform.GetSiblingIndex();

            currentLineRenderer = brushinstance.GetComponent<LineRenderer>();
            currentLineRenderer.material.color = Brush_colour.myColour;

            mousepos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            currentLineRenderer.SetPosition(0, mousepos);
            currentLineRenderer.SetPosition(1, mousepos);
        
    }

    void AddAPoint(Vector2 Pointpos)
    {
        if (check == false)
        { currentLineRenderer.positionCount++; }
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, Pointpos);
    }

    void PointToMousePos()
    {
        Vector2 MousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        if (LastPos != MousePos)
        {
            AddAPoint(MousePos);
            LastPos = MousePos;
        }
    }
}
