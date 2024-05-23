using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public GameManager gameManager;

    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.GetComponent<PlayerMovement>())
        {
            gameManager.currentPickups += 1;
            Destroy(this.gameObject);
        }
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
