using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDisappear : MonoBehaviour
{
    PlayerControl player;
    Manager manager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerControl>();
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        //burada sýkýntý var. bakýlacak
        //float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        float playerPosZ = player.transform.position.z;
        float objectPosZ = gameObject.transform.position.z;

        if (playerPosZ - 6.0f > objectPosZ)
        {
            gameObject.transform.GetComponent<Collider>().enabled = true;
            gameObject.transform.GetChild(0).GetComponent<Collider>().enabled = true;
            gameObject.SetActive(false);
            //manager.AddRingToScene();  
        }
            
    }
}
