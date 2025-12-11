using Unity.VisualScripting;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource source;
    void Start()
    {
        
    }

    public void PlayAuidoWithVolume(float volume)
    {
        source.volume = volume;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
            
        }
    }
}
