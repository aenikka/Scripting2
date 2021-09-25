using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManger : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
      

    }

    public void PlaySong(Watchman watchman)
    {
        watchman.song.Play();
        Debug.Log("Song playing");
    }

    public void StopSong(Watchman watchman)
    {
        watchman.song.Pause();
        Debug.Log("Song stopped");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
