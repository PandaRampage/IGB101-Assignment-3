using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDoor : MonoBehaviour
{
    public GameManager gameManager;  
    public Animator animation;
    
    //on trigger, check if currentPickups = maxPickups
        //play door dropping animation
    private void OnTriggerEnter(Collider otherObject)
       { 
        if (otherObject.GetComponent<PlayerMovement>())
        
            if (gameManager.currentPickups >= 6)
            //set condition (Door Knob) True
            animation.SetBool("Door knob", true);
       }
    


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
