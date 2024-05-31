using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameManager GM;
    public GameObject fog;

    void Start()
    {
        fog.SetActive(false);
    }
    void Update()
    {
        if (GM.currentPickups >= GM.maxPickups)
            fog.SetActive(true);
    }

    public void OnTriggerEnter (Collider collision)
    {
	if (collision.GetComponent<PlayerMovement>() && GM.currentPickups >= GM.maxPickups)
	{
	    collision.transform.position = new Vector3(-241, 25, -15);
	}
    }
}
