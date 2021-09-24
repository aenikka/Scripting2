using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    
    private ICutting m_CutMethod;


    void Start()
    {
       
    }

    public void CutCubes()
    {
        m_CutMethod = new Cubes();
        m_CutMethod.Cutting();
       
    }

    public void CutPieces()
    {
        m_CutMethod = new Pieces();
        m_CutMethod.Cutting();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
