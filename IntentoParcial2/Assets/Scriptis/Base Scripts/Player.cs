using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    
    Animator playerAnimator;
   public bool card;   

    void Start()
    {
        playerAnimator = GetComponent<Animator>();

        card = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) // to see when the player enters the collider
    {
        Debug.Log("Enter trigger");

        if (other.gameObject.tag == "card") //on the object you want to pick up set the tag to be anything, in this case "object"
        {
            card = true;          
            Destroy(other.gameObject);
            Debug.Log(card);
        }
                  
    }
   
}
