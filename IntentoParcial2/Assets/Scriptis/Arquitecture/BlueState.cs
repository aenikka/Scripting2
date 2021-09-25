using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueState : ICapsule
{
    public void Execute(ColorSO colorSO)
    {

        Debug.Log("Soy azulito");
        colorSO.color = Color.blue;
             
    }
}
