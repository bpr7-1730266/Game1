using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 50f;
    public bool Flipper;
    void Update()
    {
        if (Flipper && Input.GetKey(KeyCode.A))
        { GetComponent<HingeJoint2D>().useMotor = true; }

        else
        { GetComponent<HingeJoint2D>().useMotor = false; }
    }



    // Update is called once per frame
    /*void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Letter A hit");
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);

    }*/

}

