using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float_Script : MonoBehaviour
{

    public float x;
    public float z;
    public float y;
    public float amp;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x, Mathf.Sin(Time.time) *amp +y, z);
    }
}
