using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float jumpSpeed = 350f;
    [SerializeField] float moveSpeed = 350f;
void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(0,jumpSpeed,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.AddForce(moveSpeed,0,0); 
        }
        else if(Input.GetKey(KeyCode.A)){
            rb.AddForce(-moveSpeed,0,0);
        }
        else if(Input.GetKey(KeyCode.W)){
            rb.AddForce(0,0,moveSpeed);
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.AddForce(0,0,-moveSpeed);
        }
    }
}
