using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : IWatchmanStated
{
    // Start is called before the first frame update
    public void Execute(Watchman watchman)
    {
       
        Debug.Log("Patrol");
        watchman.renderer.material.color = Color.blue;
        watchman.currentSpeed = watchman.patrolSpeed;

    }



}
