using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using Random = UnityEngine.Random;

public class Manager : MonoBehaviour
{

    public GameObject mainPot;
    public TMPro.TextMeshProUGUI scoreBoard;
    

    List<GameObject> mainPots;
    Transform playerTransform;
    int score = 0;
    



    // Start is called before the first frame update
    void Start()
    {

        mainPots = new List<GameObject>();
        playerTransform = GameObject.FindWithTag("Player").transform;

        MainPotGenerator(mainPot, mainPots, 10);

        InvokeRepeating("AddMainPotToScene", 0.01f, 4.0f);

        //InvokeRepeating("AddRingToScene", 1.0f, 3.0f);
        //Invoke("AddMainPotToScene", 0.0f);
        //Invoke("AddRingToScene", 2.0f);

    }

       
    void MainPotGenerator(GameObject mainPotObject , List<GameObject> list , int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            GameObject generatedObject = Instantiate(mainPotObject);
            generatedObject.SetActive(false);
            list.Add(generatedObject);
            

        }

        print(quantity + " adet mainpot generate edildi");


    }


    public void AddMainPotToScene()
    {       
        float posX = 0.0f;
        float posY = Random.Range(-1.0f, 4.5f);
        float posZ = playerTransform.position.z + 5.0f;


        //print("playerin z pos'u" + playerTransform.position.z);
        Vector3 objectPos = new Vector3(posX, posY, posZ);

        int randomMainPotIndex = Random.Range(0, mainPots.Count);
        //print("randomringindex : " + randomMainPotIndex);


        GameObject mainPot = mainPots[randomMainPotIndex];

        if (mainPot.activeSelf == false)
        {
            
            print("randomringindex'teki mainpot'in activeSelf'i false ");
            //mainPot.GetComponent<Collider>().enabled = true;
            mainPot.transform.position = objectPos;
            mainPot.SetActive(true);
            

            //print("sahneye if'teki "+ randomMainPotIndex + "'deki mainpot eklendi.");
            
        }
        else
        {
            foreach(GameObject mainPotAnother in mainPots)
            {
                print("randomringindex'teki mainpot'in activeSelf'i true ");
                if (mainPotAnother.activeSelf == false)
                {
                    
                    mainPotAnother.SetActive(true);
                    //mainPotAnother.GetComponent<Collider>().enabled = true;
                    mainPotAnother.transform.position = objectPos;
                      //print("sahneye foreachteki" + randomMainPotIndex + "'deki mainpot eklendi.");
                    
                }
                return;
            }
        }
        
        return;
    }



    public void increaseScore(int value)
    {
        
        score += value;
        scoreBoard.text = "SCORE " + score;
    }
    
    public void decreaseScore(int value)
    {
        
        score -= value;
        scoreBoard.text = "SCORE " + score;
    }
}




