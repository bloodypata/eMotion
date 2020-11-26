using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    private Color startcolor;
    public new Renderer renderer;
    public GameObject snap;
    public GameObject original;
    public GameObject col;
    public Rigidbody obj;
    public CollisionWithDone cWithDone;
    public bool click = false;
    public bool inside = false;
  

    void Awake()
    {
       
        //snap = GameObject.Find("Body");
    }

    //snap
    void OnMouseDown()
     {
        if (click == false && snap.transform.childCount <= 3)
        {
            Debug.Log(gameObject.name);
            transform.parent = snap.transform;
            transform.position = snap.transform.localPosition + snap.transform.TransformDirection(new Vector3(0, 0, 2f));
            transform.rotation = Quaternion.identity;
            obj.isKinematic = true;
            obj.useGravity = false;
            click = true;
        }else if (click == true && snap.transform.childCount == 4)
        {
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
        }

     }


    //hover
    void OnMouseEnter()
    {
        startcolor = renderer.material.color;
        renderer.material.color = Color.yellow;
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
