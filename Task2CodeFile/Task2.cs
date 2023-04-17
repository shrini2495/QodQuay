using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
   public GameObject[] Rigidbodies;
    float leastmass;
    // Start is called before the first frame update
    void Start()
    {
      leastmass =  Rigidbodies[0].GetComponent<Rigidbody>().mass;
        foreach (GameObject obj in Rigidbodies)
        {

           if(leastmass > obj.GetComponent<Rigidbody>().mass)
            {
                leastmass = obj.GetComponent<Rigidbody>().mass;
            }

        }
        print("Least mass of all rigidbodies :"+ leastmass.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
