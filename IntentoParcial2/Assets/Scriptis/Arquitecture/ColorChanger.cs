using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public ColorSO channel;
    public Renderer capsuler;
    public Capsule capsule;

    void Start()
    {
        capsuler = capsuler.GetComponent<Renderer>();
    }
    private void OnEnable()
    {
        channel.onColorChanged += ChangeColor;
    }

    private void OnDisable()
    {
        channel.onColorChanged -= ChangeColor;
    }

    void ChangeColor(Color color)
    {
        if (color == Color.red)
        {
            capsule.Blue();
            capsuler.material.color = channel.color;
        }

        if
        (color == Color.blue)
        {
            capsule.Red();
            capsuler.material.color = channel.color;
        }

    }
}
