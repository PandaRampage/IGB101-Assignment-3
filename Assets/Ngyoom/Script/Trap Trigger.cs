using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public Animator animation;

    private void OnTriggerEnter(Collider otherObject)
        {
            if(otherObject.GetComponent<PlayerMovement>())
            {
                animation.SetBool("Rising Spikes", true);
                Destroy(this.gameObject);
            }
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
