using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    public float speed=20f;
    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        rb.velocity=Vector3.right*5f;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.AddForce(
                Vector3.up*200f,ForceMode.Acceleration);
            
        }
    }
}
