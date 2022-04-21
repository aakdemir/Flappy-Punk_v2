using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Cinemachine;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Manager manager;

    private Vector3 newPos;
    private Rigidbody rb;
    private AudioSource audioSource; 
        
    float velocityToJump = 5.0f;
    float velocityToTranslate = 1.5f;
    int perfectShotSeries = 1;

    public bool isPerfectShot;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        rb = gameObject.GetComponent<Rigidbody>();
        manager = GameObject.Find("Manager").GetComponent<Manager>();
        isPerfectShot = true;


    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.touchCount > 0)
        if(Input.GetMouseButtonDown(0))
        {
            Jump();
        }
        else
        {

        }
        //transform.Translate(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z * velocity * Time.deltaTime);
        transform.Translate(0 , 0 , velocityToTranslate * Time.deltaTime);

    }
    
    

    void Jump()
    {
        rb.velocity = Vector3.up * velocityToJump;
        //rb.transform.Translate(Vector3.right);
        audioSource.Play();
    }




    private void OnTriggerEnter(Collider other)
    {
        Transform childPotTransform;
        Transform potTransform;
        //burada torus'un collider'ına değerse flag değiştir


        if (other.transform.tag == "MainPot")
        {
            print("RingObject'in collider'ından geçildi");
            childPotTransform = other.transform.GetChild(0);
            potTransform = childPotTransform.transform.GetChild(0);

            //print("childTransformTAG = " + childTransform.tag);
            //print("childTransformNAME = " + childTransform.name);
            other.transform.GetComponent<Collider>().enabled = false;
            childPotTransform.GetComponent<Collider>().enabled = false;
            potTransform.GetComponent<Collider>().enabled = false;


            if (isPerfectShot)
            {
                manager.increaseScore(2* perfectShotSeries);
                perfectShotSeries++;
            }
            else
            {
                manager.increaseScore(1);
                perfectShotSeries = 1;
                isPerfectShot = true;
            }
                
            //manager.AddMainPotToScene();
        }
    }
  
    
   

}
