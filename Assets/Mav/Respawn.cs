using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public void OnTriggerEnter (Collider collision)
    {
	if (collision.GetComponent<PlayerMovement>())
	{
	    collision.transform.position = new Vector3(-241, 25, -15);
	}
    }
}
