using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class PauseManager : MonoBehaviour
{

    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpasued;

    Canvas canvas;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();

    }

  
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = !canvas.enabled;
            Pause();
        }
    }
    public void Pause()
    {
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        Lowpass();
    }

    void Lowpass()
    {
        if (Time.timeScale == 0)
        {
            paused.TransitionTo(.01f);
        }
        else
        {
            unpasued.TransitionTo(.01f);
        }

    }
   
}

