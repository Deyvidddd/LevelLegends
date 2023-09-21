using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayParticlesOnSoundScript : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public AudioSource audioSource;
    

    void Start()
    {
        
    }

    void Update()
    {
        ParticlesPlay();
        SoundPlay();
    }

    private void ParticlesPlay()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }
    }

    private void SoundPlay()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }
    }
}
