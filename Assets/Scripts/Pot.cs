using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        print("Pot'a �arp�ld�");

        print("pot'a �arpan�n name'i" + collision.transform.name);

        if (collision.transform.name =="Player")
        {    
            
            print("Pot'a �arp�ld�");

            print("player�n isPerfect de�eri" + collision.transform.GetComponent<PlayerControl>().isPerfectShot);
            collision.transform.GetComponent<PlayerControl>().isPerfectShot = false;
            print("player�n isPerfect de�eri 2" + collision.transform.GetComponent<PlayerControl>().isPerfectShot);
        }
    }
}
