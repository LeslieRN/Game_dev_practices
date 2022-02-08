using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shield;
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire2"))
        {
            Instantiate(shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldController>().Shoot(gameObject, 3f);
        }
    }
}
