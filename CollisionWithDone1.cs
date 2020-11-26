using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithDone1 : MonoBehaviour
{
    
    public GameObject y;
    public GameObject self;
    public bool correctObject;
    
   
    void Start()
    {
        
        self.SetActive(false);
    }

    void OnTriggerEnter(Collider x)
    {
        if (x.gameObject == y)
        {
            self.SetActive(true);
            correctObject = true;
            Debug.Log("whatever");
           
        }
        else
        {
          // built = false;
            //  correctObject = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == y)
        {

            self.SetActive(false);
        }
       
    }


}
