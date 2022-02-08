using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    /* Start is called before the first frame update
    float speedY = 20f;
    Vector3 vectorCube = new Vector3();
    const float MIN_LIMIT_Y = 4.35f, MAX_LIMIT_Y = -4.25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vectorCube.y = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        gameObject.transform.Translate(vectorCube);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x,Mathf.Clamp(gameObject.transform.position.y, MAX_LIMIT_Y, MIN_LIMIT_Y), gameObject.transform.position.z);
    }*/

    /*
    Vector3 xySpeed = new Vector3(10, 10);
    Vector3 xyPosition = new Vector3();
    const float MAX_LIMIT_Y = -4.25f, MIN_LIMIT_Y = 4.25f, MAX_LIMIT_X = -8.25f, MIN_LIMIT_X = 8.25f;
    void Update()
    {
        xyPosition.x = Input.GetAxis("Horizontal") * xySpeed.x;
        xyPosition.y = Input.GetAxis("Vertical") * xySpeed.y;
        xyPosition *= Time.deltaTime;

        gameObject.transform.Translate(xyPosition);

        //limites
        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, MAX_LIMIT_X, MIN_LIMIT_X),
                                                    Mathf.Clamp(gameObject.transform.position.y, MAX_LIMIT_Y, MIN_LIMIT_Y), 
                                                    gameObject.transform.position.z);
    }*/

    Vector3 position = new Vector3(0, 7.5f);
    public GameObject cuboRed, cuboYellow, cuboBlue, cuboPurple;
    const float MAX_TIME= 2.0f, MIN_TIME = 0.5f, MAX_LIMIT_X = -9, MIN_LIMIT_X = 9;
    float nextTime=0;

    void Start()
    {
        nextTime = GetNextTime();
    }

    void Update()
    {
        if(Time.time > nextTime)
        {
            position.x = Random.Range(MIN_LIMIT_X, MAX_LIMIT_X);
            Instantiate(nextCube(), position, Quaternion.identity);
            nextTime = GetNextTime();
        }
    }
    float GetNextTime()
    {
        return Time.time + Random.Range(MIN_TIME, MAX_TIME);
    }
    GameObject nextCube()
    {
        switch(Random.Range(0, 4))
        {
            case 0:
                return cuboRed;
            case 1:
                return cuboYellow;
            case 2:
                return cuboBlue;
            default:
                return cuboPurple;

        }
    }

}
