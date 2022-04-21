using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RingObject : MonoBehaviour
{
    PlayerControl player;
    public bool isPerfectShot;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerControl>();
    }
    private void OnCollisionEnter(Collision other)
    {
      
        foreach (ContactPoint contact in other.contacts)
        {
            Collider collider = contact.thisCollider;
            print(collider.name);
            
            if (collider.name == "Pot")
            {
                isPerfectShot = false;
            }
        }
    }
    private void OnCollisionStay(Collision other)
    {
        
        foreach (ContactPoint contact in other.contacts)
        {
            Collider collider = contact.thisCollider;
            print(collider.name);
            
            if (collider.name == "Pot")
            {
                isPerfectShot = false;
            }
        }
    }

}