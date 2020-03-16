using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KandleCheckGlow : MonoBehaviour
{
    private MeshRenderer matToChange;
    public Color toColor;
    public float matChangeTime = 2f;

    private bool glowing;

    void Start()
    {
        matToChange = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (!glowing)
        {
            if (Kandle.numOfKandlesLit == 5)
            {
                StartCoroutine(ChangeEmissiveColorRoutine());
                glowing = true;
            }
        }

    }

    IEnumerator ChangeEmissiveColorRoutine()
    {
        float timeStartedLerping = Time.time;
        float percComplete = 0f;

        Color startColor;

        if (matToChange.materials.Length > 1)
            startColor = matToChange.materials[1].GetColor("_EmissionColor");
        else
            startColor = matToChange.material.GetColor("_EmissionColor");


        while (percComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            percComplete = timeSinceStarted / matChangeTime;

            if (matToChange.materials.Length > 1)
                matToChange.materials[1].SetColor("_EmissionColor", Color.Lerp(startColor, toColor, percComplete));
            else
                matToChange.materials[0].SetColor("_EmissionColor", Color.Lerp(startColor, toColor, percComplete));

            yield return new WaitForEndOfFrame();
        }
    }
}
