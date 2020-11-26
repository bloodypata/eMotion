using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryForLaundry : MonoBehaviour
{
    public Color startcolor;
    public new Renderer renderer;
    public GameObject canvas;
    public Text laundryNumberText;
    public int inBasket;
    public List<GameObject> basket;
    public IfLaundryInBasket[] script;
    public GameObject snap;
    public GameObject snap2;
    public GameObject player1;
    public GameObject player2;
    public KeyCode Interact;
    public KeyCode Interact2;
    void Awake()
    {
        startcolor = renderer.material.color;
        snap = GameObject.Find("SNAP");
        snap2 = GameObject.Find("SNAP2");
    }
    void Update()
    {
        player1 = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");
        laundryNumberText.text = "IN BASKET: " + inBasket;
    }

    void OnTriggerEnter(Collider col)
    {
        for (var x = 0; x < script.Length; x++)
        {
            if (col.CompareTag("Clothing") && col.name == script[x].name)
            {
                inBasket += 1;
                script[x].isIn = true;

            }
        }

    }
     void OnTriggerStay(Collider col)
    {
        if (col.gameObject == player1 )
        {
            
            renderer.material.color = Color.yellow;
            if (Input.GetKeyDown(Interact) && snap.transform.childCount < 1)
            {
                canvas.SetActive(true);
               
            }
         
        }
        if (col.gameObject == player2 )
        {
            
            renderer.material.color = Color.yellow;
            if (Input.GetKeyDown(Interact2) && snap2.transform.childCount < 1)
            {
                canvas.SetActive(true);
            }
           
          
        }
    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject == player1)
        {
            renderer.material.color = startcolor;
            canvas.SetActive(false);

        }
        if (col.gameObject == player2)
        {
            renderer.material.color = startcolor;
            canvas.SetActive(false);

        }

        for (var x = 0; x < script.Length; x++)
        {
            if (col.CompareTag("Clothing") && col.name == script[x].name)
            {
                inBasket -= 1;
                script[x].isIn = false;
            }
        }
    }

    void OnMouseDown()
    {
        canvas.SetActive(true);
    }

    public void CloseBasket()
    {
        canvas.SetActive(false);
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
