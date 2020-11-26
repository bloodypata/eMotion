using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Newsnap : MonoBehaviour
{
    private Color startcolor;
    public new Renderer renderer;
    public GameObject snap;
    public GameObject snap2;
    public GameObject original;
    public GameObject col;
    public Rigidbody obj;
    public CollisionWithDone1 cWithDone;
    public bool click = false;
    public bool inside = false;
    public Vector3 heres;
    public changeimage health;
    public changeimage health2;
    //public GameObject camm;
    public GameObject[] before;
    public GameObject player1;
    public GameObject player2;
    public int n;
    public float canpickup;
    public KeyCode Interact;
    public KeyCode Interact2;
    public bool pick;
    public Player[] canttime;
    public float time ;
    public GameObject manual;
    public GameObject manual2;
    
    


    void Awake()
    {
        startcolor = renderer.material.color;
        snap = GameObject.Find("SNAP");
        snap2 = GameObject.Find("SNAP2");
        
    }
    void Update()
    {
        time -= Time.deltaTime;

        player1 = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");
    
        if (pick == true)
        {
            
            if (Input.GetKeyDown(Interact)  && snap.transform.childCount < 1)
            {
                manual.SetActive(true);
                manual2.SetActive(false);
        
                // pick = true;
                canttime[0].canttime = false;
                canttime[1].canttime = false;
                Debug.Log(gameObject.name);
                transform.parent = snap.transform;
                transform.position = snap.GetComponent<Transform>().position;
                // transform.position = snap.transform.Position + heres;+ snap.transform.TransformDirection(new Vector3(0, 2f, 0));
                transform.rotation = Quaternion.identity;
                obj.isKinematic = true;
                obj.useGravity = false;
                pick = false;
                time = 5f;
                time -= Time.deltaTime;

                // transform.position = new Vector3(0,0,0);

                //camm.SetActive(true);
            }
           
        }
      if(time <= 0)
        {
           time = 5f;
        }
        if (pick == false && time <= 4)
        {
            time -=  Time.deltaTime; 
            if (Input.GetKey(Interact)  && snap.transform.childCount == 1)
            {
                obj.isKinematic = false;
                obj.useGravity = true;
                transform.parent = original.transform;
                Debug.Log("works");
                time = 5f;
                time -= Time.deltaTime;
                if (cWithDone.correctObject == true && before[n].activeSelf == true)
                {

                    // camm.SetActive(false);
                    cWithDone.self.SetActive(true);
                    Destroy(cWithDone.y);
                }
              
            }
        }

        if (click == true  )
        {
            if (Input.GetKeyDown(Interact2)  && snap2.transform.childCount < 1)
            {
                manual.SetActive(false);
                manual2.SetActive(true);
                Debug.Log(gameObject.name);
                transform.parent = snap2.transform;
                transform.position = snap2.GetComponent<Transform>().position;
                // transform.position = snap.transform.Position + heres;+ snap.transform.TransformDirection(new Vector3(0, 2f, 0));
                transform.rotation = Quaternion.identity;
                obj.isKinematic = true;
                obj.useGravity = false;
                // transform.position = new Vector3(0,0,0);
                click = false;
                time = 5f;
                time -= Time.deltaTime;
                // camm.SetActive(true);
            }
        }
        if (click == false && time <= 4)
        {
            if( Input.GetKeyDown(Interact2)  && snap2.transform.childCount == 1)
        {
                transform.parent = original.transform;
                obj.isKinematic = false;
                obj.useGravity = true;

                Debug.Log("works");
                time = 5f;
                time -= Time.deltaTime;
                if (cWithDone.correctObject == true && before[n].activeSelf == true)
                {

                    cWithDone.self.layer = 0;
                    cWithDone.self.SetActive(true);
                  
                    Destroy(cWithDone.y);
                }
            }

        }

    }

    //snap
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player1)
        {
            renderer.material.color = Color.yellow;

            if (health.currenthealthfor >= canpickup && health2.currenthealthfor >= canpickup)
            {
                pick = true;
                //click = true;
              /*  if (Input.GetKeyDown(Interact) && click == false && snap.transform.childCount < 1)
                {
                    
                    canttime[0].canttime = false;
                    canttime[1].canttime = false;
                    Debug.Log(gameObject.name);
                    transform.parent = snap.transform;
                    transform.position = snap.GetComponent<Transform>().position;
                    // transform.position = snap.transform.Position + heres;+ snap.transform.TransformDirection(new Vector3(0, 2f, 0));
                    transform.rotation = Quaternion.identity;

                    // transform.position = new Vector3(0,0,0);
                    
                    //camm.SetActive(true);
                }*/


            }
        }
        else if (other.gameObject != player1  )
        {
           
           // camm.SetActive(false);
            pick = false;
           
        }
        if (other.gameObject == player2)
        {
            renderer.material.color = Color.yellow;
            if (health.currenthealthfor >= canpickup && health2.currenthealthfor >= canpickup)
            {
                click = true;
               


            }
        }
        else if (other.gameObject != player2)
        {
            click = false;
        } 
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player1 || other.gameObject == player2)
        {
            click = false;
            pick = false;
            renderer.material.color = startcolor;
        }
    }
}
