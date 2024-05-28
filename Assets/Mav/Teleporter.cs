using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameManager GM;

    public void OnTriggerEnter (Collider collision)
    {
	if (collision.GetComponent<PlayerMovement>() && GM.currentPickups >= GM.maxPickups)
	{
	    collision.transform.position = new Vector3(1, 1, 1);
	}
    }
}
