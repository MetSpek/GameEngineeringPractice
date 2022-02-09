using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int movementForce = 0;
    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector3.up * 500);
        }

        float horizontal = Input.GetAxis("Horizontal") * movementForce;
        float vertical = Input.GetAxis("Vertical") * movementForce;

        body.AddForce(new Vector3(horizontal, 0f, vertical));


      
    }
}
