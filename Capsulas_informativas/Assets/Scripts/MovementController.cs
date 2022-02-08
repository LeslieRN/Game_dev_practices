using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Vector3 currentPosition = new Vector3();
    const float MAX = 8f, TIME = 3f;
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        currentPosition.y = -4 + Mathf.PingPong(Time.time * TIME, MAX);
        currentPosition.x = -9 + Mathf.PingPong(Time.time * TIME, 18);
        gameObject.transform.position = currentPosition;
    }
}
