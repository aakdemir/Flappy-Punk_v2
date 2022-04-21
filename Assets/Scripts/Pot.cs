using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        print("Pot'a çarpýldý");

        print("pot'a çarpanýn name'i" + collision.transform.name);

        if (collision.transform.name =="Player")
        {    
            
            print("Pot'a çarpýldý");

            print("playerýn isPerfect deðeri" + collision.transform.GetComponent<PlayerControl>().isPerfectShot);
            collision.transform.GetComponent<PlayerControl>().isPerfectShot = false;
            print("playerýn isPerfect deðeri 2" + collision.transform.GetComponent<PlayerControl>().isPerfectShot);
        }
    }
}
