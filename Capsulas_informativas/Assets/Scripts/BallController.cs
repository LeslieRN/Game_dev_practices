using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    bool start = false;
    const float FORCE = 500f;
    Rigidbody rb;
    Vector3 startForce = new Vector3(1, 1);
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
       if(!start && Input.GetButtonDown("Fire1"))
        {
            start = true;
            startForce *= FORCE;
            rb.AddForce(startForce);
        } 
    }
}
