using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObs : MonoBehaviour
{
	public float timer = 3f;
	public bool horizontal = true; //If the movement is horizontal or vertical
	public float speed = 3f;
	public float offset = 0f; //If yo want to modify the position at the start 

	private bool isForward = true; //If the movement is out
	private Vector3 startPos;
	float cTime;
   
    void Awake()
    {
		cTime = timer;
		startPos = transform.position;
		if (horizontal)
			transform.position += Vector3.right * offset;
		else
			transform.position += Vector3.forward * offset;
	}

    // Update is called once per frame
    void Update()
    {
		if (horizontal)
		{
			if (isForward)
			{
				if (cTime >= 0f)
				{
					transform.position += transform.right * Time.deltaTime * speed;
					cTime -= Time.deltaTime;
				}
				else
					isForward = false;
			}
			else
			{
				if (cTime <= timer && isForward == false)
				{
					transform.position -= transform.right * Time.deltaTime * speed;
					cTime += Time.deltaTime;
				}
				else
					isForward = true;
			}
		}
		else
		{
			if (isForward)
			{
				if (cTime >= 0f)
				{
					transform.position += transform.forward * Time.deltaTime * speed;
					cTime -= Time.deltaTime;
				}
				else
					isForward = false;
			}
			else
			{
				if (cTime <= timer && isForward == false)
				{
					transform.position -= transform.forward * Time.deltaTime * speed;
					cTime += Time.deltaTime;
				}
				else
					isForward = true;
			}
		}
    }
}
