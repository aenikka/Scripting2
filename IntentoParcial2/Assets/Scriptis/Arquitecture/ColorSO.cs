using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class ColorSO : ScriptableObject
{
    public Color color;

    public event UnityAction<Color> onColorChanged;
    void Start()
    {
        color = Color.red;
    }

    public void OnColorChanged()
    {

        if (onColorChanged != null)
        {
            onColorChanged(color);
        }
        
    }
   
}
