using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    public MusicSO mchannel;
    public AudioClip clip;

    private AudioSource player;

    void Start()
    {
        player = GetComponent<AudioSource>();
        player.clip = clip;
        
       
    }
    private void OnEnable()
    {
        mchannel.onMusicChanged += ChangeMusic;
    }

    private void OnDisable()
    {
        mchannel.onMusicChanged -= ChangeMusic;
    }

    void ChangeMusic()
    {
       
        Debug.Log("ChangeMusic");

        if (player.isPlaying == true)
        {
            player.Pause();
            
        }
   
        else if (player.isPlaying == false)
        {
            player.Play();
         
        }

        

    }
}
