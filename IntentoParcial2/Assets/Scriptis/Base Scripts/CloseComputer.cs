using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseComputer : MonoBehaviour
{
    [SerializeField] Animator[] animator;

    GameObject player;

    int state = 0; // 0 = Waiting | 1 = Player is inside the trigger | 2 = Animation
    //float t = 0;

    void Awake()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            player = other.gameObject;            
            for (int i = 0; i < animator.Length; i++)
            {            
                animator[i].SetTrigger("Close");
            }

            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (state != 3 && other.CompareTag("Player"))
        {
            state = 0;
        }
    }

}
