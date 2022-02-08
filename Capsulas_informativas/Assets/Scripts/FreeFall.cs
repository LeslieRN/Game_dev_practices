using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFall : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 position = new Vector3();
    Vector3 speed = new Vector3();
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        position.y = speed.y*Time.deltaTime + Physics.gravity.y *( Mathf.Pow(Time.deltaTime, 2)/2);
        gameObject.transform.Translate(position);
        speed += Physics.gravity * Time.deltaTime;
    }
}
