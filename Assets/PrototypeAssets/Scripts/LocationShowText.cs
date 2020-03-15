using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationShowText : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private Text locationText;
    private Material textMat;
    [SerializeField] private float fadeInTime;
    [SerializeField] private float fadeOutTime;
    [SerializeField] private float screenTime;
    [SerializeField] private float delayTime;
    // Use this for initialization
    void Start()
    {
        Color col = locationText.color;
        col.a = 0;
        locationText.color = col;
    }

    public void ShowText()
    {

        StartCoroutine(FadeInOutText());
    }

    IEnumerator FadeInOutText()
    {
        Color init = locationText.color;

        yield return new WaitForSeconds(delayTime);
        source.Play();
        float speed = 1f / fadeInTime;
        while (locationText.color.a < 1f)
        {
            init.a += speed * Time.deltaTime;
            locationText.color = init;
            yield return null;

        }
        yield return new WaitForSeconds(screenTime);
        speed = 1f / fadeOutTime;
        while (locationText.color.a > 0f)
        {
            init.a -= speed * Time.deltaTime;
            locationText.color = init;
            yield return null;

        }
        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowText();
        }
    }

}
