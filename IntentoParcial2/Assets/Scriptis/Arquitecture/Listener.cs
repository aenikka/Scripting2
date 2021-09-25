using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    public ColorSO channel;

    private void OnEnable()
    {
        channel.onColorChanged += PrintLog;
    }

    private void OnDisable()
    {
        channel.onColorChanged -= PrintLog;
    }

    void PrintLog(Color color)
    {
        Debug.Log("he cambiado de color :)");
    
    }

}
