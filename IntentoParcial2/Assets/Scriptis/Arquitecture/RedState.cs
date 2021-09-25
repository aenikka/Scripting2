using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedState : ICapsule
{
    public void Execute(ColorSO colorSO)
    {

        Debug.Log("Soy rojito");
        colorSO.color = Color.red;

    }
}
