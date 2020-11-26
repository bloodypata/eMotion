using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLaundryInBasket : MonoBehaviour
{
    public GameObject laundry2D;
    public bool isIn;
    public InventoryForLaundry script;


    private void Update()
    {
        AddToList();
    }

    public void AddToList()
    {
        if (isIn == true && !script.basket.Contains(laundry2D))
        {
            script.basket.Add(laundry2D);
        }
        else if (isIn == false)
        {
            script.basket.Remove(laundry2D);
        }
    }
}
