using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaundrySnapObject : MonoBehaviour
{
    private Color startcolor;
    public new Renderer renderer;
    public GameObject snap;
    public GameObject original;
    public GameObject col;
    public Rigidbody obj;
    public CollisionWithDone1 cWithDone;
    public bool click = false;
    public bool inside = false;
    public Vector3 heres;
    public changeimage health;
    public changeimage health2;
    public GameObject camm;
    public GameObject[] before;
    public GameObject player1;
    public int n;
    public float canpickup;



    void Awake()
    {
        startcolor = renderer.material.color;
        snap = GameObject.Find("SNAP");
    }
    void Update()
    {
        player1 = GameObject.FindWithTag("Player1");
        
    }
    //snap
    void OnMouseDown()
     {
        snap = GameObject.Find("CHARACTER1 2/connect");
        if (health.currenthealthfor >= canpickup && health2.currenthealthfor >= canpickup)
        {
            if (click == false && snap.transform.childCount < 1)
            {
                Debug.Log(gameObject.name);
                transform.parent = snap.transform;
                transform.position = snap.GetComponent<Transform>().position;
                // transform.position = snap.transform.Position + heres;+ snap.transform.TransformDirection(new Vector3(0, 2f, 0));
                transform.rotation = Quaternion.identity;
                obj.isKinematic = true;
                obj.useGravity = false;
                // transform.position = new Vector3(0,0,0);
                click = true;
                camm.SetActive(true);
            }
            else if (click == true && snap.transform.childCount == 1)
            {
                transform.parent = original.transform;
                obj.isKinematic = false;
                obj.useGravity = true;
                click = false;
                Debug.Log("works");


                if (cWithDone.correctObject == true && before[n].activeSelf == true)
                {

                    camm.SetActive(false);
                    cWithDone.self.SetActive(true);
                    Destroy(cWithDone.y);
                }
            }
        }
     }


    //hover
    void OnMouseEnter()
    {
        if (health.currenthealthfor >= canpickup && health2.currenthealthfor >= canpickup)
        {
            
            renderer.material.color = Color.yellow;
        }
    }
    void OnMouseExit()
    {
        renderer.material.color = startcolor;
    }
}


/*if (snap.transform.childCount <= 1)
{
    Debug.Log(gameObject.name);
    transform.parent = snap.transform;
    transform.position = snap.transform.localPosition + snap.transform.TransformDirection(new Vector3(0, 0, 2));
    click = true;

} if (snap.transform.childCount == 1 && click == true)
{
    click = false;
    Debug.Log("works");
}*/


      /*  switch (click)
        {
            case false when snap.transform.childCount <= 1:
                Debug.Log(gameObject.name);
transform.parent = snap.transform;
                transform.position = snap.transform.localPosition + snap.transform.TransformDirection(new Vector3(0, 0, 2.5f));
                transform.rotation = Quaternion.identity;
                obj.isKinematic = true;
                obj.useGravity = false;
                click = true;

                break;
            case true when snap.transform.childCount == 2:
                transform.parent = original.transform;
obj.isKinematic = false;
                obj.useGravity = true;
                click = false;
                Debug.Log("works");

                    if (cWithDone.correctObject == true)
                    {
                        cWithDone.self.SetActive(true);
                        Destroy(cWithDone.y);
                    }

                break;

        } */
