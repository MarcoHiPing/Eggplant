using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ActionCommunicator : MonoBehaviourPun
{
    [SerializeField] private TextMeshProUGUI playerActionText;
    [SerializeField] private Image playerActionImage;

    [Header("Options")]
    [SerializeField] private bool showText;
    [SerializeField] private bool showImage;

    [Header("Text Settings")]
    [SerializeField] private float textFadeInTime;
    [SerializeField] private float textFadeOutTime;
    [SerializeField] private float textStayTime;
    [SerializeField] private Color textstartColor;
    [SerializeField] private Color textEndColor;

    [Header("Image Settings")]
    [SerializeField] private float imageFadeInTime;
    [SerializeField] private float imageFadeOutTime;
    [SerializeField] private float imageStayTime;
    [SerializeField] private Color imageStartColor;
    [SerializeField] private Color imageEndColor;



    public void CommunicateActionText(Text textToComm)
    {
        playerActionText.text = textToComm.text;

        if (showText)
        {
            StartCoroutine(FadeText(textstartColor, textEndColor, textFadeInTime));
            StartCoroutine(FadeText(textEndColor, textstartColor, textFadeOutTime, textStayTime));
        }
    }

    public void CommunicateActionImage(Image ImageToComm)
    {
        playerActionImage.sprite = ImageToComm.sprite;
        
        if (showImage)
        {
            StartCoroutine(FadeImage(imageStartColor, imageEndColor, imageFadeInTime));
            StartCoroutine(FadeImage(imageEndColor, imageStartColor, imageFadeOutTime, imageStayTime));
        }
    }

    private IEnumerator FadeText(Color fromColor, Color toColor, float lerpTime, float delay = 0f)
    {
        yield return new WaitForSeconds(delay);
        float timeStartedLerping = Time.time;
        float lerpPercComplete = 0f;

        while (lerpPercComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            lerpPercComplete = timeSinceStarted / lerpTime;
            playerActionText.color = Color.Lerp(fromColor, toColor, lerpPercComplete);
            yield return new WaitForEndOfFrame();
        }
    }

    private IEnumerator FadeImage(Color fromColor, Color toColor, float lerpTime, float delay = 0f)
    {
        yield return new WaitForSeconds(delay);
        float timeStartedLerping = Time.time;
        float lerpPercComplete = 0f;

        while (lerpPercComplete < 1.0f)
        {
            float timeSinceStarted = Time.time - timeStartedLerping;
            lerpPercComplete = timeSinceStarted / lerpTime;
            playerActionImage.color = Color.Lerp(fromColor, toColor, lerpPercComplete);
            yield return new WaitForEndOfFrame();
        }
    }
}
