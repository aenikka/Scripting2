using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : IWatchmanStated
{
    // Start is called before the first frame update
    public void Execute(Watchman watchman)
    {
        
        Debug.Log("Alert");
        watchman.renderer.material.color = Color.red;
        watchman.currentSpeed = watchman.chaseSpeed;

    }

}
