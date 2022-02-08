using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    // Start is called before the first frame update
    float scrolSpeed = 0.1f, tempSpeed;
    MeshRenderer renderer;
    Vector2 position = new Vector2();
    /*void Start()
    {
        
    }*/
    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        tempSpeed = scrolSpeed * (15 / gameObject.transform.position.z);
        position.x = position.x + tempSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = position;
    }
}
