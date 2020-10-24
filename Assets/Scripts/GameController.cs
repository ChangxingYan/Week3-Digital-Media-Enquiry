using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Runtime.InteropServices;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject myObstaclePrefab;

    float range = 3f;
    int interactor = 10;

    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere1;
        

        int counter = 0;
    while (counter < interactor)
        {
            sphere1 = Instantiate(myObstaclePrefab);
            sphere1.transform.position = new Vector3(UnityEngine.Random.Range(-range, range), UnityEngine.Random.Range(0, range), UnityEngine.Random.Range(-range, range));
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

}


