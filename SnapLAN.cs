using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapLAN : MonoBehaviour
{
    private Color startcolor;
    public new Renderer renderer;
    public GameObject snap;
    public GameObject snap2;
    public GameObject original;
  //public GameObject col;
    public Rigidbody obj;
  //public CollisionWithDone1 cWithDone;
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
    public GameObject tabledone;
    public float time;
    public Animator anim;
    public GameObject open;
    public Timerstart timestart;
    public float respawnTimer = 2f;

    public Vector3 originalPosition;
    public bool canspawn;

    void Awake()
    {
       originalPosition = transform.position;
        startcolor = renderer.material.color;
        snap = GameObject.Find("SNAP");
        snap2 = GameObject.Find("SNAP2");
    }
    void Update()
    {
        for(int i=0; i<timestart.foldedLaundry.Length;i++)
        {
            if (timestart.timer == false && (timestart.foldedLaundry[i].activeSelf == false
          ) && timestart.time <= 0 && canspawn == false)
            {
                //int rang = Random.Range(9, 15);
                //transform.position = new Vector3(0, 2, rang);
                gameObject.transform.position = originalPosition;
                //canspawn = true;
                respawnTimer -= Time.deltaTime;
               // obj.useGravity = false;
            }

            if (respawnTimer < 0f)
            {


                obj.useGravity = true;
                obj.isKinematic = false;
                //    
                timestart.time = 90f;
                respawnTimer = 2f;
                canspawn = false;


            }
        }
       
        time -= Time.deltaTime;
        player1 = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");
        if (pick == true && before[n].activeSelf == true)
        {
          
            if (Input.GetKeyDown(Interact)  && snap.transform.childCount < 1 )
            {
                anim.SetBool("Open", true);
                timestart.timer = true;
                Debug.Log("pickedup");
                canttime[0].canttime = false;
                canttime[1].canttime = false;
                Debug.Log(gameObject.name);
                transform.parent = snap.transform;
                transform.position = snap.GetComponent<Transform>().position;
                // transform.position = snap.transform.Position + heres;+ snap.transform.TransformDirection(new Vector3(0, 2f, 0));
                transform.rotation = Quaternion.identity;
                obj.isKinematic = true;
                obj.useGravity = false;
                time = 5f;
                time -= Time.deltaTime;
                pick = false;


                // camm.SetActive(true);
            }

        }
        if (time <= 0)
        {
            time = 5f;
        }
        if (pick == false && time <= 4 )
        {
            time -= Time.deltaTime;
            if (Input.GetKeyDown(Interact) && snap.transform.childCount == 1)
            {
                transform.parent = original.transform;
                // camm.SetActive(false);
               
                Debug.Log("works");
                obj.isKinematic = false;
                obj.useGravity = true;
            }
        }
        if (click == true && before[n].activeSelf == true)
        {
            if (Input.GetKeyDown(Interact2) && snap2.transform.childCount < 1)
            {
                timestart.timer = true;
                anim.SetBool("Open", true);
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
            if (Input.GetKeyDown(Interact2) && snap2.transform.childCount == 1)
            {
                transform.parent = original.transform;
                obj.isKinematic = false;
                obj.useGravity = true;

                Debug.Log("works");
                time = 5f;
                time -= Time.deltaTime;
            
            }

        }


    }
    //snap
  
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "respawn")
        {
            int rang = Random.Range(10,15);
            transform.position = new Vector3(0, 2, rang);
        }
    
        if (tabledone.activeSelf == true)
        {
            if (other.gameObject == player1)
            {
                renderer.material.color = Color.yellow;

                if (health.currenthealthfor >= canpickup && health2.currenthealthfor >= canpickup)
                {
                    pick = true;

                }
            }
            else if (other.gameObject != player1 )
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
            else if (other.gameObject != player2 )
            {
               click = false;

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (tabledone.activeSelf == true)
        {
            if (other.gameObject == player1 || other.gameObject == player2)
            {
                renderer.material.color = startcolor;
                click = false;
                pick = false;
            }
        }
    }
}