using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlateau : MonoBehaviour
{
    public GameObject carrePF;
    public float ecart;

    public GameObject redPF;
    public GameObject bluePF;
    
    //public GameObject[,] grid = new GameObject[8, 8];

    public Plateau pl;

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject obj = Instantiate(carrePF);

                pl.grid[i, j] = obj;

                obj.transform.parent = gameObject.transform;

                obj.GetComponent<Case>().GetRef(i,j);
                
                obj.transform.Translate(Vector3.down * ecart * i);
                obj.transform.Translate(Vector3.right * ecart * j);
            }
        }

        pl.grid[3, 3].GetComponent<Case>().GetPion(redPF);
        pl.grid[4, 4].GetComponent<Case>().GetPion(redPF);
        pl.grid[3, 4].GetComponent<Case>().GetPion(bluePF);
        pl.grid[4, 3].GetComponent<Case>().GetPion(bluePF);

    }
    
    
    
    
}
