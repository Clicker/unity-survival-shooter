using UnityEngine;
using UnityEngine.Audio;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseManager : MonoBehaviour
{
    public AudioMixerSnapshot Paused;
    public AudioMixerSnapshot Unpaused;

    Canvas _canvas;

    void Start()
    {
        _canvas = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _canvas.enabled = !_canvas.enabled;
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
            Paused.TransitionTo(.01f);
        }
        else
        {
            Unpaused.TransitionTo(.01f);
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else 
	Application.Quit();
#endif
    }
}
