using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   
    public float movespeed = 10f;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * movespeed * Time.deltaTime);
        }

       
    }
}
