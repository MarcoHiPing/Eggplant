using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySpot : MonoBehaviour
{
    private Material defaultMat;

    private void Start()
    {
        defaultMat = GetComponent<Renderer>().material;
    }

    public void Highlight(Material highlightMat)
    {
        GetComponent<Renderer>().material = highlightMat;
    }

    public void Unhighlight()
    {
        GetComponent<Renderer>().material = defaultMat;
    }
}
