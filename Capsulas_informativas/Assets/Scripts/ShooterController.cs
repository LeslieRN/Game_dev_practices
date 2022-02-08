using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startSpeed = new Vector3(20, 20);
    Vector3 userInput = new Vector3();
    float currentAngle, delta_y, delta_X;
    public GameObject Munition;
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {

        userInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        delta_y = userInput.y - gameObject.transform.position.y;
        delta_X = userInput.x - gameObject.transform.position.x;
        currentAngle = Mathf.Atan(delta_y / delta_X);

        if(Input.GetButtonDown("Fire1"))
        {

            Instantiate(Munition, gameObject.transform.position, Quaternion.identity).GetComponent<MunitionController>().Shoot(startSpeed, currentAngle);
        }
    }
}
