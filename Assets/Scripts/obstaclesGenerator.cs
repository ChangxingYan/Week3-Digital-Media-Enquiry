using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class obstaclesGenerator : MonoBehaviour
{

    public GameObject myObstaclePrefab; //connect with sphere 'OB'
    public GameObject Generator; //just for distingushing old & new,connect with square 'obstacle'
    float newRange = 1f;
    int interactor = 10;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
    }


      
    
     


    // Update is called once per frame
    void Update()
    {
      
    }
    
    void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.tag == "Player")
        {   //1 is in GameCotroller.cs

            //2
            print("Boom!");

            //3
            GameObject sphere2;
            Destroy(gameObject);  

            //4
            sphere2 = Instantiate(Generator);
            sphere2.transform.position = gameObject.transform.position + new Vector3(UnityEngine.Random.Range(0, newRange), UnityEngine.Random.Range(0, newRange), UnityEngine.Random.Range(-newRange, newRange));

            sphere2 = Instantiate(Generator);
            sphere2.transform.position = gameObject.transform.position + new Vector3(UnityEngine.Random.Range(-newRange,0), UnityEngine.Random.Range(0, newRange), UnityEngine.Random.Range(-newRange, newRange));

        }//linked to obstacle



        //5
        else if (collision.gameObject.tag == "Desk")
        {
            

            GameObject[] balls = GameObject.FindGameObjectsWithTag("Obstacle");
            counter = interactor ;
            foreach (GameObject Obstacle in balls)
            {
                if (GetComponent<Renderer>().isVisible)
                {
                    counter--;
                }
            }
         

            int left = interactor - counter;
            print("You Win!");
            print("Obstacles left:" + left);
            print("You hit:" + counter);

        }//linked to FakeGreg
       
    }
}