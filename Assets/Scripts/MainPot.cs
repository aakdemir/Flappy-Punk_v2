using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPot : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.transform.GetChild(0).GetComponent<Collider>().enabled = true; //childpot'un collider'ýný aktif et
        gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Collider>().enabled = true; //pot'un collider'ýný aktif et
    }
}
