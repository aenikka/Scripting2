using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class MusicSO : ScriptableObject
{
    // public delegate void OnMusicChanged();
    //public event OnMusicChanged onMusicChanged;

    public delegate void OnMusicChanged();

    public event OnMusicChanged onMusicChanged;


    public void OnMusicChange()
    {     

        if (onMusicChanged != null)
        {
            onMusicChanged();
        }

    }
}
