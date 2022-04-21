using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    private PlayerControl player;
    private void Start()
    {

        player = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("child'�n boxcollider'� " + gameObject.GetComponent<Collider>().enabled);

        if (other.transform.tag == "Player")
        {
            if (gameObject.GetComponent<Collider>().enabled)
            {
                Time.timeScale = 0.0f;
                print("GAME OVER");
            }
        }
    }
}
