using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kandle : ZappableObject
{
    public static int numOfKandlesLit;
    public MeshRenderer boxMat;
    public MeshRenderer pipeMat;
    public Color boxToColor;
    public float boxMatChangeTime;
    public float pipeFillTime;

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    KandleAction();
        //}
    }

    public void KandleAction()
    {
        numOfKandlesLit++;
        StartCoroutine(ChangeBoxColorRoutine());
        StartCoroutine(ChangePipeColorRoutine());
        gameObject.layer = LayerMask.NameToLayer("Default");
    }

    IEnumerator ChangeBoxColorRoutine()
    {
        float timeStartedLerping = Time.time;
        float percComplete = 0f;
        Color startColor = boxMat.materials[1].GetColor("_EmissionColor");

        while (percComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            percComplete = timeSinceStarted / boxMatChangeTime;
            boxMat.materials[1].SetColor("_EmissionColor", Color.Lerp(startColor, boxToColor, percComplete));
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator ChangePipeColorRoutine()
    {
        float timeStartedLerping = Time.time;
        float percComplete = 0f;
        float startValue = 0f;

        while (percComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            percComplete = timeSinceStarted / pipeFillTime;
            pipeMat.material.SetFloat("_FillSlider", Mathf.Lerp(startValue, 1f, percComplete));
            yield return new WaitForEndOfFrame();
        }
    }
}