using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHandler : MonoBehaviour
{
    public GameObject Cube;
    Animator Cubeanim;
    public string[] Trigger = { "IsClicked", "IsClickedAgain" };

    int counter = -1;
    // Start is called before the first frame update
    void Start()
    {
    Cubeanim = Cube.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnMouseDown()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        counter++;
        if(counter > 1)
        {
            counter = 0;
        }
        Cubeanim.SetTrigger(Trigger[counter]);

        

    }
    
}
