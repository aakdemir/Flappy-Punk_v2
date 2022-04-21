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
        /* camera'nýn gideceði yeni pozisyonu buluyoruz. X çocuða göre deðiþecek. Y deðiþmeyecek. Z ise çocuktan 1.5f geride olacak. 
         * zýplayýnca  Y'de deðiþeceði için manual aralarýndaki farký bulup eklendi.
         * Bunu oyun baþlangýcýnda çocuðun ve cameranýn deðerlerine bakarak buluyoruz. */
        cameraMovementPos = new Vector3(transform.position.x, transform.position.y, playerPosition.position.z + 3.0f);
        transform.position = Vector3.Lerp(transform.position, cameraMovementPos, velocity * Time.deltaTime);

    }
}
