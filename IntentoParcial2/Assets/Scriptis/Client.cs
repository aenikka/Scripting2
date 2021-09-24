using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Watchman watchman;
    public MusicManger music;
    public Fruit fruit;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            watchman.Patroling();
            music.StopSong(watchman);
        }
        if (Input.GetKeyDown("a"))
        {
            watchman.Alert();
            music.PlaySong(watchman);
        }
        if (Input.GetKeyDown("c"))
        {
            fruit.CutCubes();
        }
        if (Input.GetKeyDown("x"))
        {
            fruit.CutPieces();
        }



    }
}
