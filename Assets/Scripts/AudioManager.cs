using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;


// Use the following 3 enum types to update the clip names
public enum SfxClip
{

};
public enum BgClip
{

   
};

//#singleton
public class AudioManager : MonoBehaviour
{


    public static AudioManager instance;

    public int maxPoolSize=10;
    public int defaultSize=5;
    
    

  
    private static List<AudioSource> sources;

    void Awake ()
    {
        sources = new List<AudioSource>();

        for (int i = 0; i< defaultSize; i++)
        {
            CreateSources(i);
    
        }
        if (!instance)
            instance = this;
        else if (instance != this)
            Destroy(this);



    }
    public void RevokeAllCommands()
    {

        StopAllCoroutines();
    }
    private AudioSource CreateSources(int index)
    {

        GameObject sourceObj = new GameObject("Audio" + index, typeof(AudioSource));
        sourceObj.transform.SetParent(this.gameObject.transform);
        var audioSource = sourceObj.GetComponent<AudioSource>();
        sources.Add(audioSource);
        return audioSource;

    }
    public void StopClip(Audio audio)
    {

        StartCoroutine(StopSource(FindSourceByName(audio.clipName)));


    }
    public AudioSource FindSourceByName(string name)
    {

        AudioSource selectedSource = null;
        foreach (AudioSource source in sources)
        {


            if (source.clip)
            {
                if (source.clip.name.Equals(name))
                {
                    selectedSource = source;
                    break;
                }
            }

        }
        return selectedSource;
    }
    public void StopClip(AudioClip clip)
    {
       
        
        StartCoroutine(StopSource(FindSourceByName(clip.name)));

    }

    public void PlayClip(Audio audio)
    {

        
        StartCoroutine(Play(audio));
    }
    public void PlayClip(AudioClip clip, float delay)
    {
        if(clip!=null)
        StartCoroutine(Play(clip,delay));

    }
    
    private IEnumerator StopSource(AudioSource source, float delay=0)
    {
        yield return new WaitForSeconds(delay);
        source.Stop();
    }
    public void FadeOutClip(BgClip clipName,float delay, float time =1f)
    {
        var data = sources.Find(element => element.clip.name.ToLower().Contains(clipName.ToString().ToLower()));
        if (data != null)
            StartCoroutine(FadeClip(data,delay, time));


    }
    IEnumerator FadeClip(AudioSource source, float delay, float time)
    {

        yield return new WaitForSeconds(delay);
            time = 1f / time;
            while (source.volume >= 0f)
            {

                source.volume -= time * Time.deltaTime;
                yield return null;

            }
            source.Stop();
            source.volume = 1f;
     
       
    }
   
    IEnumerator FadeInClip(AudioSource source,float timeToFade=4)
    {


        float speed = 1f / timeToFade;
        source.volume = 0f;
       
        source.Play();
        while (source.volume <= 1f)
        {

            source.volume += speed * Time.deltaTime;
            yield return null;

        }
        source.volume = 1f;
    

    }
    /// <summary>
    /// Function to fade out clip from the end
    /// </summary>
    /// <param name="source"></param>
    /// <param name="fadeStartTime"></param> 
    /// <returns></returns>
    IEnumerator FadeOutClip(AudioSource source,float fadeStartTime=1f)
    {
        if (source.clip != null)
        {
            float waitTime = source.clip.length-fadeStartTime;
            yield return new WaitForSeconds(fadeStartTime);
        if (source.isPlaying)
            {
                float speed = 0.1f;
                //source.volume = 1f;

                while (source.volume >= 0f)
                {

                    source.volume -= speed * Time.deltaTime;
                    yield return null;

                }
                source.volume = 1f;
            }
        }

    }
    private AudioSource GetFreeSource()
    {

        foreach (AudioSource source in sources)
        {

            if (!source.isPlaying)
            {
                return source;
            }

        }
        return null;
    }

    IEnumerator Play(Audio audio)
    {
        yield return new WaitForSeconds(audio.delay);
        AudioSource selectedSource = GetFreeSource();
      
        if(!selectedSource)
        {
            if (sources.Count < maxPoolSize)
                selectedSource = CreateSources(sources.Count);
            else
                Debug.Log("Max pool size reached");
        }
        selectedSource.clip = audio.clip;
        selectedSource.loop = audio.isLooping;
        if(!audio.fadeIn)
            selectedSource.Play();
        else
            StartCoroutine(FadeInClip(selectedSource,audio.fadeInTime));
        if(!audio.isLooping&&audio.fadeOut)
            StartCoroutine(FadeOutClip(selectedSource, audio.fadeOutTime));
        selectedSource.playOnAwake = false;
        yield return null;
    }

    IEnumerator Play(AudioClip clip, float delay,bool isLooping = false,bool fadeIn =false,bool fadeOut = false)
    {
        yield return new WaitForSeconds(delay);
        //Debug.Log(clip.name + ", " + delay);
        AudioSource selectedSource=null;
        foreach (AudioSource source in sources)
        {

            if(!source.isPlaying&&!fadeIn)
            {
                source.clip = clip;
                selectedSource = source;
                break;
            }

        }
        if (!selectedSource)
        {
            if (sources.Count < maxPoolSize)
            {
                selectedSource = CreateSources(sources.Count);
                selectedSource.clip = clip;
            }
            else
            {
                Debug.Log("Max pool size reached");
                yield break;
            }
        }
        selectedSource.loop = isLooping;
        if (!fadeIn)
            selectedSource.Play();
        else
            StartCoroutine(FadeInClip(selectedSource));

        if (fadeOut)
        {
            StartCoroutine(FadeOutClip(selectedSource,0.5f));
        }
        selectedSource.playOnAwake = false;
      
    }
}
