using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    //public Vector2 indice;

    public int i;
    public int j;

    public bool selected;

    public Plateau grid;

    public GameObject pion;
    public void GetRef(int i, int j)
    {
        this.i = i;
        this.j = j;
    }

    public void GetPion(GameObject pion)
    {
        GameObject obj = Instantiate(pion);
        
        obj.transform.parent = gameObject.transform;
        obj.transform.position = gameObject.transform.position;
        obj.transform.Translate(Vector3.back * 10);
        

        this.pion = obj;
    }

    private void OnMouseDown()
    {
        selected = true;

        //grid.grid[i, j].selected = true;

        if (this.pion != null)
        {
            
        }
        else
        {
            
        }
    }

    private void Update()
    {
        
    }
}
