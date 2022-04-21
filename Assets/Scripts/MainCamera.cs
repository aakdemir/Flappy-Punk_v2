using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Transform playerPosition;

    Transform camerPosition;

    Vector3 cameraMovementPos;
    float velocity = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform; //GameObject.FindGameObjectWithTag("Player").transform;

        //changeCameraPosition = gameObject.transform.GetComponent<Transform>();


        //Debug.Log("Pos x : " + playerPosition.position.x);
        //Debug.Log("Pos y : " + playerPosition.position.y);
        //Debug.Log("Pos z : " + playerPosition.position.z);
    }


    private void LateUpdate()
    {
        changeCameraPosition();
    }

    void changeCameraPosition()
    {
        /* camera'n�n gidece�i yeni pozisyonu buluyoruz. X �ocu�a g�re de�i�ecek. Y de�i�meyecek. Z ise �ocuktan 1.5f geride olacak. 
         * z�play�nca  Y'de de�i�ece�i i�in manual aralar�ndaki fark� bulup eklendi.
         * Bunu oyun ba�lang�c�nda �ocu�un ve cameran�n de�erlerine bakarak buluyoruz. */
        cameraMovementPos = new Vector3(transform.position.x, transform.position.y, playerPosition.position.z + 3.0f);
        transform.position = Vector3.Lerp(transform.position, cameraMovementPos, velocity * Time.deltaTime);

    }
}
