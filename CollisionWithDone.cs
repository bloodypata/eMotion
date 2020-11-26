using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithDone : MonoBehaviour
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
        }
        else
        {
            correctObject = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        self.SetActive(false);
    }


}
