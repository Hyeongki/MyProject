using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasText : MonoBehaviour
{
    public Text TextObject;
    public Material TextMaterial;

    private void Awake()
    {
        if (TextObject == null)
            return;

        TextObject.material = Instantiate(TextMaterial);
        TextObject.material.color = Color.white;
    }

    public void SetText(string txt)
    {
        if (TextObject == null)
            return;

        TextObject.text = txt;
    }

    public void SetSize(int size)
    {
        if (TextObject == null)
            return;

        TextObject.fontSize = size;
    }

    public void SetColor(Color color)
    {
        if (TextObject == null)
            return;

        TextObject.material.color = color;
    }

    public Color GetColor()
    {
        return TextObject.material.color;
    }
}